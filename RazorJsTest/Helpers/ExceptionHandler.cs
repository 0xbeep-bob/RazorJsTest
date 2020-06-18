using Microsoft.AspNetCore.Mvc.Filters;
using Serilog;

namespace RazorJsTest.Helpers
{
    public class ExceptionHandler : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context) { }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Exception != null)
            {
                context.ExceptionHandled = true;
                Log.Error($"{context?.Exception?.Message}");
            }
        }
    }
}
