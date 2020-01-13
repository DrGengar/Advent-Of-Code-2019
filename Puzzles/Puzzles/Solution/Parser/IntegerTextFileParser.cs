namespace Puzzles.Solution.Parser
{
    public class IntegerTextFileParser : AbstractTextFileParser<int>
    {
        protected override int Convert(string line)
        {
            return int.Parse(line);
        }
    }
}
