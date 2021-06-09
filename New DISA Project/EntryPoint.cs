using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using New_DISA_Project.ClientProjects;
using New_DISA_Project.Project;
using New_DISA_Project.ProjectCreators;
using System.IO;
using New_DISA_Project.Interfaces;

namespace New_DISA_Project
{
    class EntryPoint
    {
        static void Main(string[] args)
        { 
            //*********Application Variables*********//

            ProjectCreator newProject = new ProjectCreator();
            ISelector newClientProject = null; // We had to instantiate this as an interface to be able to use methods outside of instansiation of object

            newProject.SetClienName();
            newProject.SetProjectName();
            newProject.CreatesDirectories();

            switch (newProject.ClientName)
            {
                case "XYLEM":
                    newClientProject = new XylemProject(); // implement interface in xylem class
                    break;
                case "JABIL":
                    newClientProject = new JabilProject();
                    break;
                default:
                    break;
            }

            newClientProject.AddIOSheet((newProject.ProjectDocDirectory + $@"\F-DIS-003 Formato IO'S {newProject.ProjectName}.xlsx")); // we cant just provide the directory
            newClientProject.ControlSelector(newProject.ProjectName, newProject.SystemDirectory, newProject.ControlDirectory);


            Console.ReadLine();
        }
    }
}
