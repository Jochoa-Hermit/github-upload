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


            // ********************************************* This code was used to test out the menu static method *********************************************// 

            // Using a dictionary to pass to the menu class

            var methodOptions = new Dictionary<int, Action>()
            {
                {0, () => newClientProject.AddIOSheet((newProject.ProjectDocDirectory + $@"\F-DIS-003 Formato IO'S {newProject.ProjectName}.xlsx")) },
                {1, () => newClientProject.ControlSelector(newProject.ProjectName, newProject.SystemDirectory, newProject.ControlDirectory) }
            };

            //// Testing out a static method
            string[] myStringArray = new string[] { "Jabil Project", "Xylem Project", "Misc. Project" };
            Menus.MenuWithMethods("Select from the options", myStringArray, methodOptions);

            // ********************************************* This code was used to test out the menu static method 

            Console.ReadLine();
        }
    }
}
