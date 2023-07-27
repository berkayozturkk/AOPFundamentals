using Castle.DynamicProxy;
using Core.Interceptors;
using System;

namespace InvocationApp.Aspect
{
    public class DefensiveProgramingAspect : MethodInterception
    {
        public override void OnBefore(IInvocation invocation)
        {
            var parameters = invocation.Arguments;

            foreach (var p in parameters)
            {
                if (p.Equals(null))
                    throw new ArgumentNullException();
            }
            Console.WriteLine("Null check has been complated for {0} "
                , invocation.Method);
        }
    }
}
