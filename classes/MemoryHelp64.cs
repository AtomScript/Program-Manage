using Memory.classes;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace ProgramManage
{
    class MemoryHelper64
    {
        Process process;

        public MemoryHelper64(Process TargetProcess)
        {
            process = TargetProcess;
        }

        public ulong GetBaseAddress(ulong StartingAddress)
        {
            return (ulong)process.MainModule.BaseAddress.ToInt64() + StartingAddress;
        }

        public byte[] ReadMemoryBytes(ulong MemoryAddress, int Bytes)
        {
            byte[] data = new byte[Bytes];
            ReadProcessMemory(process.Handle, MemoryAddress, data, data.Length, IntPtr.Zero);
            return data;
        }

        public T ReadMemory<T>(ulong MemoryAddress)
        {
            byte[] data = ReadMemoryBytes(MemoryAddress, Marshal.SizeOf(typeof(T)));

            T t;
            GCHandle PinnedStruct = GCHandle.Alloc(data, GCHandleType.Pinned);
            try { t = (T)Marshal.PtrToStructure(PinnedStruct.AddrOfPinnedObject(), typeof(T)); }
            catch (Exception ex) { throw ex; }
            finally { PinnedStruct.Free(); }

            return t;
        }

        public bool WriteMemory<T>(ulong MemoryAddress, T Value)
        {
            IntPtr bw = IntPtr.Zero;

            int sz = ObjectType.GetSize<T>();
            byte[] data = ObjectType.GetBytes<T>(Value);
            bool result = WriteProcessMemory(process.Handle, MemoryAddress, data, sz, out bw);
            return result && bw != IntPtr.Zero;
        }

        public void Close()
        {
            CloseHandle(process.Handle);
        }

        #region PInvoke
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool ReadProcessMemory(
            IntPtr hProcess,
            ulong lpBaseAddress,
            byte[] lpBuffer,
            int nSize,
            IntPtr lpNumberOfBytesRead);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool WriteProcessMemory(
            IntPtr hProcess,
            ulong lpBaseAddress,
            byte[] lpBuffer,
            int nSize,
            out IntPtr lpNumberOfBytesWritten
            );

        [DllImport("kernel32.dll")]
        private static extern Int32 CloseHandle(IntPtr hProcess);
        #endregion
    }
}

