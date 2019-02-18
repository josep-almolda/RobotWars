using System;
using System.Collections.Generic;
using System.Text;

namespace RobotWars.Models
{
    public class Position
    {
        public int X { get; }
        public int Y { get;  }
        public Heading Heading { get; set; }

        public Position(int x, int y, Heading heading)
        {
            X = x;
            Y = y;
            Heading = Heading;
        }
    }
}
