using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using New_DISA_Project.ClientProjects;
using New_DISA_Project.Project;
using New_DISA_Project.ProjectCreators;
using System.IO;

namespace New_DISA_Project
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            


            //*********Application Variables*********//

            ProjectCreator newProject = new ProjectCreator();
            JabilProject newClientProject = new JabilProject();

            newProject.SetClienName();
            //Console.WriteLine(newProject.ClientDirectory);


            newProject.SetProjectName();
            //Console.WriteLine(newProject.ProjectName);


            newProject.CreatesDirectories();

            newClientProject.AddIOSheet((newProject.ProjectDocDirectory + $@"\F-DIS-003 Formato IO'S {newProject.ProjectName}.xlsx")); // we cant just provide the directory

            newClientProject.ControlSelector(newProject.ProjectName, newProject.SystemDirectory, newProject.ControlDirectory);

            //Console.WriteLine(Directory.GetCurrentDirectory());

            //newProject.CreatesDirectories
            //Console.WriteLine(newProject.MainDirectory);

            // Using a dictionary to pass to the menu class
            var methodOptions = new Dictionary<int, Action>()
            {
                {0, () => newClientProject.AddIOSheet((newProject.ProjectDocDirectory + $@"\F-DIS-003 Formato IO'S {newProject.ProjectName}.xlsx")) },
                {1, () => newClientProject.ControlSelector(newProject.ProjectName, newProject.SystemDirectory, newProject.ControlDirectory) }
            };

            // Testing out a static method
            string[] myStringArray = new string[] { "Jabil Project", "Xylem Project", "Misc. Project" };
            Console.WriteLine(Menu("Select from the options", myStringArray, methodOptions));
            ///////////////////////////////////////////////////////////////

            Console.ReadLine();
        }

        public static int Menu(string promptString, string[] Options, Dictionary<int, Action> methodDictionary)
        {
            int OptionSelected = 0; // Will return this value once the selection has been made. 
            // This code will only return the value, do whatever is needed outside the method 

            Console.Write($"{promptString}:\n");
            for (int i = 0; i < Options.Length; i++)
            {
                Console.Write((i + 1));
                Console.Write(".-");
                Console.Write(Options[i]);
                Console.Write("\n");
            }
            OptionSelected = Int32.Parse(Console.ReadLine());

            // We have to test this out, to determine if this will call the method with the argument passed
            for (int i = 0; i < Options.Length; i++)
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
