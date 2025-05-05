using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace sgi_app.infrastructure.mysql
{
    public class conexSinglenton
    {

        private static conexSinglenton? _instance;
        private readonly string _connectionString;
        private MySqlConnection? _connection;
        private conexSinglenton(string connectionString)
        {
            _connectionString = connectionString;
        }
        public static conexSinglenton Instace(string connectionString)
        {
            if (_instance == null)
            {
                _instance = new conexSinglenton(connectionString);
            }
            return _instance;
        }
        
    }
}