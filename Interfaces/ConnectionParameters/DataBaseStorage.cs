using ItAcademyWebShop.Items.Interfaces;

namespace ItAcademyWebShop.Items.ConnectionParameters
{
    public class DataBaseStorage : IStorage
    {
        private static string _type = "Database";
        public string Name { get; set; }

        public string GetParametersString() => $"{_type}={Name};";
    }
}
