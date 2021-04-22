using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramManage
{
    public partial class AddInputlv : Form
    {
        Selenium se;
        int changeToB = 0;
        int typetextn = 0;
        int typebuttonn = 0;
        int attrelementtype = 0;
        int attrelementtypeb = 0;
        string pathRoot = "";
        public AddInputlv(Selenium ser)
        {
            InitializeComponent();
            se = ser;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            attrelementt.DropDownStyle = ComboBoxStyle.DropDownList;
            attrelementt.SelectedIndex = 0;
        }

        private void additemtext_Click(object sender, EventArgs e)
        {

            string element = "";
            string attr = "";
            string eider = "";
            if (attrelementtype == 1)
            {
                attr = "id";
                eider = tbid.Text;
            }
            else if (attrelementtype == 2)
            {
                attr = "class";
                eider = tbclass.Text;
            }
            else if (attrelementtype == 3)
            {
                attr = "name";
                eider = tbname.Text;
            }
            else if (attrelementtype == 4)
            {
                attr = "value";
                eider = tbvalueattr.Text;
            }
            element = tbelementt.Text;
            string value = tbvalue.Text;
            if (element != string.Empty)
            {
                string[] row = {
                "text",
                eider,
                value,
                element,
                attr,
                "null"
                 };
                ListViewItem item = new ListViewItem(row);

                se.listView1.Items.Add(item);

                tbid.Text = string.Empty;
                tbvalue.Text = string.Empty;
                tbelementt.Text = string.Empty;
                tbclass.Text = string.Empty;
                tbname.Text = string.Empty;
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

        private void attrelementt_SelectedIndexChanged(object sender, EventArgs e)
        {

            int res = -1;

            if (attrelementt.Text != String.Empty)
            {
                // O método FindStringExact procura a primeira ocorrência na lista
                res = attrelementt.FindStringExact(attrelementt.Text);

                // FindStringExact retorna -1 se nada for encontrado
                if (res != -1)
                {
                    if (res == 0)
                    {
                        attrelementtype = 1;
                        tbid.Visible = true;
                        labelid.Visible = true;

                        tbclass.Visible = false;
                        labelclass.Visible = false;

                        tbname.Visible = false;
                        labelname.Visible = false;

                        tbvalueattr.Visible = false;
                        labelvaluer.Visible = false;
                    }
                    else if (res == 1)
                    {
                        attrelementtype = 2;
                        tbid.Visible = false;
                        labelid.Visible = false;

                        tbclass.Visible = true;
                        labelclass.Visible = true;

                        tbname.Visible = false;
                        labelname.Visible = false;

                        tbvalueattr.Visible = false;
                        labelvaluer.Visible = false;
                    }
                    else if (res == 2)
                    {
                        attrelementtype = 3;
                        tbid.Visible = false;
                        labelid.Visible = false;

                        tbclass.Visible = false;
                        labelclass.Visible = false;

                        tbname.Visible = true;
                        labelname.Visible = true;

                        tbvalueattr.Visible = false;
                        labelvaluer.Visible = false;
                    }
                    else if (res == 3)
                    {
                        attrelementtype = 4;
                        tbid.Visible = false;
                        labelid.Visible = false;

                        tbclass.Visible = false;
                        labelclass.Visible = false;

                        tbname.Visible = false;
                        labelname.Visible = false;

                        tbvalueattr.Visible = true;
                        labelvaluer.Visible = true;
                    }
                    attrelementt.SelectedIndex = res;
                }
                else
                {
                }
            }
            else
            {
                attrelementt.Focus();
            }
        }

        private void tbelementt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)System.Windows.Forms.Keys.Space)
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
            else
            {
                if (!(char.IsDigit(e.KeyChar) || Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == (char)System.Windows.Forms.Keys.Space))
                { e.Handled = true; SystemSounds.Beep.Play(); }
            }
        }
    }
}
