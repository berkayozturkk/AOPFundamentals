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
            var aspect = proxy.CreateClassProxy<Employee>(
                new DefensiveProgramingAspect(),
                new InterceptionAspect());

            var emp1 = new Employee
            {
                Id = 1,
                FirstName = "TestFirstName",
                LastName = "TestLastName"
            };

            aspect.Add(emp1.Id, emp1.FirstName, emp1.LastName);

            Console.ReadLine();
        }
    }
}
