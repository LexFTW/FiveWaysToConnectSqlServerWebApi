using System;
using System.Data.SqlClient;
using System.IO;
using FirstWay.Common.Layer;

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

        public T ExecuteNonQuery()
        {
            try
            {
                return (T)Command.ExecuteScalar();
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
