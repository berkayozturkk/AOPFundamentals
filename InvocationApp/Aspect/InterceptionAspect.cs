﻿using Castle.DynamicProxy;
using Core.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvocationApp.Aspect
{
    public class InterceptionAspect : MethodInterception
    {
        public override void OnBefore(IInvocation invocation)
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

            Console.WriteLine();
        }

        public override void OnAfter(IInvocation invocation)
        {
            Console.WriteLine("After {0} invocation.", invocation.Method);
        }
    }
}
