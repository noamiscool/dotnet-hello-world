using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace hello_world_api
{
    public class Program
    {
        public static void Main(string[] args)
        {
		// Open the text file using a stream reader.
		 using StreamReader reader = new("../whatever.link");

	    // Read the stream as a string.
	    string text = reader.ReadToEnd();

	    // Write the text to the console.
	    Console.WriteLine(text);
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
