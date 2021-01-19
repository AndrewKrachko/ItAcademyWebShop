using ItAcademyWebShop.Items.Interfaces;
using ItAcademyWebShop.Items.Items;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

namespace MsSqlDb.LinqDataProvider
{
    public class LinqDataProvider : IRepository
    {
        private IConnectionData _connectionData;

        public LinqDataProvider(IConnectionData connectionData)
        {
            _connectionData = connectionData;
        }

        public IEnumerable<ICategory> GetCategories()
        {
            var db = new DataContext(_connectionData.GetConnectionString());

            var query = from category in db.GetTable<DbCategory>()
                        select category.ConvertToCategory();

            return query;
        }

        public IEnumerable<IItem> GetCategoryItems(string categoryName)
        {
            var db = new DataContext(_connectionData.GetConnectionString());

            var categoryId = (from category in db.GetTable<DbCategory>()
                             where category.Name == categoryName
                             select category.Id).First();
                var query = from link in db.GetTable<DbCategoryItemLink>()
                             join item in db.GetTable<DbItem>() on link.ItemId equals item.Id  
                             where link.CategoryId == categoryId
                             select item.ConvertToItem();

            return query;
        }

        public IItem GetItem(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IItem> GetItems()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IItem> GetItems(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IItem> GetItems(string name, string category)
        {
            throw new NotImplementedException();
        }
    }
}
