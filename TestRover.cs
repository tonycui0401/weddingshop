using System;
using Xunit;
using RobotRovers;

namespace RobotRoversTests
{
    public class TestRover
    {
        [Fact]
        public void Test_MoveN()
        {
            // Arrange
            Rover rover = new Rover(1, 1, Heading.N);

            // Act
            rover.Move();

            // Assert
            Assert.Equal(1, rover.Location.X);
            Assert.Equal(2, rover.Location.Y);
            Assert.Equal(Heading.N, rover.Heading);
        }

        [Fact]
        public void Test_MoveE()
        {
            // Arrange
            Rover rover = new Rover(1, 1, Heading.E);

            // Act
            rover.Move();

            // Assert
            Assert.Equal(2, rover.Location.X);
            Assert.Equal(1, rover.Location.Y);
            Assert.Equal(Heading.E, rover.Heading);
        }

        [Fact]
        public void Test_MoveS()
        {
            // Arrange
            Rover rover = new Rover(1, 1, Heading.S);

            // Act
            rover.Move();

            // Assert
            Assert.Equal(1, rover.Location.X);
            Assert.Equal(0, rover.Location.Y);
            Assert.Equal(Heading.S, rover.Heading);
        }

        [Fact]
        public void Test_MoveW()
        {
            // Arrange
            Rover rover = new Rover(1, 1, Heading.W);

            // Act
            rover.Move();

            // Assert
            Assert.Equal(0, rover.Location.X);
            Assert.Equal(1, rover.Location.Y);
            Assert.Equal(Heading.W, rover.Heading);
        }

        [Fact]
        public void Test_ExecuteCommandFrom_1_2_N()
        {
            // Arrange
            string command = "LMLMLMLMM";
            Rover rover = new Rover(1, 2, Heading.N);

            // Act
            rover.ExecuteCommand(command);

            // Assert
            Assert.Equal(1, rover.Location.X);
            Assert.Equal(3, rover.Location.Y);
            Assert.Equal(Heading.N, rover.Heading);
        }

        [Fact]
        public void Test_ExecuteCommandFrom_3_3_E()
        {
            // Arrange
            string command = "MMRMMRMRRM";
            Rover rover = new Rover(3, 3, Heading.E);

            // Act
            rover.ExecuteCommand(command);

            // Assert
            Assert.Equal(5, rover.Location.X);
            Assert.Equal(1, rover.Location.Y);
            Assert.Equal(Heading.E, rover.Heading);
        }
    }
}
