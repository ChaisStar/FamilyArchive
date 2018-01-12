namespace FamilyArchive.Application
{
    using Data;
    using Data.Repository;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Service;

    public class Startup
    {
        public Startup(IHostingEnvironment hostingEnvironment)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(hostingEnvironment.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            Configuration = builder.Build();
            const string dbPath = "AppSettings:Database:";
            ApplicationSettings = new ApplicationSettings
            {
                Database = new Database(Configuration[$"{dbPath}Server"], Configuration[$"{dbPath}Port"],
                    Configuration[$"{dbPath}Name"], Configuration[$"{dbPath}User"], Configuration[$"{dbPath}Password"])
            };
        }

        private IConfigurationRoot Configuration { get; }

        private ApplicationSettings ApplicationSettings { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddEntityFrameworkNpgsql().AddDbContext<FamilyArchiveContext>(x => x.UseNpgsql(ApplicationSettings.Database.ConnectionString));
            services.AddScoped<IDbFactory, DbFactory>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IPhraseRepository, PhraseRepository>();
            services.AddScoped<IPhraseService, PhraseService>();
            services.AddScoped<ApplicationSettings>();
            services.AddMvc();
        }



        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}

