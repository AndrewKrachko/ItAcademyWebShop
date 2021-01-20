using ItAcademyWebShop.Items.Interfaces;
using System.Collections.Generic;

namespace ItAcademyWebShop.Items.Items
{
    public class Category : ICategory
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public IEnumerable<Item> Items { get; set; }
}
}
