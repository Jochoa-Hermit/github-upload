using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_DISA_Project
{
    public static class Menus
    {
        public static void MenuWithMethods(string promptString, string[] Options, Dictionary<int, Action> methodDictionary)
        {
            int optionSelected = 0; // Will return this value once the selection has been made. 
            // This code will only return the value, do whatever is needed outside the method 

            Console.Write($"{promptString}:\n");
            for (int i = 0; i < Options.Length; i++)
            {
                Console.Write((i + 1));
                Console.Write(".-");
                Console.Write(Options[i]);
                Console.Write("\n");
            }
            optionSelected = Int32.Parse(Console.ReadLine());

            // We have to test this out, to determine if this will call the method with the argument passed
            for (int i = 0; i < Options.Length; i++)
            {
                if ((optionSelected - 1) == i)
                {
                    methodDictionary[i].Invoke();
                }
            }
        }

        public static bool MenuYesNo(string promptString)
        {
            int optionSelected = 0;
            bool yesNo = false;

            Console.Write($"{promptString}:\n1.Yes\n2.No");

            try
            {
                optionSelected = Int16.Parse(Console.ReadLine());

                if (optionSelected == 0)
                {
                    yesNo = false;
                }
                else if (optionSelected == 1)
                {
                    yesNo = true;
                }
                else
                {
                    yesNo = false;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return yesNo;
        }
    }
}
