using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_DISA_Project
{
    class StaticMethods
    {
        // Implementation example of the static method Menu // removed it from entry point 

        //// Using a dictionary to pass to the menu class
        //var methodOptions = new Dictionary<int, Action>()
        //    {
        //        {0, () => newClientProject.AddIOSheet((newProject.ProjectDocDirectory + $@"\F-DIS-003 Formato IO'S {newProject.ProjectName}.xlsx")) },
        //        {1, () => newClientProject.ControlSelector(newProject.ProjectName, newProject.SystemDirectory, newProject.ControlDirectory) }
        //    };

        //// Testing out a static method
        //string[] myStringArray = new string[] { "Jabil Project", "Xylem Project", "Misc. Project" };
        //Console.WriteLine(StaticMethods.Menu("Select from the options", myStringArray, methodOptions));
        



        public static int Menu(string promptString, string[] options, Dictionary<int, Action> methodDictionary)
        {
            int OptionSelected = 0; // Will return this value once the selection has been made. 
            // This code will only return the value, do whatever is needed outside the method 

            Console.Write($"{promptString}:\n");
            for (int i = 0; i < options.Length; i++)
            {
                Console.Write((i + 1));
                Console.Write(".-");
                Console.Write(options[i]);
                Console.Write("\n");
            }
            OptionSelected = Int32.Parse(Console.ReadLine());

            // We have to test this out, to determine if this will call the method with the argument passed
            for (int i = 0; i < options.Length; i++)
            {
                if ((OptionSelected - 1) == i)
                {
                    methodDictionary[i].Invoke();
                }
            }

            return OptionSelected;
        }
    }
}
