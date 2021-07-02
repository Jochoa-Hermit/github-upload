using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using New_DISA_Project.ProjectCreators;
using System.IO;
using New_DISA_Project.Interfaces;


namespace New_DISA_Project.ClientProjects
{
    public class ProjectFiles : ISelector
    {
        //**************************Fields**************************//
        private string projectName = null;



        //**************************Fields**************************//

        //**************************Properties**************************//
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



        //**************************Properties**************************//

        //----------------------------------------------------------------------------------------//

        //**************************Constructors**************************//
        public ProjectFiles(string _projectName)
        {
            this.ProjectName = _projectName;
        }

        //****************************************************************//

        //----------------------------------------------------------------------------------------//

        //**************************Control Methods**************************//
        // Implemented as an interface
        public virtual void ControlSelector(string projectName, string systemDir, string controlDir)
        {
            Console.WriteLine("Some Implementation");
        }

        //******************************************************************//

        //----------------------------------------------------------------------------------------//

        //**************************Documentation Methods**************************//

        public virtual void AddIOSheet(string directory)
        {
            int docSelector = 0;
            string ioDirectoryFile = null;

            Console.WriteLine("Would You Like to Add an IO Sheet?\n1. Yes\n2. No");
            docSelector = Int32.Parse(Console.ReadLine());

            switch (docSelector)
            {
                case 1:
                    // Thinkpad // This is set from Const namespace
                    ioDirectoryFile = Directory.GetCurrentDirectory() + Consts.ClientProject.IO_SHEET;
                    File.Copy((ioDirectoryFile), directory.Replace(ioDirectoryFile, directory), true);
                    // Rename the file to project name
                    File.Move(directory, directory.Replace(Consts.ClientProject.NAME_REPLACE_FLAG, this.projectName));


                    break;
                case 2:

                    break;
                default:
                    break;
            }
            Console.Clear();
        }

        public void AddManual()
        {

        }

        public void AddElectricalDiagram()
        {

        }

        public void AddStateDiagram()
        {

        }

        public void AddPneumaticDiagram()
        {

        }

        //*************************************************************************//

        protected void CopyFilesRecursively(string sourcePath, string targetPath)
        {
            foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
            {
                //Console.WriteLine(dirPath);
                Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
            }

            foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
            {
                //Console.WriteLine(newPath);
                File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
            }
        }
    }
}
