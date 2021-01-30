using ItAcademyWebShop.Items.Interfaces;
using ItAcademyWebShop.Items.Items;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MsSqlDb.EfDataProvider
{
    public class WebShopItemsContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Data Source=KALV-19-09;User ID=sa;Password=1234; Initial Catalog = WebShopDb");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var categoryA = new Category() { CategoryId = 1, CategoryName = "Mobile phone" };
            var categoryB = new Category() { CategoryId = 2, CategoryName = "Laptop" };
            var categoryC = new Category() { CategoryId = 3, CategoryName = "Eberising u wont" };
            var categoryD = new Category() { CategoryId = 4, CategoryName = "Empty category" };

            modelBuilder.Entity<Category>().HasData(categoryA);
            modelBuilder.Entity<Category>().HasData(categoryB);
            modelBuilder.Entity<Category>().HasData(categoryC);
            modelBuilder.Entity<Category>().HasData(categoryD);

            modelBuilder.Entity<Item>().HasData(new Item { ItemId = 1, ItemName = "Typical phone", Description = "Typical Mobile Phone", Price = 10, Categories=new List<Category>() { categoryA, categoryC } });
            modelBuilder.Entity<Item>().HasData(new Item { ItemId = 2, ItemName = "Nontypical Phone", Description = "As it was written in desctription - it is typical Nontypical phone", Price = -30, Categories = new List<Category>() { categoryA, categoryC } });
            modelBuilder.Entity<Item>().HasData(new Item { ItemId = 3, ItemName = "Generic Laptop", Description = "For the emperror!", Price = 1000, Categories = new List<Category>() { categoryB, categoryC } });
            modelBuilder.Entity<Item>().HasData(new Item { ItemId = 4, ItemName = "BFG 2074", Description = "Big Funny Gun", Price = 1000000, Categories = new List<Category>() { categoryB, categoryC } });
        }

    }
}
