using System;
using System.Collections.Generic;
using System.Text;

namespace RobotWars.Models
{
    public class Dimensions
    {
        public int X { get; }
        public int Y { get; }

        public Dimensions(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
