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
            public const string IO_SHEET = @"\Directorios_Disa\Documentacion Disa\F-DIS-003 Formato nameHere IO_S.xlsx";
            //public const string IO_SHEET = @"C:\Users\jarvi\Documents\DISA\ARCHIVOS DISA\Archivo de Texto.txt"; // Thinkpad
            //public const string IO_SHEET = @"C:\Users\DISA_Lenovo\Documents\DISA\RECURSOS\Documentacion Disa\F-DIS-003 Formato IO'S.xlsx"; // Disa

            // Jabil Test Directory
            public const string JBTEST_DIRECTORY = @"\Directorios_Disa\Sistema\Jabil Test Project\Sistema";
            //public const string JBTEST_DIRECTORY = @"C:\Users\jarvi\Documents\Test Directory"; // Thinkpad
            //public const string JBTEST_DIRECTORY = @"C:\Users\DISA_Lenovo\Documents\DISA\RECURSOS\Sistema\Jabil Test Project\Sistema";




        }
    }
}
