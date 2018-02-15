namespace FamilyArchive.Application.Infrustructure
{
    using ApplicationSettingsClasses;
    using Microsoft.Extensions.Configuration;

    public class ApplicationSettings
    {
        public ApplicationSettings(IConfiguration configuration)
        {
            Database = new Database(configuration.GetSection("appSettings:database"));
            JwtToken = new JwtToken(configuration.GetSection("appSettings:jwtToken"));
        }

        public Database Database { get; }

        public JwtToken JwtToken { get; }
    }
}