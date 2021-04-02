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
            ProjectCreator newProject = new ProjectCreator();

            Console.WriteLine(newProject.MainDirectory);
        }
    }
}
