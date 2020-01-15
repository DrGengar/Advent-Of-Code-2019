using Challenges.Source;
using Challenges.Source.Converter;
using Challenges.Source.TextFile;
using System.Collections.Generic;

namespace Challenges.Solution.DayOne
{
    public class TaskOne
    {
        private const string MODULE_MASS_TEXT_FILE_PATH = "D:\\Arbeit\\repositories\\Advent-Of-Code-2019\\Puzzles\\Puzzles\\Solution\\DayOne\\ModuleMassList.txt";

        public static long CalculateFuelForMass()
        {
            TextFileParser<int> parser = new TextFileParser<int>(new IntegerConverter());
            FuelCalculator calculator = new FuelCalculator();

            List<int> moduleMasses = parser.Parse(MODULE_MASS_TEXT_FILE_PATH);
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
            TextFileParser<int> parser = new TextFileParser<int>(new IntegerConverter());
            FuelCalculator calculator = new FuelCalculator();

            List<int> moduleMasses = parser.Parse(MODULE_MASS_TEXT_FILE_PATH);
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
