namespace TSKata.TSKata.Core;

public class TwoSum(int[] input, int target)
{
    public int[] Ans()
    {
        var visitedDict = new Dictionary<int, int>();

        var count = 0;
        foreach (var i in input)
        {
            if (visitedDict.TryGetValue(target - i, out var num1))
            {
               return [count, num1]; 
            }
            visitedDict[i] = count;
            count++;
        }

        return [];
    }
}