using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Core;

namespace FirstWay.Business.Layer.AM
{
    public class IoCSupported<TModule> where TModule : IModule, new()
    {

        private readonly IContainer container;

        public IoCSupported()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new TModule());

            container = builder.Build();
        }

        protected TEntity Resolve<TEntity>()
        {
            return container.Resolve<TEntity>();
        }

        protected void Dispose()
        {
            container.Dispose();
        }

    }
}
