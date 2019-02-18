using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotWars.Models;

namespace RobotWarsTests.Utils.Parser
{
    [TestClass]
    public class FormatPosition
    {
        [TestMethod]
        public void WhenInputCorrectreturnPositionString()
        {
            // Arrange
            var input = new List<Position>()
            {
                new Position(1, 2, Heading.N),
                new Position(3, 4, Heading.W),
            };
            var systemUnderTest = new RobotWars.Utils.Parser();    

            // Act
            var result = systemUnderTest.FormatPositions(input);

            // Assert
            result.Should().BeOfType<string>();
            var split = result.Split('\n');
            result.Split('\n').Length.Should().Be(2);
            result.Split('\n')[0].Should().Be("1 2 N");
            result.Split('\n')[1].Should().Be("3 4 W");
        }

    }
}
