using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ArraySymmetry
{
    class CheckingIfArrayIsSymmetry
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split(' ');

            string[] words2 = words.ToArray();
            
            bool isEqual = words.Reverse().SequenceEqual(words2);

            if (isEqual == true)
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
