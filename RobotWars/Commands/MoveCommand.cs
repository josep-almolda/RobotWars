using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RobotWars.Models;

namespace RobotWars.Commands
{
    public class MoveCommand : ICommand
    {
        private bool IsOutOfArena(Position position, Dimensions dimensions)
        {
            return position.X > dimensions.X ||
                   position.Y > dimensions.X ||
                   position.X < 0 ||
                   position.Y < 0;
        }

        private bool IsARobotClash(Position position, List<Robot> robots)
        {
            return robots.Any(r => r.Report().X == position.X && r.Report().Y == position.Y);
        }

        public Position Execute(Position position, List<Robot> robots, Dimensions dimensions)
        {
            var newPosition = new Position(position.X, position.Y, position.Heading);

            switch (position.Heading)
            {
                case Heading.E:
                    newPosition = new Position(position.X + 1, position.Y, position.Heading);
                    break;
                case Heading.S:
                    newPosition = new Position(position.X, position.Y - 1, position.Heading);
                    break;
                case Heading.N:
                    newPosition = new Position(position.X, position.Y + 1, position.Heading);
                    break;
                case Heading.W:
                    newPosition = new Position(position.X - 1, position.Y, position.Heading);
                    break;
            }

            if (IsOutOfArena(newPosition, dimensions) || IsARobotClash(newPosition, robots))
            {
                return position;
            }

            return newPosition;
        }
    }
}
