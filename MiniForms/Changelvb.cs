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
    public partial class Changelvb : Form
    {
        Selenium se;
        public Changelvb(Selenium ser)
        {
            InitializeComponent();
            se = ser;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            tbidc.Text = se.listView1.SelectedItems[0].SubItems[1].Text;
            tbelement.Text = se.listView1.SelectedItems[0].SubItems[3].Text;
            string tbtyper = se.listView1.SelectedItems[0].SubItems[2].Text;
            if (tbtyper != "click" || tbtyper != "clear")
            {
                tbtype.Text = tbtyper;
                tbtype.Visible = true;
                labeltype.Visible = true;
            }
            else
            {
                tbtype.Visible = false;
                labeltype.Visible = false;
            }

            if (tbtyper != "clear")
            {
            }
            else
            {
                tbtype.Visible = false;
                labeltype.Visible = false;
            }
        }

        private void changeitem_Click(object sender, EventArgs e)
        {
            se.listView1.SelectedItems[0].SubItems[1].Text = tbidc.Text;
            se.listView1.SelectedItems[0].SubItems[3].Text = tbelement.Text;
            string tbtyper = se.listView1.SelectedItems[0].SubItems[2].Text;
            if (tbtype.Text != string.Empty)
            {
                if (tbtyper != "click")
                {
                    se.listView1.SelectedItems[0].SubItems[2].Text = tbtype.Text;
                }
            }
            this.Close();
        }

        private void tbtype_KeyPress(object sender, KeyPressEventArgs e)
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
