using ItAcademyWebShop.Items.Interfaces;

namespace ItAcademyWebShop.Items.ConnectionParameters
{
    public class MsSqlConnectionData : IConnectionData
    {
        public IProvider Provider { get; set; }
        public IStorage Storage { get; set; }
        public ICredentials Credentials { get => Credentials ?? new EmptyCredentials(); set => Credentials = value; }
        public ISecuritySettings SecuritySettings { get => SecuritySettings ?? new EmptySecuritySettings(); set => SecuritySettings = value; }
        public IOptions Options { get => Options ?? new EmptyOptions(); set => Options = value; }

        public MsSqlConnectionData(IProvider provider, IStorage storage)
        {
            Provider = provider;
            Storage = storage;
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
