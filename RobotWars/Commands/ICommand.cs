using System;
using System.Collections.Generic;
using System.Text;
using RobotWars.Models;

namespace RobotWars.Commands
{
    public interface ICommand
    {
        Position Execute(Position position, List<Robot> robots, Dimensions dimensions);
    }
}
