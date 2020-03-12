using System.Data.SqlClient;
using FirstWay.DataAccess.Layer.Interfaces;

namespace FirstWay.DataAccess.Layer.Utilities
{
    class ConnectionUtility
    {
        public SqlConnection Connection { get; private set; }

        public ConnectionUtility()
        {
            Connection = new SqlConnection("Server=.;Database=Vueling;User Id=sa;Password=yourStrong(!)Password;");
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
