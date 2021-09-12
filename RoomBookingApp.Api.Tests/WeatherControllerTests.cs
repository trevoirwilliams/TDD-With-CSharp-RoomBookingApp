using Microsoft.Extensions.Logging;
using Moq;
using RoomBookingApp.Api.Controllers;
using System;
using Xunit;
using Shouldly;
using System.Linq;

namespace RoomBookingApp.Api.Tests
{
    public class WeatherControllerTests
    {
        [Fact]
        public void Should_Return_Forcast_Results()
        {
            var loggerMock = new Mock<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(loggerMock.Object);

            var result = controller.Get();

            result.ShouldNotBeNull();
            result.Count().ShouldBeGreaterThan(1);
            
        }
    }
}
