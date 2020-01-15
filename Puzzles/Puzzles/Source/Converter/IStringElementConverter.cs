namespace Challenges.Source.Converter
{
    public interface IStringElementConverter<T>
    {
        public T Convert(string element);
    }
}