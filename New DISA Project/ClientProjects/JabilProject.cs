using New_DISA_Project.ClientProjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace New_DISA_Project.Project
{
    class JabilProject : ClientProject
    {
        public void AddIOSheet()
        {

        }
        public override void ControlSelector(string projectName, string systemDir, string controlDir)
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
            CopyFilesRecursively(@"C:\Users\DISA_Lenovo\Documents\DISA\RECURSOS\Sistema\Jabil Test Project\Sistema", systemDir);
            // Gets all files from the jabil test script directory

            // Should replace all files that contain "nameHere" with the project Name
            foreach (string fileName in Directory.GetFiles((controlDir + @"\Jabil Test Scripts\"), "*.*", SearchOption.AllDirectories))
            {
                if(fileName.Contains("nameHere"))
                {
                    File.Move(fileName, fileName.Replace("nameHere", projectName));
                }
            }
        }

        private void AddLabviewProject(string projectName)
        {

        }

        
    }
}