using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using RegistrodeTecnico.Components;
using RegistrodeTecnico.Components.DAL;
using System;
using System.Threading.Tasks;
using RegistrodeTecnico.DAL;

namespace YourProjectNamespace
{
    public class Program
    {
        public static object WebAssemblyHostBuilder { get; private set; }

        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddSingleton<TecDAL>();

            await builder.Build().RunAsync();
        }
    }
}
