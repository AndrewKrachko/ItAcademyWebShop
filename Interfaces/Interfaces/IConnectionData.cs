namespace ItAcademyWebShop.Items.Interfaces
{
    public interface IConnectionData
    {
        IProvider Provider { get; set; }
        IStorage Storage { get; set; }
        ICredentials Credentials { get; set; }
        ISecuritySettings SecuritySettings { get; set; }
        IOptions Options { get; set; }

        string GetConnectionString();
    }
}
