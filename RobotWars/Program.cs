using System;
using RobotWars.Utils;

namespace RobotWars
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = string.Empty;
            var currentLine = Console.ReadLine();
            while (currentLine != "S")
            {
                input += $"{currentLine}\n";
                currentLine = Console.ReadLine();
            }
            Console.WriteLine(input);
            var robotWars = new RobotWars(new Parser());
            var result = robotWars.Process(input);
            Console.WriteLine(result);
            Console.ReadKey();
        }        
    }
}
