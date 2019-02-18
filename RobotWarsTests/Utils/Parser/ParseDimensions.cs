using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotWars.Models;

namespace RobotWarsTests.Utils.Parser
{
    [TestClass]
    public class ParseDimensions
    {
        [TestMethod]
        public void WhenInputCorrectReturnDimensionsObject()
        {
            // Arrange
            var input = "3 4";
            var systemUnderTest = new RobotWars.Utils.Parser();    

            // Act
            var result = systemUnderTest.ParseDimensions(input);

            // Assert
            result.Should().BeOfType<Dimensions>();
            result.X.Should().Be(3);
            result.Y.Should().Be(4);

        }

    }
}
