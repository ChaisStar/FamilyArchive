namespace FamilyArchive.Application.Infrustructure.ApplicationSettingsClasses
{
    using Microsoft.Extensions.Configuration;

    public class JwtToken
    {
        public JwtToken(IConfiguration configuration)
        {
            Lifetime = configuration.GetValue<int>("lifetime");
            SecretKey = configuration.GetValue<string>("secretKey");
            ValidAudience = configuration.GetValue<string>("validAudience");
            ValidIssuer = configuration.GetValue<string>("validIssuer");
        }

        public int Lifetime { get; set; }

        public string SecretKey { get; set; }

        public string ValidAudience { get; set; }

        public string ValidIssuer { get; set; }
    }
}