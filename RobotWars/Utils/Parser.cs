using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using RobotWars.Commands;
using RobotWars.Models;

namespace RobotWars.Utils
{
    public class Parser : IParser
    {
        public Dimensions ParseDimensions(string input)
        {
            try
            {
                var x = int.Parse(input.Substring(0, 1));
                var y = int.Parse(input.Substring(2, 1));
                return new Dimensions(x, y);
            }
            catch (Exception ex)
            {
                throw new Exception($"input is not in a correct format: {ex.Message}");
            }
        }

        public Position ParsePosition(string input)
        {
            try
            {
                var x = int.Parse(input.Substring(0, 1));
                var y = int.Parse(input.Substring(2, 1));
                var heading = default(Heading);

                switch (input.Substring(4, 1))
                {
                    case "E":
                        heading = Heading.E;
                        break;
                    case "W":
                        heading = Heading.W;
                        break;
                    case "N":
                        heading = Heading.N;
                        break;
                    case "S":
                        heading = Heading.S;
                        break;
                }

                return new Position(x, y, heading);
            }
            catch (Exception ex)
            {
                throw new Exception($"input is not in a correct format: {ex.Message}");
            }
        }

        public List<ICommand> ParseCommands(string input)
        {
            try
            {
                var result = new List<ICommand>();

                foreach (var c in input.ToCharArray())
                {
                    switch (c)
                    {
                        case 'R':
                            result.Add(new RightCommand());
                            break;
                        case 'L':
                            result.Add(new LeftCommand());
                            break;
                        case 'M':
                            result.Add(new MoveCommand());
                            break;
                        default:
                            throw new Exception($"Wrong command letter: ${c}");
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception($"input is not in a correct format: {ex.Message}");
            }
        }

        public string FormatPositions(List<Position> reportRobotsPositions)
        {
            var positions = reportRobotsPositions
                .Select(item => $"{item.X} {item.Y} {item.Heading.ToString()}");
            return string.Join("\n", positions);
        }
    }
}
