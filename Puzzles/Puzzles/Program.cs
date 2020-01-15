using Challenges.Solution.DayOne;
using Challenges.Solution.DayTwo;
using System;
using System.Diagnostics;

namespace Challenges
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SolveDayOneChallenge();
            Console.WriteLine();

            SolveDayTwoChallenge();
            Console.WriteLine();
        }

        private static void SolveDayOneChallenge()
        {
            Console.WriteLine("##### Day One ######");
            long fuelForMass = TaskOne.CalculateFuelForMass();
            Console.WriteLine(fuelForMass);
            Debug.WriteLine(fuelForMass);

            long fuelForMassAndFuel = TaskOne.CalculateFuelForMassAndFuel();
            Console.WriteLine(fuelForMassAndFuel);
            Debug.WriteLine(fuelForMassAndFuel);
        }

        private static void SolveDayTwoChallenge()
        {
            Console.WriteLine("##### Day Two ######");
            int finalValue = TaskTwo.FindFinalValue();
            Console.WriteLine(finalValue);
            Debug.WriteLine(finalValue);

            int output = TaskTwo.FindInputValues();
            Console.WriteLine(output);
            Debug.WriteLine(output);
        }
    }
}
