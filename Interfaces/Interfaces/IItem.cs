using System.Collections.Generic;

namespace ItAcademyWebShop.Items.Interfaces
{
    public interface IItem
    {
        string ItemId { get; }
        string ItemName { get; }
        IEnumerable<ICategory> Categories { get; }
        string Description { get; }
        double Price { get; }
    }
}
