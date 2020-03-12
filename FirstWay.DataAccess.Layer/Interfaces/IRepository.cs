namespace FirstWay.DataAccess.Layer.Interfaces
{
    public interface IRepository<T> : ICreate<T>, IRead<T>, 
        IUpdate<T>, IDelete<T>{ }
}
