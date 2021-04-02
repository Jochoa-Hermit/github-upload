using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            set
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
    }
}
