using Microsoft.AspNetCore.Mvc.Filters;

namespace TestMVC.Filter
{
    public class MyCustomAuthorizeFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            // Custom authorization logic can be implemented here
        }
    }
}