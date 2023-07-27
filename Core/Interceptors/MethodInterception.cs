﻿using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interceptors
{
    public class MethodInterception : MethodInterceptionBaseAttribute
    {
        public override void Intercept(IInvocation invocation)
        {
            bool succesFlag = true;
            OnBefore(invocation);

            try
            {
                invocation.Proceed();
            }
            catch (Exception ex)
            {
                succesFlag = false;
                OnException(invocation, ex);
                throw;
            }
            finally
            {
                if(succesFlag)
                    OnSucces(invocation);
            }

            OnAfter(invocation);
        }

        public virtual void OnBefore(IInvocation invocation) { }
        public virtual void OnAfter(IInvocation invocation) { }
        public virtual void OnException(IInvocation invocation,Exception ex) { }
        public virtual void OnSucces(IInvocation invocation) { }

    }
}
