using ItAcademyWebShop.Items.Items;
using System.Collections.Generic;

namespace ItAcademyWebShop.Items.Interfaces
{
    public interface IItem
    {
        int ItemId { get; }
        string ItemName { get; }
        IEnumerable<Category> Categories { get; }
        string Description { get; }
        double Price { get; }
    }
}
