using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml.Linq;
using ItAcademyWebShop.Items.Interfaces;
using ItAcademyWebShop.Items.ConnectionParameters;

namespace ItAcademyWebShop.BL
{
    public class DataProviderConfigurator
    {
        public DataDistributors Distributor { get; set; }
        public DataReciever Reciever { get; set; }
        public IConnectionData ConnectionData { get; set; }

        public DataProviderConfigurator(string path)
        {
            var configFile = XDocument.Load(path);

            var distributor = configFile.Element("DataProvider").Element("Distribution").Value;
            var reciever = configFile.Element("DataProvider").Element("Reciever").Value;

            Distributor = GetDataDistributor(distributor);
            Reciever = GetReceiver(reciever);
            ConnectionData = GetConnectionData(configFile);
        }

        private DataReciever GetReceiver(string reciever)
        {
            switch (reciever)
            {
                case "AdoNet":
                    return DataReciever.AdoNet;
                case "Linq":
                    return DataReciever.Linq;
                default:
                    return DataReciever.None;
            }
        }

        private IConnectionData GetConnectionData(XDocument configFile)
        {
            switch (Distributor)
            {
                case DataDistributors.MsSqlServer2016:
                    return GetMsSqlConnectionData(configFile);
                default:
                    throw new Exception("Cannot read server parameters");
            };
        }

        private IConnectionData GetMsSqlConnectionData(XDocument configFile)
        {
            var provider = new ServerProvider() { Name = configFile.Element("DataProvider").Element("Provider").Value };
            var database = new DataBaseStorage() { Name = configFile.Element("DataProvider").Element("DataBase").Value };
            var credentials = new MsSqlLoginPasswordCredentials() { Login = configFile.Element("DataProvider").Element("Login").Value, Password = configFile.Element("DataProvider").Element("Password").Value };

            return new MsSqlConnectionData(provider, database,credentials);
        }

        private DataDistributors GetDataDistributor(string distributor)
        {
            switch(distributor)
            {
                case "Microsoft SQL Server 2016":
                    return DataDistributors.MsSqlServer2016;
                default:
                    return DataDistributors.None;
            }
        }
    }
}
