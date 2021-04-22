using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramManage
{
    public partial class newwaitlv : Form
    {
        int changeToB = 0;
        int typetextn = 0;
        int typebuttonn = 0;
        int attrelementtype = 0;
        int attrelementtypeb = 0;
        string pathRoot = "";
        Selenium se;
        public newwaitlv(Selenium ser)
        {
            InitializeComponent();
            se = ser;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            attrelementb.DropDownStyle = ComboBoxStyle.DropDownList;
            attrelementb.SelectedIndex = 0;
        }

        private void attrelementb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rese = -1;

            if (attrelementb.Text != String.Empty)
            {
                // O método FindStringExact procura a primeira ocorrência na lista
                rese = attrelementb.FindStringExact(attrelementb.Text);

                // FindStringExact retorna -1 se nada for encontrado
                if (rese != -1)
                {
                    if (rese == 0)
                    {
                        attrelementtypeb = 1;
                        tbidbutton.Visible = true;
                        label1.Visible = true;

                        tbclassb.Visible = false;
                        labelclassb.Visible = false;

                        tbnameb.Visible = false;
                        labelnameb.Visible = false;

                        tbvalueb.Visible = false;
                        labelvalueb.Visible = false;
                    }
                    else if (rese == 1)
                    {
                        attrelementtypeb = 2;

                        tbidbutton.Visible = false;
                        label1.Visible = false;

                        tbclassb.Visible = true;
                        labelclassb.Visible = true;

                        tbnameb.Visible = false;
                        labelnameb.Visible = false;

                        tbvalueb.Visible = false;
                        labelvalueb.Visible = false;
                    }
                    else if (rese == 2)
                    {
                        attrelementtypeb = 3;

                        tbidbutton.Visible = false;
                        label1.Visible = false;

                        tbclassb.Visible = false;
                        labelclassb.Visible = false;

                        tbnameb.Visible = true;
                        labelnameb.Visible = true;

                        tbvalueb.Visible = false;
                        labelvalueb.Visible = false;
                    }
                    else if (rese == 3)
                    {
                        attrelementtypeb = 4;

                        tbidbutton.Visible = false;
                        label1.Visible = false;

                        tbclassb.Visible = false;
                        labelclassb.Visible = false;

                        tbnameb.Visible = false;
                        labelnameb.Visible = false;

                        tbvalueb.Visible = true;
                        labelvalueb.Visible = true;
                    }
                    attrelementb.SelectedIndex = rese;
                }
                else
                {
                }
            }
            else
            {
                attrelementb.Focus();
            }
        }

        private void additembutton_Click(object sender, EventArgs e)
        {
            string element = "";
            string attr = "";
            string eide = "";
            if (attrelementtypeb == 1)
            {
                attr = "id";
                eide = tbidbutton.Text;
            }
            else if (attrelementtypeb == 2)
            {
                attr = "class";
                eide = tbclassb.Text;
            }
            else if (attrelementtypeb == 3)
            {
                attr = "name";
                eide = tbnameb.Text;
            }
            else if (attrelementtypeb == 4)
            {
                attr = "value";
                eide = tbvalueb.Text;
            }
            element = tbelementb.Text;

            if (element != string.Empty)
            {
                string[] row = {
                "wait",
                eide,
                "wait",
                element,
                attr,
                "null",
                "null",
                "null"
                 };
                ListViewItem item = new ListViewItem(row);

                se.listView1.Items.Add(item);

                tbidbutton.Text = string.Empty;
                tbelementb.Text = string.Empty;
                tbclassb.Text = string.Empty;
                tbnameb.Text = string.Empty;
                if (cbclose.Checked)
                {
                    this.Close();
                }
            }
            else
            {
                try
                {
                    string hora = "" + DateTime.Now.ToString("HH:mm:ss") + "";
                    se.listBox1.Items.Add("[" + hora + "]: O elemento não pode ficar em branco!");
                }
                catch
                {

                }
            }
        }
    }
}
