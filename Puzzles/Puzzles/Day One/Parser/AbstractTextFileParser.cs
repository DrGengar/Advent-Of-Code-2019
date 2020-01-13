using System.Collections.Generic;
using System.IO;

namespace Puzzles.Day_One.Parser
{
    public abstract class AbstractTextFileParser<T>
    {
        public List<T> Parse(string textFilePath)
        {
            List<T> result = new List<T>();

            if (File.Exists(textFilePath))
            {
                using StreamReader reader = new StreamReader(textFilePath);

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    result.Add(this.Convert(line));
                }
            }

            return result;
        }

        protected abstract T Convert(string line);
    }
}
