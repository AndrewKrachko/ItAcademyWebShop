using ItAcademyWebShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DatabaseConnector
{
    public class DatabaseProvider : IRepository
    {
        private string _connectionString = "";
 
        public DatabaseProvider(string connectionString)
        {
            _connectionString = connectionString;
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

        public IEnumerable<IItem> GetItems(string name, string category)
        {
            throw new NotImplementedException();
        }
    }
}
