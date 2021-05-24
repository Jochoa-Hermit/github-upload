using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using New_DISA_Project.ProjectCreators;
using System.IO;

namespace New_DISA_Project.ClientProjects
{
    public abstract class ClientProject
    {
        //**************************Fields**************************//




        //**************************Fields**************************//

        //----------------------------------------------------------------------------------------//

        //**************************Constructors**************************//
        public ClientProject()
        {

        }

        //****************************************************************//

        //----------------------------------------------------------------------------------------//

        //**************************Control Methods**************************//
        public abstract void ControlSelector(string projectName, string systemDir, string controlDir);


        //******************************************************************//

        //----------------------------------------------------------------------------------------//

        //**************************Documentation Methods**************************//
        public void DocumentationSelector()
        {

            

        }

        public virtual void AddIOSheet(string directory)
        {
            int docSelector = 0;

            Console.WriteLine("Would You Like to Add an IO Sheet?\n1. Yes\n2. No");
            docSelector = Int32.Parse(Console.ReadLine());

            switch (docSelector)
            {
                case 1:
                    // Thinkpad
                    //File.Copy(@"C:\Users\jarvi\Documents\DISA\ARCHIVOS DISA\Archivo de Texto.txt", directory);

                    // Disa Laptop
                    File.Copy(@"C:\Users\DISA_Lenovo\Documents\DISA\RECURSOS\Documentacion Disa\F-DIS-003 Formato IO'S.xlsx", directory);
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
