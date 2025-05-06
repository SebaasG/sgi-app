using System;
using Microsoft.Extensions.Configuration;
using sgi_app.domain.factory;
using sgi_app.infrastructure.mysql;

namespace MiAppConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Obtener sección de la configuración
            var dbSettings = configuration.GetSection("DatabaseSettings");

            // Obtener valores individuales
            var server = dbSettings["Server"];
            var port = dbSettings["Port"];
            var database = dbSettings["Database"];
            var user = dbSettings["User"];
            var password = dbSettings["Password"];

            // Construir la cadena de conexión
            var connectionString = $"Server={server};Port={port};Database={database};User={user};Password={password};";

            // Mostrar o usar la cadena
            Console.WriteLine("Cadena de conexión generada:");
            Console.WriteLine(connectionString);


            var conec = new mysqlDbFactory(connectionString);
           

        }
    }
}
