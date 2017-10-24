using Microsoft.AspNetCore.Hosting;
using System;

namespace KestrelConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new WebHostBuilder()
              .UseStartup<Startup>()
              .UseKestrel(options =>
              {
                  options.AllowSynchronousIO = true;
                  options.AddServerHeader = true;

              })
              .Build();
            host.Run();
        }
    }
}
