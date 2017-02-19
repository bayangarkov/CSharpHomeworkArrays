using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Phonebook
{
    class Phonebook
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ');

            string[] names = Console.ReadLine().Split(' ');

            string result = "";

            for (int i = 0; ; i++)
            {
                string inputName = Console.ReadLine();

                if (inputName == "done")
                {
                    break;
                }

                for (int j = 0; j < names.Length; j++)
                {
                    if (inputName == names[j])
                    {
                        result += $"{names[j]} -> {numbers[j]}" + Environment.NewLine;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
