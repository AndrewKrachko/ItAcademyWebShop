using ItAcademyWebShop.Items.Interfaces;

namespace ItAcademyWebShop.Items.ConnectionParameters
{
    public class MsSqlConnectionData : IConnectionData
    {
        public IProvider Provider { get; set; }
        public IStorage Storage { get; set; }
        public ICredentials Credentials { get; set; }
        public ISecuritySettings SecuritySettings { get; set; }
        public IOptions Options { get; set; }

        public MsSqlConnectionData(IProvider provider, IStorage storage)
        {
            Provider = provider;
            Storage = storage;
            Credentials = new EmptyCredentials();
            SecuritySettings = new EmptySecuritySettings();
            Options = new EmptyOptions();
        }

        public MsSqlConnectionData(IProvider provider, IStorage storage, ICredentials credetials) : this(provider, storage)
        {
            Credentials = credetials;
        }

        public string GetConnectionString()
        {
            return $"{Provider.GetParametersString()}{Storage.GetParametersString()}{Credentials.GetParametersString()}{SecuritySettings.GetParametersString()}{Options.GetParametersString()}";
        }
    }
}
