using System;
using System.Data.SqlClient;
using System.IO;

namespace FirstWay.DataAccess.Layer.Utilities
{
    class CommandUtility<T>
    {
        public SqlCommand Command { get; private set; }

        public CommandUtility(string query, ConnectionUtility connection)
        {
            Command = new SqlCommand(query, connection.Connection);
        }

        public void AddParameter(string id, string value)
        {
            Command.Parameters.AddWithValue(id, value);
        }


        public void AddParameter(string id, int value)
        {
            Command.Parameters.AddWithValue(id, value);
        }

        public void AddParameter(string id, Guid value)
        {
            Command.Parameters.AddWithValue(id, value);
        }

        public int ExecuteNonQuery()
        {
            try
            {
                return Command.ExecuteNonQuery();
            }
            catch (ObjectDisposedException)
            {
                throw;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (InvalidCastException)
            {
                throw;
            }
            catch (IOException)
            {
                throw;
            }
            catch (InvalidOperationException)
            {
                throw;
            }
        }
    }
}
