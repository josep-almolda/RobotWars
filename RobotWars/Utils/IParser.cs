using System;
using System.Collections.Generic;
using System.Text;
using RobotWars.Commands;
using RobotWars.Models;

namespace RobotWars.Utils
{
    public interface IParser
    {
        Dimensions ParseDimensions(string input);
        Position ParsePosition(string input);
        List<ICommand> ParseCommamnds(string input);
        string FormatPositions(List<Position> reportRobotsPositions);
    }
}
