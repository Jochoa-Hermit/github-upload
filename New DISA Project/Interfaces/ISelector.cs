using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_DISA_Project.Interfaces
{
    public interface ISelector
    {
        void ControlSelector(string projectName, string systemDir, string controlDir);

        // Create a method to add file, but in the implementation of the methods below use the proper const
        void AddIOSheet(string _directory);
        void AddManual(string _directory);

    }
}
