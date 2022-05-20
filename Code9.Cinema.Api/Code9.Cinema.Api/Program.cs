using Code9.Cinema.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Code9.Cinema.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DataBase.MockCinemaDataBase();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
