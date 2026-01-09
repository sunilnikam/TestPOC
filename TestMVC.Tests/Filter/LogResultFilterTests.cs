using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using TestMVC.Filter;
using Xunit;

namespace TestMVC.Tests.Filter
{
    public class LogResultFilterTests
    {
        //[Fact]
        //public void OnResultExecuting_LogsInformation()
        //{
        //    // Arrange
        //    var loggerMock = new Mock<ILogger<LogResultFilter>>();
        //    var filter = new LogResultFilter(loggerMock.Object);

        //    var httpContext = new DefaultHttpContext();
        //    var routeData = new RouteData();
        //    var actionDescriptor = new ActionDescriptor();
        //    var actionContext = new ActionContext(httpContext, routeData, actionDescriptor);

        //    var context = new ResultExecutingContext(
        //        actionContext,
        //        new List<IFilterMetadata>(),
        //        new ViewResult(),
        //        new Mock<Controller>().Object);

        //    // Act
        //    filter.OnResultExecuting(context);

        //    // Assert
        //    loggerMock.Verify(
        //        x => x.Log(
        //            LogLevel.Information,
        //            It.IsAny<EventId>(),
        //            It.Is<It.IsAnyType>((v, t) => v.ToString().Contains("Executing result")),
        //            null,
        //            It.IsAny<Func<It.IsAnyType, Exception, string>>()),
        //        Times.Once);
        //}

        //[Fact]
        //public void OnResultExecuted_LogsInformation()
        //{
        //    // Arrange
        //    var loggerMock = new Mock<ILogger<LogResultFilter>>();
        //    var filter = new LogResultFilter(loggerMock.Object);

        //    var httpContext = new DefaultHttpContext();
        //    var routeData = new RouteData();
        //    var actionDescriptor = new ActionDescriptor();
        //    var actionContext = new ActionContext(httpContext, routeData, actionDescriptor);

        //    var context = new ResultExecutedContext(
        //        actionContext,
        //        new List<IFilterMetadata>(),
        //        new ViewResult(),
        //        new Mock<Controller>().Object);

        //    // Act
        //    filter.OnResultExecuted(context);

        //    // Assert
        //    loggerMock.Verify(
        //        x => x.Log(
        //            LogLevel.Information,
        //            It.IsAny<EventId>(),
        //            It.Is<It.IsAnyType>((v, t) => v.ToString().Contains("Executed result")),
        //            null,
        //            It.IsAny<Func<It.IsAnyType, Exception, string>>()),
        //        Times.Once);
        //}
    }
}