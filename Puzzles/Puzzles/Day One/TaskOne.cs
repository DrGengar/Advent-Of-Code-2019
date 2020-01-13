using System.Collections.Generic;
using Puzzles.Day_One.Parser;

namespace Puzzles.Day_One
{
    public class TaskOne
    {
        private const string MODULE_MASS_TEXT_FILE = "D:\\Arbeit\\repositories\\Advent-Of-Code-2019\\Puzzles\\Puzzles\\Day One\\ModuleMassList.txt";

        public static long Solve()
        {

            IntegerTextFileParser parser = new IntegerTextFileParser();

            List<int> moduleMasses = parser.Parse(MODULE_MASS_TEXT_FILE);
            long neededFuel = 0;
            foreach (int mass in moduleMasses)
            {
                Module module = new Module(mass);
                neededFuel += module.CalculateFuel();
            }

            return neededFuel;
        }
    }
}
