using System;
using System.Collections.Generic;
using System.Text;

namespace ItAcademyWebShop.Items.Interfaces
{
    public interface IConnectionStringGenerator
    {
        IConnectionData GenerateConnectionData(IEnumerable<string> parameters);
    }
}
