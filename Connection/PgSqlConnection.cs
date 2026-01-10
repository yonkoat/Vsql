using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Vsql.Connection
{
    public class PgSqlConnection
    {
        private readonly string ConnectionString;

        public PgSqlConnection(string host, string database, string username, string password, int port = 5432)
        {
            ConnectionString = $"Host={host};Port={port};Database={database};Username={username};Password={password};";
        }

        public void TestConnection()
        {
            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Подключение успешно!");

                    
                    using (var cmd = new NpgsqlCommand("SELECT version();", connection))
                    {
                        var version = cmd.ExecuteScalar();
                        Console.WriteLine($"Версия PostgreSQL: {version}");
                    }
                }
                catch (NpgsqlException ex)
                {
                    Console.WriteLine($"Ошибка подключения: {ex.Message}");
                }
            }
        }
    }

}

