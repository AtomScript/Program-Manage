namespace ProgramManage
{
    partial class AddCustomlv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomlv));
            this.tbelement = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCustom = new System.Windows.Forms.Button();
            this.tbfunction = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbclose = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbelement
            // 
            this.tbelement.Location = new System.Drawing.Point(68, 37);
            this.tbelement.Name = "tbelement";
            this.tbelement.Size = new System.Drawing.Size(353, 20);
            this.tbelement.TabIndex = 0;
            this.tbelement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbnumber_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "elemento";
            // 
            // btnAddCustom
            // 
            this.btnAddCustom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddCustom.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnAddCustom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btnAddCustom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.btnAddCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustom.ForeColor = System.Drawing.Color.White;
            this.btnAddCustom.Location = new System.Drawing.Point(211, 138);
            this.btnAddCustom.Name = "btnAddCustom";
            this.btnAddCustom.Size = new System.Drawing.Size(201, 29);
            this.btnAddCustom.TabIndex = 39;
            this.btnAddCustom.Text = "Adicioanar";
            this.btnAddCustom.UseVisualStyleBackColor = true;
            this.btnAddCustom.Click += new System.EventHandler(this.btnAddCustom_Click);
            // 
            // tbfunction
            // 
            this.tbfunction.Location = new System.Drawing.Point(68, 81);
            this.tbfunction.Name = "tbfunction";
            this.tbfunction.Size = new System.Drawing.Size(353, 20);
            this.tbfunction.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Função";
            // 
            // cbclose
            // 
            this.cbclose.AutoSize = true;
            this.cbclose.Location = new System.Drawing.Point(12, 145);
            this.cbclose.Name = "cbclose";
            this.cbclose.Size = new System.Drawing.Size(155, 17);
            this.cbclose.TabIndex = 42;
            this.cbclose.Text = "Fechar assim que adicionar";
            this.cbclose.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(95, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 29);
            this.button1.TabIndex = 43;
            this.button1.Text = "Adicioanar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddCustomlv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(424, 182);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbclose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbfunction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddCustom);
            this.Controls.Add(this.tbelement);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCustomlv";
            this.Text = "Adicionar função customizada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbelement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCustom;
        private System.Windows.Forms.TextBox tbfunction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbclose;
        private System.Windows.Forms.Button button1;
    }
}