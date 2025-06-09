namespace TSKata.TSKata.Core;

public class DeadAnts(string inputString)
{
    public int DeadAntsNums { get; private set; }

    public void Cal()
    {
        var countDict = new Dictionary<char, int>()
        {
            { 'a', 0 },
            { 'n', 0 },
            { 't', 0 },
        };

        foreach (var c in inputString.Split("ant").SelectMany(w => w))
        {
            if (countDict.ContainsKey(c))
            {
                countDict[c] += 1;
            }
        }

        DeadAntsNums = countDict.Values.Max();
    }
}