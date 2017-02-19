using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CountofGivenElementinArray
{
    class CountofGivenElementinArray
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int chosenNumber = int.Parse(Console.ReadLine());

            int counter = 0;

            foreach (var i in array)
            {
                if (i == chosenNumber)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);

        }
    }
}
