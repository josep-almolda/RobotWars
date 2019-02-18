using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotWars.Models;

namespace RobotWarsTests.Utils.Parser
{
    [TestClass]
    public class ParsePosition
    {
        [TestMethod]
        public void WhenInputCorrectReturnPositionObject()
        {
            // Arrange
            var input = "1 2 E";
            var systemUnderTest = new RobotWars.Utils.Parser();    

            // Act
            var result = systemUnderTest.ParsePosition(input);

            // Assert
            result.Should().BeOfType<Position>();
            result.X.Should().Be(1);
            result.Y.Should().Be(2);
            result.Heading.Should().Be(Heading.E);

        }

    }
}
