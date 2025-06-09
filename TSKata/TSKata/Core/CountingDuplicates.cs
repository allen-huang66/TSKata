namespace TSKata.TSKata.Core;

public class CountingDuplicates(string input)
{
    private readonly HashSet<char> _countBiggerThanTwo = [];
    
    private readonly Dictionary<char, int> _wordCountDict = new();
    private string Input { get; } = input;

    public int Cal()
    {
        foreach (var lowerChar in Input.Select(char.ToLower).Where(lowerChar => !IsExist(lowerChar)))
        {
            _wordCountDict[lowerChar] += 1;
            _countBiggerThanTwo.Add(lowerChar);
        }

        return _countBiggerThanTwo.Count;
    }

    private bool IsExist(char c)
    {
        return _wordCountDict.TryAdd(c, 1);
    }
}