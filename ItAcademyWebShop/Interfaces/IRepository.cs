using System.Collections.Generic;

namespace ItAcademyWebShop.Interfaces
{
    public interface IRepository
    {
        IItem GetItem(string id);
        IEnumerable<IItem> GetItems();
        IEnumerable<IItem> GetItems(string name);
        IEnumerable<IItem> GetItems(string name, string category);
        IEnumerable<IItem> GetCategoryItems(string category);
        IEnumerable<ICategory> GetCategories();
    }
}
