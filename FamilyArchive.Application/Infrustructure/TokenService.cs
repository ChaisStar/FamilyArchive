namespace FamilyArchive.Application.Infrustructure
{
    using System;
    using System.IdentityModel.Tokens.Jwt;
    using System.Text;
    using ApplicationSettingsClasses;
    using Microsoft.IdentityModel.Tokens;

    public class TokenService : ITokenService
    {
        public static SymmetricSecurityKey GetSymmetricSecurityKey(string key) => new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));

        private readonly JwtToken _jwtToken;

        public TokenService(ApplicationSettings applicationSettings)
        {
            _jwtToken = applicationSettings.JwtToken;
        }

        public string GetToken()
        {
            var date = DateTime.UtcNow;
            var jwt = new JwtSecurityToken(_jwtToken.ValidIssuer, _jwtToken.ValidAudience, null, date,
                date.AddHours(_jwtToken.Lifetime),
                new SigningCredentials(GetSymmetricSecurityKey(_jwtToken.SecretKey), SecurityAlgorithms.HmacSha256));
            return new JwtSecurityTokenHandler().WriteToken(jwt);
        }
    }
}
