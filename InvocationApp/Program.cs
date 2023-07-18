using Castle.DynamicProxy;
using Entities;
using InvocationApp.Aspect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvocationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var proxy = new ProxyGenerator();
            var aspect = proxy.CreateClassProxy<Employee>(new InterceptionAspect());

            aspect.Add(1, "TestName", "TestLastName");

            Console.ReadLine();
        }
    }
}
