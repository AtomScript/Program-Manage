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
    public partial class Changelv : Form
    {
        int ready = 0;
        int ie;
        int selectedIndex = 0;
        Selenium se;
        public Changelv(Selenium ser)
        {
            InitializeComponent();
            se = ser;

            ie = se.listView1.Items.Count;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            tbidc.Text = se.listView1.SelectedItems[0].SubItems[1].Text;
            richTextBox1.Text = se.listView1.SelectedItems[0].SubItems[2].Text;
            tbelement.Text = se.listView1.SelectedItems[0].SubItems[3].Text;
            ready = 1;
        }

        private void additemtext_Click(object sender, EventArgs e)
        {
            se.listView1.SelectedItems[0].SubItems[1].Text = tbidc.Text;
            se.listView1.SelectedItems[0].SubItems[2].Text = richTextBox1.Text;
            se.listView1.SelectedItems[0].SubItems[3].Text = tbelement.Text;
            this.Close();
        }
    }
}
