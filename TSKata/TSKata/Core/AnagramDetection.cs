namespace TSKata.TSKata.Core;

public class AnagramDetection(string a, string b)
{
    public bool IsAnagram()
    {
        if (a.Length != b.Length)
        {
         return false;
        }

        var charCount = new int[26];

        for (var i = 0; i < a.Length; i++)
        {
            charCount[char.ToLower(a[i]) - 'a']++;
            charCount[char.ToLower(b[i]) - 'a']--;
        }

        return charCount.All(count => count == 0);
    }
}