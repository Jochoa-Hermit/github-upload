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

        void AddIOSheet(string _directory);

    }
}
