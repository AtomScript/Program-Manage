namespace ProgramManage
{
    partial class AddInputlv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddInputlv));
            this.attrelementt = new System.Windows.Forms.ComboBox();
            this.tbid = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbvalueattr = new System.Windows.Forms.TextBox();
            this.tbclass = new System.Windows.Forms.TextBox();
            this.labelvaluer = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.labelclass = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.tbelementt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbvalue = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.additemtext = new System.Windows.Forms.Button();
            this.cbclose = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // attrelementt
            // 
            this.attrelementt.FormattingEnabled = true;
            this.attrelementt.Items.AddRange(new object[] {
            "Id",
            "Class",
            "Name",
            "Value"});
            this.attrelementt.Location = new System.Drawing.Point(111, 12);
            this.attrelementt.Name = "attrelementt";
            this.attrelementt.Size = new System.Drawing.Size(121, 21);
            this.attrelementt.TabIndex = 51;
            this.attrelementt.SelectedIndexChanged += new System.EventHandler(this.attrelementt_SelectedIndexChanged);
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(123, 55);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(100, 20);
            this.tbid.TabIndex = 52;
            this.tbid.Visible = false;
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(123, 54);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(100, 20);
            this.tbname.TabIndex = 53;
            this.tbname.Visible = false;
            // 
            // tbvalueattr
            // 
            this.tbvalueattr.Location = new System.Drawing.Point(123, 55);
            this.tbvalueattr.Name = "tbvalueattr";
            this.tbvalueattr.Size = new System.Drawing.Size(100, 20);
            this.tbvalueattr.TabIndex = 57;
            this.tbvalueattr.Visible = false;
            // 
            // tbclass
            // 
            this.tbclass.Location = new System.Drawing.Point(123, 55);
            this.tbclass.Name = "tbclass";
            this.tbclass.Size = new System.Drawing.Size(100, 20);
            this.tbclass.TabIndex = 58;
            this.tbclass.Visible = false;
            // 
            // labelvaluer
            // 
            this.labelvaluer.AutoSize = true;
            this.labelvaluer.Location = new System.Drawing.Point(12, 58);
            this.labelvaluer.Name = "labelvaluer";
            this.labelvaluer.Size = new System.Drawing.Size(94, 13);
            this.labelvaluer.TabIndex = 62;
            this.labelvaluer.Text = "value do elemento";
            this.labelvaluer.Visible = false;
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Location = new System.Drawing.Point(12, 54);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(94, 13);
            this.labelname.TabIndex = 61;
            this.labelname.Text = "name do elemento";
            this.labelname.Visible = false;
            // 
            // labelclass
            // 
            this.labelclass.AutoSize = true;
            this.labelclass.Location = new System.Drawing.Point(14, 58);
            this.labelclass.Name = "labelclass";
            this.labelclass.Size = new System.Drawing.Size(92, 13);
            this.labelclass.TabIndex = 60;
            this.labelclass.Text = "class do elemento";
            this.labelclass.Visible = false;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(24, 58);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(76, 13);
            this.labelid.TabIndex = 59;
            this.labelid.Text = "id do elemento";
            this.labelid.Visible = false;
            // 
            // tbelementt
            // 
            this.tbelementt.Location = new System.Drawing.Point(123, 92);
            this.tbelementt.Name = "tbelementt";
            this.tbelementt.Size = new System.Drawing.Size(100, 20);
            this.tbelementt.TabIndex = 63;
            this.tbelementt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbelementt_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "elemento";
            // 
            // tbvalue
            // 
            this.tbvalue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbvalue.Location = new System.Drawing.Point(-2, 160);
            this.tbvalue.Name = "tbvalue";
            this.tbvalue.Size = new System.Drawing.Size(365, 137);
            this.tbvalue.TabIndex = 65;
            this.tbvalue.Tag = "";
            this.tbvalue.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "Valor";
            // 
            // additemtext
            // 
            this.additemtext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.additemtext.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.additemtext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.additemtext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.additemtext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.additemtext.ForeColor = System.Drawing.Color.White;
            this.additemtext.Location = new System.Drawing.Point(250, 303);
            this.additemtext.Name = "additemtext";
            this.additemtext.Size = new System.Drawing.Size(101, 23);
            this.additemtext.TabIndex = 67;
            this.additemtext.Text = "Adicionar função";
            this.additemtext.UseVisualStyleBackColor = true;
            this.additemtext.Click += new System.EventHandler(this.additemtext_Click);
            // 
            // cbclose
            // 
            this.cbclose.AutoSize = true;
            this.cbclose.Location = new System.Drawing.Point(11, 307);
            this.cbclose.Name = "cbclose";
            this.cbclose.Size = new System.Drawing.Size(155, 17);
            this.cbclose.TabIndex = 68;
            this.cbclose.Text = "Fechar assim que adicionar";
            this.cbclose.UseVisualStyleBackColor = true;
            // 
            // AddInputlv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(363, 338);
            this.Controls.Add(this.cbclose);
            this.Controls.Add(this.additemtext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbvalue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbelementt);
            this.Controls.Add(this.labelvaluer);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.labelclass);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.tbclass);
            this.Controls.Add(this.tbvalueattr);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.attrelementt);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddInputlv";
            this.Text = "Adicionar nova entrada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox attrelementt;
        public System.Windows.Forms.TextBox tbid;
        public System.Windows.Forms.TextBox tbname;
        public System.Windows.Forms.TextBox tbvalueattr;
        public System.Windows.Forms.TextBox tbclass;
        private System.Windows.Forms.Label labelvaluer;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelclass;
        private System.Windows.Forms.Label labelid;
        public System.Windows.Forms.TextBox tbelementt;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.RichTextBox tbvalue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button additemtext;
        private System.Windows.Forms.CheckBox cbclose;
    }
}