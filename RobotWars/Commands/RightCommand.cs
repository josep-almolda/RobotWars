using System;
using System.Collections.Generic;
using System.Text;
using RobotWars.Models;

namespace RobotWars.Commands
{
    public class RightCommand : ICommand
    {
        public Position Execute(Position position, List<Robot> robots, Dimensions dimensions)
        {
            Position result;
            switch (position.Heading)
            {
                case Heading.E:
                    result = new Position(position.X, position.Y, Heading.S);
                    break;
                case Heading.S:
                    result = new Position(position.X, position.Y, Heading.W);
                    break;
                case Heading.W:
                    result = new Position(position.X, position.Y, Heading.N);
                    break;
                case Heading.N:
                    result = new Position(position.X, position.Y, Heading.E);
                    break;
                default:
                    result = null;
                    break;
            }

            return result;
        }
    }
}
