using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotWars.Utils;

namespace RobotWarsTests.IntegrationTests
{
    [TestClass]
    public class RobotWarsProcessor
    {
        [TestMethod]
        public void TestInput()
        {
            // Arrange

            const string input = @"5 5
                                    1 2 N
                                    LMLMLMLMM
                                    3 3 E
                                    MMRMMRMRRM";
            const string output = "1 3 N\n5 1 E";

            var robotWars = new RobotWars.RobotWarsProcessor(new Parser());

            // Act
            var result = robotWars.Process(input);

            // Assert
            result.Should().Be(output);
        }
    }
}
