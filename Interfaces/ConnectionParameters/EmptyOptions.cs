using ItAcademyWebShop.Items.Interfaces;

namespace ItAcademyWebShop.Items.ConnectionParameters
{
    public class EmptyOptions : IOptions
    {
        public string GetParametersString()
        {
            return string.Empty;
        }
    }
}
