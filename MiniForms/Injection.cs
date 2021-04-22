using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gh;

namespace ProgramManage
{
    public partial class Injection : Form
    {
        ConfigProcess instanciaDoForm1;
        public Injection(ConfigProcess cp)
        {
            InitializeComponent();
            instanciaDoForm1 = cp;
            this.ControlBox = false;
            labelname.Text = instanciaDoForm1.ProcessNameL.Text;
            labelid.Text = instanciaDoForm1.ConfigIdP.Text;
        }

        private void CloseThisForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Dll Files (.dll)|*.dll";
            string ofdname = "";


            if (ofd.ShowDialog().Equals(DialogResult.OK))
            {
                ofdname = ofd.FileName;
                FileInfo fileInfo = new FileInfo(ofdname);
                //Mostra o nome do arquivo
                string fileName = fileInfo.Name;
                //Mostra a extensão do arquivo
                string fileExtension = fileInfo.Extension;
                //Mostra o caminho completo do arquivo junto com o nome
                string fileFullName = fileInfo.FullName;

                if (ofdname == "")
                {
                    InjectDllButton.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    lineShape1.Visible = false;
                    lineShape2.Visible = false;
                }
                else
                {
                    lineShape1.Visible = true;
                    lineShape2.Visible = true;

                    InjectDllButton.Visible = true;
                    label1.Text = fileFullName;

                    label2.Visible = true;
                    label2.Text = "Dll: " + fileName;
                    label3.Visible = true;

                    string ProcesNme = labelname.Text;
                    label3.Text = "Alvo: " + ProcesNme;
                }
            }
        }

        private void InjectDllButton_Click(object sender, EventArgs e)
        {
            string ProcesNme = labelname.Text;
            string fileFullName = label1.Text;
            try
            {
                var injects = ghapi.InjectDLL(fileFullName, ProcesNme);

                if (injects)
                {
                    labelREsult.Visible = true;
                    labelREsult.ForeColor = Color.Lime;
                    labelREsult.Text = "Dll injetada com sucesso";
                }
                else
                {
                    labelREsult.Visible = true;
                    labelREsult.ForeColor = Color.Red;
                    labelREsult.Text = "Dll não injetada";
                }
             }
            catch
            {
                labelREsult.Visible = true;
                labelREsult.ForeColor = Color.Red;
                labelREsult.Text = "Falha ao injetar Dll";
            }
        }
    }
}
