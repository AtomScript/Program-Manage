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
using System.IO;

namespace ProgramManage
{
    public partial class Form1 : Form
    {
        public string itemremovedid = "0";
        public Form1()
        {
            InitializeComponent();
            Inicio();
            this.Text = "Program Manage";
            ListProcessFormu1.DoubleBuffering(true);
        }

        private void SelectProcess_Click(object sender, EventArgs e)
        {
            SelectProcessForme SelectProcessForm2 = new SelectProcessForme(this);
            SelectProcessForm2.ShowDialog();
        }

        private void Inicio()
        {
            if (this.panelContainer.Controls.Count > 0)
                this.panelContainer.Controls.RemoveAt(0);
            inicio fh1 = new inicio();
            fh1.TopLevel = false;
            fh1.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(fh1);
            this.panelContainer.Tag = fh1;
            fh1.Show();
        }
        private void button1form1_Click(object sender, EventArgs e)
        {
        }

        private class MyItem
        {
            public string Type { get; set; }
            public int NumberOfLines { get; set; }
            public bool IsGeneric { get; set; }
        }
        private void ListProcessFormu1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name.ToString() == "RestoreNotifyicon")
            {
                if (WindowState == FormWindowState.Normal)
                {
                    MessageBox.Show("Não é possivel Restaurar." + "\n" + "Motivo: O programa já esta restaurado.", "Alerta");
                    this.Visible = true;
                }
                else
                {
                    this.Visible = true;
                    this.WindowState = FormWindowState.Normal;
                    notifyIcon1.Text = "Process Manage - Opened";
                }
            }
            else if (e.ClickedItem.Name.ToString() == "CloseNotifyicon")
            {
                this.Close();
            }
            else if (e.ClickedItem.Name.ToString() == "MinimizeNotifyicon")
            {
                if(WindowState == FormWindowState.Minimized)
                {
                    MessageBox.Show("Não é possivel minimizar." + "\n" + "Motivo: O programa já esta minimizado.", "Aviso!");
                }
                else
                {
                    this.WindowState = FormWindowState.Minimized;
                    this.Visible = false;
                    notifyIcon1.Text = "Process Manage - Minimized";
                }
            }
            else if (e.ClickedItem.Name.ToString() == "InvisibleNotifyicon")
            {
                CloseNotifyicon2();
            }
        }
        private void CloseNotifyicon2()
        {
            if (this.Visible == true)
            {
                notifyIcon1.Visible = false;
            }
            else if (WindowState == FormWindowState.Minimized)
            {
                var result = MessageBox.Show("O programa esta minimizado, se você fechar a bandeja, você não conseguirá abrir o programa novamente! Caso queira continuar, você pode fechar o programa pelo gerenciador de tarefas", "Aviso!", MessageBoxButtons.OKCancel);
                switch (result)
                {
                    case DialogResult.OK:
                        notifyIcon1.Visible = false;
                    break;
                    case DialogResult.Cancel:

                        break;
                }
            }
        }

        private void BackInicio_Click(object sender, EventArgs e)
        {
            Inicio();
        }

        private void ConfigMenu_Click(object sender, EventArgs e)
        {
        }

        private void ListProcessFormu1_MouseUp(object sender, MouseEventArgs e)
        {
            if (ListProcessFormu1.SelectedItems.Count > 0)
            {
                string PN = ListProcessFormu1.SelectedItems[0].SubItems[0].Text;
                if (ListProcessFormu1.SelectedItems[0].SubItems[0].Text == PN)
                {
                    ListProcessFormu1.ContextMenuStrip = Gerenciar;

                }
                else
                {
                    ListProcessFormu1.ContextMenuStrip = noneStrip;
                }
            }
            else
            {
                ListProcessFormu1.ContextMenuStrip = noneStrip;
            }
        }
        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            itemremovedid = ListProcessFormu1.SelectedItems[0].SubItems[1].Text;
            ListProcessFormu1.SelectedItems[0].Remove();
        
        }

        private void ListProcessFormu1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ListProcessFormu1.SelectedItems.Count > 0)
            {
                string ProcessName = ListProcessFormu1.SelectedItems[0].SubItems[0].Text;
                //
                //

                if (this.panelContainer.Controls.Count > 0)
                    this.panelContainer.Controls.RemoveAt(0);
                Form4 fh = new Form4(this);
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panelContainer.Controls.Add(fh);
                this.panelContainer.Tag = fh;
                fh.Show();
            }
        }

        private void tempForm1_Tick(object sender, EventArgs e)
        {
            if (tempForm1.Enabled != false)
            {
                tempForm1.Enabled = false;
                if (tempForm1.Enabled == false)
                {
                    var patheprogramform1 = Directory.GetCurrentDirectory();
                    if (File.Exists(patheprogramform1 + "/" + "FunctionsQuery.dll"))
                    {
                    }
                    else
                    {
                        MessageBox.Show("Está faltando uma dll. Certifique-se de que todas as dlls estão no mesmo diretorio que o programa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                }
            }
        }
    }
}
