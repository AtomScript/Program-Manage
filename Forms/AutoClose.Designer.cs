namespace ProgramManage
{
    partial class AutoClose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoClose));
            this.ButtonAC = new System.Windows.Forms.Button();
            this.ListProcessFormu1 = new System.Windows.Forms.ListView();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openProgram = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gerenciar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removerDaListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.interval = new System.Windows.Forms.Timer(this.components);
            this.buttonpausa = new System.Windows.Forms.Button();
            this.buttonretorna = new System.Windows.Forms.Button();
            this.ChangeInterval = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1active = new System.Windows.Forms.Button();
            this.buttonloadp = new System.Windows.Forms.Button();
            this.SaveConfigs = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LBAction = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.gerenciar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonAC
            // 
            this.ButtonAC.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.ButtonAC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.ButtonAC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.ButtonAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAC.ForeColor = System.Drawing.Color.White;
            this.ButtonAC.Location = new System.Drawing.Point(3, 3);
            this.ButtonAC.Name = "ButtonAC";
            this.ButtonAC.Size = new System.Drawing.Size(116, 23);
            this.ButtonAC.TabIndex = 29;
            this.ButtonAC.Text = "Selecionar processo ";
            this.ButtonAC.UseVisualStyleBackColor = true;
            this.ButtonAC.Click += new System.EventHandler(this.ButtonAC_Click);
            // 
            // ListProcessFormu1
            // 
            this.ListProcessFormu1.AllowColumnReorder = true;
            this.ListProcessFormu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ListProcessFormu1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome});
            this.ListProcessFormu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListProcessFormu1.ForeColor = System.Drawing.Color.White;
            this.ListProcessFormu1.FullRowSelect = true;
            this.ListProcessFormu1.HideSelection = false;
            this.ListProcessFormu1.Location = new System.Drawing.Point(0, 0);
            this.ListProcessFormu1.Name = "ListProcessFormu1";
            this.ListProcessFormu1.Size = new System.Drawing.Size(361, 382);
            this.ListProcessFormu1.TabIndex = 30;
            this.ListProcessFormu1.UseCompatibleStateImageBehavior = false;
            this.ListProcessFormu1.View = System.Windows.Forms.View.Details;
            this.ListProcessFormu1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ListProcessFormu1_MouseUp);
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 350;
            // 
            // openProgram
            // 
            this.openProgram.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.openProgram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.openProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.openProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openProgram.ForeColor = System.Drawing.Color.White;
            this.openProgram.Location = new System.Drawing.Point(125, 3);
            this.openProgram.Name = "openProgram";
            this.openProgram.Size = new System.Drawing.Size(115, 23);
            this.openProgram.TabIndex = 31;
            this.openProgram.Text = "Selecionar programa";
            this.openProgram.UseVisualStyleBackColor = true;
            this.openProgram.Click += new System.EventHandler(this.openProgram_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // gerenciar
            // 
            this.gerenciar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removerDaListaToolStripMenuItem});
            this.gerenciar.Name = "gerenciar";
            this.gerenciar.Size = new System.Drawing.Size(162, 26);
            this.gerenciar.Opening += new System.ComponentModel.CancelEventHandler(this.gerenciar_Opening);
            // 
            // removerDaListaToolStripMenuItem
            // 
            this.removerDaListaToolStripMenuItem.Name = "removerDaListaToolStripMenuItem";
            this.removerDaListaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.removerDaListaToolStripMenuItem.Text = "Remover da lista";
            this.removerDaListaToolStripMenuItem.Click += new System.EventHandler(this.removerDaListaToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(61, 4);
            // 
            // interval
            // 
            this.interval.Enabled = true;
            this.interval.Interval = 1000;
            this.interval.Tick += new System.EventHandler(this.interval_Tick);
            // 
            // buttonpausa
            // 
            this.buttonpausa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonpausa.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.buttonpausa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.buttonpausa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.buttonpausa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonpausa.ForeColor = System.Drawing.Color.White;
            this.buttonpausa.Location = new System.Drawing.Point(689, 3);
            this.buttonpausa.Name = "buttonpausa";
            this.buttonpausa.Size = new System.Drawing.Size(76, 23);
            this.buttonpausa.TabIndex = 34;
            this.buttonpausa.Text = "Pausar";
            this.buttonpausa.UseVisualStyleBackColor = true;
            this.buttonpausa.Click += new System.EventHandler(this.buttonpausa_Click);
            // 
            // buttonretorna
            // 
            this.buttonretorna.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonretorna.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.buttonretorna.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.buttonretorna.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.buttonretorna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonretorna.ForeColor = System.Drawing.Color.White;
            this.buttonretorna.Location = new System.Drawing.Point(689, 3);
            this.buttonretorna.Name = "buttonretorna";
            this.buttonretorna.Size = new System.Drawing.Size(76, 23);
            this.buttonretorna.TabIndex = 35;
            this.buttonretorna.Text = "Retornar";
            this.buttonretorna.UseVisualStyleBackColor = true;
            this.buttonretorna.Visible = false;
            this.buttonretorna.Click += new System.EventHandler(this.buttonretorna_Click);
            // 
            // ChangeInterval
            // 
            this.ChangeInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeInterval.FormattingEnabled = true;
            this.ChangeInterval.Items.AddRange(new object[] {
            "1 nanosegundo",
            "500 milisegundos",
            "1 segundo",
            "5 segundos",
            "10 segundos",
            "50 segundos",
            "1 minuto",
            "5 minutos"});
            this.ChangeInterval.Location = new System.Drawing.Point(550, 3);
            this.ChangeInterval.Name = "ChangeInterval";
            this.ChangeInterval.Size = new System.Drawing.Size(133, 21);
            this.ChangeInterval.TabIndex = 36;
            this.ChangeInterval.Text = "intervalo (1 segundo)";
            this.ChangeInterval.SelectedIndexChanged += new System.EventHandler(this.ChangeInterval_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1active);
            this.panel1.Controls.Add(this.buttonloadp);
            this.panel1.Controls.Add(this.SaveConfigs);
            this.panel1.Controls.Add(this.ButtonAC);
            this.panel1.Controls.Add(this.ChangeInterval);
            this.panel1.Controls.Add(this.openProgram);
            this.panel1.Controls.Add(this.buttonretorna);
            this.panel1.Controls.Add(this.buttonpausa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 42);
            this.panel1.TabIndex = 37;
            // 
            // button1active
            // 
            this.button1active.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.button1active.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.button1active.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.button1active.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1active.ForeColor = System.Drawing.Color.White;
            this.button1active.Location = new System.Drawing.Point(246, 3);
            this.button1active.Name = "button1active";
            this.button1active.Size = new System.Drawing.Size(144, 23);
            this.button1active.TabIndex = 39;
            this.button1active.Text = "Matar arvore de processos";
            this.button1active.UseVisualStyleBackColor = true;
            this.button1active.Click += new System.EventHandler(this.button1active_Click);
            // 
            // buttonloadp
            // 
            this.buttonloadp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonloadp.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.buttonloadp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.buttonloadp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.buttonloadp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonloadp.ForeColor = System.Drawing.Color.White;
            this.buttonloadp.Location = new System.Drawing.Point(405, 3);
            this.buttonloadp.Name = "buttonloadp";
            this.buttonloadp.Size = new System.Drawing.Size(71, 23);
            this.buttonloadp.TabIndex = 38;
            this.buttonloadp.Text = "Carregar";
            this.buttonloadp.UseVisualStyleBackColor = true;
            this.buttonloadp.Click += new System.EventHandler(this.buttonloadp_Click);
            // 
            // SaveConfigs
            // 
            this.SaveConfigs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveConfigs.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.SaveConfigs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.SaveConfigs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.SaveConfigs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveConfigs.ForeColor = System.Drawing.Color.White;
            this.SaveConfigs.Location = new System.Drawing.Point(482, 3);
            this.SaveConfigs.Name = "SaveConfigs";
            this.SaveConfigs.Size = new System.Drawing.Size(62, 23);
            this.SaveConfigs.TabIndex = 37;
            this.SaveConfigs.Text = "Salvar";
            this.SaveConfigs.UseVisualStyleBackColor = true;
            this.SaveConfigs.Click += new System.EventHandler(this.SaveConfigs_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ListProcessFormu1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 382);
            this.panel2.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LBAction);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(361, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(407, 382);
            this.panel3.TabIndex = 39;
            // 
            // LBAction
            // 
            this.LBAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.LBAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBAction.ForeColor = System.Drawing.Color.White;
            this.LBAction.FormattingEnabled = true;
            this.LBAction.Location = new System.Drawing.Point(0, 0);
            this.LBAction.Name = "LBAction";
            this.LBAction.Size = new System.Drawing.Size(407, 382);
            this.LBAction.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // AutoClose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(768, 424);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AutoClose";
            this.Text = "Automatic Close";
            this.Load += new System.EventHandler(this.AutoClose_Load);
            this.gerenciar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonAC;
        public System.Windows.Forms.ColumnHeader Nome;
        public System.Windows.Forms.ListView ListProcessFormu1;
        private System.Windows.Forms.Button openProgram;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip gerenciar;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem removerDaListaToolStripMenuItem;
        private System.Windows.Forms.Timer interval;
        private System.Windows.Forms.Button buttonpausa;
        private System.Windows.Forms.Button buttonretorna;
        private System.Windows.Forms.ComboBox ChangeInterval;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.ListBox LBAction;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button SaveConfigs;
        private System.Windows.Forms.Button buttonloadp;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button button1active;
    }
}