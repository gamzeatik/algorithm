using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Totals
    {
        public static int GiveFaktoriyel(int number) 
        {
            int sonuc = 1;
            //for (int i = 0; i > 0 ; i--)
            //{
            //    sonuc *= i;
            //}
            //return sonuc;


            while (number > 0)
            {
                sonuc *= number;
                number--;
            }
            return sonuc;
        }

        //non-consecutive numbers
        public static int MaxNonAdjacentSum(int[] numbers)
        {
            if(numbers.Length == 0) return 0; 
            if (numbers.Length == 1) return numbers[0];
            int prev1 = 0, prev2 = 0;
            foreach (int n in numbers)
            {
                int temp = prev1;
                prev1 = Math.Max(prev1,prev2 + n);
                prev2 = temp;
            }
            return prev1;
        }

    }
}
