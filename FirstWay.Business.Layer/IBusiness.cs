using System.Collections.Generic;
using FirstWay.Common.Layer;

namespace FirstWay.Business.Layer
{
    public interface IBusiness<T>
    {

        T Add(T model);
        IEnumerable<T> Get(T model);
        T Update(T model);
        bool Delete(T model);
    }
}
