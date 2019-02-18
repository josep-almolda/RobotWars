using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using RobotWars.Utils;

namespace RobotWars
{
    public class RobotWarsProcessor
    {
        private readonly IParser _parser;

        public RobotWarsProcessor(IParser parser)
        {
            _parser = parser;
        }

        public string Process(string input)
        {
            string result;
            try
            {
                var lines = input.Split('\n');

                var arena = new Arena(_parser.ParseDimensions(lines[0].Trim()));

                for (var index = 1; index < lines.Length; index += 2)
                {
                    var robot = new Robot(_parser.ParsePosition(lines[index].Trim()));
                    _parser.ParseCommands(lines[index + 1].Trim()).ForEach(command =>
                    {
                        robot.AddCommand(command);
                    });
                    arena.AddRobot(robot);
                }

                result = _parser.FormatPositions(arena.ReportRobotsPositions());
            }
            catch (Exception ex)
            {
                result = $"Input is not in a correct format: {ex.Message}";
            }
            return result;
        }
    }
}
