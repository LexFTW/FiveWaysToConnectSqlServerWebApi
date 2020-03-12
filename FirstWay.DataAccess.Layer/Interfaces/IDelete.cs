namespace FirstWay.DataAccess.Layer.Interfaces
{
    public interface IDelete<T>
    {

        bool Delete(T model);

    }
}
