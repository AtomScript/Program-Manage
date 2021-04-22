using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgramManage.classes
{
    class Convertion
    {
        public static string Get(int a)
        {
            GCHandle handle = GCHandle.Alloc(a, GCHandleType.Pinned);
            try
            {
                IntPtr pointer = GCHandle.ToIntPtr(handle);
                return "0x" + pointer.ToString("X");
            }
            finally
            {
                handle.Free();
            }
        }
    }
}
