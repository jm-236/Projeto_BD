using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace patrimonioDB.Shared.Database
{
    public class DatabaseConnection
    {
        private const string ConnectionString = @"Host=localhost;Port=5433;Username=postgres;Password=Pecm3563#;Database=dbpatrimonio";

        public static NpgsqlConnection GetConnection()
        {
            var connection = new NpgsqlConnection(ConnectionConfig.ConnectionString);
            connection.Open();
            return connection;
        }
    }
}
