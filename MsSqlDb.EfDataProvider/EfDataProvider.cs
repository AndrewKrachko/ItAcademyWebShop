using System;
using System.Collections.Generic;
using System.Text;
using ItAcademyWebShop.Items.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MsSqlDb.EfDataProvider
{
    public class EfDataProvider : IRepository
    {
        private DbContext _dbContext;

        public EfDataProvider(IConnectionData connectionData)
        {
            _dbContext = new WebShopItemsContext();
            _dbContext.Database.SetConnectionString(connectionData.GetConnectionString());
            _dbContext.Database.EnsureCreated();
        }

        public IEnumerable<ICategory> GetCategories()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IItem> GetCategoryItems(string category)
        {
            throw new NotImplementedException();
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
    }
}
