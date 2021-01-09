using System.Data.Linq.Mapping;

namespace MsSqlDb.LinqDataProvider
{
    [Table(Name = "CategoryItems")]
    internal class DbCategoryItemLink
    {
        [Column(Name = "CategoryId", IsPrimaryKey = true)]
        public int CategoryId { get; set; }
        [Column(Name = "ItemId", IsPrimaryKey = true)]
        public int ItemId { get; set; }
    }
}