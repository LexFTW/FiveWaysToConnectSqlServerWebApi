using System.Data.SqlClient;
using FirstWay.DataAccess.Layer.Interfaces;

namespace FirstWay.DataAccess.Layer.Utilities
{
    class ConnectionUtility : IConnectionUtility
    {
        private readonly SqlConnection Connection;

        public ConnectionUtility()
        {
            Connection = new SqlConnection();
        }

        public bool OpenConnection()
        {
            Connection.Open();
            return true;
        }

        public bool CloseConnection()
        {
            Connection.Close();
            return true;
        }
    }
}
