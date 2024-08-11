namespace ConsoleApp1;

public abstract class Fibonacci
{
    public static List<int> FibonacciNums(int n)
    {
        var fibonacciList = new List<int> { 0, 1 };

        for (var i = 2; i < n; i++)
        {
            var newNum = fibonacciList[i - 1] + fibonacciList[i - 2];
            fibonacciList.Add(newNum);
        }

        return fibonacciList;
    }
}