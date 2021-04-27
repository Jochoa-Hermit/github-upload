using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// Namespace and project name should not have the same name
namespace New_DISA_Project.ProjectCreators
{
    public class ProjectCreator
    {
        // String Fields
        private string mainDirectory;
        private string clientDirectory;
        private string projectName;

        // Bool Fields
        private bool containsControl;

        public string MainDirectory
        {
            get
            {
                return this.mainDirectory;
            }
            private set
            {
                this.mainDirectory = value;
            }
        }

        public string ClientDirectory 
        {
            get
            {
                return this.clientDirectory;
            }
            private set
            {
                this.clientDirectory = value;
            }
        }

        public string ProjectName 
        {
            get
            {
                return this.projectName;
            }
            private set
            {
                this.projectName = value;
            }
        }

        public bool ContainsControl 
        {
            get
            {
                return this.containsControl;
            }
            private set
            {
                this.containsControl = value;
            }
        }

        public ProjectCreator()
        {
            this.mainDirectory = Consts.ProjectCreator.MAIN_DIRECTORY;
            this.clientDirectory = Consts.ProjectCreator.CLIENT_DIRECTORY;
            this.containsControl = Consts.ProjectCreator.CONTAINS_CONTROL;
        }

        public ProjectCreator(bool containsControl)
        {
            this.mainDirectory = Consts.ProjectCreator.MAIN_DIRECTORY;
            this.clientDirectory = Consts.ProjectCreator.CLIENT_DIRECTORY;
            this.containsControl = containsControl;
        }

        public void SetClienName()
        {
            // Check if client name is empty, if it is, then we allow tu set a new client name
            
            int clientOptionSelected;

            Console.WriteLine("Choose an Option:\n1. XYLEM\n2. JABIL");
            Console.WriteLine();
            clientOptionSelected = Int16.Parse(Console.ReadLine());

            switch (clientOptionSelected) // Eventually instead of hardcoding, add enumerations
            {
                case 1:
                    this.ClientDirectory = "XYLEM";
                    break;

                case 2:
                    this.ClientDirectory = "JABIL";
                    break;

                default:
                    break;
            }
        }

        public void SetProjectName()
        {
            // Check if Project name is empty, if it is, then we allow to set a new client name

            Console.WriteLine("Enter the project Name");
            this.ProjectName = Console.ReadLine();
        }

        public void CreatesDirectories()
        {
            string stringDirectory; // Add backslash via a for loop, add all strings in an array to do this.

            //for (int i = 0; i < length; i++)
            //{

            //}

            stringDirectory = this.mainDirectory + @"\" + this.clientDirectory + @"\" + this.projectName;
            Console.WriteLine(stringDirectory);

            Directory.CreateDirectory(stringDirectory);
        }
    }
}
