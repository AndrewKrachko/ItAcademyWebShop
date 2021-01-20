using ItAcademyWebShop.Items.Interfaces;
using System.Collections.Generic;

namespace ItAcademyWebShop.Items.Items
{
    public class Item : IItem
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}
