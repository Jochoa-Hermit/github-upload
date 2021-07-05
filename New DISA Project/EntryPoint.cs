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
            DisaProject newProject = new DisaProject();
            ISelector newProjectFiles = null; // We had to instantiate this as an interface to be able to use methods outside of instansiation of object

            newProject.SetClienName();
            newProject.SetProjectName();
            newProject.CreatesDirectories();

            switch (newProject.ClientName)
            {
                case "XYLEM":
                    newProjectFiles = new XylemProjectFiles(newProject.ProjectName); // implement interface in xylem class
                    break;
                case "JABIL":
                    Console.WriteLine("here");
                    newProjectFiles = new JabilProjectFiles(newProject.ProjectName);
                    break;
                default:
                    break;
            }

            newProjectFiles.AddIOSheet((newProject.ProjectDocDirectory + @"\" + Consts.ClientProject.IO_SHEET)); // we cant just provide the directory
            newProjectFiles.AddManual((newProject.ProjectDocDirectory + @"\" + Consts.ClientProject.MANUAL));
            newProjectFiles.ControlSelector(newProject.ProjectName, newProject.SystemDirectory, newProject.ControlDirectory);

            Console.WriteLine("Any key to continue");
            Console.ReadLine();
        }
    }
}
