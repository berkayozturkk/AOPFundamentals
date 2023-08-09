using System;

namespace CastleDynamicProxyFirstApp
{
    public interface IMyClass
    {
        void MyMethod();
    }

    [MyInterceptorAspect]
    public class MyClass : IMyClass
    {
        public virtual void MyMethod()
        {
            Console.WriteLine("MyMethod body.");
        }
    }
}
