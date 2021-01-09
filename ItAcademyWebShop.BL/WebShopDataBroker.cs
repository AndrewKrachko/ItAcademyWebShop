using ItAcademyWebShop.Items.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ItAcademyWebShop.BL
{
    public class WebShopDataBroker : IDataBroker
    {
        private IRepository _repository;

        public WebShopDataBroker(IRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<ICategory> GetCategory(string name = "")
        {
            return _repository.GetCategories().Where(c => c.CategoryName.Contains(name));
        }

        public IEnumerable<IItem> GetItem(string id = "")
        {
            if (id.Length == 0)
            {
                return new List<IItem>() { _repository.GetItem(id) };
            }

            return _repository.GetItems();
        }

        public IEnumerable<IItem> GetItemsByCategory(string categoryName)
        {
            return _repository.GetCategoryItems(categoryName);
        }
    }
}
