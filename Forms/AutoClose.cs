using Microsoft.Azure.NotificationHubs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ProgramManage
{
    public partial class AutoClose : Form
    {
        private Thread thread;
        int activemataarvore = 0;
        string pathRoot;
        public class data
        {
            public string Name { get; set; }
            public string Code { get; set; }

        }

        public class dataconfig
        {
            public int Enable { get; set; }
        }
        public Boolean KillLog;
        public static int hourse = DateTime.Now.Hour;
        public static int minutese = DateTime.Now.Minute;
        public static int secondse = DateTime.Now.Second;

        public string hora = "" + DateTime.Now.ToString("HH:mm:ss") + "";

        public AutoClose()
        {
            InitializeComponent();

            string path = Directory.GetCurrentDirectory();
            pathRoot = Path.GetPathRoot(path);
            ListProcessFormu1.DoubleBuffering(true);


            ChangeInterval.DropDownStyle = ComboBoxStyle.DropDownList;
            ChangeInterval.SelectedIndex = ChangeInterval.Items.Count - 6;

            if (interval.Enabled == true)
            {
                buttonretorna.Visible = false;
                buttonpausa.Visible = true;
            }
            else
            {
                buttonpausa.Visible = false;
                buttonretorna.Visible = true;
            }
            loadConfigs();
        }
        public class JsonResult
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Endereco { get; set; }
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
        private void loadConfigs()
        {
            int configtrue = 0;
            try
            {
                try
                {
                    thread = new Thread(() =>
                    {
                        using (StreamReader r = new StreamReader(pathRoot + @"Program Files\Program Manage\config\list.json"))
                    {
                        string json = r.ReadToEnd();
                        List<data> items = JsonConvert.DeserializeObject<List<data>>(json);
                        dynamic array = JsonConvert.DeserializeObject(json);
                        foreach (var item in array)
                        {
                            configtrue = 1;
                            string md = MD5Hash("" + item.Name);
                            if (item.Code == md)
                            {
                                ListViewItem novoListViewItem = new ListViewItem();
                                novoListViewItem.Text = ("" + item.Name);

                                    try
                                    {
                                        this.Invoke(new Action(() =>
                                    {
                                        ListProcessFormu1.Items.Add(novoListViewItem);
                                    }));
                                    }
                                    catch { }
                                    if (item.Name != null)
                                {
                                    LBAction.Items.Add("[" + hora + "]: Importando: " + item.Name);
                                }
                            }
                            else
                            {
                                LBAction.Items.Add("[" + hora + "]: Arquivo não correspondente ");
                            }
                        }
                    }
                        using (StreamReader r = new StreamReader(pathRoot + @"Program Files\Program Manage\config\config.json"))
                        {
                            string json = r.ReadToEnd();
                            List<data> items = JsonConvert.DeserializeObject<List<data>>(json);
                            dynamic array = JsonConvert.DeserializeObject(json);
                            foreach (var item in array)
                            {
                                if (item.Enable == 1)
                                {
                                    interval.Enabled = false;
                                    buttonpausa.Visible = false;
                                    buttonretorna.Visible = true;
                                }
                                else if (item.Enable == 2)
                                {
                                    interval.Enabled = true;
                                    buttonretorna.Visible = false;
                                    buttonpausa.Visible = true;
                                }
                            }
                        }
                    });
                    thread.Start();
                }
                finally
                {
                    if (configtrue == 1)
                    {
                        LBAction.Items.Add("[" + hora + "]: Importação bem-sucedida!");
                        configtrue = 0;
                    }

                }
            }
            catch
            {
            }
        }
        private void AutoClose_Load(object sender, EventArgs e)
        {
            //=
        }

        private void ButtonAC_Click(object sender, EventArgs e)
        {
            SelectProcesse sp = new SelectProcesse(this);
            sp.ShowDialog();
        }

        private void openProgram_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Aplicações (*.exe*)|*.exe*";
            string ofdname = "";


            if (ofd.ShowDialog().Equals(DialogResult.OK))
            {
                ofdname = ofd.FileName;
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
                    int additem = 1;
                    if (additem == 1)
                    {
                        for (int i = 0; i < ListProcessFormu1.Items.Count; i++)
                        {
                            string pnc = Convert.ToString(ListProcessFormu1.Items[i].Text);

                            if (pnc == fileExtension)
                            {
                                additem = 0;
                            }

                            else
                            {
                                additem = 1;
                            }
                        }
                    }

                    if (additem == 1)
                    {
                        ListViewItem novoListViewItem = new ListViewItem();
                        novoListViewItem.Text = (fileExtension);

                        ListProcessFormu1.Items.Add(novoListViewItem);
                        try
                        {
                            LBAction.Items.Add("[" + hora + "]: " + fileExtension + " Adicionado a lista.");
                        }
                        catch { }
                    }
                    else
                    {
                        LBAction.Items.Add("[" + hora + "]: " + fileExtension + " já foi adicionado!");
                        additem = 2;
                    }
                }
            }
        }


        private void ListProcessFormu1_MouseUp(object sender, MouseEventArgs e)
        {

            if (ListProcessFormu1.SelectedItems.Count > 0)
            {
                string PN = ListProcessFormu1.SelectedItems[0].SubItems[0].Text;
                if (ListProcessFormu1.SelectedItems[0].SubItems[0].Text == PN)
                {
                    ListProcessFormu1.ContextMenuStrip = gerenciar;
                }
                else
                {
                    ListProcessFormu1.ContextMenuStrip = menu;
                }
            }
            else
            {
                ListProcessFormu1.ContextMenuStrip = menu;
            }
        }

        private void gerenciar_Opening(object sender, CancelEventArgs e)
        {

        }

        private void removerDaListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                LBAction.Items.Add("[" + hora + "]: " + ListProcessFormu1.SelectedItems[0].Text + " Removido da lista.");
            }
            catch { }
            ListProcessFormu1.SelectedItems[0].Remove();
        }
        private static void KillProcessAndChildren(int pid)
        {
            try
            {
                // Cannot close 'system idle process'.
                if (pid == 0)
                {
                    return;
                }
                ManagementObjectSearcher searcher = new ManagementObjectSearcher
                        ("Select * From Win32_Process Where ParentProcessID=" + pid);
                ManagementObjectCollection moc = searcher.Get();
                foreach (ManagementObject mo in moc)
                {
                    KillProcessAndChildren(Convert.ToInt32(mo["ProcessID"]));
                }
                try
                {
                    Task.Delay(300).ContinueWith(
                    t =>
                    {
                        Process proc = Process.GetProcessById(pid);
                        proc.Kill();
                    });
                }
                catch (ArgumentException)
                {
                    // Process already exited.
                }
            }
            catch { }
        }
        private void interval_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < ListProcessFormu1.Items.Count; i++)
            {
                var pnc = ListProcessFormu1.Items[i].Text;
                string pn = Convert.ToString(pnc);

                string processName = pn.Replace(".exe", "");
                try
                {
                    foreach (var process in Process.GetProcessesByName(processName))
                    {
                        try
                        {
                            try
                            {
                                try
                                {
                                    if(activemataarvore == 1)
                                    {
                                        KillProcessAndChildren(process.Id);
                                    }
                                    process.Kill();
                                }
                                finally
                                {
                                    LBAction.Items.Add("[" + hora + "]: " + processName + " Fechado com sucesso.");
                                }
                            }
                            catch { }

                            if (KillLog == true)
                            {

                            }
                            process.WaitForExit();

                        }
                        catch
                        {
                            LBAction.Items.Add("[" + hora + "]: " + processName + " Resultou em acesso negado. Tentando novamente...");
                        }
                    }
                }
                catch { }

            }
        }

        private void buttonretorna_Click(object sender, EventArgs e)
        {
            interval.Enabled = true;
            if (interval.Enabled == true)
            {
                buttonretorna.Visible = false;
                buttonpausa.Visible = true;
                try
                {
                    LBAction.Items.Add("[" + hora + "]: Processo reativado.");
                }
                catch { }
            }
        }

        private void buttonpausa_Click(object sender, EventArgs e)
        {
            interval.Enabled = false;
            if (interval.Enabled == false)
            {
                buttonpausa.Visible = false;
                buttonretorna.Visible = true;
                try
                {
                    LBAction.Items.Add("[" + hora + "]: Processo desativado.");
                }
                catch { }
            }
        }

        private void procuraStringNaCombo()
        {
            int changeToB = 0;
            int res = -1;

            if (ChangeInterval.Text != String.Empty)
            {
                // O método FindStringExact procura a primeira ocorrência na lista
                res = ChangeInterval.FindStringExact(ChangeInterval.Text);

                // FindStringExact retorna -1 se nada for encontrado
                if (res != -1)
                {
                    if (res == 0)
                    {
                        changeToB = 1;
                        try
                        {
                            LBAction.Items.Add("[" + hora + "]: Intervalo alterado para 1 nanosegundo.");
                        }
                        catch { }
                    }
                    else if (res == 1)
                    {
                        changeToB = 500;
                        try
                        {
                            LBAction.Items.Add("[" + hora + "]: Intervalo alterado para 500 milisegundos.");
                        }
                        catch { }
                    }
                    else if (res == 2)
                    {
                        changeToB = 1000;
                        try
                        {
                            LBAction.Items.Add("[" + hora + "]: Intervalo alterado para 1 segundo.");
                        }
                        catch { }
                    }
                    else if (res == 3)
                    {
                        changeToB = 5000;
                        try
                        {
                            LBAction.Items.Add("[" + hora + "]: Intervalo alterado para 5 segundos.");
                        }
                        catch { }
                    }
                    else if (res == 4)
                    {
                        changeToB = 10000;
                        try
                        {
                            LBAction.Items.Add("[" + hora + "]: Intervalo alterado para 10 segundos.");
                        }
                        catch { }
                    }
                    else if (res == 5)
                    {
                        changeToB = 50000;
                        try
                        {
                            LBAction.Items.Add("[" + hora + "]: Intervalo alterado para 50 segundos.");
                        }
                        catch { }
                    }
                    else if (res == 6)
                    {
                        changeToB = 60000;
                        try
                        {
                            LBAction.Items.Add("[" + hora + "]: Intervalo alterado para 1 minuto.");
                        }
                        catch { }
                    }
                    else if (res == 7)
                    {
                        changeToB = 300000;
                        try
                        {
                            LBAction.Items.Add("[" + hora + "]: Intervalo alterado para 5 minutos.");
                        }
                        catch { }
                    }
                    ChangeInterval.SelectedIndex = res;
                    interval.Interval = changeToB;
                }
                else
                {
                }
            }
            else
            {
                ChangeInterval.Focus();
            }
        }

        private void ChangeInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            procuraStringNaCombo();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            int hours = DateTime.Now.Hour;
            int minutes = DateTime.Now.Minute;
            int seconds = DateTime.Now.Second;
            hora = "" + DateTime.Now.ToString("HH:mm:ss") + "";
        }
        private void SaveConfigs_Click(object sender, EventArgs e)
        {
            int enables = 0;
            List<dataconfig> _dataconfig = new List<dataconfig>();
            List<data> _data = new List<data>();
            for (int i = 0; i < ListProcessFormu1.Items.Count; i++)
            {
                var pnc = ListProcessFormu1.Items[i].Text;
                string pn = Convert.ToString(pnc);
                string md = MD5Hash(pn);
                _data.Add(new data()
                {
                    Name = pn,
                    Code = md
                });
                if (buttonretorna.Visible == true)
                {
                    enables = 1;
                }
                else if (buttonpausa.Visible == true)
                {
                    enables = 2;
                }
                _dataconfig.Add(new dataconfig()
                {
                    Enable = enables
                });
            }

            string json = JsonConvert.SerializeObject(_data.ToArray());
            string jsone = JsonConvert.SerializeObject(_dataconfig.ToArray());

            //write string to file
            try
            {
                System.IO.File.WriteAllText(pathRoot + @"Program Files\Program Manage\config\list.json", json);
                System.IO.File.WriteAllText(pathRoot + @"Program Files\Program Manage\config\config.json", jsone);
            }
            finally
            {
                LBAction.Items.Add("[" + hora + "]: Configurações salvas com sucesso!");
            }
        }

        private void buttonloadp_Click(object sender, EventArgs e)
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
                                    string md = MD5Hash("" + iteme.Name);
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
                                    ListProcessFormu1.Items.Clear();
                                    configtruef = 0;
                                }
                            }


                                using (StreamReader r = new StreamReader(ofdname))
                            {
                                string json = r.ReadToEnd();
                                List<data> items = JsonConvert.DeserializeObject<List<data>>(json);
                                dynamic array = JsonConvert.DeserializeObject(json);
                                foreach (var item in array)
                                {
                                    configtrue = 1;
                                    string md = MD5Hash("" + item.Name);
                                    if (item.Code == md)
                                    {
                                        ListViewItem novoListViewItem = new ListViewItem();
                                        novoListViewItem.Text = ("" + item.Name);

                                        ListProcessFormu1.Items.Add(novoListViewItem);
                                        if (item.Name != null)
                                        {
                                            LBAction.Items.Add("[" + hora + "]: Importando: " + item.Name);
                                        }
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
                                        string md = MD5Hash("" + item.Name);
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
                                    LBAction.Items.Add("[" + hora + "]: Arquivo não correspondente ");
                                }

                                configtrue = 0;
                            }

                        }
                    }
                    catch
                    {
                    }
                }
            }
        }

        private void button1active_Click(object sender, EventArgs e)
        {
            if (activemataarvore == 1)
            {
                activemataarvore = 0;
                LBAction.Items.Add("[" + hora + "]: Matar arvore de processos desativado.");
            } 
            else if (activemataarvore == 0) 
            {
                activemataarvore = 1;
                LBAction.Items.Add("[" + hora + "]: Matar arvore de processos ativado.");
            }
        }
    }
}