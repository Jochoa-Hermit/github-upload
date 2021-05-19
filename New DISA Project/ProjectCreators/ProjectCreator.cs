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
        const string escBSlash = @"\";

        // String Fields
        private string mainDirectory;
        private string clientDirectory;
        // Documentation Fields
        private string docDirectory;
        private string projectDocDirectory;
        private string technicalDocDirectory;
        // System Fields
        private string systemDirectory;
        private string controlDirectory;
        private string resourceDirectory;

        private string projectName;

        // Bool Fields
        bool containsControl;


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

        public string DocDirectory {
            get
            {
                return this.docDirectory;
            }
            private set
            {
                this.docDirectory = value;
            }
        }

        public string ProjectDocDirectory
        {
            get
            {
                return this.projectDocDirectory ;
            }
            private set
            {
                this.projectDocDirectory = value;
            }
        }

        public string TechnicalDocDirectory
        {
            get
            {
                return this.technicalDocDirectory;
            }
            private set
            {
                this.technicalDocDirectory = value;
            }
        }

        public string SystemDirectory { 
            get
            {
                return this.systemDirectory;
            }
            private set
            {
                this.systemDirectory = value;
            }
        }

        public string ControlDirectory
        {
            get
            {
                return this.controlDirectory;
            }
            private set
            {
                this.controlDirectory = value;
            }
        }

        public string ResourceDirectory
        {
            get
            {
                return this.resourceDirectory;
            }
            private set
            {
                this.resourceDirectory = value;
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

        public bool ContainsControl {
            get
            {
                return this.containsControl;
            }
            set
            {
                this.containsControl = value;
            }
        }

        public ProjectCreator()
        {
            this.mainDirectory = Consts.ProjectCreator.MAIN_DIRECTORY;
            this.clientDirectory = Consts.ProjectCreator.CLIENT_DIRECTORY;
            this.containsControl = Consts.ProjectCreator.CONTAINS_CONTROL; // Only create system directory if this is true;
        }

        //public ProjectCreator(bool containsControl)
        //{
        //    this.mainDirectory = Consts.ProjectCreator.MAIN_DIRECTORY;
        //    this.clientDirectory = Consts.ProjectCreator.CLIENT_DIRECTORY;
        //    this.containsControl = containsControl;
        //}

        public void SetClienName()
        {
            // Check if client name is empty, if it is, then we allow to set a new client name

            int clientOptionSelected;

            if ((this.clientDirectory == null) || (this.clientDirectory == "") || (this.clientDirectory == Consts.ProjectCreator.CLIENT_DIRECTORY))
            {
                Console.WriteLine("Choose an Option:\n1. XYLEM\n2. JABIL");
                Console.WriteLine();
                clientOptionSelected = Int16.Parse(Console.ReadLine());

                switch (clientOptionSelected) // Eventually instead of hardcoding, add enumerations
                {
                    case 1:
                        this.ClientDirectory = Consts.ProjectCreator.CLIENT_DIR_XYLEM;
                        break;

                    case 2:
                        this.ClientDirectory = Consts.ProjectCreator.CLIENT_DIR_JABIL;
                        break;

                    default:
                        break;
                }
            }

            else
            {
                Console.WriteLine($"The Client name has already been set: {this.ClientDirectory}");
            }
            Console.Clear();
        }

        public void SetProjectName()
        {
            // Check if Project name is empty, if it is, then we allow to set a new client name

            Console.WriteLine("Enter the project Name");
            this.ProjectName = Console.ReadLine();

            Console.Clear();
        }

        public void CreatesDirectories()
        {
            string stringDirectory; // Add backslash via a for loop, add all strings in an array to do this.

            //for (int i = 0; i < length; i++)
            //{

            //}

            stringDirectory = this.mainDirectory + @"\" + this.clientDirectory + @"\" + this.projectName;
            //Console.WriteLine(stringDirectory);

            Directory.CreateDirectory(stringDirectory);

            CreatesDocumentationDirectory(stringDirectory);
            CreatesSystemDirectory(stringDirectory);
        }

        private void CreatesDocumentationDirectory(String stringDirectory)
        {
            this.docDirectory = stringDirectory + escBSlash + "Documentacion";
            this.projectDocDirectory = this.docDirectory + escBSlash + "Documentacion_de_Proyecto";
            this.technicalDocDirectory = this.docDirectory +escBSlash + "Documentacion_Tecnica";

            string[] docDirectoryArray = new string[3] { this.docDirectory, this.projectDocDirectory, this.technicalDocDirectory };

            for (int i = 0; i < docDirectoryArray.Length; i++)
            {
                Directory.CreateDirectory(docDirectoryArray[i]);
            }

            //Directory.CreateDirectory(documentationDirectory);
        }

        private void CreatesSystemDirectory(String stringDirectory)
        {
            this.systemDirectory = stringDirectory + escBSlash + "Sistema";
            this.controlDirectory = this.systemDirectory + escBSlash + "Control"; // We will have a control folder in each type of project, within the control folder we will have another folder with the actual control
            // For example, we have from our resources folder a folder called Jabil Test Project -> Sistema -> Control -> Jabil Test Scripts
            // do the same for others Labview Project -> Sistema -> Control -> ftes
            // This  way when it find the control folder in the new project it will add subfolder to the control folder 


            this.resourceDirectory = this.systemDirectory + escBSlash + "Recursos";

            string[] systemDirectoryArray = new string[3] { this.systemDirectory, this.controlDirectory, this.resourceDirectory };

            for (int i = 0; i < systemDirectoryArray.Length; i++)
            {
                Directory.CreateDirectory(systemDirectoryArray[i]);
            }
        }
 
    }
}
