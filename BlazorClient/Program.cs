using BlazorClient.Components;
using DavidTielke.PersonManagerApp.Backend.Data.DataAccess;
using DavidTielke.PersonManagerApp.Backend.Data.FileStorage;
using DavidTielke.PersonManagerApp.Backend.PersonManagement;
using DavidTielke.PersonManagerApp.CrossCutting.Configuration;
using DavidTielke.PersonManagerApp.CrossCutting.Logging;

namespace BlazorClient
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();
            // Dependency Injection Setup
            builder.Services.AddScoped<IPersonManager, PersonManager>();
            //builder.Services.AddScoped<IPersonRepository, PersonRepository>();
            //builder.Services.AddScoped<IPersonConverter, PersonConverter>();
            //builder.Services.AddScoped<IPersonParser, PersonParser>();
            //builder.Services.AddScoped<IFileStorer, FileStorer>();
            //builder.Services.AddScoped<IPersonDataValidator, PersonDataValidator>();
            builder.Services.AddScoped<IPersonLogicValidator, PersonLogicValidator>();
            builder.Services.AddScoped<DavidTielke.PersonManagerApp.CrossCutting.Logging.ILogger, Logger>();
           
            // Singleton-Registrierung für IConfigurator
            builder.Services.AddSingleton<IConfigurator, Configurator>();

            var app = builder.Build();

            var config = app.Services.GetService<IConfigurator>();
            config.Set("AgeTreshold", 10);
            config.Set(DataConfigConstants.FILEPATH, "data.csv");
            config.Set("Separator", ",");


            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
