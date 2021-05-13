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
        public abstract void ControlSelector();


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
                    File.Copy(@"C:\Users\jarvi\Documents\DISA\ARCHIVOS DISA\Archivo de Texto.txt", directory);
                    break;
                case 2:

                    break;  
                default:
                    break;
            }

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

    }
}
