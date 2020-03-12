using System.Collections.Generic;

namespace FirstWay.Business.Layer
{
    public interface IBusiness<T>
    {

        T Add(T model);
        IEnumerable<T> Get();
        T Get(int id);
        T Update(T model);
        bool Delete(T model);
    }
}
