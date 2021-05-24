using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_DISA_Project
{
    class StaticMethods
    {
        public static int Menu(string promptString, string[] options, Action[] methodOptions)
        {
            // Perform validations that provided Options is equal to provided methods

            int OptionSelected = 0;

            Console.Write($"{promptString}:\n");
            for (int i = 0; i < options.Length; i++)
            { 
                Console.Write((i + 1));
                Console.Write(".-");
                Console.Write(options[i]);
                Console.Write("\n");
            }
            OptionSelected = Int32.Parse(Console.ReadLine());

            return OptionSelected;
        }
    }
}
