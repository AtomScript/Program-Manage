using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Management;

namespace ProgramManage
{
    class content
    {
        public void CheckInstance()
        {
            Process[] thisnameprocesslist;
            string modulename, processname;
            Process p = Process.GetCurrentProcess();
            modulename = p.MainModule.ModuleName.ToString();
            processname = System.IO.Path.GetFileNameWithoutExtension(modulename);
            thisnameprocesslist = Process.GetProcessesByName(processname);
            if (thisnameprocesslist.Length > 1)
            {
                Application.Exit();
            }
        }
    }
}
