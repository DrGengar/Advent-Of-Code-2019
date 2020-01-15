using Challenges.Source.Converter;
using System.Collections.Generic;
using System.IO;

namespace Challenges.Source.TextFile
{
    public class TextFileSplitter<T>
    {
        private readonly IStringElementConverter<T> converter;

        public TextFileSplitter(IStringElementConverter<T> converter)
        {
            this.converter = converter;
        }

        public List<T> Split(string textFilePath, char splitCharacter)
        {
            List<T> result = new List<T>();

            if (File.Exists(textFilePath))
            {
                string text = File.ReadAllText(textFilePath);
                string[] elements = text.Split(splitCharacter);
                foreach (string element in elements)
                {
                    T convertedElement = this.converter.Convert(element);
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
