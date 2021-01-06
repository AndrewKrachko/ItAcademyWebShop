using ItAcademyWebShop.Items.Interfaces;

namespace ItAcademyWebShop.Items.Items
{
    public class Category : ICategory
    {
        private string _id;
        private string _name;

        public string CategoryId => _id;
        public string CategoryName => _name;


        public Category(string id, string name)
        {
            _id = id;
            _name = name;
        }
    }
}
