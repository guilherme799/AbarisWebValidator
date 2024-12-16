using Microsoft.AspNetCore;

namespace AbarisWebValidator.SampleWebValidator.WCF
{
    public class Program
    {
        static void Main(string[] args)
        {
            IWebHost host = CreateWebHostBuilder(args).Build();
            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
           WebHost.CreateDefaultBuilder(args)
            .UseStartup<BasicHttpBindingStartup>();
    }
}
