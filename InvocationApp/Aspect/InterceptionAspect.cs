using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvocationApp.Aspect
{
    public class InterceptionAspect : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("Before {0} invocation.",invocation.Method);
            Console.WriteLine($"Method Name : {invocation.Method.Name}.");
            Console.WriteLine($"TargetType : {invocation.TargetType}.");
            //Console.WriteLine($"Invocationtarget : {invocation.InvocationTarget}.");
            Console.WriteLine($"Proxy : {invocation.Proxy}.");

            Console.WriteLine($"ARGUMENTS");
            invocation.Arguments.ToList().ForEach(x =>
            Console.WriteLine($"Type : {x.GetType()}  ,  {x}")
            );

            invocation.Proceed();
            Console.WriteLine("After {0} invocation.", invocation.Method);
        }
    }
}
