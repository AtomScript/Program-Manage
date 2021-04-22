using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ApiReference
{
	class ApiExample
	{
		[DllImport("kernel32")]
		static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, IntPtr lpBuffer, uint nSize, out uint lpNumberOfBytesRead);
		public unsafe void Main(string[] arge)
		{
			// myAge 라는 변수에 23 을 저장한다.
			int myAge = 23;

			// myAge 변수의 주소 값을 가지는 변수와 결과를 받을 변수를 선언한다.
			IntPtr pAgeAddress = new IntPtr(&myAge), pResultAge;
			pResultAge = Marshal.AllocHGlobal(4);
			uint reads;

			if (!ReadProcessMemory(Process.GetCurrentProcess().Handle, pAgeAddress, pResultAge, 4, out reads))
			{
				MessageBox.Show("Memory read failure!");
			}
			else
			{
				MessageBox.Show("Memory read success!");
				MessageBox.Show("the value of the myAge variable: {0}", myAge.ToString());
				// 이 방법도 되지만
				string v1 = Convert.ToString(*(int*)pResultAge.ToPointer());
				MessageBox.Show("pResultAge The value of the address pointed to by the variable: {0}", v1);

				string v2 = Convert.ToString(Marshal.ReadInt32(pResultAge));
				MessageBox.Show("pResultAge The value of the address pointed to by the variable: {0}", v2);
			}

			Marshal.FreeHGlobal(pResultAge);
			Console.ReadKey(true);
		}
	}
}