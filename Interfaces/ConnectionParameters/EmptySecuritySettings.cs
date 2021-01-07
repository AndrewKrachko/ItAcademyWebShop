using ItAcademyWebShop.Items.Interfaces;

namespace ItAcademyWebShop.Items.ConnectionParameters
{
    public class EmptySecuritySettings : ISecuritySettings
    {
        public string GetParametersString()
        {
            return string.Empty;
        }
    }
}
