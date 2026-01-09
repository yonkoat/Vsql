using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsql.Connection
{
    public class SqlConnectionManager : IDisposable
    {
        private SqlConnection connection;
        private readonly string connectionString;
        private bool disposed = false;
        public SqlConnectionManager(string ConnectionString)
        {
            if (string.IsNullOrWhiteSpace(ConnectionString))
            {
                throw new ArgumentException("Connection string cant be null or empty: " + nameof(connectionString));
            }
            connectionString = ConnectionString;
        }

        public int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            using (var command = new SqlCommand(sql, OpenConnection()))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                return command.ExecuteNonQuery();
            }
        }

        public DataTable GetDataTable(string sql, params SqlParameter[] parameters)
        {
            if(sql == null)
            {
                MessageBox.Show("Sql query cant be null");
                return null;
            }
            using (var command = new SqlCommand(sql, connection))
            {
                if (connection == null)
                {
                    MessageBox.Show("Connect to your database first");
                    return null;
                }
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                using (var adapter = new SqlDataAdapter(command))
                {
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public SqlConnection OpenConnection()
        {
            try
            {
                if (connection == null)
                {
                    connection = new SqlConnection(connectionString);
                }

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                return connection;
            }
            catch(SqlException ex)
            {
                throw new ArgumentException($"Failed to open sql server: {ex.Message} ", ex);
            }    
        }

        public void CloseConnection()
        {
            try
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Couldnt close the sql connection due to Error: {ex}");
            }
        }

        public void Dispose()
        {
            Dispose(true);
            MessageBox.Show("Connection disposed");
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    CloseConnection();
                    connection?.Dispose();
                }
                disposed = true;
            }
        }

        
        // сделать доп метод для отключения от сети
        // Сделать метод проверки ключа подключения
        // сделать метод освобождения ресурсов
        
        
    }
}
