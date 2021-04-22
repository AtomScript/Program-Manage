using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramManage
{
    public partial class Fileinfo : Form
    {
        private Thread threader;
        public Process proc;
        public Fileinfo()
        {
            InitializeComponent();
            textBox1.Text = "Selecione um arquivo";
        }

        private void ButtonAC_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Aplicações (*.exe*)|*.exe*";
            string ofdname = "";


            if (ofd.ShowDialog().Equals(DialogResult.OK))
            {
                ofdname = ofd.FileName;
                FileInfo fileInfo = new FileInfo(ofdname);
                //Mostra o nome do arquivo
                string fileFullName = fileInfo.FullName;
                string fileName = fileInfo.Name;
                //Mostra a extensão do arquivo
                var fileExtension1 = Path.GetFileName(fileFullName);
                string fileExtension = Convert.ToString(fileExtension1);
                //Mostra o caminho completo do arquivo junto com o nome

                if (ofdname == null)
                {
                }
                else
                {
                    try
                    {
                        textBox1.Text = fileFullName;
                        proc = Process.Start(fileFullName);
                        suspendproc.SuspendProcess(proc.Id);
                        string wmiQueryString = "SELECT ProcessId, ExecutablePath FROM Win32_Process WHERE ProcessId = " + proc.Id;
                        listBox1.Items.Add("---------------= Process info =---------------");
                        try
                        {
                            threader = new Thread(() =>
                            {
                                this.Invoke(new Action(() =>
                                {
                                    try
                                    {
                                        listBox1.Items.Add("Id: " + proc.Id + "");
                                    }
                                    catch { }
                                }));
                                this.Invoke(new Action(() =>
                                {
                                    try
                                    {
                                        listBox1.Items.Add("Nome: " + proc.ProcessName + "");
                                    }
                                    catch { }
                                }));
                                this.Invoke(new Action(() =>
                                {
                                    try
                                    {
                                        listBox1.Items.Add("Modulo: " + proc.MainModule + "");
                                    }
                                    catch { }
                                }));
                                this.Invoke(new Action(() =>
                                {
                                    try
                                    {
                                        listBox1.Items.Add("Modulo: " + proc.MainModule + "");
                                    }
                                    catch { }
                                }));
                                this.Invoke(new Action(() =>
                                {
                                    try
                                    {
                                        bool bits = checkbit.Is64Bit(proc.Id);
                                        if (bits)
                                        {
                                            listBox1.Items.Add("Plataforma: 32 bits/86x");
                                        }
                                        else
                                        {
                                            listBox1.Items.Add("Plataforma: 64 bits/64x");
                                        }
                                    }
                                    catch { }
                                }));
                                this.Invoke(new Action(() =>
                                {
                                    try
                                    {
                                        try
                                        {
                                            IntPtr hProc = proc.Handle;

                                            var base_adr = proc.MainModule.BaseAddress;
                                            int height_offset = 0x0;
                                            IntPtr height_adr = (IntPtr)(base_adr + height_offset);
                                            listBox1.Items.Add("Endereço: " + base_adr.ToString("X") + "");
                                        }
                                        catch
                                        {
                                            listBox1.Items.Add("Endereço: Falha");
                                        }
                                    }
                                    catch { }
                                }));
                                this.Invoke(new Action(() =>
                            {
                                try
                                {
                                    try
                                    {
                                        try
                                        {
                                            listBox1.Items.Add("-------------------Dll's usada pelo processo-------------------" + "\n" + "\n");

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
                                                listBox1.Items.Add("Dll: " + mdp + ", endereço base: " + myProcessModule.BaseAddress.ToString("X") + ", Endereço do ponteiro: " + epa + ", local: " + fnp + ".");


                                            }
                                        }
                                        catch { }
                                    }
                                    catch
                                    {
                                        listBox1.Items.Add("Endereço: Falha");
                                    }
                                }
                                catch { }
                            }));
                            });
                            this.Invoke(new Action(() =>
                            {
                                try
                                {
                                    using (var searcher = new ManagementObjectSearcher(wmiQueryString))
                                    {
                                        using (ManagementObjectCollection results = searcher.Get())
                                        {
                                            foreach (ManagementObject mo in results)
                                            {
                                                try
                                                {
                                                    if (mo["ExecutablePath"] != null)
                                                    {
                                                        string filename = @"" + mo["ExecutablePath"] + "";
                                                        FileInfo fi = new FileInfo(filename);
                                                        string filefullpath = fi.DirectoryName;
                                                        try
                                                        {
                                                            listBox1.Items.Add("Tamanho: " + fileInfoTam(fi.Length) + "\n");
                                                            string fileInfoTam(long length)
                                                            {
                                                                double value = (length / 1024);
                                                                string label = "Kb";
                                                                if ((length / 1024) > 1024)
                                                                {
                                                                    value = ((length / 1024) / 1024);
                                                                    label = "Mb";
                                                                }

                                                                return string.Format("{0} {1}", Math.Round(value, 4), label);
                                                            }
                                                        }
                                                        catch
                                                        {
                                                            listBox1.Items.Add("tamanho: falha" + "\n");
                                                        }
                                                        try
                                                        {
                                                            DateTime dataCriacao = new DateTime();

                                                            FileInfo arquivo = new FileInfo(filename);
                                                            dataCriacao = arquivo.CreationTime;
                                                            listBox1.Items.Add("Data de download: " + dataCriacao + "\n");

                                                        }
                                                        catch
                                                        {
                                                            listBox1.Items.Add("Data de download: falha" + "\n");
                                                        }
                                                        try
                                                        {
                                                            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
                                                            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo("" + mo["ExecutablePath"] + "");
                                                            string version = fvi.FileVersion;
                                                            listBox1.Items.Add("Versão: " + version + "\n");
                                                        }
                                                        catch
                                                        {
                                                            listBox1.Items.Add("Versão: falha" + "\n");
                                                        }
                                                        try
                                                        {
                                                            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
                                                            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo("" + mo["ExecutablePath"] + "");
                                                            string versionn = fvi.ProductName;
                                                            listBox1.Items.Add("Nome: " + versionn + "\n");
                                                        }
                                                        catch
                                                        {
                                                            listBox1.Items.Add("Nome: falha" + "\n");
                                                        }
                                                        try
                                                        {
                                                            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
                                                            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo("" + mo["ExecutablePath"] + "");
                                                            string versionnc = fvi.CompanyName;
                                                            listBox1.Items.Add("Empresa: " + versionnc + "\n");
                                                        }
                                                        catch
                                                        {
                                                            listBox1.Items.Add("Empresa: falha" + "\n");
                                                        }

                                                        try
                                                        {
                                                            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
                                                            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo("" + mo["ExecutablePath"] + "");
                                                            string versionnc12 = fvi.Language;
                                                            listBox1.Items.Add("Linguagem padrão: " + versionnc12 + "\n");
                                                        }
                                                        catch
                                                        {
                                                            listBox1.Items.Add("Linguagem padrão: falha" + "\n");
                                                        }

                                                        try
                                                        {
                                                            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
                                                            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo("" + mo["ExecutablePath"] + "");
                                                            bool ispath = fvi.IsPatched;
                                                            if (ispath == false)
                                                            {
                                                                string stat = "Não";
                                                                listBox1.Items.Add("Aplicação pirata: " + stat + "\n");
                                                            }
                                                            else if (ispath == true)
                                                            {
                                                                string stat = "Sim";
                                                                listBox1.Items.Add("Aplicação pirata: " + stat + "\n");
                                                            }
                                                        }
                                                        catch
                                                        {
                                                            listBox1.Items.Add("Aplicação pirata: falha" + "\n");
                                                        }
                                                        try
                                                        {
                                                            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
                                                            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo("" + mo["ExecutablePath"] + "");
                                                            bool versionnc12 = fvi.IsPreRelease;
                                                            if (versionnc12 == false)
                                                            {
                                                                string stat = "Não";
                                                                listBox1.Items.Add("Versão beta: " + stat + "\n");
                                                            }
                                                            else if (versionnc12 == true)
                                                            {
                                                                string stat = "Sim";
                                                                listBox1.Items.Add("Versão beta: " + stat + "\n");
                                                            }
                                                        }
                                                        catch
                                                        {
                                                            listBox1.Items.Add("Versão beta: falha" + "\n");
                                                        }

                                                    }
                                                }
                                                catch { }
                                            }
                                        }
                                    }
                                }
                                catch { }
                            }));
                        }
                        catch { }
                        threader.Start();
                        proc.Kill();
                    }
                    catch { }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fileinfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                threader.Abort();
            }
            catch { }
            try
            {
                proc.Kill();

            }
            catch
            {

            }
        }
    }
}
