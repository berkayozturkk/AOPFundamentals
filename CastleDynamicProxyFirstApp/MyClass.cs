using System;

namespace CastleDynamicProxyFirstApp
{
    [MyInterceptorAspect]
    public class MyClass
    {
        public virtual void MyMethod()
        {
            Console.WriteLine("MyMethod body.");
        }
    }
}
