using System.Collections.Generic;

namespace FirstWay.DataAccess.Layer.Interfaces
{
    public interface IRead<T>
    {

        List<T> GetAll(T model);
        T GetById(int id);

    }
}
