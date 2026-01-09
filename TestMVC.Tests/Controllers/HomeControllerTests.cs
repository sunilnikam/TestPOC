using System.Diagnostics;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestMVC.Controllers;
using TestMVC.Models;
using Xunit;

namespace TestMVC.Tests.Controllers
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_ReturnsViewResult()
        {
            var controller = new HomeController
            {
                ControllerContext = new ControllerContext
                {
                    HttpContext = new DefaultHttpContext()
                }
            };

            var result = controller.Index();

            result.Should().BeOfType<ViewResult>();
        }

        [Fact]
        public void Privacy_ReturnsViewResult()
        {
            var controller = new HomeController
            {
                ControllerContext = new ControllerContext
                {
                    HttpContext = new DefaultHttpContext()
                }
            };

            var result = controller.Privacy();

            result.Should().BeOfType<ViewResult>();
        }

        [Fact]
        public void Error_WhenActivityNull_UsesHttpContextTraceIdentifier()
        {
            Activity.Current = null;

            var traceId = "trace-123";
            var httpContext = new DefaultHttpContext();
            httpContext.TraceIdentifier = traceId;

            var controller = new HomeController
            {
                ControllerContext = new ControllerContext
                {
                    HttpContext = httpContext
                }
            };

            var result = controller.Error() as ViewResult;
            result.Should().NotBeNull();

            var model = result!.Model as ErrorViewModel;
            model.Should().NotBeNull();
            model!.RequestId.Should().Be(traceId);
        }

        [Fact]
        public void Error_WhenActivityPresent_UsesActivityId()
        {
            var activity = new Activity("test-activity");
            activity.Start();
            try
            {
                var httpContext = new DefaultHttpContext();
                var controller = new HomeController
                {
                    ControllerContext = new ControllerContext
                    {
                        HttpContext = httpContext
                    }
                };

                var result = controller.Error() as ViewResult;
                result.Should().NotBeNull();

                var model = result!.Model as ErrorViewModel;
                model.Should().NotBeNull();
                model!.RequestId.Should().Be(activity.Id);
            }
            finally
            {
                activity.Stop();
                Activity.Current = null;
            }
        }
    }
}