using Microsoft.AspNetCore.Mvc.Filters;

namespace TestMVC.Filter
{
    public class LogActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // Logica prima dell'esecuzione dell'azione
            base.OnActionExecuting(context);
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            // Logica dopo l'esecuzione dell'azione
            base.OnActionExecuted(context);
        }
    }
}