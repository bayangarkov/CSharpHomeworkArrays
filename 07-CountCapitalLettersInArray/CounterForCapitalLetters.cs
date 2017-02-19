using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_CountCapitalLettersInArray
{
    class CounterForCapitalLetters
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split(' ');

            int counter = 0;

            foreach (var item in words)
            {
                if (item.Length == 1)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
