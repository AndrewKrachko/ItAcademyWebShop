using ItAcademyWebShop.Items.Interfaces;
using MsSqlDb.AdoDataProvider;
using MsSqlDb.LinqDataProvider;
using System;

namespace ItAcademyWebShop.BL
{
    public class WebShopProcessor : IProcessor
    {
        private static string _configFile = "Parameters.xml";

        public IDataBroker DataBroker { get; set; }

        public WebShopProcessor()
        {
            ConfigureWebShop();
        }

        private void ConfigureWebShop()
        {
            var configurator = new WebShopConfigurator(_configFile);

            DataBroker = new WebShopDataBroker(configurator.SetDataProvider());
        }
    }
}
