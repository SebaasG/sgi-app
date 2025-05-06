using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sgi_app.domain.factory;

namespace sgi_app.infrastructure.mysql
{
    public class mysqlDbFactory : IDbFactory
    {
        private readonly string _connectionString;
        public mysqlDbFactory(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}