namespace TSKata.Core;

public class StringAverage
{
    private static readonly Dictionary<string, int> WordToNumber = new(StringComparer.OrdinalIgnoreCase)
    {
        { "zero", 0 },
        { "one", 1 },
        { "two", 2 },
        { "three", 3 },
        { "four", 4 },
        { "five", 5 },
        { "six", 6 },
        { "seven", 7 },
        { "eight", 8 },
        { "nine", 9 },
    };

    private static readonly Dictionary<int, string> NumberToWord = WordToNumber.ToDictionary(kv => kv.Value, kv => kv.Key);
    public required string Input { get; set; }

    public string CalculateFlooredAverage()
    {
        var splitWord = Input.Split(" ");

        try
        {
            var sum = splitWord.Select(x => WordToNumber[x]).Sum();
            return NumberToWord[sum / splitWord.Length];
        }
        catch (Exception)
        {
            return "n/a";
        }
    }
}