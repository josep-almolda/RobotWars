﻿using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotWars;
using RobotWars.Models;

namespace RobotWarsTests.Commands
{
    [TestClass]
    public class RightCommand
    {
        [TestMethod]
        public void WhenEInputHeadingChangesToS()
        {
            // Arrange
            var otherRobots = new List<Robot>();
            var dimensions = new Dimensions(3, 3);
            var initialPosition = new Position(0, 0, Heading.E);
            var systemUnderTest = new RobotWars.Commands.RightCommand();

            // Act
            var result = systemUnderTest.Execute(initialPosition, otherRobots, dimensions);

            // Assert
            result.Should().BeOfType<Position>();
            result.X.Should().Be(initialPosition.X);
            result.Y.Should().Be(initialPosition.Y);
            result.Heading.Should().Be(Heading.S);
        }

        [TestMethod]
        public void WhenSInputHeadingChangesToW()
        {
            // Arrange
            var otherRobots = new List<Robot>();
            var dimensions = new Dimensions(3, 3);
            var initialPosition = new Position(0, 0, Heading.S);
            var systemUnderTest = new RobotWars.Commands.RightCommand();

            // Act
            var result = systemUnderTest.Execute(initialPosition, otherRobots, dimensions);

            // Assert
            result.Should().BeOfType<Position>();
            result.X.Should().Be(initialPosition.X);
            result.Y.Should().Be(initialPosition.Y);
            result.Heading.Should().Be(Heading.W);
        }

        [TestMethod]
        public void WhenWInputHeadingChangesToN()
        {
            // Arrange
            var otherRobots = new List<Robot>();
            var dimensions = new Dimensions(3, 3);
            var initialPosition = new Position(0, 0, Heading.W);
            var systemUnderTest = new RobotWars.Commands.RightCommand();

            // Act
            var result = systemUnderTest.Execute(initialPosition, otherRobots, dimensions);

            // Assert
            result.Should().BeOfType<Position>();
            result.X.Should().Be(initialPosition.X);
            result.Y.Should().Be(initialPosition.Y);
            result.Heading.Should().Be(Heading.N);
        }

        [TestMethod]
        public void WhenNInputHeadingChangesToE()
        {
            // Arrange
            var otherRobots = new List<Robot>();
            var dimensions = new Dimensions(3, 3);
            var initialPosition = new Position(0, 0, Heading.N);
            var systemUnderTest = new RobotWars.Commands.RightCommand();

            // Act
            var result = systemUnderTest.Execute(initialPosition, otherRobots, dimensions);

            // Assert
            result.Should().BeOfType<Position>();
            result.X.Should().Be(initialPosition.X);
            result.Y.Should().Be(initialPosition.Y);
            result.Heading.Should().Be(Heading.E);
        }
    }
}
