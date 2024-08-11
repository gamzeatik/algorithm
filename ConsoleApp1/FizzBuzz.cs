namespace ConsoleApp1;

public abstract class FizzBuzz
{
    //belirli bir sayı aralığındaki sayıları ekrana yazdırırken, eğer sayı 3ün katı ise "Fizz",
    //5in katı ise "Buzz" ve her ikisinin katı ise "FizzBuzz" yazdıracağız. Bu şartlara uymayanları
    //sayı olarak yazdıracağız.

    public static string Numbers(int x)
    {
        if (x % 5 == 0 && x % 3 == 0)
        {
            return "FizzBuzz";
        }
        else if (x % 3 == 0)
        {
            return "Fizz";
        }
        else if (x % 5 == 0)
        {
            return "Buzz";
        }
        else
        {
            return x.ToString();
        }
    }
}