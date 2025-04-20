using Xunit;
using WorkFlow_for_labs.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace MyAspNetApp.Tests
{
    public class MathControllerTests
    {
        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            // Arrange
            var controller = new MathController();

            // Act
            var result = controller.Add(5, 3);
            var okResult = result.Result as OkObjectResult;

            // Assert
            Assert.NotNull(okResult);
            Assert.Equal(8, okResult.Value);
        }
    }
}

