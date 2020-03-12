namespace FirstWay.DataAccess.Layer.Interfaces
{
    public interface IConnectionUtility
    {

        bool OpenConnection();
        bool CloseConnection();

    }
}
