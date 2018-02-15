namespace FamilyArchive.Application.Extensions
{
    using Infrustructure;
    using Infrustructure.ApplicationSettingsClasses;
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.IdentityModel.Tokens;

    public static class ServiceCollectionExtensions
    {
        public static void AddJwtAutentication(this IServiceCollection services, JwtToken jwtToken)
        {
            services.AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(options =>
                {
                    options.RequireHttpsMetadata = false;
                    options.SaveToken = true;
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateLifetime = true,
                        ValidAudience = jwtToken.ValidAudience,
                        ValidIssuer = jwtToken.ValidIssuer,
                        IssuerSigningKey = TokenService.GetSymmetricSecurityKey(jwtToken.SecretKey),
                        ValidateIssuerSigningKey = true
                    };
                });
        }
    }
}
