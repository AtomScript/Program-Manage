using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Opera;
using System.Media;
using System.Threading;
using Newtonsoft.Json;
using System.Security.Cryptography;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Events;
using System.Diagnostics;
using System.Management;
using System.CodeDom.Compiler;
using Microsoft.CSharp;

namespace ProgramManage
{
    public partial class Selenium : Form
    {
        int existconsole = 2;
        private Thread threader;
        Thread thr;
        IWebDriver driverc;
        int timerr = 0;
        int timerpr = 0;
        int changeToB = 0;
        int typetextn = 0;
        int typebuttonn = 0;
        int attrelementtype = 0;
        int attrelementtypeb = 0;
        string pathRoot = "";
        public Selenium()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;

            string path = Directory.GetCurrentDirectory();
            pathRoot = Path.GetPathRoot(path);
            listView1.DoubleBuffering(true);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public class data
        {
            public string Type { get; set; }
            public string Attribute { get; set; }
            public string Value { get; set; }
            public string Element { get; set; }
            public string ElementAttribute { get; set; }
            public string Waitelementattribute { get; set; }
            public string ElementWait { get; set; }
            public string WaitType { get; set; }
            public string Code { get; set; }
        }
        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
        public static void WaitForElementLoad(By by, int timeoutInSeconds, IWebDriver driverce)
        {
            if (timeoutInSeconds > 0)
            {
                WebDriverWait wait = new WebDriverWait(driverce, TimeSpan.FromSeconds(timeoutInSeconds));
                wait.Until(ExpectedConditions.ElementIsVisible(by));
            }
        }

