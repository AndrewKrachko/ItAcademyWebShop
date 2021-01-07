using ItAcademyWebShop.Items.Interfaces;

namespace ItAcademyWebShop.Items.ConnectionParameters
{
    public class ServerProvider : IProvider
    {
        private static string _type = "Server";
        public string Name { get; set; }

        public string GetParametersString() => $"{_type}={Name};";
    }
}
