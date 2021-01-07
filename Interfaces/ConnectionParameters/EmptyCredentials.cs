using ItAcademyWebShop.Items.Interfaces;

namespace ItAcademyWebShop.Items.ConnectionParameters
{
    class EmptyCredentials : ICredentials
    {
        public string GetParametersString() => string.Empty;
    }
}
