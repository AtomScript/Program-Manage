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

namespace ProgramManage
{
    public partial class Form3 : Form
    {
        private System.Timers.Timer _refreshTimer;

        public System.Windows.Forms.ColumnHeader ApplicationNameColumnHeader;
        public System.Windows.Forms.ColumnHeader ApplicationStatusColumnHeader;

        public Form3()
        {
            InitializeComponent();
        }

        void InitialzeComponent()
        {
            throw new NotImplementedException();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            // Setting ListView in "Details" view mode
            ApplicationsListView.View = System.Windows.Forms.View.Details;

            InitializeRefreshTimer();
            PopulateApplications();
        }

        void InitializeRefreshTimer()
        {
            // 1 second interval - too fast???
            _refreshTimer = new System.Timers.Timer(1000);
            // To perform the update in this Form's thread
            _refreshTimer.SynchronizingObject = this;

            _refreshTimer.Elapsed += new System.Timers.ElapsedEventHandler(TimerToUpdate_Elapsed);

            _refreshTimer.Start();
        }

        void TimerToUpdate_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            PopulateApplications();
        }

        void PopulateApplications()
        {
            try
            {
                // Blocking updates to ListView
                ApplicationsListView.BeginUpdate();

                List<String> pidsDisplayedInListView = new List<string>();

                foreach (ListViewItem item in ApplicationsListView.Items)
                {
                    // Process-id is stored in item's Name property
                    pidsDisplayedInListView.Add(item.Name);
                }

                Dictionary<String, String> pidsRunningInSystem = new Dictionary<String, String>();
                Process[] processlist = Process.GetProcesses();

                foreach (Process process in processlist)
                {
                    try
                    {
                        if (!String.IsNullOrEmpty(process.MainWindowTitle))
                        {
                            String id = process.Id.ToString();

                            pidsRunningInSystem.Add(id, id);

                            String status = process.Responding ? "Running" : "Not Responding";

                            // Process-id acts as the key (Item's name)
                            if (ApplicationsListView.Items.ContainsKey(id))
                            {
                                // This process is already displayed. So, just update the status
                                ListViewItem existingItem = ApplicationsListView.Items[id];
                                // Status is shown in the 2nd column
                                ListViewItem.ListViewSubItem statusItem = existingItem.SubItems[1];
                                statusItem.Text = status;
                            }
                            else
                            {
                                // This process is newly found. So, add it
                                ListViewItem newItem = new ListViewItem(new string[] { process.ProcessName, process.MainWindowTitle, status });
                                // Process-id is going to act as the key (Item's name)
                                newItem.Name = id;
                                // Add it
                                ApplicationsListView.Items.Add(newItem);
                            }
                        }
                    }
                    catch { }
                }

                // Remove all the applications which were shut down recently
                foreach (String pid in pidsDisplayedInListView)
                {
                    if (!pidsRunningInSystem.ContainsKey(pid))
                    {
                        ApplicationsListView.Items.RemoveByKey(pid);
                    }
                }
            }
            finally
            {
                // Allowing updates to ListView
                ApplicationsListView.EndUpdate();
            }
        }
    }
}