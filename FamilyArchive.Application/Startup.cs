namespace FamilyArchive.Application
{
    using System.Reflection;
    using AutoMapper;
    using Data;
    using Data.Repository;
    using Extensions;
    using FluentValidation.AspNetCore;
    using Infrustructure;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Model;
    using Service;

    public class Startup
    {
        public Startup(IHostingEnvironment hostingEnvironment)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(hostingEnvironment.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            ApplicationSettings = new ApplicationSettings(builder.Build());
        }

        private ApplicationSettings ApplicationSettings { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddEntityFrameworkNpgsql().AddDbContext<FamilyArchiveContext>(x => x.UseNpgsql(ApplicationSettings.Database.ConnectionString));
            services.AddIdentity<User, UserRole>()
                .AddEntityFrameworkStores<FamilyArchiveContext>();
            services.AddJwtAutentication(ApplicationSettings.JwtToken);
            services.AddScoped<IUserManager, UserManager>();
            services.AddScoped<IDbFactory, DbFactory>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IPhraseRepository, PhraseRepository>();
            services.AddScoped<IPhraseService, PhraseService>();
            services.AddScoped<ApplicationSettings>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddAutoMapper(expression => expression.AddProfiles(Assembly.GetEntryAssembly()));
            services.AddMvc().AddFluentValidation(configuration => configuration.RegisterValidatorsFromAssembly(Assembly.GetEntryAssembly()));
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseMvc();
        }
    }
}

