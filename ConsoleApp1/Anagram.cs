namespace ConsoleApp1;

public abstract class Anagram
{
    //aynı karakterler ve aynı uzunluğa sahip, farklı karakter sıraları olan kelimeler
    public static bool AnagramCheck(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            return false;
        }

        var charCount1 = str1.GroupBy(c => c).ToDictionary(m => m.Key, m => m.Count());
        var charCount2 = str2.GroupBy(c => c).ToDictionary(m => m.Key, m => m.Count());

        return charCount1.SequenceEqual(charCount2);
    }
}