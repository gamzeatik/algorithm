namespace ConsoleApp1;

public abstract class FindMinNum
{
    public static int Finder(int[] numbers)
    {
        var minNumber = 0;
        foreach (var t in numbers)
        {
            if (t < minNumber)
            {
                minNumber = t;
            }
        }

        return minNumber;
    }
}