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
        public override void ControlSelector()
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

        }
    }
}