using Challenges.Source.Converter;
using System.Collections.Generic;
using System.IO;

namespace Challenges.Source.TextFile
{
    public class TextFileParser<T>
    {
        private readonly IStringElementConverter<T> converter;

        public TextFileParser(IStringElementConverter<T> converter)
        {
            this.converter = converter;
        }

        public List<T> Parse(string textFilePath)
        {
            List<T> result = new List<T>();

            if (File.Exists(textFilePath))
            {
                using StreamReader reader = new StreamReader(textFilePath);

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    T convertedElement = this.converter.Convert(line);
                    if (convertedElement != null)
                    {
                        result.Add(convertedElement);
                    }
                }
            }

            return result;
        }
    }
}
