using New_DISA_Project.ClientProjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using New_DISA_Project.Interfaces;

namespace New_DISA_Project.Project
{
    class JabilProject : ClientProject
    {
        public override void ControlSelector(string projectName, string systemDir, string controlDir) // new keyword is used to create different implementation from inherited class
        {
            int controlSelection, continueAdding;
            bool addMore = true;
            Console.WriteLine("Choose from the following types:\n1. Jabil Test\n2. PLC\n3. .NET\n4. Labview");
            controlSelection = Int32.Parse(Console.ReadLine());

            while (addMore)
            {
                switch (controlSelection)
                {
                    case 1:
                        // Adds Jabil Test Template to file
                        AddJBTestProject(projectName, systemDir, controlDir);
                        break;

                    case 2:
                        // Adds PLC Template
                        break;

                    case 3:
                        // Add .NET file
                        break;

                    case 4:
                        // Adds Labview Template
                        break;

                    default:

                        break;
                }

                Console.WriteLine("Would you Like to add another Control?\n1. Yes\n2. No");
                continueAdding = Int16.Parse(Console.ReadLine());
                if (continueAdding == 1)
                {
                    addMore = true;
                }
                else if (continueAdding == 2)
                {
                    addMore = false;
                }
                else
                {
                    Console.WriteLine("You have not chosen an appropriate option");
                }

            }
            Console.Clear();
        }

        private void AddJBTestProject(string projectName, string systemDir, string controlDir)
        {

            // Instaed of using whole first directory, it just uses systemDir, and to whatever directoryit finds it adds to systemDir
            CopyFilesRecursively(Consts.ClientProject.JBTEST_DIRECTORY, systemDir);

            // Gets all files from the jabil test script directory

            // Should replace all files that contain "nameHere" with the project Name
            if (Consts.ClientProject.JBTEST_DIRECTORY.Contains("Jarvi"))
            {
                // Solo cambiar nombres si se esta usando laptop de Disa
                foreach (string fileName in Directory.GetFiles((controlDir + @"\Jabil Test Scripts\"), "*.*", SearchOption.AllDirectories))
                {
                    if (fileName.Contains("nameHere"))
                    {
                        File.Move(fileName, fileName.Replace("nameHere", projectName));
                    }
                }
            }
        }

        private void AddLabviewProject(string projectName)
        {

        }
    }
}