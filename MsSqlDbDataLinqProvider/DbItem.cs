using ItAcademyWebShop.Items.Interfaces;
using ItAcademyWebShop.Items.Items;
using System.Collections.Generic;
using System.Data.Linq.Mapping;

namespace MsSqlDb.LinqDataProvider
{
    [Table(Name = "Items")]
    internal class DbItem
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(Name = "Name")]
        public string Name { get; set; }
        [Column(Name = "Description")]
        public string Description { get; set; }
        [Column(Name = "Price")]
        public decimal Price { get; set; }

        public Item ConvertToItem()
        {
            return new Item(Id.ToString(), Name, new List<ICategory>(), Description, (double)Price);
        }
    }
}