using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(The_cool_Library.Areas.Identity.IdentityHostingStartup))]
namespace The_cool_Library.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}