namespace ConsoleApp1;

public abstract class Ebob
{
    public static int EbobFunction(int a, int b)
    {
        while (b != 0)
        {
            var temp = b;
            b = a % b;
            a = temp;
        }

        return a;
    }
}