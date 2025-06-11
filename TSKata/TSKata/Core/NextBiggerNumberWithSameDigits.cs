namespace TSKata.TSKata.Core;

public class NextBiggerNumberWithSameDigits
{
    private const int NotFoundBiggerNumber = -1;

    public long GetNextBiggerNumber(long input)
    {
        var ica = input.ToString().ToCharArray();

        var smallChangePoint = FindSmallChangePoint(ica);

        if (NoFindAnyLeftDigitLessThenRightDigit(smallChangePoint))
        {
            return NotFoundBiggerNumber;
        }

        var biggerChangePoint = FindBiggerChangePoint(ica, smallChangePoint);

        (ica[smallChangePoint], ica[biggerChangePoint]) = (ica[biggerChangePoint], ica[smallChangePoint]);

        Array.Sort(ica, smallChangePoint + 1, ica.Length - smallChangePoint - 1);

        return long.Parse(ica);
    }

    private static int FindBiggerChangePoint(char[] ica, int smallChangePoint)
    {
        for (var i = ica.Length - 1; i >= 0; i--)
        {
            if (ica[i] > ica[smallChangePoint])
            {
                return i;
            }
        }

        return NotFoundBiggerNumber;
    }

    private static int FindSmallChangePoint(char[] ica)
    {
        for (var i = ica.Length - 1; i > 0; i--)
        {
            if (ica[i - 1] < ica[i])
            {
                return i - 1;
            }
        }

        return NotFoundBiggerNumber;
    }

    private static bool NoFindAnyLeftDigitLessThenRightDigit(int smallChangePoint)
    {
        return smallChangePoint == NotFoundBiggerNumber;
    }
}