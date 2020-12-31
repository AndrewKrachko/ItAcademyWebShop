using System.Collections.Generic;

namespace ItAcademyWebShop.Interfaces
{
    public interface IItem
    {
        string ItemId { get; }
        string ItemName { get; }
        IEnumerable<ICategory> Category { get; }
        string Description { get; }
        double Price { get; }
    }
}
