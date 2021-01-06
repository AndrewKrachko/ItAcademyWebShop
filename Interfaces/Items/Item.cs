using ItAcademyWebShop.Items.Interfaces;
using System.Collections.Generic;

namespace ItAcademyWebShop.Items.Items
{
    public class Item : IItem
    {
        private string _id;
        private string _name;
        private List<ICategory> _categories;
        private string _description;
        private double _price;

        public string ItemId => _id;
        public string ItemName => _name;
        public IEnumerable<ICategory> Categories => _categories;
        public string Description => _description;
        public double Price => _price;

        public Item(string id, string name, List<ICategory> categories, string description, double price)
        {
            _id = id;
            _name = name;
            _categories = categories;
            _description = description;
            _price = price;
        }
    }
}
