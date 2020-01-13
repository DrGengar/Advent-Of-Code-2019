using System;
using System.Diagnostics;
using Puzzles.Solution;

namespace Puzzles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            long fuelForMass = TaskOne.CalculateFuelForMass();
            Console.WriteLine(fuelForMass);
            Debug.WriteLine(fuelForMass);

            long fuelForMassAndFuel = TaskOne.CalculateFuelForMassAndFuel();
            Console.WriteLine(fuelForMassAndFuel);
            Debug.WriteLine(fuelForMassAndFuel);
        }
    }
}
