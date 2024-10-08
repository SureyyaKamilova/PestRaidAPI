﻿using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helpers.Interceptors
{
    public class MethodInterception:MethodInterceptorBaseAttribute
    {
        public virtual void OnBefore(IInvocation invocation)
        {

        }
        public virtual void OnAfter(IInvocation invocation) { }
        public virtual void OnException(IInvocation invocation,System.Exception exception) { }
        public virtual void OnSuccess(IInvocation invocation) { }

        public override void Intercept(IInvocation invocation)
        {
            var isSuccess = true;
            OnBefore(invocation);
            try
            {
                invocation.Proceed();
            }
            catch (Exception exception)
            {
                isSuccess = false;
                OnException(invocation, exception);
                throw;
            }
            finally
            {
                if (isSuccess)
                {
                    OnSuccess(invocation);
                }
            }
            OnAfter(invocation);

        }
    }
}
