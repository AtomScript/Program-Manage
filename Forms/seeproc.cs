using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramManage
{
    public partial class seeproc : Form
    {
        Form4 frm4;
        public int id;
        public seeproc(Form4 frm44)
        {
            InitializeComponent();
            frm4 = frm44;
            id = Convert.ToInt32(frm4.labelProc.Text);
            string nome = frm4.NomeDoProcesso.Text;
            try
            {
                this.Text = "Processos associado com " + nome;
            }
            catch { }
            KillProcessAndChildren(id);
        }
        private void KillProcessAndChildren(int pid)
        {
            try
            {
                // Cannot close 'system idle process'.
                if (pid == 0)
                {
                    return;
                }
                ManagementObjectSearcher searcher = new ManagementObjectSearcher
                        ("Select * From Win32_Process Where ParentProcessID=" + pid);
                ManagementObjectCollection moc = searcher.Get();
                foreach (ManagementObject mo in moc)
                {
                    KillProcessAndChildren(Convert.ToInt32(mo["ProcessID"]));
                }
                try
                {
                    Process proc = Process.GetProcessById(pid);

                    ListViewItem novoListViewItem = new ListViewItem();
                    novoListViewItem.Text = (proc.ProcessName);
                    novoListViewItem.SubItems.Add("" + proc.Id);

                    listView1.Items.Add(novoListViewItem);
                }
                catch (ArgumentException)
                {
                    // Process already exited.
                }
            }
            catch { }
        }
    }
}
