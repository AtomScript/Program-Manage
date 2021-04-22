using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;
using System.Threading;
using System.Reflection;

namespace ProgramManage
{
    public partial class SelectProcessForme : Form
    {
        Form1 instanciaDoForm1;
        private Thread thread;

        public SelectProcessForme(Form1 frm1)
        {
            InitializeComponent();
            lvServicosAtivos.Sorting = SortOrder.Ascending;
            PopulateApplications();
            this.ControlBox = false;
            instanciaDoForm1 = frm1;
            lvServicosAtivos.DoubleBuffering(true);
        }
        private void SelectProcessForme_Load(object sender, EventArgs e)
        {
        }
        public void PopulateApplications()
        {
            ImageList Imagelist = new ImageList();
            Process[] processlist = Process.GetProcesses();


            Dictionary<String, String> pidsRunningInSystem = new Dictionary<String, String>();

            ListViewGroup ap_group = new ListViewGroup("Aplicativos");
            ListViewGroup pr_group = new ListViewGroup("Processos");
            lvServicosAtivos.Groups.Add(ap_group);
            lvServicosAtivos.Groups.Add(pr_group);

            lvServicosAtivos.BeginUpdate();
            try
            {
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
            }
            finally
            {
                lvServicosAtivos.EndUpdate();
            }

            lvServicosAtivos.SmallImageList = Imagelist;
        }
        public class MyItem
        {
            public string Type { get; set; }
            public int NumberOfLines { get; set; }
            public bool IsGeneric { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            thread.Abort();
            this.Close();
        }

        private void lvServicosAtivos_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (lvServicosAtivos.SelectedItems.Count > 0)
            {
                string Processid = lvServicosAtivos.SelectedItems[0].SubItems[1].Text;
                string ProcessName = lvServicosAtivos.SelectedItems[0].SubItems[0].Text;

                    ListViewItem novoListViewItem = new ListViewItem();
                    novoListViewItem.Text = ((string)ProcessName);
                    novoListViewItem.SubItems.Add(Processid);

                    instanciaDoForm1.ListProcessFormu1.Items.Add(novoListViewItem);


                this.Close();
            }
        }

        private void lvServicosAtivos_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

    }
}