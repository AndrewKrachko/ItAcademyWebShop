using DatabaseUtilites;
using ItAcademyWebShop.Items.Enums;
using ItAcademyWebShop.Items.Interfaces;
using MsSqlDb.AdoDataProvider;
using MsSqlDb.LinqDataProvider;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItAcademyWebShop.BL
{
    class WebShopConfigurator
    {
        private ConnectionStringGenerator _dataProviderConfigurator;

        public WebShopConfigurator(string configFile)
        {
            _dataProviderConfigurator = new ConnectionStringGenerator(configFile);
        }

        public IRepository SetDataProvider()
        {
            switch (_dataProviderConfigurator.Reciever)
            {
                case DataReciever.AdoNet:
                    return new SqlDataProvider(_dataProviderConfigurator.ConnectionData);
                case DataReciever.Linq:
                    return new LinqDataProvider(_dataProviderConfigurator.ConnectionData);
                default:
                    throw new Exception("Cannot read server parameters");
            }
        }

    }
}
