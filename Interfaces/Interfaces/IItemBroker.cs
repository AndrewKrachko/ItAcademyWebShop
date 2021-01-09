using System.Collections.Generic;

namespace ItAcademyWebShop.Items.Interfaces
{
    public interface IItemBroker
    {
        IEnumerable<IItem> GetItem(string id);
        IEnumerable<IItem> GetItemsByCategory(string categoryName);
    }
}