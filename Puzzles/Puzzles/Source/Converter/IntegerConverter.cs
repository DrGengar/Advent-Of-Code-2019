namespace Challenges.Source.Converter
{
    public class IntegerConverter : IStringElementConverter<int>
    {
        public int Convert(string element)
        {
            return int.Parse(element);
        }
    }
}
