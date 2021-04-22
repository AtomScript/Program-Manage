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
using gh;

namespace ProgramManage
{
    public partial class ConfigProcess : Form
    {
        Form4 instanciaDoForm40;
        MR.Program m;

        int changeToB = 2;

        public ConfigProcess(Form4 frm4)
        {

            InitializeComponent();
            instanciaDoForm40 = frm4;
            string ProcessNamep = instanciaDoForm40.NomeDoProcesso.Text;
            string ProcessIdp = instanciaDoForm40.labelProc.Text;
            ProcessNameL.Text = ProcessNamep;
            ConfigIdP.Text = ProcessIdp;
            TemporizadorP.Enabled = true;
            comboBoxSelectBytes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSelectBytes.SelectedIndex = comboBoxSelectBytes.Items.Count - 3;
        }

        private void TemporizadorP_Tick(object sender, EventArgs e)
        {
            try
            {
                string ProcessNamep = instanciaDoForm40.NomeDoProcesso.Text;
                string ProcessIdp = instanciaDoForm40.labelProc.Text;
                int ProcessIdps = Convert.ToInt32(ProcessIdp);
                Process p = Process.GetProcessById(ProcessIdps);
            }
            catch
            {
                TemporizadorP.Enabled = false;
                this.Close();
            }
        }

        private void ConfigProcess_Load(object sender, EventArgs e)
        {
                string ProcessNamep = instanciaDoForm40.NomeDoProcesso.Text;
                string ProcessIdp = instanciaDoForm40.labelProc.Text;
                int ProcessIdps = Convert.ToInt32(ProcessIdp);
                Process process = Process.GetProcessById(ProcessIdps);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                LabelResultBytesRead.Visible = false;
                lvValueMP.Items.Clear();
                string va = GetValueTextBox.Text;
                int val = Convert.ToInt32(va);
                string valu = classes.Convertion.Get(val);
                MessageBox.Show(valu.ToString());

                    int idproc = Convert.ToInt32(instanciaDoForm40.labelProc.Text);
            }
            catch { }










        }

        private void GetValueTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void procuraStringNaCombo()
        {
            int res = -1;

            if (comboBoxSelectBytes.Text != String.Empty)
            {
                // O método FindStringExact procura a primeira ocorrência na lista
                res = comboBoxSelectBytes.FindStringExact(comboBoxSelectBytes.Text);

                // FindStringExact retorna -1 se nada for encontrado
                if (res != -1)
                {
                    if(res == 0)
                    {
                        changeToB = 2;
                    }
                    else if(res == 1)
                    {
                        changeToB = 4;
                    }
                    else if (res == 2)
                    {
                        changeToB = 8;
                    }
                    comboBoxSelectBytes.SelectedIndex = res;
                }
                else
                {
                }
            }
            else
            {
                comboBoxSelectBytes.Focus();
            }
        }

        private void comboBoxSelectBytes_SelectedIndexChanged(object sender, EventArgs e)
        {
            procuraStringNaCombo();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InjectDllBP_Click(object sender, EventArgs e)
        {
            Injection injectForm = new Injection(this);

            injectForm.ShowDialog();
        }
    }
}
