using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace MR
{
    class Program
    {
        const int PROCESS_WM_READ = 0x0010;

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);
        //static void Main(string[] args)
        // {
        //    Process process = Process.GetProcessesByName("MyProgram")[0];
        //    IntPtr processHandle = OpenProcess(PROCESS_WM_READ, false, process.Id);
        //
        //     int bytesRead = 0;
        //     byte[] buffer = new byte[24]; //To read a 24 byte unicode string
        //
        //    ReadProcessMemory((int)processHandle, 0xD5369227FC, buffer, buffer.Length, ref bytesRead);
        //
        //     Console.WriteLine(Encoding.Unicode.GetString(buffer) +
        //           " (" + bytesRead.ToString() + "bytes)");
        //     Console.ReadLine();
        // }
    }
}