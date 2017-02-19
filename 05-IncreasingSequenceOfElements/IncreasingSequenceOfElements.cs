using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_IncreasingSequenceOfElements
{
    class IncreasingSequenceOfElements
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool isIncrementing = true;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                {
                    isIncrementing = false;
                    break;
                }
            }

            if (isIncrementing == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
