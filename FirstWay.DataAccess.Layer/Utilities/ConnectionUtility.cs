using System;
using System.Configuration;
using System.Data.SqlClient;
using FirstWay.DataAccess.Layer.Interfaces;

namespace FirstWay.DataAccess.Layer.Utilities
{
    class ConnectionUtility : IConnectionUtility
    {
        private SqlConnection Connection;

        public ConnectionUtility()
        {
            Connection = new SqlConnection();
        }

        public bool OpenConnection()
        {
            try
            {
                Connection.Open();
                return true;
            }catch(InvalidOperationException exception)
            {
                throw;
            }catch(SqlException exception)
            {
                throw;
            }catch(ConfigurationException exception)
            {
                throw;
            }
            
        }

        public bool CloseConnection()
        {
            try
            {
                Connection.Close();
                return true;
            }
            catch (SqlException exception)
            {
                throw;
            }
        }
    }
}
