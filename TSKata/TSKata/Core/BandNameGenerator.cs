namespace TSKata.TSKata.Core;

public class BandNameGenerator
{
    public static string Decrypt(string noun)
    {
        if (IsFirstAndLastCharSame(noun))
        {
            return "The " + ConvertStringFirstCharUpper(noun);
        }

        return ConvertStringFirstCharUpper(noun) + noun[1..];
    }

    private static string ConvertStringFirstCharUpper(string noun)
    {
        return char.ToUpper(noun[0]) + noun[1..];
    }

    private static bool IsFirstAndLastCharSame(string noun)
    {
        return noun[0] != noun[^1];
    }
}