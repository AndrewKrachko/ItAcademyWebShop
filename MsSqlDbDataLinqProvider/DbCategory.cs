using ItAcademyWebShop.Items.Items;
using System.Data.Linq.Mapping;

namespace MsSqlDb.LinqDataProvider
{
    [Table(Name = "Category")]
    internal class DbCategory
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(Name = "Name")]
        public string Name { get; set; }

        public Category ConvertToCategory()
        {
            return new Category(Id.ToString(), Name);
        }
    }
}