using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace VandaCloud.Service.Common.ActionFilter
{
    /// <summary>
    /// 
    /// </summary>
    public class DemoActionFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            // our code before action executes
            Console.WriteLine("OnActionExecuting");
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            // our code after action executes
            Console.WriteLine("OnActionExecuted");
        }
    }
}
