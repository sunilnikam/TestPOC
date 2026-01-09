using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using Moq;
using TestMVC.Filter;
using Xunit;

namespace TestMVC.Tests.Filter
{
    public class LogActionFilterTests
    {
        //[Fact]
        //public void OnActionExecuting_LogsInformation()
        //{
        //    // Arrange
        //    var loggerMock = new Mock<ILogger<LogActionFilter>>();
        //    var filter = new LogActionFilter(loggerMock.Object);

        //    var httpContext = new DefaultHttpContext();
        //    var routeData = new RouteData();
        //    var actionDescriptor = new ActionDescriptor();

        //    var actionContext = new ActionContext(httpContext, routeData, actionDescriptor);
        //    var context = new ActionExecutingContext(
        //        actionContext,
        //        new List<IFilterMetadata>(),
        //        new Dictionary<string, object>(),
        //        new Mock<Controller>().Object);

        //    // Act
        //    filter.OnActionExecuting(context);

        //    // Assert
        //    loggerMock.Verify(
        //        x => x.Log(
        //            LogLevel.Information,
        //            It.IsAny<EventId>(),
        //            It.Is<It.IsAnyType>((v, t) => v.ToString().Contains("Executing action")),
        //            null,
        //            It.IsAny<Func<It.IsAnyType, Exception, string>>()),
        //        Times.Once);
        //}

        //[Fact]
        //public void OnActionExecuted_LogsInformation()
        //{
        //    // Arrange
        //    var loggerMock = new Mock<ILogger<LogActionFilter>>();
        //    var filter = new LogActionFilter(loggerMock.Object);

        //    var httpContext = new DefaultHttpContext();
        //    var routeData = new RouteData();
        //    var actionDescriptor = new ActionDescriptor();

        //    var actionContext = new ActionContext(httpContext, routeData, actionDescriptor);
        //    var context = new ActionExecutedContext(
        //        actionContext,
        //        new List<IFilterMetadata>(),
        //        new Mock<Controller>().Object);

        //    // Act
        //    filter.OnActionExecuted(context);

        //    // Assert
        //    loggerMock.Verify(
        //        x => x.Log(
        //            LogLevel.Information,
        //            It.IsAny<EventId>(),
        //            It.Is<It.IsAnyType>((v, t) => v.ToString().Contains("Executed action")),
        //            null,
        //            It.IsAny<Func<It.IsAnyType, Exception, string>>()),
        //        Times.Once);
        //}
    }
}