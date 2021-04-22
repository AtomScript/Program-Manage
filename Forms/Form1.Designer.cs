namespace ProgramManage
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SelectProcess = new System.Windows.Forms.Button();
            this.ListProcessFormu1 = new System.Windows.Forms.ListView();
            this.Process = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Processi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RestoreNotifyicon = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseNotifyicon = new System.Windows.Forms.ToolStripMenuItem();
            this.MinimizeNotifyicon = new System.Windows.Forms.ToolStripMenuItem();
            this.InvisibleNotifyicon = new System.Windows.Forms.ToolStripMenuItem();
            this.BackInicio = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.Gerenciar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tempForm1 = new System.Windows.Forms.Timer(this.components);
            this.Menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Gerenciar.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectProcess
            // 
            this.SelectProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.SelectProcess.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.SelectProcess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.SelectProcess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.SelectProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectProcess.ForeColor = System.Drawing.Color.Aqua;
            this.SelectProcess.Location = new System.Drawing.Point(0, 453);
            this.SelectProcess.Name = "SelectProcess";
            this.SelectProcess.Size = new System.Drawing.Size(177, 35);
            this.SelectProcess.TabIndex = 0;
            this.SelectProcess.Text = "Selecionar Processo";
            this.SelectProcess.UseVisualStyleBackColor = false;
            this.SelectProcess.Click += new System.EventHandler(this.SelectProcess_Click);
            // 
            // ListProcessFormu1
            // 
            this.ListProcessFormu1.AllowColumnReorder = true;
            this.ListProcessFormu1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListProcessFormu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ListProcessFormu1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Process,
            this.Processi});
            this.ListProcessFormu1.ForeColor = System.Drawing.Color.LightCyan;
            this.ListProcessFormu1.FullRowSelect = true;
            this.ListProcessFormu1.HideSelection = false;
            this.ListProcessFormu1.Location = new System.Drawing.Point(0, 0);
            this.ListProcessFormu1.Name = "ListProcessFormu1";
            this.ListProcessFormu1.Size = new System.Drawing.Size(177, 454);
            this.ListProcessFormu1.TabIndex = 3;
            this.ListProcessFormu1.UseCompatibleStateImageBehavior = false;
            this.ListProcessFormu1.View = System.Windows.Forms.View.Details;
            this.ListProcessFormu1.SelectedIndexChanged += new System.EventHandler(this.ListProcessFormu1_SelectedIndexChanged);
            this.ListProcessFormu1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListProcessFormu1_MouseDoubleClick);
            this.ListProcessFormu1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ListProcessFormu1_MouseUp);
            // 
            // Process
            // 
            this.Process.Text = "Processos:";
            this.Process.Width = 200;
            // 
            // Processi
            // 
            this.Processi.Text = "Id";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.Menu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Gerenciamento";
            this.notifyIcon1.Visible = true;
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RestoreNotifyicon,
            this.CloseNotifyicon,
            this.MinimizeNotifyicon,
            this.InvisibleNotifyicon});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(155, 92);
            this.Menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Menu_ItemClicked);
            // 
            // RestoreNotifyicon
            // 
            this.RestoreNotifyicon.Name = "RestoreNotifyicon";
            this.RestoreNotifyicon.Size = new System.Drawing.Size(154, 22);
            this.RestoreNotifyicon.Text = "Restaurar";
            // 
            // CloseNotifyicon
            // 
            this.CloseNotifyicon.Name = "CloseNotifyicon";
            this.CloseNotifyicon.Size = new System.Drawing.Size(154, 22);
            this.CloseNotifyicon.Text = "Fechar";
            // 
            // MinimizeNotifyicon
            // 
            this.MinimizeNotifyicon.Name = "MinimizeNotifyicon";
            this.MinimizeNotifyicon.Size = new System.Drawing.Size(154, 22);
            this.MinimizeNotifyicon.Text = "Minimizar";
            // 
            // InvisibleNotifyicon
            // 
            this.InvisibleNotifyicon.Name = "InvisibleNotifyicon";
            this.InvisibleNotifyicon.Size = new System.Drawing.Size(154, 22);
            this.InvisibleNotifyicon.Text = "Fechar Bandeja";
            // 
            // BackInicio
            // 
            this.BackInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.BackInicio.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BackInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.BackInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.BackInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackInicio.ForeColor = System.Drawing.Color.Aqua;
            this.BackInicio.Location = new System.Drawing.Point(0, 485);
            this.BackInicio.Name = "BackInicio";
            this.BackInicio.Size = new System.Drawing.Size(177, 33);
            this.BackInicio.TabIndex = 4;
            this.BackInicio.Text = "Inicio";
            this.BackInicio.UseVisualStyleBackColor = false;
            this.BackInicio.Click += new System.EventHandler(this.BackInicio_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ListProcessFormu1);
            this.panel1.Controls.Add(this.BackInicio);
            this.panel1.Controls.Add(this.SelectProcess);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 516);
            this.panel1.TabIndex = 6;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(177, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(731, 516);
            this.panelContainer.TabIndex = 7;
            // 
            // Gerenciar
            // 
            this.Gerenciar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removerToolStripMenuItem});
            this.Gerenciar.Name = "Gerenciar";
            this.Gerenciar.Size = new System.Drawing.Size(125, 26);
            // 
            // removerToolStripMenuItem
            // 
            this.removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            this.removerToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.removerToolStripMenuItem.Text = " Remover";
            this.removerToolStripMenuItem.Click += new System.EventHandler(this.removerToolStripMenuItem_Click);
            // 
            // noneStrip
            // 
            this.noneStrip.Name = "noneStrip";
            this.noneStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // tempForm1
            // 
            this.tempForm1.Enabled = true;
            this.tempForm1.Interval = 500;
            this.tempForm1.Tick += new System.EventHandler(this.tempForm1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(908, 516);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Program Manage";
            this.Menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.Gerenciar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SelectProcess;
        private System.Windows.Forms.ColumnHeader Process;
        public System.Windows.Forms.ListView ListProcessFormu1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem RestoreNotifyicon;
        private System.Windows.Forms.ToolStripMenuItem CloseNotifyicon;
        private System.Windows.Forms.ToolStripMenuItem MinimizeNotifyicon;
        private System.Windows.Forms.ToolStripMenuItem InvisibleNotifyicon;
        private System.Windows.Forms.Button BackInicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader Processi;
        private System.Windows.Forms.ContextMenuStrip Gerenciar;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip noneStrip;
        public System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Timer tempForm1;
    }
}

