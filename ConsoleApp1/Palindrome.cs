namespace ConsoleApp1;

public abstract class Palindrome
{
    //bir string değerin okunuşunun tersten de aynı mı kontrolü

    public static bool PalindromeCheck(string word)
    {
        var startIndex = 0;
        var endIndex = word.Length - 1;

        while (startIndex < endIndex)
        {
            if (word[startIndex] != word[endIndex])
            {
                return false;
            }

            startIndex++;
            endIndex--;
        }

        return true;
    }
}