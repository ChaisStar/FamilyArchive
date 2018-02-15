namespace FamilyArchive.Application.Infrustructure.ApplicationSettingsClasses
{
    using Microsoft.Extensions.Configuration;

    public class Database
    {
        public Database(IConfiguration configuration)
        {
            ConnectionString = $"Server={configuration["server"]};Port={configuration["port"]};Database={configuration["name"]};User Id={configuration["user"]};Password={configuration["password"]}";
        }

        public string ConnectionString { get; }
    }
}