        private void brun_Click(object sender, EventArgs e)
        {
            try
            {
                string hora = "" + DateTime.Now.ToString("HH:mm:ss") + "";
                listBox1.Items.Add("[" + hora + "]: Iniciando...");
                cbtimer.Enabled = true;
            }
            catch
            {

            }
            string wb = tbwebsite.Text;
            string btnloopnumber = tbloop.Text;

            if (existconsole == 2)
            if (btnloopnumber != "0")
            {
                if (wb != string.Empty)
                {
                    if (btnloopnumber != string.Empty)
                    {
                        try
                        {
                            threader = new Thread(() =>
                            {
                                if (changeToB == 1)
                                {

                                    this.Invoke(new Action(() =>
                                    {
                                        driverc = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                                    }));
                                    driverc.Navigate().GoToUrl(wb);
                                    threader.Abort();

                                    restartElement();
                                }
                                else if (changeToB == 2)
                                {
                                    this.Invoke(new Action(() =>
                                    {
                                        driverc = new FirefoxDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                                    }));
                                    driverc.Navigate().GoToUrl(wb);
                                    threader.Abort();
                                    restartElement();
                                }
                                else if (changeToB == 4)
                                {
                                    this.Invoke(new Action(() =>
                                    {
                                        driverc = new OperaDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                                    }));
                                    driverc.Navigate().GoToUrl(wb);
                                    threader.Abort();
                                    restartElement();
                                }
                                else if (changeToB == 3)
                                {
                                    this.Invoke(new Action(() =>
                                    {
                                        driverc = new EdgeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                                    }));
                                    driverc.Navigate().GoToUrl(wb);
                                    threader.Abort();
                                    restartElement();
                                }
                            });
                            threader.Start();
                        }
                        catch
                        {
                            string hora = "" + DateTime.Now.ToString("HH:mm:ss") + "";
                            if (changeToB == 0)
                            {
                                listBox1.Items.Add("[" + hora + "]: Adicione o tipo de navegador para continuar!");
                            }
                            else
                            {
                            }
                        }
                    }
                    else
                    {
                        try
                        {
                            string hora = "" + DateTime.Now.ToString("HH:mm:ss") + "";
                            listBox1.Items.Add("[" + hora + "]: Numero de repetições não pode ficar em branco! Alterando numero para 1. Avançando com o processo...");
                            tbloop.Text = "1";
                            Thread.Sleep(2000);
                            brun.PerformClick();
                        }
                        catch { }
                    }
                }
                else
                {
                    try
                    {
                        string hora = "" + DateTime.Now.ToString("HH:mm:ss") + "";
                        listBox1.Items.Add("[" + hora + "]: Adicione uma url de um site para continuar!");
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
                    listBox1.Items.Add("[" + hora + "]: Numero de repetições não pode ser 0! Alterando numero para 1. Avançando com o processo...");
                    tbloop.Text = "1";
                    Thread.Sleep(2000);
                    brun.PerformClick();
                }
                catch
                {

                }
            }
        }

        private void procuraStringNaCombo()
        {
            int res = -1;

            if (comboBox1.Text != String.Empty)
            {
                // O método FindStringExact procura a primeira ocorrência na lista
                res = comboBox1.FindStringExact(comboBox1.Text);

                // FindStringExact retorna -1 se nada for encontrado
                if (res != -1)
                {
                    if (res == 0)
                    {
                        changeToB = 1;
                        try
                        {
                            string hora = "" + DateTime.Now.ToString("HH:mm:ss") + "";
                            listBox1.Items.Add("[" + hora + "]: Navegador Google Chrome selecionado");
                        }
                        catch
                        {

                        }
                    }
                    else if (res == 1)
                    {
                        changeToB = 2;
                        try
                        {
                            string hora = "" + DateTime.Now.ToString("HH:mm:ss") + "";
                            listBox1.Items.Add("[" + hora + "]: Navegador FireFox selecionado");
                        }
                        catch
                        {

                        }
                    }
                    else if (res == 2)
                    {
                        changeToB = 3;
                        try
                        {
                            string hora = "" + DateTime.Now.ToString("HH:mm:ss") + "";
                            listBox1.Items.Add("[" + hora + "]: Navegador Edge selecionado");
                        }
                        catch
                        {

                        }
                    }
                    else if (res == 3)
                    {
                        changeToB = 4;
                        try
                        {
                            string hora = "" + DateTime.Now.ToString("HH:mm:ss") + "";
                            listBox1.Items.Add("[" + hora + "]: Navegador Opera selecionado");
                        }
                        catch
                        {

                        }
                    }
                    comboBox1.SelectedIndex = res;
                }
                else
                {
                }
            }
            else
            {
                comboBox1.Focus();
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            procuraStringNaCombo();
        }

        private void additembutton_Click(object sender, EventArgs e)
        {
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].Remove();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menu_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void listView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string PN = listView1.SelectedItems[0].SubItems[0].Text;
                if (PN == "text") 
                {
                    if (listView1.SelectedItems[0].SubItems[0].Text == PN)
                    {
                        listView1.ContextMenuStrip = gerenciar;

                    }
                    else
                    {
                        listView1.ContextMenuStrip = menu;
                    }
                }
                else if (PN == "button")
                {
                    if (listView1.SelectedItems[0].SubItems[0].Text == PN)
                    {
                        listView1.ContextMenuStrip = gerencia;

                    }
                    else
                    {
                        listView1.ContextMenuStrip = menu;
                    }
                }
                else if (PN == "replace")
                {
                    if (listView1.SelectedItems[0].SubItems[0].Text == PN)
                    {
                        listView1.ContextMenuStrip = gerenciarr;

                    }
                    else
                    {
                        listView1.ContextMenuStrip = menu;
                    }
                }
                else if (PN == "clear")
                {
                    if (listView1.SelectedItems[0].SubItems[0].Text == PN)
                    {
                        listView1.ContextMenuStrip = gerencia;

                    }
                    else
                    {
                        listView1.ContextMenuStrip = menu;
                    }
                }
                else if (PN == "wait")
                {
                    if (listView1.SelectedItems[0].SubItems[0].Text == PN)
                    {
                        listView1.ContextMenuStrip = gerencia;

                    }
                    else
                    {
                        listView1.ContextMenuStrip = menu;
                    }
                }
            }
            else
            {
                listView1.ContextMenuStrip = menu;
            }
        }

