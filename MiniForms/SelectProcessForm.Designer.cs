namespace ProgramManage
{
    partial class SelectProcessForme
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Aplicativos", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Processos", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectProcessForme));
            this.lvServicosAtivos = new System.Windows.Forms.ListView();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Processid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Imagelist = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lvServicosAtivos
            // 
            this.lvServicosAtivos.AllowColumnReorder = true;
            this.lvServicosAtivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.lvServicosAtivos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.Processid});
            this.lvServicosAtivos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvServicosAtivos.ForeColor = System.Drawing.Color.White;
            this.lvServicosAtivos.FullRowSelect = true;
            listViewGroup1.Header = "Aplicativos";
            listViewGroup1.Name = "Aplicativos";
            listViewGroup1.Tag = "Aplicativos";
            listViewGroup2.Header = "Processos";
            listViewGroup2.Name = "Processos";
            listViewGroup2.Tag = "Processos";
            this.lvServicosAtivos.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.lvServicosAtivos.HideSelection = false;
            this.lvServicosAtivos.Location = new System.Drawing.Point(0, 0);
            this.lvServicosAtivos.Name = "lvServicosAtivos";
            this.lvServicosAtivos.Size = new System.Drawing.Size(256, 322);
            this.lvServicosAtivos.TabIndex = 0;
            this.lvServicosAtivos.UseCompatibleStateImageBehavior = false;
            this.lvServicosAtivos.View = System.Windows.Forms.View.Details;
            this.lvServicosAtivos.SelectedIndexChanged += new System.EventHandler(this.lvServicosAtivos_SelectedIndexChanged_1);
            this.lvServicosAtivos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvServicosAtivos_MouseDoubleClick);
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 400;
            // 
            // Processid
            // 
            this.Processid.Text = "Id";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Aqua;
            this.button1.ImageKey = "(nenhum/a)";
            this.button1.Location = new System.Drawing.Point(0, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.lvServicosAtivos;
            this.bunifuDragControl2.Vertical = true;
            // 
            // Imagelist
            // 
            this.Imagelist.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.Imagelist.ImageSize = new System.Drawing.Size(16, 16);
            this.Imagelist.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // SelectProcessForme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(256, 392);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvServicosAtivos);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectProcessForme";
            this.Text = "Selecionar Processo";
            this.Load += new System.EventHandler(this.SelectProcessForme_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvServicosAtivos;
        public System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        public System.Windows.Forms.ColumnHeader Processid;
        private System.Windows.Forms.ImageList Imagelist;
    }
}