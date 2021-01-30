using DatabaseUtilites;
using ItAcademyWebShop.Items.Enums;
using ItAcademyWebShop.Items.Interfaces;
using MsSqlDb.AdoDataProvider;
using MsSqlDb.EfDataProvider;
using MsSqlDb.LinqDataProvider;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItAcademyWebShop.BL
{
    class WebShopConfigurator
    {
        private RepositoryUtillit _dataProviderConfigurator;

        public WebShopConfigurator(string configFile)
        {
            _dataProviderConfigurator = new RepositoryUtillit(configFile);
        }

        public IRepository SetDataProvider()
        {
            switch (_dataProviderConfigurator.Reciever)
            {
                case DataReciever.AdoNet:
                    return new SqlDataProvider(_dataProviderConfigurator.ConnectionData);
                case DataReciever.Linq:
                    return new LinqDataProvider(_dataProviderConfigurator.ConnectionData);
                case DataReciever.EF:
                    var databaseConnector = new EfDataProvider(_dataProviderConfigurator.ConnectionData);
                    databaseConnector.PrepareIfNotPresent();
                    return databaseConnector;
                default:
                    throw new Exception("Cannot read server parameters");
            }
        }
    }
}
