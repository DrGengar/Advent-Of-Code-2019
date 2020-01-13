using System.Collections.Generic;
using Puzzles.Solution.Parser;

namespace Puzzles.Solution
{
    public class TaskOne
    {
        private const string MODULE_MASS_TEXT_FILE = "D:\\Arbeit\\repositories\\Advent-Of-Code-2019\\Puzzles\\Puzzles\\Solution\\ModuleMassList.txt";

        public static long CalculateFuelForMass()
        {
            IntegerTextFileParser parser = new IntegerTextFileParser();
            FuelCalculator calculator = new FuelCalculator();

            List<int> moduleMasses = parser.Parse(MODULE_MASS_TEXT_FILE);
            long neededFuel = 0;
            foreach (int mass in moduleMasses)
            {
                Module module = new Module(mass);
                neededFuel += calculator.CalculateForMass(module);
            }

            return neededFuel;
        }

        public static long CalculateFuelForMassAndFuel()
        {
            IntegerTextFileParser parser = new IntegerTextFileParser();
            FuelCalculator calculator = new FuelCalculator();

            List<int> moduleMasses = parser.Parse(MODULE_MASS_TEXT_FILE);
            long neededFuel = 0;
            foreach (int mass in moduleMasses)
            {
                Module module = new Module(mass);
                long fuelForMass = calculator.CalculateForMass(module);
                long fuelForFuel = calculator.CalculateForFuel(fuelForMass);
                neededFuel += (fuelForMass + fuelForFuel);
            }

            return neededFuel;
        }
    }
}
