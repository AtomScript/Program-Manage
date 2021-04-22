namespace ProgramManage
{
    partial class AddClicklv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClicklv));
            this.cbclose = new System.Windows.Forms.CheckBox();
            this.attrelementb = new System.Windows.Forms.ComboBox();
            this.labelvalueb = new System.Windows.Forms.Label();
            this.tbvalueb = new System.Windows.Forms.TextBox();
            this.labelnameb = new System.Windows.Forms.Label();
            this.labelclassb = new System.Windows.Forms.Label();
            this.tbnameb = new System.Windows.Forms.TextBox();
            this.tbclassb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbelementb = new System.Windows.Forms.TextBox();
            this.additembutton = new System.Windows.Forms.Button();
            this.tbidbutton = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbkeys = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbclose
            // 
            this.cbclose.AutoSize = true;
            this.cbclose.Location = new System.Drawing.Point(25, 182);
            this.cbclose.Name = "cbclose";
            this.cbclose.Size = new System.Drawing.Size(155, 17);
            this.cbclose.TabIndex = 69;
            this.cbclose.Text = "Fechar assim que adicionar";
            this.cbclose.UseVisualStyleBackColor = true;
            // 
            // attrelementb
            // 
            this.attrelementb.FormattingEnabled = true;
            this.attrelementb.Items.AddRange(new object[] {
            "Id",
            "Class",
            "Name",
            "Value"});
            this.attrelementb.Location = new System.Drawing.Point(125, 12);
            this.attrelementb.Name = "attrelementb";
            this.attrelementb.Size = new System.Drawing.Size(121, 21);
            this.attrelementb.TabIndex = 70;
            this.attrelementb.SelectedIndexChanged += new System.EventHandler(this.attrelementb_SelectedIndexChanged);
            // 
            // labelvalueb
            // 
            this.labelvalueb.AutoSize = true;
            this.labelvalueb.Location = new System.Drawing.Point(31, 73);
            this.labelvalueb.Name = "labelvalueb";
            this.labelvalueb.Size = new System.Drawing.Size(94, 13);
            this.labelvalueb.TabIndex = 82;
            this.labelvalueb.Text = "value do elemento";
            this.labelvalueb.Visible = false;
            // 
            // tbvalueb
            // 
            this.tbvalueb.Location = new System.Drawing.Point(125, 70);
            this.tbvalueb.Name = "tbvalueb";
            this.tbvalueb.Size = new System.Drawing.Size(116, 20);
            this.tbvalueb.TabIndex = 81;
            this.tbvalueb.Visible = false;
            // 
            // labelnameb
            // 
            this.labelnameb.AutoSize = true;
            this.labelnameb.Location = new System.Drawing.Point(31, 73);
            this.labelnameb.Name = "labelnameb";
            this.labelnameb.Size = new System.Drawing.Size(94, 13);
            this.labelnameb.TabIndex = 80;
            this.labelnameb.Text = "name do elemento";
            this.labelnameb.Visible = false;
            // 
            // labelclassb
            // 
            this.labelclassb.AutoSize = true;
            this.labelclassb.Location = new System.Drawing.Point(31, 77);
            this.labelclassb.Name = "labelclassb";
            this.labelclassb.Size = new System.Drawing.Size(92, 13);
            this.labelclassb.TabIndex = 79;
            this.labelclassb.Text = "class do elemento";
            this.labelclassb.Visible = false;
            // 
            // tbnameb
            // 
            this.tbnameb.Location = new System.Drawing.Point(125, 70);
            this.tbnameb.Name = "tbnameb";
            this.tbnameb.Size = new System.Drawing.Size(116, 20);
            this.tbnameb.TabIndex = 78;
            this.tbnameb.Visible = false;
            // 
            // tbclassb
            // 
            this.tbclassb.Location = new System.Drawing.Point(125, 70);
            this.tbclassb.Name = "tbclassb";
            this.tbclassb.Size = new System.Drawing.Size(116, 20);
            this.tbclassb.TabIndex = 77;
            this.tbclassb.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 75;
            this.label8.Text = "elemento";
            // 
            // tbelementb
            // 
            this.tbelementb.Location = new System.Drawing.Point(125, 104);
            this.tbelementb.Name = "tbelementb";
            this.tbelementb.Size = new System.Drawing.Size(116, 20);
            this.tbelementb.TabIndex = 74;
            // 
            // additembutton
            // 
            this.additembutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.additembutton.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.additembutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.additembutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.additembutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.additembutton.ForeColor = System.Drawing.Color.White;
            this.additembutton.Location = new System.Drawing.Point(186, 182);
            this.additembutton.Name = "additembutton";
            this.additembutton.Size = new System.Drawing.Size(167, 23);
            this.additembutton.TabIndex = 73;
            this.additembutton.Text = "Adicionar função click";
            this.additembutton.UseVisualStyleBackColor = true;
            this.additembutton.Click += new System.EventHandler(this.additembutton_Click);
            // 
            // tbidbutton
            // 
            this.tbidbutton.Location = new System.Drawing.Point(125, 70);
            this.tbidbutton.Name = "tbidbutton";
            this.tbidbutton.Size = new System.Drawing.Size(116, 20);
            this.tbidbutton.TabIndex = 71;
            this.tbidbutton.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "id do elemento";
            this.label1.Visible = false;
            // 
            // tbkeys
            // 
            this.tbkeys.Location = new System.Drawing.Point(125, 138);
            this.tbkeys.Name = "tbkeys";
            this.tbkeys.Size = new System.Drawing.Size(116, 20);
            this.tbkeys.TabIndex = 83;
            this.tbkeys.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbkeys_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 84;
            this.label2.Text = "Keys Code";
            // 
            // AddClicklv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(365, 221);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbkeys);
            this.Controls.Add(this.labelvalueb);
            this.Controls.Add(this.tbvalueb);
            this.Controls.Add(this.labelnameb);
            this.Controls.Add(this.labelclassb);
            this.Controls.Add(this.tbnameb);
            this.Controls.Add(this.tbclassb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbelementb);
            this.Controls.Add(this.additembutton);
            this.Controls.Add(this.tbidbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.attrelementb);
            this.Controls.Add(this.cbclose);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddClicklv";
            this.Text = "Adicionar função click";
            this.Load += new System.EventHandler(this.AddClicklv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbclose;
        private System.Windows.Forms.ComboBox attrelementb;
        private System.Windows.Forms.Label labelvalueb;
        private System.Windows.Forms.TextBox tbvalueb;
        private System.Windows.Forms.Label labelnameb;
        private System.Windows.Forms.Label labelclassb;
        private System.Windows.Forms.TextBox tbnameb;
        private System.Windows.Forms.TextBox tbclassb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbelementb;
        private System.Windows.Forms.Button additembutton;
        private System.Windows.Forms.TextBox tbidbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbkeys;
        private System.Windows.Forms.Label label2;
    }
}