using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotWars.Commands;
using RobotWars.Models;

namespace RobotWarsTests.Utils.Parser
{
    [TestClass]
    public class ParseCommands
    {
        [TestMethod]
        public void WhenInputCorrectReturnCommandsList()
        {
            // Arrange
            var input = "RRLMM";
            var systemUnderTest = new RobotWars.Utils.Parser();    

            // Act
            var result = systemUnderTest.ParseCommands(input);

            // Assert
            result.Should().BeOfType<List<ICommand>>();
            result.Count.Should().Be(5);
            result[0].Should().BeOfType<RightCommand>();
            result[1].Should().BeOfType<RightCommand>();
            result[2].Should().BeOfType<LeftCommand>();
            result[3].Should().BeOfType<MoveCommand>();
            result[4].Should().BeOfType<MoveCommand>();

        }

    }
}
