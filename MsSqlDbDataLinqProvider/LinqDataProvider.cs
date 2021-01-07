using ItAcademyWebShop.Items.Interfaces;
using System;
using System.Collections.Generic;

namespace MsSqlDb.LinqDataProvider
{
    public class LinqDataProvider : IRepository
    {
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

        public IEnumerable<IItem> GetItems(string name, string category)
        {
            throw new NotImplementedException();
        }
    }
}
