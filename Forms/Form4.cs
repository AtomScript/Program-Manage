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
using System.IO;
using System.Reflection;

namespace ProgramManage
{
    public partial class Form4 : Form
    {
        Form1 instanciaDoForm1;
        public string pidpe;

        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }
        int resultpcb;
        Botoes btn = new Botoes();
        public Form4(Form1 frm1)
        {
            InitializeComponent();
            carregarbotao();
            this.ControlBox = false;
            this.Text = "";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            instanciaDoForm1 = frm1;
            string ProcessName = instanciaDoForm1.ListProcessFormu1.SelectedItems[0].SubItems[0].Text;
            string Processidp = instanciaDoForm1.ListProcessFormu1.SelectedItems[0].SubItems[1].Text;
            NomeDoProcesso.Text = ProcessName;
            labelProc.Text = Processidp;
            this.pidpe = Processidp;



            try
            {
                string ProcessIdp = labelProc.Text;
                int ProcessIdps = Convert.ToInt32(ProcessIdp);
                Process p = Process.GetProcessById(ProcessIdps);
                labelSessionId.Text = "" + p.SessionId;
                int levelidp = p.SessionId;

                if (levelidp == 0)
                {
                    MessageBox.Show("Esse processo esta ligado com sistema operacional! Caso faça alguma alteração neste processo, seu computador estara correndo riscos!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                labelSessionId.Text = "Falha";
            }

            GetProcessDate();
            badressprocess();



            PCB.DropDownStyle = ComboBoxStyle.DropDownList;
            PCB.SelectedIndex = PCB.Items.Count - 2;

            string RespondingP = "Processando...";
            ProcessLocal.Text = RespondingP;
            TimerStartedP.Text = RespondingP;
            MemorySizeP.Text = RespondingP;
            ProcessNameLabel.Text = RespondingP;
            labelStatusIdS.Text = RespondingP;
            CpuUsageP.Text = RespondingP;
            labelREsponding.Text = RespondingP;

        }
        private FlowLayoutPanel flowLayoutPanel1;
        public void carregarbotao()
        {
        }
        public void GetProcessDate()
        {
            string ProcessName1 = instanciaDoForm1.ListProcessFormu1.SelectedItems[0].SubItems[0].Text;
            NomeDoProcesso.Text = ProcessName1;
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            try
            {

                string potenciae = "0";
                string potenciaee = "0";
                try
                {
                    potenciae = labelProc.Text;
                    potenciaee = NomeDoProcesso.Text;
                }
                catch { }

                if (instanciaDoForm1.itemremovedid == potenciae)
                {
                    if (instanciaDoForm1.panelContainer.Controls.Count > 0)
                    {
                        instanciaDoForm1.panelContainer.Controls.RemoveAt(0);
                        inicio fh1 = new inicio();
                        fh1.TopLevel = false;
                        fh1.Dock = DockStyle.Fill;
                        instanciaDoForm1.panelContainer.Controls.Add(fh1);
                        instanciaDoForm1.panelContainer.Tag = fh1;
                        fh1.Show();
                        instanciaDoForm1.itemremovedid = "0";
                    }
                }
            }
            catch { }
            try
            {
                labelStatusIdS.Visible = false;
                labelREsponding.Visible = false;
                Temporizador.Enabled = true;
                string ProcessIdp = labelProc.Text;
                int ProcessIdps = Convert.ToInt32(ProcessIdp);
                string wmiQueryString = "SELECT ProcessId, ExecutablePath FROM Win32_Process WHERE ProcessId = " + ProcessIdps;
                using (var searcher = new ManagementObjectSearcher(wmiQueryString))
                {
                    using (ManagementObjectCollection results = searcher.Get())
                    {
                        foreach (ManagementObject mo in results)
                        {
                            try
                            {
                                ProcessLocal.Text = "" + mo["ExecutablePath"];
                                if (ProcessLocal.Text != "")
                                {
                                    GoToPath.Visible = true;
                                }
                                else if (ProcessLocal.Text == "")
                                {
                                    GoToPath.Visible = false;
                                    label9.Text = "Vazio";
                                }
                                else if (ProcessLocal.Text == " ")
                                {
                                    GoToPath.Visible = false;
                                    label9.Text = "Vazio";
                                }
                            }
                            catch
                            {
                                ProcessLocal.Text = "Falha";
                            }

                            try
                            {
                                System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
                                System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo("" + mo["ExecutablePath"] + "");
                                string versionp = fvi.ProductName;
                                ProcessNameLabel.Text = "" + versionp;
                            }
                            catch
                            {
                                ProcessNameLabel.Text = "Falha";
                            }
                        }
                    }
                }
                Process p = Process.GetProcessById(ProcessIdps);
                try
                {
                    int memsize = 0;
                    memsize = Convert.ToInt32(p.PagedMemorySize64) / (int)(1024);
                    if (memsize < 1024)
                    {
                        MemoriaSizeP.Text = "" + memsize + " KB";
                    }
                    else
                    {
                        memsize = Convert.ToInt32(p.PagedMemorySize64) / (int)(1024 * 1024);
                        MemoriaSizeP.Text = "" + memsize + " MB";

                    }
                }
                catch
                {
                    MemoriaSizeP.Text = "Falha";
                }


                try
                {
                    GetCpuUsageForProcess();

                    async Task<double> GetCpuUsageForProcess()
                    {
                        var startTime = DateTime.UtcNow;
                        var startCpuUsage = p.TotalProcessorTime;
                        await Task.Delay(500);

                        var endTime = DateTime.UtcNow;
                        var endCpuUsage = p.TotalProcessorTime;
                        var cpuUsedMs = (endCpuUsage - startCpuUsage).TotalMilliseconds;
                        var totalMsPassed = (endTime - startTime).TotalMilliseconds;
                        var cpuUsageTotal = cpuUsedMs / (Environment.ProcessorCount * totalMsPassed);
                        CpuUsageP.Text = "" + cpuUsageTotal + "%";
                        if (BuWriteProcessInfo.Visible == false)
                        {
                            BuWriteProcessInfo.Visible = true;
                        }
                        return cpuUsageTotal * 100;
                    }
                }

                catch
                {
                    CpuUsageP.Text = "Falha";
                }


                try
                {
                    TimerStartedP.Text = "" + p.StartTime;
                }
                catch
                {
                    TimerStartedP.Text = "Falha";
                }


                try
                {
                    if (p.Responding.ToString() == "True")
                    {
                        MemorySizeP.Text = "Em execução";
                    }
                    else if (p.Responding.ToString() == "False")
                    {
                        MemorySizeP.Text = "Parado";
                    }
                }
                catch
                {
                    MemorySizeP.Text = "Falha";
                }




                try
                {
                    IconProcess.Image = Icon.ExtractAssociatedIcon(p.MainModule.FileName).ToBitmap();
                }
                catch
                {

                }


            }
            catch
            {
                if (BuWriteProcessInfo.Visible == true)
                {
                    BuWriteProcessInfo.Visible = false;
                }
                if (Temporizador.Enabled != false)
                {
                    Temporizador.Enabled = false;
                    if (Temporizador.Enabled == false)
                    {
                        MessageBox.Show("Houve uma falha ao analisar o processo." + "\n" + "Motivo: Processo não encontrado", "Alerta");

                        labelStatusIdS.Visible = true;
                        string RespondingP = "Falha";
                        ProcessLocal.Text = RespondingP;
                        TimerStartedP.Text = RespondingP;
                        MemorySizeP.Text = RespondingP;
                        ProcessNameLabel.Text = RespondingP;
                        labelStatusIdS.Text = RespondingP;
                        string ProcessName = NomeDoProcesso.Text;

                        for (int i = 0; i < instanciaDoForm1.ListProcessFormu1.Items.Count; i++)
                        {
                            if (instanciaDoForm1.ListProcessFormu1.Items[i].Text.Equals(ProcessName))
                            {
                                instanciaDoForm1.ListProcessFormu1.Items[i].Remove();
                            }
                        }
                        inicio();
                        this.Close();
                    }
                }
            }
        }
        private void badressprocess()
        {

        }

    private void GoToLocal_Click(object sender, EventArgs e)
        {
            try
            {
                string ProcessIdp = labelProc.Text;
                int ProcessIdps = Convert.ToInt32(ProcessIdp);
                string wmiQueryString = "SELECT ProcessId, ExecutablePath FROM Win32_Process WHERE ProcessId = " + ProcessIdps;
                using (var searcher = new ManagementObjectSearcher(wmiQueryString))
                {
                    using (ManagementObjectCollection results = searcher.Get())
                    {
                        foreach (ManagementObject mo in results)
                        {
                            var path = mo["ExecutablePath"];
                            string source = Convert.ToString(path);
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void KillProcessButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Quer realmente fechar o processo em execução? Sim/Não", "Fechar processo", MessageBoxButtons.OKCancel);
            switch (result)
            {
                case DialogResult.OK:

                    try
                    {
                        Temporizador.Enabled = false;
                        string ProcessIdp = labelProc.Text;
                        int ProcessIdps = Convert.ToInt32(ProcessIdp);
                        Process p = Process.GetProcessById(ProcessIdps);
                        p.Kill();
                        p.WaitForExit();

                        string ProcessName = NomeDoProcesso.Text;
                        for (int i = 0; i < instanciaDoForm1.ListProcessFormu1.Items.Count; i++)
                        {
                            if (instanciaDoForm1.ListProcessFormu1.Items[i].Text.Equals(ProcessName))
                            {
                                instanciaDoForm1.ListProcessFormu1.Items[i].Remove();
                            }
                        }
                        inicio();
                    }
                    catch
                    {
                        MessageBox.Show("Falha ao fechar o processo", "Falha");
                    }
                    break;
                case DialogResult.Cancel:

                    break;
            }
        }

        private void PShowFormConfig_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<ConfigProcess>().Count() > 0)
            {
                MessageBox.Show("Esta ferramenta esta aberta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ConfigProcess ConfigProcess1 = new ConfigProcess(this);
                ConfigProcess1.Show();
            }

        }
        private void inicio()
        {
            if (instanciaDoForm1.panelContainer.Controls.Count > 0)
                instanciaDoForm1.panelContainer.Controls.RemoveAt(0);
            inicio fh1 = new inicio();
            fh1.TopLevel = false;
            fh1.Dock = DockStyle.Fill;
            instanciaDoForm1.panelContainer.Controls.Add(fh1);
            instanciaDoForm1.panelContainer.Tag = fh1;
            fh1.Show();
        }
        public string FormataExibicaoTamanhoArquivo(long i)
        {
            // Obtém o valor absoluto
            long i_absoluto = (i < 0 ? -i : i);
            // Determina o sufixo e o valor
            string sufixo;
            double leitura;
            if (i_absoluto >= 0x1000000000000000) // Exabyte
            {
                sufixo = "EB";
                leitura = (i >> 50);
            }
            else if (i_absoluto >= 0x4000000000000) // Petabyte
            {
                sufixo = "PB";
                leitura = (i >> 40);
            }
            else if (i_absoluto >= 0x10000000000) // Terabyte
            {
                sufixo = "TB";
                leitura = (i >> 30);
            }
            else if (i_absoluto >= 0x40000000) // Gigabyte
            {
                sufixo = "GB";
                leitura = (i >> 20);
            }
            else if (i_absoluto >= 0x100000) // Megabyte
            {
                sufixo = "MB";
                leitura = (i >> 10);
            }
            else if (i_absoluto >= 0x400) // Kilobyte
            {
                sufixo = "KB";
                leitura = i;
            }
            else
            {
                return i.ToString("0 bytes"); // Byte
            }
            // Divide por 1024 para obter o valor fracionário
            leitura = (leitura / 1024);
            // retorna o número formatado com sufixo
            return leitura.ToString("0.### ") + sufixo;
        }

        private void GoToPath_Click(object sender, EventArgs e)
        {
            string ProcessIdp = labelProc.Text;
            int ProcessIdps = Convert.ToInt32(ProcessIdp);
            string wmiQueryString = "SELECT ProcessId, ExecutablePath FROM Win32_Process WHERE ProcessId = " + ProcessIdps;
            using (var searcher = new ManagementObjectSearcher(wmiQueryString))
            {
                using (ManagementObjectCollection results = searcher.Get())
                {
                    foreach (ManagementObject mor in results)
                    {
                        string argument = @"/select, " + mor["ExecutablePath"];
                        System.Diagnostics.Process.Start("explorer.exe", argument);
                    }
                }
            }
        }

        private void BuWriteProcessInfo_Click(object sender, EventArgs e)
        {
            try
            {
                string ProcessIdp = labelProc.Text;
                int ProcessIdps = Convert.ToInt32(ProcessIdp);
                Process processes = Process.GetProcessById(ProcessIdps);


                var pathe = Directory.GetCurrentDirectory();

                if (Directory.Exists(pathe + "/" + "ProcessLog" + "/"))
                {

                }
                else
                {
                    Directory.CreateDirectory(pathe + "/" + "ProcessLog");
                }



                try
                {
                    Process p = Process.GetProcessById(ProcessIdps);
                    using (StreamWriter sw = new StreamWriter(pathe + "/" + "ProcessLog" + "/" + processes.ProcessName + processes.Id + processes.SessionId + ".txt"))
                    {
                        //Aqui você pode escrever no arquivo
                        sw.Write("---------------------Informações de registro---------------------" + "\n");
                        sw.Write("Salvo no diretorio: " + pathe + "/" + "ProcessLog" + "/" + processes.ProcessName + processes.Id + processes.SessionId + ".txt" + "\n");


                        sw.Write("Registro salvo as: " + DateTime.Now.ToString("HH:mm:ss") + " " + DateTime.Now.ToString("dddd / MMMM / yyyy") + "\n");



                        //



                        sw.Write("\n" + "\n" + "\n" + "\n");
                        sw.Write("---------------------Informações do processo---------------------" + "\n");
                        try
                        {
                            sw.Write("id: " + p.Id + "\n");
                        }
                        catch
                        {
                            sw.Write("id: falha" + "\n");
                        }


                        try
                        {
                            sw.Write("processo: " + NomeDoProcesso.Text + "\n");
                        }
                        catch
                        {
                            sw.Write("processo: falha" + "\n");
                        }


                        try
                        {
                            string wmiQueryString1 = "SELECT ProcessId, ExecutablePath FROM Win32_Process WHERE ProcessId = " + ProcessIdps;
                            using (var searcher = new ManagementObjectSearcher(wmiQueryString1))
                            {
                                using (ManagementObjectCollection results = searcher.Get())
                                {
                                    foreach (ManagementObject mo in results)
                                    {
                                        System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
                                        System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo("" + mo["ExecutablePath"] + "");
                                        string versionnp = fvi.ProductName;
                                        sw.Write("Nome: " + versionnp + "\n");
                                    }
                                }
                            }
                        }
                        catch
                        {
                            sw.Write("Nome: falha" + "\n");
                        }


                        try
                        {
                            bool bits = checkbit.Is64Bit(processes.Id);
                            if (bits)
                            {
                                sw.Write("plataforma: 32 bits/x86" + "\n");
                            }
                            else
                            {
                                sw.Write("plataforma: 64 bits/x64" + "\n");
                            }
                        }
                        catch
                        {
                            sw.Write("plataforma: falha" + "\n");
                        }

                        try
                        {
                            sw.Write("iniciado as: " + p.StartTime + "\n");
                        }
                        catch
                        {
                            sw.Write("iniciado as: falha" + "\n");
                        }

                        try
                        {
                            if (p.Responding.ToString() == "True")
                            {
                                sw.Write("status: Em execução" + "\n");
                            }
                            else if (p.Responding.ToString() == "False")
                            {
                                sw.Write("status: Parado" + "\n");
                            }
                        }
                        catch
                        {
                            sw.Write("status: falha" + "\n");
                        }

                        try
                        {
                            string cpuUsageTotal = CpuUsageP.Text;
                            sw.Write("CPU: " + cpuUsageTotal + "\n");
                        }
                        catch
                        {
                            sw.Write("CPU: falha" + "\n");
                        }

                        try
                        {
                            int memsize = 0;
                            memsize = Convert.ToInt32(p.PagedMemorySize64) / (int)(1024);
                            if (memsize < 1024)
                            {
                                sw.Write("Memoria: " + memsize + " KB" + "\n");
                            }
                            else
                            {
                                memsize = Convert.ToInt32(p.PagedMemorySize64) / (int)(1024 * 1024);
                                sw.Write("Memoria: " + memsize + " MB" + "\n");

                            }
                        }
                        catch
                        {
                            sw.Write("Memoria: falha" + "\n");
                        }


                        string wmiQueryString = "SELECT ProcessId, ExecutablePath FROM Win32_Process WHERE ProcessId = " + ProcessIdps;
                        using (var searcher = new ManagementObjectSearcher(wmiQueryString))
                        {
                            using (ManagementObjectCollection results = searcher.Get())
                            {
                                foreach (ManagementObject mo in results)
                                {
                                    try
                                    {
                                        if (ProcessLocal.Text != "")
                                        {
                                            sw.Write("local: " + mo["ExecutablePath"] + "\n");
                                        }
                                        else if (ProcessLocal.Text == "")
                                        {
                                            sw.Write("local: vazio" + "\n");
                                        }
                                        else if (ProcessLocal.Text == " ")
                                        {
                                            sw.Write("local: vazio" + "\n");
                                        }
                                    }
                                    catch
                                    {
                                        sw.Write("local: falha" + "\n");
                                    }
                                }
                            }
                        }


                        try
                        {

                            Process mProc = processes;
                            IntPtr hProc = mProc.Handle;

                            var base_adr = processes.MainModule.BaseAddress;
                            int height_offset = 0x0;
                            IntPtr height_adr = (IntPtr)(base_adr + height_offset);
                            sw.Write("endereço base: " + base_adr.ToString("X") + "\n");
                        }
                        catch
                        {
                            sw.Write("endereço: falha" + "\n");
                        }

                        try
                        {

                            Process mProc = processes;
                            IntPtr hProc = mProc.Handle;

                            var base_adr = processes.MainModule.EntryPointAddress;
                            int height_offset = 0x0;
                            IntPtr height_adr = (IntPtr)(base_adr + height_offset);
                            sw.Write("endereço de altura: " + height_adr.ToString("X") + "\n");
                        }
                        catch
                        {
                            sw.Write("endereço de altura: falha" + "\n");
                        }

                        try
                        {
                            sw.Write("\n" + "\n");
                            sw.Write("-------------------Dll's usada pelo processo-------------------" + "\n" + "\n");
                            Process proc = Process.GetProcessById(ProcessIdps);

                            ProcessModule myProcessModule;
                            //Get all the modules associated with 'myProcess".
                            ProcessModuleCollection myProcessModuleCollection = proc.Modules;

                            for (int i = 0; i < myProcessModuleCollection.Count; i++)
                            {
                                myProcessModule = myProcessModuleCollection[i];
                                string mdp = Convert.ToString(myProcessModule.ModuleName);
                                string fnp = Convert.ToString(myProcessModule.FileName);
                                string bap = Convert.ToString(myProcessModule.BaseAddress);
                                string epa = Convert.ToString(myProcessModule.EntryPointAddress);

                                ListViewItem novoListViewItem = new ListViewItem();
                                novoListViewItem.Text = (mdp);
                                novoListViewItem.SubItems.Add(fnp);


                                int offset = 0x100; //whatever offset you wish
                                string bap1 = bap += offset;
                                sw.Write("Dll: " + mdp + ", endereço base: " + myProcessModule.BaseAddress.ToString("X") + ", Endereço do ponteiro: " + epa + ", local: " + fnp + "." + "\n");


                            }
                        }
                        catch { }


                        sw.Write("\n" + "\n" + "\n" + "\n");
                        sw.Write("---------------------Informações do programa---------------------" + "\n");
                        try
                        {
                            using (var searcher = new ManagementObjectSearcher(wmiQueryString))
                            {
                                using (ManagementObjectCollection results = searcher.Get())
                                {
                                    foreach (ManagementObject mo in results)
                                    {
                                        try
                                        {
                                            if (ProcessLocal.Text != "")
                                            {
                                                string filename = @"" + mo["ExecutablePath"] + "";
                                                FileInfo fi = new FileInfo(filename);
                                                string filefullpath = fi.DirectoryName;
                                                sw.Write("local: " + filefullpath + "\n");

                                                try
                                                {
                                                    sw.Write("Tamanho: " + fileInfoTam(fi.Length) + "\n");
                                                    string fileInfoTam(long length)
                                                    {
                                                        double value = (length / 1024);
                                                        string label = "Kb";
                                                        if ((length / 1024) > 1024)
                                                        {
                                                            value = ((length / 1024) / 1024);
                                                            label = "Mb";
                                                        }

                                                        return string.Format("{0} {1}", Math.Round(value, 4), label);
                                                    }
                                                }
                                                catch
                                                {
                                                    sw.Write("tamanho: falha" + "\n");
                                                }

                                                try
                                                {
                                                    DateTime dataCriacao = new DateTime();

                                                    FileInfo arquivo = new FileInfo(filename);
                                                    dataCriacao = arquivo.CreationTime;
                                                    sw.Write("Data de instalação: " + dataCriacao + "\n");

                                                }
                                                catch
                                                {
                                                    sw.Write("Data de instalação: falha" + "\n");
                                                }

                                                try
                                                {
                                                    System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
                                                    System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo("" + mo["ExecutablePath"] + "");
                                                    string version = fvi.FileVersion;
                                                    sw.Write("Versão: " + version + "\n");
                                                }
                                                catch
                                                {
                                                    sw.Write("Versão: falha" + "\n");
                                                }

                                                try
                                                {
                                                    System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
                                                    System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo("" + mo["ExecutablePath"] + "");
                                                    string versionn = fvi.ProductName;
                                                    sw.Write("Nome: " + versionn + "\n");
                                                }
                                                catch
                                                {
                                                    sw.Write("Nome: falha" + "\n");
                                                }

                                                try
                                                {
                                                    System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
                                                    System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo("" + mo["ExecutablePath"] + "");
                                                    string versionnc = fvi.CompanyName;
                                                    sw.Write("Empresa: " + versionnc + "\n");
                                                }
                                                catch
                                                {
                                                    sw.Write("Empresa: falha" + "\n");
                                                }

                                                try
                                                {
                                                    System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
                                                    System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo("" + mo["ExecutablePath"] + "");
                                                    string versionnc12 = fvi.Language;
                                                    sw.Write("Linguagem padrão: " + versionnc12 + "\n");
                                                }
                                                catch
                                                {
                                                    sw.Write("Linguagem padrão: falha" + "\n");
                                                }


                                                try
                                                {
                                                    System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
                                                    System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo("" + mo["ExecutablePath"] + "");
                                                    bool versionnc12 = fvi.IsPreRelease;
                                                    if (versionnc12 == false)
                                                    {
                                                        string stat = "Não";
                                                        sw.Write("Versão beta: " + stat + "\n");
                                                    }
                                                    else if(versionnc12 == true)
                                                    {
                                                        string stat = "Sim";
                                                        sw.Write("Versão beta: " + stat + "\n");
                                                    }
                                                }
                                                catch
                                                {
                                                    sw.Write("Versão beta: falha" + "\n");
                                                }

                                                try
                                                {
                                                    System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
                                                    System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo("" + mo["ExecutablePath"] + "");
                                                    bool ispath = fvi.IsPatched;
                                                    if (ispath == false)
                                                    {
                                                        string stat = "Não";
                                                        sw.Write("Aplicação pirata: " + stat + "\n");
                                                    }
                                                    else if (ispath == true)
                                                    {
                                                        string stat = "Sim";
                                                        sw.Write("Aplicação pirata: " + stat + "\n");
                                                    }
                                                }
                                                catch
                                                {
                                                    sw.Write("Aplicação pirata: falha" + "\n");
                                                }





                                                try
                                                {
                                                    System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
                                                    System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo("" + mo["ExecutablePath"] + "");
                                                    string versionnc12 = fvi.LegalCopyright;
                                                    sw.Write("Direitos autorais: " + versionnc12 + "\n");
                                                }
                                                catch
                                                {
                                                    sw.Write("Direitos autorais: falha" + "\n");
                                                }




                                            }
                                            else if (ProcessLocal.Text == "")
                                            {
                                                sw.Write("Falha" + "\n");
                                            }
                                            else if (ProcessLocal.Text == " ")
                                            {
                                                sw.Write("Falha" + "\n");
                                            }
                                        }
                                        catch
                                        {
                                            sw.Write("Falha" + "\n");
                                        }
                                    }
                                }
                            }
                        }
                        catch { }
                    }

                    string path = Directory.GetCurrentDirectory();
                    string pathRoot = Path.GetPathRoot(path);


                    //


                    string argument = pathRoot + @"Program Files\Program Manage\logs\" + processes.ProcessName + processes.Id + processes.SessionId + ".txt";
                    System.Diagnostics.Process.Start("explorer.exe", argument);

                }
                catch { }
            }
            catch { MessageBox.Show("Falha ao imprimir informações", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonGetModule_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ConfigProcessMod>().Count() > 0)
            {
                MessageBox.Show("Esta ferramenta esta aberta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ConfigProcessMod ConfigProcessMod1 = new ConfigProcessMod(this);
                ConfigProcessMod1.Show();
            }
        }

        private void GetPHex_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Viewer>().Count() > 0)
            {
                MessageBox.Show("Esta ferramenta esta aberta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Viewer oph = new Viewer(this);
                oph.Show();
            }
        }
        private void procuraStringNaCombo()
        {
            int res = -1;

                Process services = Process.GetProcessById(Convert.ToInt32(labelProc.Text));

                if (PCB.Text != String.Empty)
                {
                    // O método FindStringExact procura a primeira ocorrência na lista
                    res = PCB.FindStringExact(PCB.Text);

                    // FindStringExact retorna -1 se nada for encontrado
                    if (res != -1)
                    {
                    if (res == 0)
                    {
                        try
                        {
                            services.PriorityClass = ProcessPriorityClass.Idle;
                        }
                        catch { }
                    }
                    else if (res == 1)
                    {
                        try
                        {
                            services.PriorityClass = ProcessPriorityClass.BelowNormal;
                        }
                        catch { }
                    }
                    else if (res == 2)
                    {
                        try
                        {
                            services.PriorityClass = ProcessPriorityClass.Normal;
                        }
                        catch { }
                    }
                    else if (res == 3)
                    {
                        try
                        {
                            services.PriorityClass = ProcessPriorityClass.AboveNormal;
                        }
                        catch { }
                    }
                    else if (res == 4)
                    {
                        try
                        {
                            services.PriorityClass = ProcessPriorityClass.High;
                        }
                        catch { }
                    }
                    else if (res == 5)
                    {
                        try
                        {
                            services.PriorityClass = ProcessPriorityClass.RealTime;
                        }
                        catch { }
                    }
                    PCB.SelectedIndex = res;
                }
                else
                {
                }
            }
            else
            {
                PCB.Focus();
            }
        }
        public void Getpcb()
        {
            try
            {
                var services = Process.GetProcessById((int)Convert.ToInt32(labelProc.Text));

                if (services.PriorityClass == ProcessPriorityClass.Idle)
                {
                    resultpcb = 0;
                }
                if (services.PriorityClass == ProcessPriorityClass.BelowNormal)
                {
                    resultpcb = 1;
                }
                if (services.PriorityClass == ProcessPriorityClass.Normal)
                {
                    resultpcb = 2;
                }
                if (services.PriorityClass == ProcessPriorityClass.AboveNormal)
                {
                    resultpcb = 3;
                }
                if (services.PriorityClass == ProcessPriorityClass.High)
                {
                    resultpcb = 4;
                }
                if (services.PriorityClass == ProcessPriorityClass.RealTime)
                {
                    resultpcb = 5;
                }
            }
            catch
            {

            }
        }

        private void PCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BuWriteProcessInfo.Visible == true)
            {
                procuraStringNaCombo();
            }
            else
            {
                Getpcb();
                PCB.SelectedIndex = resultpcb;
            }
        }

        private void bseeproc_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<seeproc>().Count() > 0)
            {
                MessageBox.Show("Esta ferramenta esta aberta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                seeproc fsp = new seeproc(this);
                fsp.Show();
            }
        }
    }
}