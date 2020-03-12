using System.Collections.Generic;

namespace FirstWay.DataAccess.Layer.Interfaces
{
    public interface IRead<T>
    {

        IEnumerable<T> GetAll(T model);
        T GetById(int id);

    }
}
