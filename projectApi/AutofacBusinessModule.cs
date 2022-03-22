using ApiFunction.Product;
using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolves.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
         
            //builder.RegisterType<ProductApi>().As<ProductApi>();
           /// builder.RegisterType<EfProductDal>().As<IProductDal>();

            
        }
    }
}
