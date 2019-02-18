using System;
using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using RobotWars.Commands;
using RobotWars.Models;
using RobotWars.Utils;

namespace RobotWarsTests.RobotWarsProcessor
{
    [TestClass]
    public class Process
    {
        private const string input =  @"5 5
                                        1 2 N
                                        LMLMLMLMM
                                        3 3 E
                                        MMRMMRMRRM";

        [TestMethod]
        public void WhenInputIsCorrectCallParseDimensions()
        {
            // Arrange
            var parser = Substitute.For<IParser>();
            var systemUnderTest = new RobotWars.RobotWarsProcessor(parser);

            // Act
            systemUnderTest.Process(input);

            // Assert
            parser.Received(1).ParseDimensions("5 5");

        }

        [TestMethod]
        public void WhenInputIsCorrectCallParsePosition()
        {
            // Arrange
            var parser = Substitute.For<IParser>();
            parser.ParseCommands(Arg.Any<string>()).Returns(new List<ICommand>());

            var systemUnderTest = new RobotWars.RobotWarsProcessor(parser);

            // Act
            systemUnderTest.Process(input);

            // Assert
            parser.Received(2).ParsePosition(Arg.Any<string>());

        }

        [TestMethod]
        public void WhenInputIsCorrectCallParseCommands()
        {
            // Arrange
            var parser = Substitute.For<IParser>();
            parser.ParsePosition(Arg.Any<string>()).Returns(new Position(0, 0, Heading.E));
            parser.ParseCommands(Arg.Any<string>()).Returns(new List<ICommand>());

            var systemUnderTest = new RobotWars.RobotWarsProcessor(parser);


            // Act
            systemUnderTest.Process(input);

            // Assert
            parser.Received(2).ParseCommands(Arg.Any<string>());

        }

        [TestMethod]
        public void WhenInputIsIncorrectReturnErrorMessage()
        {
            // Arrange
            var parser = Substitute.For<IParser>();
            parser.ParsePosition(Arg.Any<string>()).Returns(x => 
                throw new Exception("Exception"));
            var systemUnderTest = new RobotWars.RobotWarsProcessor(parser);


            // Act
            var result = systemUnderTest.Process(input);

            // Assert
            result.Should().Contain("Input is not in a correct format");

        }

    }
}
