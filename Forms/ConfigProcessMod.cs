using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;
using System.Runtime.InteropServices;
using gh;
using System.IO;

namespace ProgramManage
{
    public partial class ConfigProcessMod : Form
    {

        Form4 instanciaDoForm40;

        int changeToB = 2;
        private object resMg;

        public ConfigProcessMod(Form4 frm4)
        {

            InitializeComponent();
            instanciaDoForm40 = frm4;
            string ProcessNamep = instanciaDoForm40.NomeDoProcesso.Text;
            string ProcessIdp = instanciaDoForm40.labelProc.Text;
            ProcessNameLe.Text = ProcessNamep;
            processidpe.Text = ProcessIdp;
            getModuleP();
        }

        class ProcInfo
        {
            public FileInfo FileProc { get; set; }
            public int Handle { get; set; }
            public List<ModInfo> Modules { get; set; }

            public ProcInfo()
            {
                Modules = new List<ModInfo>();
            }
        }

        class ModInfo
        {
            public FileInfo FileMod { get; set; }
        }





        private void getModuleP()
        {
            lvValueMPe.Items.Clear();
            lvValueMPe.Refresh();
            try
            {
                string processidpef = processidpe.Text;
                int processidp = Convert.ToInt32(processidpef);
                Process proc = Process.GetProcessById(processidp);

                ProcessModule myProcessModule;
                //Get all the modules associated with 'myProcess".
                ProcessModuleCollection myProcessModuleCollection = proc.Modules;

                for (int i = 0; i < myProcessModuleCollection.Count; i++)
                {
                    myProcessModule = myProcessModuleCollection[i];
                    string mdp = Convert.ToString(myProcessModule.ModuleName);
                    string fnp = Convert.ToString(myProcessModule.FileName);
                   string bap = Convert.ToString(myProcessModule.BaseAddress);
                    string epa = Convert.ToString(myProcessModule.EntryPointAddress);

                    ListViewItem novoListViewItem = new ListViewItem();
                    novoListViewItem.Text = (mdp);
                    novoListViewItem.SubItems.Add(fnp);


                    int offset = 0x100; //whatever offset you wish
                    string bap1 = bap += offset;
                    novoListViewItem.SubItems.Add("0x" + myProcessModule.BaseAddress.ToString("X"));
                    //myProcessModule.BaseAddress.ToString("X")
                    novoListViewItem.SubItems.Add("0x" + epa);

                    lvValueMPe.Items.Add(novoListViewItem);

                    lvValueMPe.Refresh(); //recarrego ela
                }
            }
            catch { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }
    }
}
