using ItAcademyWebShop.Items.Interfaces;
using System;
using System.Collections.Generic;

namespace ConnectionStringGenerator
{
    public class ConnectionStringGenerator : IConnectionStringGenerator
    {
        public ConnectionStringGenerator()
        {

        }

        public IConnectionData GenerateConnectionData(IEnumerable<string> parameters)
        {
            throw new NotImplementedException();
        }
    }
}
