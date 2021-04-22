using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramManage
{
    public partial class SelectProcesse : Form
    {
        private Thread thread;
        public static int hourse = DateTime.Now.Hour;
        public static int minutese = DateTime.Now.Minute;
        public static int secondse = DateTime.Now.Second;
        public string hora = "" + DateTime.Now.ToString("HH:mm:ss") + "";

        AutoClose instanciaDoForm1;
        public SelectProcesse(AutoClose frm1)
        {
            InitializeComponent();
            lvServicosAtivos.Items.Clear();
            lvServicosAtivos.Sorting = SortOrder.Ascending;
            GetProcess();
            this.ControlBox = false;
            instanciaDoForm1 = frm1;
            lvServicosAtivos.DoubleBuffering(true);
        }
        public void GetProcess()
        {
            ImageList Imagelist = new ImageList();
            Process[] processlist = Process.GetProcesses();

            thread = new Thread(() =>
            {
                foreach (Process process in processlist)
            {
                ListViewItem novoListViewItem = new ListViewItem();
                string[] row = {
                process.ProcessName.ToString(),
                process.Id.ToString()
                 };
                //novoListViewItem.Text = ((string)process["Name"]);
                //novoListViewItem.SubItems.Add(process["ProcessId"].ToString());
                try
                {
                    Imagelist.Images.Add(
                // Add an unique Key as identifier for the icon (same as the ID of the process)
                process.Id.ToString(),
                        // Add Icon to the List 
                        Icon.ExtractAssociatedIcon((string)process.MainModule.FileName)
                    );
                }
                catch { }

                ListViewItem item = new ListViewItem(row)
                {
                    // Set the ImageIndex of the item as the same defined in the previous try-catch
                    ImageIndex = Imagelist.Images.IndexOfKey(process.Id.ToString())
                };

                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {
                    item.Group = lvServicosAtivos.Groups["Aplicativos"];
                }
                else
                {
                    item.Group = lvServicosAtivos.Groups["Processos"];
                    }
                    try
                    {
                        this.Invoke(new Action(() =>
                    {
                        lvServicosAtivos.Items.Add(item);
                    }));
                    }
                    catch { }
                }
            });
            thread.Start();
            lvServicosAtivos.SmallImageList = Imagelist;
        }
        public class MyItem
        {
            public string Type { get; set; }
            public int NumberOfLines { get; set; }
            public bool IsGeneric { get; set; }
        }

        private void lvServicosAtivos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int additem = 1;
            if (lvServicosAtivos.SelectedItems.Count > 0)
            {
                string Processid = lvServicosAtivos.SelectedItems[0].SubItems[1].Text;
                string ProcessName = lvServicosAtivos.SelectedItems[0].SubItems[0].Text;

                for (int i = 0; i < instanciaDoForm1.ListProcessFormu1.Items.Count; i++)
                {
                    string pnc = Convert.ToString(instanciaDoForm1.ListProcessFormu1.Items[i].Text);

                    if (pnc == ProcessName)
                    {
                        additem = 0;
                    }
                    else
                    {
                        additem = 1;
                    }
                }

                if (additem == 1)
                {
                    ListViewItem novoListViewItem = new ListViewItem();
                    novoListViewItem.Text = ((string)ProcessName);

                    instanciaDoForm1.ListProcessFormu1.Items.Add(novoListViewItem);
                    try
                    {
                        instanciaDoForm1.LBAction.Items.Add("[" + hora + "]: " + ProcessName + " Adicionado a lista. ");
                        this.Close();
                    }
                    catch
                    {
                        this.Close();
                    }
                }
                else
                {
                    instanciaDoForm1.LBAction.Items.Add("[" + hora + "]: " + ProcessName + " Já foi adicionado a lista! ");
                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            thread.Abort();
            this.Close();
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            int hours = DateTime.Now.Hour;
            int minutes = DateTime.Now.Minute;
            int seconds = DateTime.Now.Second;
            hora = "" + DateTime.Now.ToString("HH:mm:ss") + "";
        }
    }
}
