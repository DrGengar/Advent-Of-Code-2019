using System;
using System.Diagnostics;
using Puzzles.Day_One;

namespace Puzzles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            long neededFuel = TaskOne.Solve();
            Console.WriteLine(neededFuel);
            Debug.WriteLine(neededFuel);
        }
    }
}
