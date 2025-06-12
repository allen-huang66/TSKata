namespace TSKata.TSKata.Core;

public class ContainsDuplicate2
{
    private readonly Dictionary<int, int> _dict = new();

    public bool IsDuplicate(int[] input, int k)
    {
        return ValidateDuplicateEntry(input, k);
    }

    private bool ValidateDuplicateEntry(int[] input, int k)
    {
        for (var i = 0; i < input.Length; i++)
        {
            var value = input[i];

            if (_dict.TryGetValue(value, out var index) && CheckDuplicateWithinRange(k, i, index))
            {
                return true;
            }
            
            _dict[value] = i;
        }

        return false;
    }

    private static bool CheckDuplicateWithinRange(int k, int i, int index)
    {
        return i - index <= k;
    }
}