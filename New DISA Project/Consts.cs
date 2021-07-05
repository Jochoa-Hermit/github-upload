using System.IO;

namespace New_DISA_Project
{
    public static class Consts
    {
        public static class ProjectCreator
        {
            // Thinkpad
            public const string MAIN_DIRECTORY = @"C:\Users\jarvi\Documents\DISA\PROYECTOS";

            // Disa Laptop 
            //public const string MAIN_DIRECTORY = @"C:\Users\DISA_Lenovo\Documents\DISA\PROYECTOS";

            public const string CLIENT_DIRECTORY = "MISCELLANEOUS";
            public const string CLIENT_DIR_JABIL = "JABIL";
            public const string CLIENT_DIR_XYLEM = "XYLEM";

            public const bool CONTAINS_CONTROL = true;
        }

        public static class ClientProject
        {
            public const string NAME_REPLACE_FLAG = "nameHere";
            // Documentation Directory Constants
            public const string DOC_DISA = @"\Directorios_Disa\Documentacion Disa\";
            public const string IO_SHEET = @"F-DIS-003 Formato nameHere IO_S.xlsx";
            public const string MANUAL = @"MANUAL - nameHere.docx";

            public const string DOC_DIAGRAM = @"\Directorios\Documentacion Disa\Diagramas\Diagramas\";
            public const string PNEUM_DIAGRAM = @"Diagrama Neumatico - nameHere.vsd";
            public const string ELECTRIC_DIAGRAM = @"Diagrama Electrico - nameHere.vsd";
            public const string FUNCTION_DIAGRAM = @"Funcionamiento - nameHere.vsd";


            // Jabil Test Directory
            public const string JBTEST_DIRECTORY = @"\Directorios_Disa\Sistema\Jabil Test Project\Sistema";




        }
    }
}
