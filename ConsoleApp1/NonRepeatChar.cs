namespace ConsoleApp1;

public abstract class NonRepeatChar

{
    //bir string değer parametresi bekliyor, tekrar etmeyen ilk karakteri dönsün
     public static char? ReturnFirstNonRepeatChar(string input)
     {
         var charDictionary = new Dictionary<char, int>();
    
         foreach (var c in input.Where(c => !charDictionary.TryAdd(c, 1)))
         {
             charDictionary[c]++;
         }
    
         foreach (var c in input.Where(c => charDictionary[c] == 1))
         {
             return c;
         }
    
         return null;
     }


    public static char? NonRepeat(string input)
    {
        var charDictionary = new Dictionary<char, int>();

        foreach (var c in input)
        {
            if (charDictionary.ContainsKey(c))
            {
                charDictionary[c]++;
            }
            else
            {
                charDictionary[c] = 1;
            }
        }

        foreach (var c in input.Where(c => charDictionary[c] == 1))
        {
            return c;
        }

        return null;
    }
}