namespace ProgramManage
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NomeDoProcesso = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.baaddrp = new System.Windows.Forms.Label();
            this.IconProcess = new System.Windows.Forms.PictureBox();
            this.labelProc = new System.Windows.Forms.Label();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape9 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape8 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape7 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape6 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TimerStartedP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MemorySizeP = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSessionId = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProcessLocal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ProcessNameLabel = new System.Windows.Forms.Label();
            this.KillProcessButton = new System.Windows.Forms.Button();
            this.labelStatusIdS = new System.Windows.Forms.Label();
            this.PShowFormConfig = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.MemoriaSizeP = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CpuUsageP = new System.Windows.Forms.Label();
            this.labelREsponding = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.GoToPath = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.BuWriteProcessInfo = new System.Windows.Forms.Button();
            this.buttonGetModule = new System.Windows.Forms.Button();
            this.GetPHex = new System.Windows.Forms.Button();
            this.PCB = new System.Windows.Forms.ComboBox();
            this.bseeproc = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // NomeDoProcesso
            // 
            this.NomeDoProcesso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NomeDoProcesso.AutoSize = true;
            this.NomeDoProcesso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NomeDoProcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeDoProcesso.Location = new System.Drawing.Point(362, 9);
            this.NomeDoProcesso.Name = "NomeDoProcesso";
            this.NomeDoProcesso.Size = new System.Drawing.Size(96, 27);
            this.NomeDoProcesso.TabIndex = 0;
            this.NomeDoProcesso.Tag = "";
            this.NomeDoProcesso.Text = "Processo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.baaddrp);
            this.panel1.Controls.Add(this.IconProcess);
            this.panel1.Controls.Add(this.NomeDoProcesso);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 44);
            this.panel1.TabIndex = 1;
            // 
            // baaddrp
            // 
            this.baaddrp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.baaddrp.AutoSize = true;
            this.baaddrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baaddrp.ForeColor = System.Drawing.Color.White;
            this.baaddrp.Location = new System.Drawing.Point(525, 9);
            this.baaddrp.Name = "baaddrp";
            this.baaddrp.Size = new System.Drawing.Size(0, 25);
            this.baaddrp.TabIndex = 28;
            // 
            // IconProcess
            // 
            this.IconProcess.Location = new System.Drawing.Point(7, 9);
            this.IconProcess.Name = "IconProcess";
            this.IconProcess.Size = new System.Drawing.Size(31, 27);
            this.IconProcess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconProcess.TabIndex = 14;
            this.IconProcess.TabStop = false;
            // 
            // labelProc
            // 
            this.labelProc.AutoSize = true;
            this.labelProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProc.ForeColor = System.Drawing.Color.White;
            this.labelProc.Location = new System.Drawing.Point(168, 53);
            this.labelProc.Name = "labelProc";
            this.labelProc.Size = new System.Drawing.Size(0, 25);
            this.labelProc.TabIndex = 2;
            // 
            // Temporizador
            // 
            this.Temporizador.Enabled = true;
            this.Temporizador.Interval = 1000;
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape9,
            this.lineShape8,
            this.lineShape7,
            this.lineShape5,
            this.lineShape6,
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(828, 563);
            this.shapeContainer1.TabIndex = 3;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape9
            // 
            this.lineShape9.BorderColor = System.Drawing.Color.White;
            this.lineShape9.Name = "lineShape9";
            this.lineShape9.X1 = 0;
            this.lineShape9.X2 = 256;
            this.lineShape9.Y1 = 370;
            this.lineShape9.Y2 = 370;
            // 
            // lineShape8
            // 
            this.lineShape8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape8.BorderColor = System.Drawing.Color.White;
            this.lineShape8.Name = "lineShape8";
            this.lineShape8.X1 = 550;
            this.lineShape8.X2 = 829;
            this.lineShape8.Y1 = 259;
            this.lineShape8.Y2 = 259;
            // 
            // lineShape7
            // 
            this.lineShape7.BorderColor = System.Drawing.Color.White;
            this.lineShape7.Name = "lineShape7";
            this.lineShape7.X1 = 0;
            this.lineShape7.X2 = 256;
            this.lineShape7.Y1 = 312;
            this.lineShape7.Y2 = 312;
            // 
            // lineShape5
            // 
            this.lineShape5.BorderColor = System.Drawing.Color.White;
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 2;
            this.lineShape5.X2 = 260;
            this.lineShape5.Y1 = 259;
            this.lineShape5.Y2 = 259;
            // 
            // lineShape6
            // 
            this.lineShape6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape6.BorderColor = System.Drawing.Color.White;
            this.lineShape6.Name = "lineShape6";
            this.lineShape6.X1 = 571;
            this.lineShape6.X2 = 829;
            this.lineShape6.Y1 = 90;
            this.lineShape6.Y2 = 90;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 0;
            this.lineShape4.X2 = 75;
            this.lineShape4.Y1 = 0;
            this.lineShape4.Y2 = 23;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.White;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = -3;
            this.lineShape3.X2 = 522;
            this.lineShape3.Y1 = 200;
            this.lineShape3.Y2 = 200;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.White;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 0;
            this.lineShape2.X2 = 258;
            this.lineShape2.Y1 = 146;
            this.lineShape2.Y2 = 146;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.White;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 0;
            this.lineShape1.X2 = 258;
            this.lineShape1.Y1 = 92;
            this.lineShape1.Y2 = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id do processo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Iniciado as:";
            // 
            // TimerStartedP
            // 
            this.TimerStartedP.AutoSize = true;
            this.TimerStartedP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerStartedP.ForeColor = System.Drawing.Color.White;
            this.TimerStartedP.Location = new System.Drawing.Point(130, 109);
            this.TimerStartedP.Name = "TimerStartedP";
            this.TimerStartedP.Size = new System.Drawing.Size(0, 25);
            this.TimerStartedP.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Status:";
            // 
            // MemorySizeP
            // 
            this.MemorySizeP.AutoSize = true;
            this.MemorySizeP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemorySizeP.ForeColor = System.Drawing.Color.White;
            this.MemorySizeP.Location = new System.Drawing.Point(88, 221);
            this.MemorySizeP.Name = "MemorySizeP";
            this.MemorySizeP.Size = new System.Drawing.Size(0, 25);
            this.MemorySizeP.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(685, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = ":Id da sessão";
            // 
            // labelSessionId
            // 
            this.labelSessionId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSessionId.AutoSize = true;
            this.labelSessionId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSessionId.ForeColor = System.Drawing.Color.White;
            this.labelSessionId.Location = new System.Drawing.Point(659, 53);
            this.labelSessionId.Name = "labelSessionId";
            this.labelSessionId.Size = new System.Drawing.Size(0, 25);
            this.labelSessionId.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Local:";
            // 
            // ProcessLocal
            // 
            this.ProcessLocal.AutoSize = true;
            this.ProcessLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessLocal.ForeColor = System.Drawing.Color.White;
            this.ProcessLocal.Location = new System.Drawing.Point(130, 167);
            this.ProcessLocal.Name = "ProcessLocal";
            this.ProcessLocal.Size = new System.Drawing.Size(0, 25);
            this.ProcessLocal.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nome:";
            // 
            // ProcessNameLabel
            // 
            this.ProcessNameLabel.AutoSize = true;
            this.ProcessNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessNameLabel.ForeColor = System.Drawing.Color.White;
            this.ProcessNameLabel.Location = new System.Drawing.Point(88, 277);
            this.ProcessNameLabel.Name = "ProcessNameLabel";
            this.ProcessNameLabel.Size = new System.Drawing.Size(0, 25);
            this.ProcessNameLabel.TabIndex = 17;
            // 
            // KillProcessButton
            // 
            this.KillProcessButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.KillProcessButton.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.KillProcessButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.KillProcessButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.KillProcessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KillProcessButton.ForeColor = System.Drawing.Color.White;
            this.KillProcessButton.Location = new System.Drawing.Point(8, 492);
            this.KillProcessButton.Name = "KillProcessButton";
            this.KillProcessButton.Size = new System.Drawing.Size(101, 23);
            this.KillProcessButton.TabIndex = 18;
            this.KillProcessButton.Text = "Fechar Processo";
            this.KillProcessButton.UseVisualStyleBackColor = true;
            this.KillProcessButton.Click += new System.EventHandler(this.KillProcessButton_Click);
            // 
            // labelStatusIdS
            // 
            this.labelStatusIdS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatusIdS.AutoSize = true;
            this.labelStatusIdS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusIdS.ForeColor = System.Drawing.Color.White;
            this.labelStatusIdS.Location = new System.Drawing.Point(566, 53);
            this.labelStatusIdS.Name = "labelStatusIdS";
            this.labelStatusIdS.Size = new System.Drawing.Size(0, 25);
            this.labelStatusIdS.TabIndex = 19;
            // 
            // PShowFormConfig
            // 
            this.PShowFormConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PShowFormConfig.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.PShowFormConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.PShowFormConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.PShowFormConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PShowFormConfig.ForeColor = System.Drawing.Color.White;
            this.PShowFormConfig.Location = new System.Drawing.Point(173, 528);
            this.PShowFormConfig.Name = "PShowFormConfig";
            this.PShowFormConfig.Size = new System.Drawing.Size(101, 23);
            this.PShowFormConfig.TabIndex = 20;
            this.PShowFormConfig.Text = "Configurar";
            this.PShowFormConfig.UseVisualStyleBackColor = true;
            this.PShowFormConfig.Click += new System.EventHandler(this.PShowFormConfig_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(664, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = ":Memoria usada";
            // 
            // MemoriaSizeP
            // 
            this.MemoriaSizeP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MemoriaSizeP.AutoSize = true;
            this.MemoriaSizeP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoriaSizeP.ForeColor = System.Drawing.Color.White;
            this.MemoriaSizeP.Location = new System.Drawing.Point(566, 221);
            this.MemoriaSizeP.Name = "MemoriaSizeP";
            this.MemoriaSizeP.Size = new System.Drawing.Size(0, 25);
            this.MemoriaSizeP.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(2, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "CPU:";
            // 
            // CpuUsageP
            // 
            this.CpuUsageP.AutoSize = true;
            this.CpuUsageP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CpuUsageP.ForeColor = System.Drawing.Color.White;
            this.CpuUsageP.Location = new System.Drawing.Point(77, 334);
            this.CpuUsageP.Name = "CpuUsageP";
            this.CpuUsageP.Size = new System.Drawing.Size(0, 25);
            this.CpuUsageP.TabIndex = 24;
            // 
            // labelREsponding
            // 
            this.labelREsponding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelREsponding.AutoSize = true;
            this.labelREsponding.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelREsponding.ForeColor = System.Drawing.Color.White;
            this.labelREsponding.Location = new System.Drawing.Point(545, 221);
            this.labelREsponding.Name = "labelREsponding";
            this.labelREsponding.Size = new System.Drawing.Size(0, 25);
            this.labelREsponding.TabIndex = 25;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // GoToPath
            // 
            this.GoToPath.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.GoToPath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.GoToPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.GoToPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoToPath.ForeColor = System.Drawing.Color.White;
            this.GoToPath.Location = new System.Drawing.Point(77, 167);
            this.GoToPath.Name = "GoToPath";
            this.GoToPath.Size = new System.Drawing.Size(47, 23);
            this.GoToPath.TabIndex = 26;
            this.GoToPath.Text = "local";
            this.GoToPath.UseVisualStyleBackColor = true;
            this.GoToPath.Visible = false;
            this.GoToPath.Click += new System.EventHandler(this.GoToPath_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(88, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 25);
            this.label9.TabIndex = 27;
            // 
            // BuWriteProcessInfo
            // 
            this.BuWriteProcessInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BuWriteProcessInfo.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BuWriteProcessInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.BuWriteProcessInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.BuWriteProcessInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuWriteProcessInfo.ForeColor = System.Drawing.Color.White;
            this.BuWriteProcessInfo.Location = new System.Drawing.Point(280, 528);
            this.BuWriteProcessInfo.Name = "BuWriteProcessInfo";
            this.BuWriteProcessInfo.Size = new System.Drawing.Size(183, 23);
            this.BuWriteProcessInfo.TabIndex = 28;
            this.BuWriteProcessInfo.Text = "imprimir todas as informações";
            this.BuWriteProcessInfo.UseVisualStyleBackColor = true;
            this.BuWriteProcessInfo.Visible = false;
            this.BuWriteProcessInfo.Click += new System.EventHandler(this.BuWriteProcessInfo_Click);
            // 
            // buttonGetModule
            // 
            this.buttonGetModule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonGetModule.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.buttonGetModule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.buttonGetModule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.buttonGetModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetModule.ForeColor = System.Drawing.Color.White;
            this.buttonGetModule.Location = new System.Drawing.Point(469, 528);
            this.buttonGetModule.Name = "buttonGetModule";
            this.buttonGetModule.Size = new System.Drawing.Size(101, 23);
            this.buttonGetModule.TabIndex = 29;
            this.buttonGetModule.Text = "Modulos";
            this.buttonGetModule.UseVisualStyleBackColor = true;
            this.buttonGetModule.Click += new System.EventHandler(this.buttonGetModule_Click);
            // 
            // GetPHex
            // 
            this.GetPHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GetPHex.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.GetPHex.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.GetPHex.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.GetPHex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetPHex.ForeColor = System.Drawing.Color.White;
            this.GetPHex.Location = new System.Drawing.Point(576, 528);
            this.GetPHex.Name = "GetPHex";
            this.GetPHex.Size = new System.Drawing.Size(218, 23);
            this.GetPHex.TabIndex = 32;
            this.GetPHex.Text = "visualizar codigos hex do programa";
            this.GetPHex.UseVisualStyleBackColor = true;
            this.GetPHex.Click += new System.EventHandler(this.GetPHex_Click);
            // 
            // PCB
            // 
            this.PCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PCB.Items.AddRange(new object[] {
            "Prioridade (baixa)",
            "Prioridade (baixa do normal)",
            "Prioridade (normal)",
            "Prioridade (acima do normal)",
            "Prioridade (alta)",
            "Prioridade (tempo real)"});
            this.PCB.Location = new System.Drawing.Point(8, 528);
            this.PCB.Name = "PCB";
            this.PCB.Size = new System.Drawing.Size(154, 21);
            this.PCB.TabIndex = 33;
            this.PCB.Text = "Prioridade (baixa)";
            this.PCB.SelectedIndexChanged += new System.EventHandler(this.PCB_SelectedIndexChanged);
            // 
            // bseeproc
            // 
            this.bseeproc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bseeproc.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.bseeproc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.bseeproc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.bseeproc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bseeproc.ForeColor = System.Drawing.Color.White;
            this.bseeproc.Location = new System.Drawing.Point(122, 492);
            this.bseeproc.Name = "bseeproc";
            this.bseeproc.Size = new System.Drawing.Size(139, 23);
            this.bseeproc.TabIndex = 34;
            this.bseeproc.Text = "Ver processos associado";
            this.bseeproc.UseVisualStyleBackColor = true;
            this.bseeproc.Click += new System.EventHandler(this.bseeproc_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(828, 563);
            this.Controls.Add(this.bseeproc);
            this.Controls.Add(this.PCB);
            this.Controls.Add(this.GetPHex);
            this.Controls.Add(this.buttonGetModule);
            this.Controls.Add(this.BuWriteProcessInfo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GoToPath);
            this.Controls.Add(this.labelREsponding);
            this.Controls.Add(this.CpuUsageP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MemoriaSizeP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PShowFormConfig);
            this.Controls.Add(this.labelStatusIdS);
            this.Controls.Add(this.KillProcessButton);
            this.Controls.Add(this.ProcessNameLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ProcessLocal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelSessionId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MemorySizeP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TimerStartedP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelProc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconProcess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer Temporizador;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TimerStartedP;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MemorySizeP;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape6;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSessionId;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ProcessLocal;
        private System.Windows.Forms.PictureBox IconProcess;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ProcessNameLabel;
        private System.Windows.Forms.Button KillProcessButton;
        private System.Windows.Forms.Label labelStatusIdS;
        private System.Windows.Forms.Button PShowFormConfig;
        public System.Windows.Forms.Label NomeDoProcesso;
        public System.Windows.Forms.Label labelProc;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label MemoriaSizeP;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label CpuUsageP;
        private System.Windows.Forms.Label labelREsponding;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button GoToPath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label baaddrp;
        private System.Windows.Forms.Button BuWriteProcessInfo;
        private System.Windows.Forms.Button buttonGetModule;
        private System.Windows.Forms.Button GetPHex;
        private System.Windows.Forms.ComboBox PCB;
        private System.Windows.Forms.Button bseeproc;
    }
}