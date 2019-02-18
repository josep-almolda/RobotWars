using System;
using System.Collections.Generic;
using System.Text;
using RobotWars.Commands;
using RobotWars.Models;

namespace RobotWars
{
    public class Robot
    {
        private Position Position { get; set; }
        private List<ICommand> Commands { get; } = new List<ICommand>();

        public Robot(Position position)
        {
            Position = position;
        }

        public void AddCommand(ICommand command)
        {
            Commands.Add(command);
        }

        public void ExecuteCommands(List<Robot> robots, Dimensions dimensions)
        {
            foreach (var command in Commands)
            {
                Position = command.Execute(Position, robots, dimensions);
            }
        }

        public Position Report()
        {
            return Position;
        }
    }
}
