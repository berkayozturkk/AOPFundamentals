using Castle.DynamicProxy;
using System;

namespace CastleDynamicProxyFirstApp
{
    public class MyInterceptorAspect : Attribute,IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("Before {0}",invocation.Method);

            invocation.Proceed();

            Console.WriteLine("After {0}", invocation.Method);
        }
    }
}
