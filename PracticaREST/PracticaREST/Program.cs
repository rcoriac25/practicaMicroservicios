using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaREST
{
    /// <summary>
    /// Clase Program 
    /// </summary>
    public class Program
    {
        /// <summary>
        /// M�todo Main
        /// </summary>
        /// <param name="args">Argumentos de Inicio</param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        /// <summary>
        /// M�todo de Cracion de Host
        /// </summary>
        /// <param name="args">Argumentos de inicio</param>
        /// 
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
