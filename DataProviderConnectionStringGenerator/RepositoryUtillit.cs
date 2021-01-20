using ItAcademyWebShop.Items.ConnectionParameters;
using ItAcademyWebShop.Items.Enums;
using ItAcademyWebShop.Items.Interfaces;
using ItAcademyWebShop.Items.Items;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace DatabaseUtilites
{
    public class RepositoryUtillit : IConnectionStringGenerator
    {
        public DataDistributors Distributor { get; set; }
        public DataReciever Reciever { get; set; }
        public IConnectionData ConnectionData { get; set; }


        public RepositoryUtillit(string path)
        {
            var configFile = XDocument.Load(path);

            var distributor = configFile.Element("DataProvider").Element("Distribution").Value;
            var reciever = configFile.Element("DataProvider").Element("Reciever").Value;

            Distributor = GetDataDistributor(distributor);
            Reciever = GetReceiver(reciever);
            ConnectionData = GetConnectionData(configFile);
        }

        public IConnectionData GenerateConnectionData(IEnumerable<string> parameters)
        {
            throw new NotImplementedException();
        }

        private DataReciever GetReceiver(string reciever)
        {
            switch (reciever)
            {
                case "AdoNet":
                    return DataReciever.AdoNet;
                case "Linq":
                    return DataReciever.Linq;
                case "EF":
                    return DataReciever.EF;
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

            return new MsSqlConnectionData(provider, database, credentials);
        }

        private DataDistributors GetDataDistributor(string distributor)
        {
            switch (distributor)
            {
                case "Microsoft SQL Server 2016":
                    return DataDistributors.MsSqlServer2016;
                default:
                    return DataDistributors.None;
            }
        }
    }
}
