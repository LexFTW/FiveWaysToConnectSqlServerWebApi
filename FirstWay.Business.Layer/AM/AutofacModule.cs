using Autofac;
using FirstWay.Common.Layer;
using FirstWay.DataAccess.Layer;
using FirstWay.DataAccess.Layer.Interfaces;

namespace FirstWay.Business.Layer.AM
{
    public class AutofacModule : Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StudentDao>().As<IRepository<Student>>();
            base.Load(builder);
        }

    }
}
