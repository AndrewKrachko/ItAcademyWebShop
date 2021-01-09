using System;
using System.Collections.Generic;
using System.Text;

namespace ItAcademyWebShop.Items.Interfaces
{
    public interface IProcessor
    {
        IDataBroker DataBroker { get; set; }
    }
}
