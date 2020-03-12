using System.Collections.Generic;

namespace FirstWay.Business.Layer
{
    public interface IBusiness<T>
    {

        T Add(T model);

        List<T> Get(T model);

    }
}
