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
    public partial class AddCustomlv : Form
    {
        Selenium se;
        public AddCustomlv(Selenium ser)
        {
            InitializeComponent();
            se = ser;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnAddCustom_Click(object sender, EventArgs f)
        {
            if (tbelement.Text != string.Empty)
            {
                if (tbfunction.Text != string.Empty)
                {
                    string[] row = {
                "custom",
                tbelement.Text,
                tbfunction.Text,
                "null",
                "null",
                "null",
                "null",
                "null"
                 };
                    ListViewItem item = new ListViewItem(row);

                    se.listView1.Items.Add(item);

                    tbelement.Text = string.Empty;
                    tbfunction.Text = string.Empty;
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
                        se.listBox1.Items.Add("[" + hora + "]: A função não pode ficar em branco!");
                    }
                    catch
                    {

                    }
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

        private void tbnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code = "";
            string texto = tbelement.Text;
            string toBeSearched = "=";

            //Validar se contém "criativo"
            if (texto.Contains("criativo")) {}

            //Validar se começa com "criativo"
            if (texto.StartsWith("<"))
            {
                if (texto.EndsWith(">"))
                {

                    //Validar se termina com "criativo"

                    int ix = texto.IndexOf(toBeSearched);

                    if (ix != -1)
                    {
                        code = texto.Substring(ix + toBeSearched.Length);
                        // do something here
                    }


                    var palavras = texto.Split('<');
                    var palavra = palavras[1].Replace(">", ""); //e

                    string pr1 = Convert.ToString(palavra);
                    var pr2 = pr1.Split('=');
                    var inicioPalavra = pr1.IndexOf(' ', pr1.IndexOf('=') + 1);
                    string pr3 = Convert.ToString(inicioPalavra);


                    MessageBox.Show("elemento: " + palavra + ". atributos: " + code);
                }
            }
        }
    }
}