        private void removerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].Remove();
        }

        private void alterarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Changelv fclv = new Changelv(this);
            fclv.ShowDialog();
        }

        private void removerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].Remove();
        }

        private void alterarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Changelvb fclvb = new Changelvb(this);
            fclvb.ShowDialog();
        }

        private void listView1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                int currentIndex = listView1.SelectedItems[0].Index;
                ListViewItem item = listView1.Items[currentIndex];
                if (currentIndex > 0)
                {
                    listView1.Items.RemoveAt(currentIndex);
                    listView1.Items.Insert(currentIndex - 1, item);
                }
                else
                {
                    /*If the item is the top item make it the last*/
                    listView1.Items.RemoveAt(currentIndex);
                    listView1.Items.Insert(listView1.Items.Count, item);
                }
            }
            catch
            {
                SystemSounds.Beep.Play();
            }
        }
        private void listView1_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void btnnewwait_Click(object sender, EventArgs e)
        {
            newwaitlv nwt = new newwaitlv(this);
            nwt.ShowDialog();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbwebsite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)System.Windows.Forms.Keys.Space)
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
            else
            {
                if (!(char.IsDigit(e.KeyChar) || Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == (char)System.Windows.Forms.Keys.Space))
                { e.Handled = true; SystemSounds.Beep.Play(); }
            }
        }

        private void tbelementb_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnload_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.Filter = "Arquivos json (*.json*)|*.json*";
            string ofdname;

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {

                ofdname = openFileDialog2.FileName;
                FileInfo fileInfo = new FileInfo(ofdname);
                //Mostra o nome do arquivo
                string fileFullName = fileInfo.FullName;
                string fileName = fileInfo.Name;
                //Mostra a extensão do arquivo
                var fileExtension1 = Path.GetFileName(fileFullName);
                string fileExtension = Convert.ToString(fileExtension1);
                //Mostra o caminho completo do arquivo junto com o nome
                if (ofdname == null)
                {
                }
                else
                {
                    int configtrue = 0;
                    try
                    {
                        try
                        {
                            int configtruef = 0;
                            using (StreamReader er = new StreamReader(ofdname))
                            {
                                string jsone = er.ReadToEnd();
                                List<data> itemse = JsonConvert.DeserializeObject<List<data>>(jsone);
                                dynamic arrays = JsonConvert.DeserializeObject(jsone);
                                foreach (var iteme in arrays)
                                {
                                    string md = MD5Hash("" + iteme.Attribute);
                                    if (iteme.Code == md)
                                    {
                                        configtruef = 1;
                                    }
                                    else
                                    {
                                    }
                                }
                                if (configtruef == 1)
                                {
                                    listView1.Items.Clear();
                                    configtruef = 0;
                                }
                            }

                            using (StreamReader r = new StreamReader(ofdname))
                            {
                                string json = r.ReadToEnd();
                                List<data> items = JsonConvert.DeserializeObject<List<data>>(json);
                                dynamic array = JsonConvert.DeserializeObject(json);
                                try
                                {
                                    string hora = "" + DateTime.Now.ToString("HH:mm:ss") + "";
                                    listBox1.Items.Add("[" + hora + "]: Elementos importados com sucesso!");
                                }
                                catch { }

                                foreach (var item in array)
                                {
                                    configtrue = 1;
                                    string md = MD5Hash("" + item.Attribute);
                                    if (item.Code == md)
                                    {
                                        ListViewItem novoListViewItem = new ListViewItem();
                                         novoListViewItem.Text = ("" + item.Type);
                                        novoListViewItem.SubItems.Add("" + item.Attribute);
                                        novoListViewItem.SubItems.Add("" + item.Value);
                                        novoListViewItem.SubItems.Add("" + item.Element);
                                        novoListViewItem.SubItems.Add("" + item.ElementAttribute);
                                        novoListViewItem.SubItems.Add("" + item.Waitelementattribute);
                                        novoListViewItem.SubItems.Add("" + item.ElementWait);
                                        novoListViewItem.SubItems.Add("" + item.WaitType);
                                        novoListViewItem.SubItems.Add("" + item.Code);

                                        listView1.Items.Add(novoListViewItem);
                                    }
                                    else
                                    {
                                    }
                                }
                            }
                        }
                        finally
                        {
                            if (configtrue == 1)
                            {
                                int configtruee = 0;
                                using (StreamReader r = new StreamReader(ofdname))
                                {
                                    string json = r.ReadToEnd();
                                    List<data> items = JsonConvert.DeserializeObject<List<data>>(json);
                                    dynamic array = JsonConvert.DeserializeObject(json);
                                    foreach (var item in array)
                                    {
                                        string md = MD5Hash("" + item.Attribute);
                                        if (item.Code == md)
                                        {
                                        }
                                        else
                                        {
                                            configtruee = 1;
                                        }
                                    }
                                }
                                if (configtruee == 1)
                                {
                                    string hora = "" + DateTime.Now.ToString("HH:mm:ss") + "";
                                    listBox1.Items.Add("[" + hora + "]: Elemento não correspondente.");
                                }

                                configtrue = 0;
                            }

                        }
                    }
                    catch { }
                }
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            List<data> _data = new List<data>();
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                string pnc = "";
                string pnc2 = "";
                string pnc3 = "";
                string pnc4 = "";
                string pnc5 = "";
                string pnc6 = "";
                string pnc7 = "";

                try
                {
                    pnc = listView1.Items[i].SubItems[0].Text;
                }
                catch { }
                var pnc1 = listView1.Items[i].SubItems[1].Text;
                try
                {
                    pnc2 = listView1.Items[i].SubItems[2].Text;
                }
                catch { }
                try
                {
                    pnc3 = listView1.Items[i].SubItems[3].Text;
                }
                catch { }
                try
                {
                    pnc4 = listView1.Items[i].SubItems[4].Text;
                }
                catch { }
                try
                {
                    pnc5 = listView1.Items[i].SubItems[5].Text;
                }
                catch { }
                try {
                pnc6 = listView1.Items[i].SubItems[6].Text;
                }
                catch { }
                try {                
                    pnc7 = listView1.Items[i].SubItems[7].Text;
                }
                catch { }
                string pn = Convert.ToString(pnc1);
                string md = MD5Hash(pn);
                _data.Add(new data()
                {
                    Type = pnc,
                    Attribute = pnc1,
                    Value = pnc2,
                    Element = pnc3,
                    ElementAttribute = pnc4,
                    Waitelementattribute = pnc5,
                    ElementWait = pnc6,
                    WaitType = pnc7,
                    Code = md
                });
            }

            string json = JsonConvert.SerializeObject(_data.ToArray());

            //write string to file
            try
            {
                System.IO.File.WriteAllText(pathRoot + @"Program Files\Program Manage\logs\Selenium.json", json);
            }
            finally
            {
                string hora = "" + DateTime.Now.ToString("HH:mm:ss") + "";
                listBox1.Items.Add("[" + hora + "]: Elementos salvos com sucesso em "+pathRoot+@"Program Files\Program Manage\logs\Selenium.json");
            }
        }

        private void openaddinput_Click(object sender, EventArgs e)
        {
            AddInputlv ad = new AddInputlv(this);
            ad.ShowDialog();
        }

        private void btnopenclicklv_Click(object sender, EventArgs e)
        {
            AddClicklv ad = new AddClicklv(this);
            ad.ShowDialog();
        }

        private void btnopenclearlv_Click(object sender, EventArgs e)
        {
            AddClearlv ad = new AddClearlv(this);
            ad.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddReplacelv ad = new AddReplacelv(this);
            ad.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].Remove();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ChangeReplacelv ad = new ChangeReplacelv(this);
            ad.ShowDialog();
        }

        private void cbtimer_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtimer.Checked)
            {
                timer1.Enabled = false;
                timerpr = 1;
                btnpausa.Enabled = true;
                btnretorna.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
                timerpr = 0;
                btnpausa.Enabled = false;
                btnretorna.Enabled = false;
            }
        }
        int lmsg = 3;

        private void btnretorna_Click(object sender, EventArgs e)
        {
            if (btnretorna.Visible == true)
            {
                timer1.Enabled = true;
                lmsg = 1;
                btnretorna.Visible = false;
                btnretorna.Enabled = false;
                btnpausa.Visible = true;
                btnpausa.Enabled = true;
                timer1.Interval = 1000;
                try
                {
                    string hora = "" + DateTime.Now.ToString("HH:mm:ss") + "";
                    listBox1.Items.Add("[" + hora + "]: Timer ativado");
                }
                catch { }
            }
            else
            {
                btnretorna.Visible = true;
                btnretorna.Enabled = true;
                btnpausa.Visible = false;
                btnpausa.Enabled = false;
            }
        }

        private void btnpausa_Click(object sender, EventArgs e)
        {
            if (btnpausa.Visible == true)
            {
                timer1.Enabled = false;
                lmsg = 2;
                try
                {
                        string hora = "" + DateTime.Now.ToString("HH:mm:ss") + "";
                        listBox1.Items.Add("[" + hora + "]: Timer desativado");
                        lmsg = 0;
                }
                catch { }
                timer1.Interval = 1000;
                btnretorna.Visible = true;
                btnretorna.Enabled = true;
                btnpausa.Visible = false;
                btnpausa.Enabled = false;
            }
            else
            {
                btnretorna.Visible = false;
                btnretorna.Enabled = false;
                btnpausa.Visible = true;
                btnpausa.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int latestinterval = timer1.Interval;
            try
            {
                int inter = Convert.ToInt32(tbinterval.Text + "000");
                    if (latestinterval != inter)
                {
                    latestinterval = inter;
                    timer1.Interval = inter;
                    try
                    {
                        string hora = "" + DateTime.Now.ToString("HH:mm:ss") + "";
                        if(inter <= 1)
                            listBox1.Items.Add("[" + hora + "]: Intervalo alterado para " + inter + "segundo");
                        else
                            listBox1.Items.Add("[" + hora + "]: Intervalo alterado para " + inter + "segundos");
                    }
                    catch { }
                }
            }
            catch { }

            try
            {
                Process[] proc = Process.GetProcessesByName("chromedriver");

                if (proc == null)
                {
                    existconsole = 2;
                }
                else
                {
                    existconsole = 0;
                }

                threader = new Thread(() =>
                {
                    foreach (var pr in proc)
                    {
                        pr.Kill();
                        existconsole = 0;
                    }
                });
            }
            catch
            {
                existconsole = 2;
            }

            try
            {
                if(existconsole == 2)
                restartElement();
            }
            catch
            {
            }
        }


        public void restartElement()
        {
            try
            {
                for (int i = 0; 0 < listView1.Items.Count; i++)
                {
                    try
                    {
                        string attrtypelement = "";
                        string replacetexter = "";
                        string lelement = "";
                        string lvalue = "";
                        string lid = "";
                        string ltype = listView1.Items[i].SubItems[0].Text;
                            if (listView1.Items[i].SubItems[1].Text != string.Empty)
                            {
                                lid = listView1.Items[i].SubItems[1].Text;
                            }
                            if (listView1.Items[i].SubItems[2].Text != string.Empty)
                            {
                                lvalue = listView1.Items[i].SubItems[2].Text;
                            }
                            if (listView1.Items[i].SubItems[3].Text != string.Empty)
                            {
                                lelement = listView1.Items[i].SubItems[3].Text;
                            }
                            if (listView1.Items[i].SubItems[4].Text != string.Empty)
                            {
                                attrtypelement = listView1.Items[i].SubItems[4].Text;
                            }
                            if (listView1.Items[i].SubItems[5].Text != string.Empty)
                            {
                                replacetexter = listView1.Items[i].SubItems[5].Text;
                            }

                        int tblt = Convert.ToInt32(tbloop.Text);

                        for (int ff = 0; ff < tblt; ff++)
                        {
                            if (ltype == "text")
                            {
                                try
                                {
                                    IWebElement id = driverc.FindElement(By.XPath("//" + lelement + "[@" + attrtypelement + "='" + lid + "']")); Thread.Sleep(30);
                                    id.SendKeys(lvalue); Thread.Sleep(30);

                                    string hora = "" + DateTime.Now.ToString("HH:mm:ss") + "";
                                    listBox1.Items.Add("[" + hora + "]: Texto digitado com sucesso.");
                                }
                                catch
                                {
                                    string hora = "" + DateTime.Now.ToString("HH:mm:ss") + "";
                                    listBox1.Items.Add("[" + hora + "]: Falha ao alterar valor do elemento.");
                                }
                            }
                            else if (ltype == "button")
                            {
                                try
                                {
                                    IWebElement id = driverc.FindElement(By.XPath("//" + lelement + "[@" + attrtypelement + "='" + lid + "']")); Thread.Sleep(30);
                                    if (lvalue != "click")
                                    {
                                        id.Submit();
                                        id.SendKeys(lvalue); Thread.Sleep(30);
                                    }
                                    else
                                    {
                                        id.Click(); Thread.Sleep(30);
                                    }

                                    string hora = "" + DateTime.Now.ToString("HH:mm:ss") + "";
                                    listBox1.Items.Add("[" + hora + "]: Click simulado com sucesso.");
                                }
                                catch
                                {
                                    string hora = "" + DateTime.Now.ToString("HH:mm:ss") + "";
                                    listBox1.Items.Add("[" + hora + "]: Falha ao simular click do elemento.");
                                }
                            }
                            else if (ltype == "clear")
                            {
                                try
                                {

                                    IWebElement id = driverc.FindElement(By.XPath("//" + lelement + "[@" + attrtypelement + "='" + lid + "']")); Thread.Sleep(30);
                                    id.Clear(); Thread.Sleep(30);


                                    string hora = "" + DateTime.Now.ToString("HH:mm:ss") + "";
                                    listBox1.Items.Add("[" + hora + "]: Campo apagado com sucesso.");
                                }
                                catch
                                {
                                    string hora = "" + DateTime.Now.ToString("HH:mm:ss") + "";
                                    listBox1.Items.Add("[" + hora + "]: Falha ao simular apagar campo do elemento.");
                                }
                            }
                            else if (ltype == "replace")
                            {
                                try
                                {
                                    IWebElement id = driverc.FindElement(By.XPath("//" + lelement + "[@" + attrtypelement + "='" + lid + "']")); Thread.Sleep(30);
                                    id.Text.Replace(replacetexter, lvalue); Thread.Sleep(30);


                                    string hora = "" + DateTime.Now.ToString("HH:mm:ss") + "";
                                    listBox1.Items.Add("[" + hora + "]: Valor do campo alterado com sucesso.");
                                }
                                catch
                                {
                                    string hora = "" + DateTime.Now.ToString("HH:mm:ss") + "";
                                    listBox1.Items.Add("[" + hora + "]: Falha ao alterar valor do campo.");
                                }
                            }
                            else if (ltype == "wait")
                            {
                                try
                                {
                                    WaitForElementLoad(By.XPath("//" + lelement + "[@" + attrtypelement + "='" + lid + "']"), 2, driverc); Thread.Sleep(30);

                                    string hora = "" + DateTime.Now.ToString("HH:mm:ss") + "";
                                    listBox1.Items.Add("[" + hora + "]: Elemento encontrado com sucesso.");
                                }
                                catch
                                {
                                    string hora = "" + DateTime.Now.ToString("HH:mm:ss") + "";
                                    listBox1.Items.Add("[" + hora + "]: Falha aguardar o elemento.");
                                }
                            }
                            else if (ltype == "custom")
                            {
                                try
                                {
                                    this.Invoke(new Action(() =>
                                    {
                                        IWebElement id = driverc.FindElement(By.XPath("" + lid + "")); Thread.Sleep(50);
                                        id.Submit(); Thread.Sleep(30);
                                    }));
                                }
                                catch
                                {
                                    string hora = "" + DateTime.Now.ToString("HH:mm:ss") + "";
                                    listBox1.Items.Add("[" + hora + "]: Falha rodar o elemento customizado.");
                                }
                            }
                        }
                    }
                    finally
                    {

                    }
                }
            }
            catch (Exception err)
            {
                string hora = "" + DateTime.Now.ToString("HH:mm:ss") + "";
                //timer1.Enabled = false;
                //timerpr = 0;
               // btnpausa.Enabled = false;
                //btnretorna.Enabled = false;
                //MessageBox.Show("" + err);

            }
        }
        private void KillProcessAndChildren(int pid)
        {
            try
            {
                // Cannot close 'system idle process'.
                if (pid == 0)
                {
                    return;
                }
                ManagementObjectSearcher searcher = new ManagementObjectSearcher
                        ("Select * From Win32_Process Where ParentProcessID=" + pid + "Name = 'notepad.exe'");
                ManagementObjectCollection moc = searcher.Get();
                foreach (ManagementObject mo in moc)
                {
                    KillProcessAndChildren(Convert.ToInt32(mo["ProcessID"]));
                }
                try
                {
                    Process proc = Process.GetProcessById(pid);
                    if(proc != null)
                    {
                        existconsole = 1;
                    }
                }
                catch
                {
                }
            }
            catch { }
        }

        private void btnRestartL_Click(object sender, EventArgs e)
        {
            try
            {
                Process[] proc = Process.GetProcessesByName("chromedriver");


                threader = new Thread(() =>
                {
                    foreach (var pr in proc)
                    {
                if (pr == null)
                {
                    existconsole = 2;
                }
                else
                {
                    existconsole = 0;
                }
                        pr.Kill();
                        existconsole = 0;
                    }
                });
            }
            catch
            {
                existconsole = 2;
            }
            try
            {
                if(existconsole == 0)
                restartElement();
            }
            catch { }
        }

        private void btnaddcustomlv_Click(object sender, EventArgs e)
        {
            AddCustomlv ad = new AddCustomlv(this);
            ad.ShowDialog();
        }

        private void comboBox1_MouseEnter(object sender, EventArgs e)
        {
            if (comboBox1 != null)
            {
                this.toolTip1.Show("Seleciona o navegador para automatizar", comboBox1);
            }
        }

        private void comboBox1_MouseLeave(object sender, EventArgs e)
        {
            if (comboBox1 != null)
            {
                this.toolTip1.Hide(comboBox1);
            }
        }

        private void brun_Leave(object sender, EventArgs e)
        {

        }

        private void brun_MouseEnter(object sender, EventArgs e)
        {
            if (brun != null)
            {
                this.toolTip1.Show("Iniciar automatização", brun);
            }
        }

        private void brun_MouseLeave(object sender, EventArgs e)
        {
            if (brun != null)
            {
                this.toolTip1.Hide(brun);
            }
        }

        private void btnRestartL_MouseEnter(object sender, EventArgs e)
        {
            if (btnRestartL != null)
            {
                this.toolTip1.Show("Recomeça a rodar os novos/antigos elementos", btnRestartL);
            }
        }

        private void btnRestartL_MouseLeave(object sender, EventArgs e)
        {
            if (btnRestartL != null)
            {
                this.toolTip1.Hide(btnRestartL);
            }
        }

        private void tbwebsite_MouseEnter(object sender, EventArgs e)
        {
            if (tbwebsite != null)
            {
                this.toolTip1.Show("Site nescessario para ser automatizado", tbwebsite);
            }
        }

        private void tbwebsite_MouseLeave(object sender, EventArgs e)
        {
            if (tbwebsite != null)
            {
                this.toolTip1.Hide(tbwebsite);
            }
        }
    }
}
