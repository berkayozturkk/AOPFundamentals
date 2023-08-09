using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Interceptors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleDynamicProxyFirstApp
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var proxy = new ProxyGenerator();
            var aspect = proxy
                .CreateClassProxy<MyClass>(new MyInterceptorAspect());

            aspect.MyMethod();

            Console.WriteLine(new String('-',50));

            var builder = new ContainerBuilder();
            builder.RegisterType<MyClass>()
                .As<MyClass>()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                })
                .SingleInstance();

            Console.ReadLine();
        }
    }
}
