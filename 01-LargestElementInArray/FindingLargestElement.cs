using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LargestElementInArray
{
    class FindingLargestElement
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] arrayOfInt = new int[n];
            for (int i = 0; i < arrayOfInt.Length; i++)
            {
                arrayOfInt[i] = int.Parse(Console.ReadLine());
            }

            int findMax = arrayOfInt.Max();

            Console.WriteLine(findMax);
        }
    }
}
