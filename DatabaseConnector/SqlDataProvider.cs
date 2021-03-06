﻿using ItAcademyWebShop.Items.ConnectionParameters;
using ItAcademyWebShop.Items.Interfaces;
using ItAcademyWebShop.Items.Items;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MsSqlDb.AdoDataProvider
{
    public class SqlDataProvider : IRepository
    {
        private IConnectionData _connectionData;

        public SqlDataProvider(IConnectionData connectionData)
        {
            _connectionData = connectionData;
        }

        public IEnumerable<ICategory> GetCategories()
        {
            var result = new List<Category>();

            using (var connection = new SqlConnection(_connectionData.GetConnectionString()))
            {

                var command = new SqlCommand("Select * from Category", connection);
                command.CommandType = CommandType.Text;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var data = new object[reader.FieldCount];
                    reader.GetValues(data);

                    result.Add(new Category() { CategoryId = int.Parse(data[0].ToString()), CategoryName = data[1].ToString() });
                }

                connection.Close();
            }

            return result;
        }

        public IEnumerable<IItem> GetCategoryItems(string category)
        {
            var result = new List<Item>();


            using (var connection = new SqlConnection(_connectionData.GetConnectionString()))
            {
                var command = new SqlCommand($"Select Items.id, Items.Name, Items.Description, Items.Price from Items " +
                    $"join CategoryItems on Items.Id = CategoryItems.ItemId " +
                    $"join Category on CategoryItems.CategoryId = Category.id " +
                    $"where Category.Name = '{category}';", connection);
                command.CommandType = CommandType.Text;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var data = new object[reader.FieldCount];
                    reader.GetValues(data);

                    var price = 0.0;
                    double.TryParse(data[3].ToString(), out price);
                    result.Add(new Item() { ItemId = int.Parse(data[0].ToString()), ItemName = data[1].ToString(), Categories = new List<Category>(), Description = data[2].ToString(), Price = price });
                }

                connection.Close();
            }

            return result;
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
