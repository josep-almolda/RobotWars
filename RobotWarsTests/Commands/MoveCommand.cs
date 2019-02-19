using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotWars;
using RobotWars.Models;

namespace RobotWarsTests.Commands
{
    [TestClass]
    public class MoveCommand
    {
        [DataTestMethod]
        [DataRow(0, 0, Heading.E, 1, 0)]
        [DataRow(0, 0, Heading.N, 0, 1)]
        [DataRow(1, 1, Heading.S, 1, 0)]
        [DataRow(1, 1, Heading.W, 0, 1)]
        public void WhenValidMovementNewPositionChangesBasedOnHeading(
            int initialPositionX, 
            int initialPositionY, 
            Heading heading,
            int finalPositionX,
            int finalPositionY
            )
        {
            // Arrange
            var otherRobots = new List<Robot>();
            var dimensions = new Dimensions(3, 3);
            var initialPosition = new Position(initialPositionX, initialPositionY, heading);
            var systemUnderTest = new RobotWars.Commands.MoveCommand();

            // Act
            var result = systemUnderTest.Execute(initialPosition, otherRobots, dimensions);

            // Assert
            result.Should().BeOfType<Position>();
            result.X.Should().Be(finalPositionX);
            result.Y.Should().Be(finalPositionY);
            result.Heading.Should().Be(heading);
        }

        [DataTestMethod]
        [DataRow(1, 1, Heading.E, 1, 1)]
        [DataRow(1, 1, Heading.N, 1, 1)]
        [DataRow(1, 1, Heading.S, 1, 1)]
        [DataRow(1, 1, Heading.W, 1, 1)]
        public void WhenOtherRobotInTheWayPositionStaysTheSame(
            int initialPositionX,
            int initialPositionY,
            Heading heading,
            int finalPositionX,
            int finalPositionY
            )
        {
            // Arrange
            var otherRobots = new List<Robot>
            {
                new Robot(new Position(0, 1, Heading.E)),
                new Robot(new Position(1, 0, Heading.E)),
                new Robot(new Position(1, 2, Heading.E)),
                new Robot(new Position(2, 1, Heading.E)),
            };
            var dimensions = new Dimensions(3, 3);
            var initialPosition = new Position(initialPositionX, initialPositionY, heading);
            var systemUnderTest = new RobotWars.Commands.MoveCommand();

            // Act
            var result = systemUnderTest.Execute(initialPosition, otherRobots, dimensions);

            // Assert
            result.Should().BeOfType<Position>();
            result.X.Should().Be(finalPositionX);
            result.Y.Should().Be(finalPositionY);
            result.Heading.Should().Be(heading);
        }

        [DataTestMethod]
        [DataRow(3, 3, Heading.E, 3, 3)]
        [DataRow(3, 3, Heading.N, 3, 3)]
        [DataRow(0, 0, Heading.S, 0, 0)]
        [DataRow(0, 0, Heading.W, 0, 0)]
        public void WhenMovementOutOfTheArenaPositionStaysTheSame(
            int initialPositionX,
            int initialPositionY,
            Heading heading,
            int finalPositionX,
            int finalPositionY
            )
        {
            // Arrange
            var otherRobots = new List<Robot>
            {
                new Robot(new Position(0, 1, Heading.E)),
                new Robot(new Position(1, 0, Heading.E)),
                new Robot(new Position(1, 2, Heading.E)),
                new Robot(new Position(2, 1, Heading.E)),
            };
            var dimensions = new Dimensions(3, 3);
            var initialPosition = new Position(initialPositionX, initialPositionY, heading);
            var systemUnderTest = new RobotWars.Commands.MoveCommand();

            // Act
            var result = systemUnderTest.Execute(initialPosition, otherRobots, dimensions);

            // Assert
            result.Should().BeOfType<Position>();
            result.X.Should().Be(finalPositionX);
            result.Y.Should().Be(finalPositionY);
            result.Heading.Should().Be(heading);
        }

    }
}
