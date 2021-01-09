using System.Collections.Generic;

namespace ItAcademyWebShop.Items.Interfaces
{
    public interface ICategoryBroker
    {
        IEnumerable<ICategory> GetCategory(string name = "");
    }
}