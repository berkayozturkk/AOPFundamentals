using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
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
            var aspect = proxy.CreateClassProxy<MyClass>(new MyInterceptorAspect());

            aspect.MyMethod();

            Console.ReadLine();
        }
    }
}
