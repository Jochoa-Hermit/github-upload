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
            Console.WriteLine(newProject.ClientDirectory);

            Console.WriteLine();

            newProject.SetProjectName();
            Console.WriteLine(newProject.ProjectName);

            Console.WriteLine();

            newProject.CreatesDirectories();

            newClientProject.AddIOSheet((newProject.ProjectDocDirectory + @"\project Sheet.txt")); // we cant just provide the directory

            Console.WriteLine(Directory.GetCurrentDirectory());

            //newProject.CreatesDirectories
            //Console.WriteLine(newProject.MainDirectory);

            Console.ReadLine();
        }
    }
}
