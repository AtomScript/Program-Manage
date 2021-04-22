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

namespace ProgramManage
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void ButtonAC_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<AutoClose>().Count() > 0)
            {
                MessageBox.Show("Esta ferramenta esta aberta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AutoClose OAC = new AutoClose();
                OAC.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fileinfo ffi = new Fileinfo();
            ffi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Selenium>().Count() > 0)
            {
                MessageBox.Show("Esta ferramenta esta aberta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Selenium fse = new Selenium();
                fse.Show();
            }
        }
    }
}
