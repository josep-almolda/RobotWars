using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RobotWars.Models;

namespace RobotWars
{
    public class Arena
    {
        public Dimensions Dimensions { get; }
        public List<Robot> Robots { get; } = new List<Robot>();

        public Arena(Dimensions dimensions)
        {
            Dimensions = dimensions;
        }

        public void AddRobot(Robot robot)
        {
            robot.ExecuteCommands(Robots, Dimensions);
            Robots.Add(robot);
        }

        public List<Position> ReportRobotsPositions()
        {
            return Robots.Select(r => r.Report()).ToList();
        }
    }
}
