using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MudBlazor.Services;
using CloudinaryDotNet.Actions;
using CloudinaryDotNet;
using System.Linq;
using R4Clothes.Server.Helpers;
using MudBlazor;

namespace R4Clothes.Server
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:44356") });

            builder.Services.AddMudServices();

            // Add cloudinary svc
            var cloudName = ("r4clothes");
            var apiKey = ("696194932544569");
            var apiSecret = ("yq3e_W2BBdpq5ziR3KDsR1DM9GQ");
            if (new[] { cloudName, apiKey, apiSecret }.Any(string.IsNullOrWhiteSpace))
            {
                throw new ArgumentException("Please specify Cloudinary account details!");
            }
            builder.Services.AddSingleton(new Cloudinary(new Account(cloudName, apiKey, apiSecret)));
            builder.Services.AddTransient<IUploadImage, UploadImage>();

            builder.Services.AddMudServices(config =>
            {
                config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.TopRight;

                config.SnackbarConfiguration.PreventDuplicates = false;
                config.SnackbarConfiguration.NewestOnTop = false;
                config.SnackbarConfiguration.ShowCloseIcon = true;
                config.SnackbarConfiguration.VisibleStateDuration = 5000;
                config.SnackbarConfiguration.HideTransitionDuration = 500;
                config.SnackbarConfiguration.ShowTransitionDuration = 500;
                config.SnackbarConfiguration.SnackbarVariant = Variant.Filled;
            });

            await builder.Build().RunAsync();
        }
    }
}
