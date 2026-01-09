using Microsoft.AspNetCore.Mvc.Filters;

namespace TestMVC.Filter
{
    public class LogResultFilter: ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            // Logica prima dell'esecuzione del risultato
            base.OnResultExecuting(context);
        }
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            // Logica dopo l'esecuzione del risultato
            base.OnResultExecuted(context);
        }
    }
}
