using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using New_DISA_Project.ProjectCreators;

namespace New_DISA_Project
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            //*********Application Variables*********//

            ProjectCreator newProject = new ProjectCreator();

            newProject.SetClienName();
            Console.WriteLine(newProject.ClientDirectory);

            Console.WriteLine();

            newProject.SetProjectName();
            Console.WriteLine(newProject.ProjectName);

            Console.WriteLine();

            newProject.CreatesDirectories();
            //newProject.CreatesDirectories
            //Console.WriteLine(newProject.MainDirectory);
        }
    }
}
