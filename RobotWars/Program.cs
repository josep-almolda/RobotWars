using System;
using System.Collections.Generic;
using RobotWars.Utils;

namespace RobotWars
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new List<string>();
            var currentLine = Console.ReadLine();
            while (currentLine != "F")
            {
                input.Add(currentLine);
                currentLine = Console.ReadLine();
            }
            var robotWars = new RobotWarsProcessor(new Parser());
            var result = robotWars.Process(string.Join('\n', input));
            Console.WriteLine(result);
            Console.ReadKey();
        }        
    }
}
