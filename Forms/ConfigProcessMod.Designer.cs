namespace ProgramManage
{
    partial class ConfigProcessMod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigProcessMod));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.processidpe = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProcessNameLe = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelResultBytesRead = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvValueMPe = new System.Windows.Forms.ListView();
            this.modulolv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.locallv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.balv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pointlv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuGradientPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(47)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 45);
            this.panel1.TabIndex = 3;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.processidpe);
            this.bunifuGradientPanel2.Controls.Add(this.label2);
            this.bunifuGradientPanel2.Controls.Add(this.ProcessNameLe);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(766, 45);
            this.bunifuGradientPanel2.TabIndex = 0;
            // 
            // processidpe
            // 
            this.processidpe.AutoSize = true;
            this.processidpe.Location = new System.Drawing.Point(433, 9);
            this.processidpe.Name = "processidpe";
            this.processidpe.Size = new System.Drawing.Size(35, 13);
            this.processidpe.TabIndex = 2;
            this.processidpe.Text = "label1";
            this.processidpe.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            this.label2.Visible = false;
            // 
            // ProcessNameLe
            // 
            this.ProcessNameLe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProcessNameLe.AutoSize = true;
            this.ProcessNameLe.BackColor = System.Drawing.Color.Transparent;
            this.ProcessNameLe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProcessNameLe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProcessNameLe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessNameLe.ForeColor = System.Drawing.Color.White;
            this.ProcessNameLe.Location = new System.Drawing.Point(304, 4);
            this.ProcessNameLe.Name = "ProcessNameLe";
            this.ProcessNameLe.Size = new System.Drawing.Size(115, 33);
            this.ProcessNameLe.TabIndex = 0;
            this.ProcessNameLe.Text = "Process";
            this.ProcessNameLe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel2.Controls.Add(this.LabelResultBytesRead);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(766, 358);
            this.panel2.TabIndex = 4;
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
            this.panel3.Controls.Add(this.lvValueMPe);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(766, 358);
            this.panel3.TabIndex = 4;
            // 
            // lvValueMPe
            // 
            this.lvValueMPe.AllowColumnReorder = true;
            this.lvValueMPe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.lvValueMPe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.modulolv,
            this.locallv,
            this.balv,
            this.pointlv});
            this.lvValueMPe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvValueMPe.ForeColor = System.Drawing.Color.White;
            this.lvValueMPe.GridLines = true;
            this.lvValueMPe.HideSelection = false;
            this.lvValueMPe.Location = new System.Drawing.Point(0, 0);
            this.lvValueMPe.Name = "lvValueMPe";
            this.lvValueMPe.Size = new System.Drawing.Size(766, 358);
            this.lvValueMPe.TabIndex = 0;
            this.lvValueMPe.UseCompatibleStateImageBehavior = false;
            this.lvValueMPe.View = System.Windows.Forms.View.Details;
            // 
            // modulolv
            // 
            this.modulolv.Text = "Modulo";
            this.modulolv.Width = 300;
            // 
            // locallv
            // 
            this.locallv.DisplayIndex = 3;
            this.locallv.Text = "local";
            this.locallv.Width = 1500;
            // 
            // balv
            // 
            this.balv.DisplayIndex = 1;
            this.balv.Text = "Endereço da base";
            this.balv.Width = 200;
            // 
            // pointlv
            // 
            this.pointlv.DisplayIndex = 2;
            this.pointlv.Text = "Endereço do pointer";
            this.pointlv.Width = 200;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ConfigProcessMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 403);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigProcessMod";
            this.Text = "Modulos";
            this.panel1.ResumeLayout(false);
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label ProcessNameLe;
        private System.Windows.Forms.Label processidpe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LabelResultBytesRead;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.ListView lvValueMPe;
        private System.Windows.Forms.ColumnHeader modulolv;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColumnHeader balv;
        private System.Windows.Forms.ColumnHeader pointlv;
        private System.Windows.Forms.ColumnHeader locallv;
    }
}