﻿using AopAlliance.Intercept;
using KuasCore.Models;
using System;
using System.Diagnostics;

namespace KuasCore.Interceptors
{
    class UpdateEmployeeNameInterceptor : IMethodInterceptor
    {
        public object Invoke(IMethodInvocation invocation)
        {
            Console.WriteLine("UpdateEmployeeNameInterceptor 攔截到一個方法呼叫 = [{0}]", invocation);
            Debug.Print("UpdateEmployeeNameInterceptor 攔截到一個方法呼叫 = [{0}]", invocation);

            object result = invocation.Proceed();

            if (result is Employee)
            {
                Employee employee = (Employee)result;
                employee.Name = employee.Name + "_BY_第一個AOP作業";
                result = employee;
            }

        

            return result;
        }
    }
}
