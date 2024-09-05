using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class RepeatNum
    {
        public static int Repeat(int[] nums)
        {
            var dictionary = new Dictionary<int, int>();

            foreach (var item in nums) 
            { 
                if (dictionary.ContainsKey(item))
                    dictionary[item]++;
                else dictionary[item] = 1;
            }

            return dictionary.Aggregate((l,r) => l.Value > r.Value ? l : r).Key;
        }

    }
}
