using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CountOccurrencesOfLargerNumbersInArray
{
    class CountOccurrences
    {
        static void Main()
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            double chosenNumber = double.Parse(Console.ReadLine());

            int counter = 0;
            
            foreach (var item in array)
            {
                if (item > chosenNumber)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
