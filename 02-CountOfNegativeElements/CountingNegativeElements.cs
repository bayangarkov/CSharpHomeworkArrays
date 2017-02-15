using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CountOfNegativeElements
{
    class CountingNegativeElements
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int counterNegative = 0;

            int[] arrayOfInt = new int[n];

            for (int i = 0; i < arrayOfInt.Length; i++)
            {
                arrayOfInt[i] = int.Parse(Console.ReadLine());
                if (arrayOfInt[i] < 0)
                {
                    counterNegative += 1;
                }
            }

            Console.WriteLine(counterNegative);
        }
    }
}
