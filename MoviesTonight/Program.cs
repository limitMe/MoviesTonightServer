using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;

using MoviesTonight.Support;
using MoviesTonight.Models;

namespace MoviesTonight
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            BasicInfo.Instance.movies = JsonConvert.DeserializeObject<List<MovieInfo>>(File.ReadAllText("movies.json"));

            host.Run();
        }
    }
}
