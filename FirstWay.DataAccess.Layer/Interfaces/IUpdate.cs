namespace FirstWay.DataAccess.Layer.Interfaces
{
    public interface IUpdate<T>
    {
        T Update(int id, T model);
    }
}
