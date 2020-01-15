using Challenges.Source;
using Challenges.Source.Converter;
using Challenges.Source.TextFile;
using System.Collections.Generic;

namespace Challenges.Solution.DayTwo
{
    public static class TaskTwo
    {
        private const char COMMA = ',';
        private const string INTEGER_CODE_TEXT_FILE_PATH = "D:\\Arbeit\\repositories\\Advent-Of-Code-2019\\Puzzles\\Puzzles\\Solution\\DayTwo\\IntegerCode.txt";

        public static int FindFinalValue()
        {
            TextFileSplitter<int> splitter = new TextFileSplitter<int>(new IntegerConverter());
            List<int> code = splitter.Split(INTEGER_CODE_TEXT_FILE_PATH, COMMA);

            Intcode intcode = new Intcode(code.ToArray());
            intcode.Replace(1, 12);
            intcode.Replace(2, 2);
            intcode.Execute();

            return intcode.Get(0);
        }

        public static int FindInputValues()
        {
            TextFileSplitter<int> splitter = new TextFileSplitter<int>(new IntegerConverter());
            List<int> code = splitter.Split(INTEGER_CODE_TEXT_FILE_PATH, COMMA);

            for (int noun = 0; noun < 100; noun++)
            {
                for (int verb = 0; verb < 100; verb++)
                {
                    Intcode intcode = new Intcode(code.ToArray());
                    intcode.Replace(1, noun);
                    intcode.Replace(2, verb);
                    intcode.Execute();

                    if (intcode.Get(0) == 19690720)
                    {
                        int result = 100 * noun + verb;
                        return result;
                    }
                }
            }

            return -1;
        }
    }
}
