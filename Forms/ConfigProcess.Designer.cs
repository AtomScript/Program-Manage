namespace ProgramManage
{
    partial class ConfigProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigProcess));
            this.TemporizadorP = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.ConfigIdP = new System.Windows.Forms.Label();
            this.ProcessNameL = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxSelectBytes = new System.Windows.Forms.ComboBox();
            this.LabelResultBytesRead = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvValueMP = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.GetValueTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.InjectDllBP = new System.Windows.Forms.Button();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TemporizadorP
            // 
            this.TemporizadorP.Interval = 1000;
            this.TemporizadorP.Tick += new System.EventHandler(this.TemporizadorP_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuGradientPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(47)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 43);
            this.panel1.TabIndex = 2;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.ConfigIdP);
            this.bunifuGradientPanel1.Controls.Add(this.ProcessNameL);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(777, 43);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // ConfigIdP
            // 
            this.ConfigIdP.AutoSize = true;
            this.ConfigIdP.Location = new System.Drawing.Point(446, 21);
            this.ConfigIdP.Name = "ConfigIdP";
            this.ConfigIdP.Size = new System.Drawing.Size(0, 13);
            this.ConfigIdP.TabIndex = 1;
            this.ConfigIdP.Visible = false;
            // 
            // ProcessNameL
            // 
            this.ProcessNameL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProcessNameL.AutoSize = true;
            this.ProcessNameL.BackColor = System.Drawing.Color.Transparent;
            this.ProcessNameL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProcessNameL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProcessNameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessNameL.ForeColor = System.Drawing.Color.White;
            this.ProcessNameL.Location = new System.Drawing.Point(299, 4);
            this.ProcessNameL.Name = "ProcessNameL";
            this.ProcessNameL.Size = new System.Drawing.Size(115, 33);
            this.ProcessNameL.TabIndex = 0;
            this.ProcessNameL.Text = "Process";
            this.ProcessNameL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel2.Controls.Add(this.comboBoxSelectBytes);
            this.panel2.Controls.Add(this.LabelResultBytesRead);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.GetValueTextBox);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.InjectDllBP);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(777, 396);
            this.panel2.TabIndex = 3;
            // 
            // comboBoxSelectBytes
            // 
            this.comboBoxSelectBytes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSelectBytes.FormattingEnabled = true;
            this.comboBoxSelectBytes.Items.AddRange(new object[] {
            "2 Bytes",
            "4 Bytes",
            "8 Bytes",
            "Double",
            "String",
            "float"});
            this.comboBoxSelectBytes.Location = new System.Drawing.Point(329, 8);
            this.comboBoxSelectBytes.Name = "comboBoxSelectBytes";
            this.comboBoxSelectBytes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelectBytes.TabIndex = 10;
            this.comboBoxSelectBytes.Text = "Value type";
            this.comboBoxSelectBytes.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectBytes_SelectedIndexChanged);
            // 
            // LabelResultBytesRead
            // 
            this.LabelResultBytesRead.AutoSize = true;
            this.LabelResultBytesRead.ForeColor = System.Drawing.Color.White;
            this.LabelResultBytesRead.Location = new System.Drawing.Point(3, 40);
            this.LabelResultBytesRead.Name = "LabelResultBytesRead";
            this.LabelResultBytesRead.Size = new System.Drawing.Size(0, 13);
            this.LabelResultBytesRead.TabIndex = 9;
            this.LabelResultBytesRead.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.lvValueMP);
            this.panel3.Location = new System.Drawing.Point(0, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(555, 329);
            this.panel3.TabIndex = 4;
            // 
            // lvValueMP
            // 
            this.lvValueMP.AllowColumnReorder = true;
            this.lvValueMP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.lvValueMP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvValueMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvValueMP.ForeColor = System.Drawing.Color.White;
            this.lvValueMP.HideSelection = false;
            this.lvValueMP.Location = new System.Drawing.Point(0, 0);
            this.lvValueMP.Name = "lvValueMP";
            this.lvValueMP.Size = new System.Drawing.Size(555, 329);
            this.lvValueMP.TabIndex = 0;
            this.lvValueMP.UseCompatibleStateImageBehavior = false;
            this.lvValueMP.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Valor";
            this.columnHeader1.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor:";
            // 
            // GetValueTextBox
            // 
            this.GetValueTextBox.Location = new System.Drawing.Point(40, 6);
            this.GetValueTextBox.Name = "GetValueTextBox";
            this.GetValueTextBox.Size = new System.Drawing.Size(202, 20);
            this.GetValueTextBox.TabIndex = 2;
            this.GetValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GetValueTextBox_KeyPress);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(248, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InjectDllBP
            // 
            this.InjectDllBP.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.InjectDllBP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.InjectDllBP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.InjectDllBP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InjectDllBP.ForeColor = System.Drawing.Color.White;
            this.InjectDllBP.Location = new System.Drawing.Point(468, 8);
            this.InjectDllBP.Name = "InjectDllBP";
            this.InjectDllBP.Size = new System.Drawing.Size(75, 23);
            this.InjectDllBP.TabIndex = 0;
            this.InjectDllBP.Text = "Injetar Dll";
            this.InjectDllBP.UseVisualStyleBackColor = true;
            this.InjectDllBP.Click += new System.EventHandler(this.InjectDllBP_Click);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "address";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "pointer";
            this.columnHeader3.Width = 200;
            // 
            // ConfigProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 439);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(47)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigProcess";
            this.Text = "Configurar Processo";
            this.Load += new System.EventHandler(this.ConfigProcess_Load);
            this.panel1.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer TemporizadorP;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button InjectDllBP;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.ListView lvValueMP;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GetValueTextBox;
        private System.Windows.Forms.Label LabelResultBytesRead;
        private System.Windows.Forms.ComboBox comboBoxSelectBytes;
        public System.Windows.Forms.Label ProcessNameL;
        public System.Windows.Forms.Label ConfigIdP;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}