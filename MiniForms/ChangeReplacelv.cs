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
    public partial class ChangeReplacelv : Form
    {
        Selenium se;
        public ChangeReplacelv(Selenium ser)
        {
            InitializeComponent();
            se = ser;
            tbattr.Text = se.listView1.SelectedItems[0].SubItems[1].Text;
            tbelementb.Text = se.listView1.SelectedItems[0].SubItems[3].Text;
            tboldvalue.Text = se.listView1.SelectedItems[0].SubItems[5].Text;
            tbnevalue.Text = se.listView1.SelectedItems[0].SubItems[2].Text;
        }

        private void additembutton_Click(object sender, EventArgs e)
        {
            se.listView1.SelectedItems[0].SubItems[1].Text = tbattr.Text;
            se.listView1.SelectedItems[0].SubItems[3].Text = tbelementb.Text;
            se.listView1.SelectedItems[0].SubItems[5].Text = tboldvalue.Text;
            se.listView1.SelectedItems[0].SubItems[2].Text = tbnevalue.Text;
            this.Close();
        }
    }
}
