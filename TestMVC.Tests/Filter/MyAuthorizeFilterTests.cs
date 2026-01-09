using System.Collections.Generic;
using System.Security.Claims;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using TestMVC.Filter;
using Xunit;

namespace TestMVC.Tests.Filter
{
    public class MyAuthorizeFilterTests
    {
        //[Fact]
        //public void OnAuthorization_WhenUserNotAuthenticated_ReturnsUnauthorizedResult()
        //{
        //    // Arrange
        //    var filter = new MyAuthorizeFilter();
        //    var httpContext = new DefaultHttpContext();
        //    httpContext.User = new ClaimsPrincipal(new ClaimsIdentity()); // Not authenticated

        //    var actionContext = new ActionContext(httpContext, new RouteData(), new ActionDescriptor());
        //    var context = new AuthorizationFilterContext(actionContext, new List<IFilterMetadata>());

        //    // Act
        //    filter.OnAuthorization(context);

        //    // Assert
        //    context.Result.Should().BeOfType<UnauthorizedResult>();
        //}

        //[Fact]
        //public void OnAuthorization_WhenUserIsAuthenticated_DoesNotSetResult()
        //{
        //    // Arrange
        //    var filter = new MyAuthorizeFilter();
        //    var claims = new[] { new Claim(ClaimTypes.Name, "testuser") };
        //    var identity = new ClaimsIdentity(claims, "TestAuthType");
        //    var user = new ClaimsPrincipal(identity);

        //    var httpContext = new DefaultHttpContext { User = user };

        //    var actionContext = new ActionContext(httpContext, new RouteData(), new ActionDescriptor());
        //    var context = new AuthorizationFilterContext(actionContext, new List<IFilterMetadata>());

        //    // Act
        //    filter.OnAuthorization(context);

        //    // Assert
        //    context.Result.Should().BeNull();
        //}
    }
}