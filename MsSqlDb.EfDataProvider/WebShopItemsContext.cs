using ItAcademyWebShop.Items.Interfaces;
using ItAcademyWebShop.Items.Items;
using Microsoft.EntityFrameworkCore;

namespace MsSqlDb.EfDataProvider
{
    public class WebShopItemsContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Data Source=WSLI002\\SQLEXPRESS;Initial Catalog=ItAcademyWebShop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
