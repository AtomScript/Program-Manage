namespace ProgramManage
{
    partial class Changelvb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Changelvb));
            this.tbidc = new System.Windows.Forms.TextBox();
            this.tbelement = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.changeitem = new System.Windows.Forms.Button();
            this.tbtype = new System.Windows.Forms.TextBox();
            this.labeltype = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbidc
            // 
            this.tbidc.Location = new System.Drawing.Point(88, 9);
            this.tbidc.Name = "tbidc";
            this.tbidc.Size = new System.Drawing.Size(189, 20);
            this.tbidc.TabIndex = 42;
            // 
            // tbelement
            // 
            this.tbelement.Location = new System.Drawing.Point(88, 49);
            this.tbelement.Name = "tbelement";
            this.tbelement.Size = new System.Drawing.Size(189, 20);
            this.tbelement.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "id do elemento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "elemento";
            // 
            // changeitem
            // 
            this.changeitem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.changeitem.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.changeitem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.changeitem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.changeitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeitem.ForeColor = System.Drawing.Color.White;
            this.changeitem.Location = new System.Drawing.Point(117, 150);
            this.changeitem.Name = "changeitem";
            this.changeitem.Size = new System.Drawing.Size(117, 23);
            this.changeitem.TabIndex = 51;
            this.changeitem.Text = "Alterar";
            this.changeitem.UseVisualStyleBackColor = true;
            this.changeitem.Click += new System.EventHandler(this.changeitem_Click);
            // 
            // tbtype
            // 
            this.tbtype.Location = new System.Drawing.Point(88, 95);
            this.tbtype.Name = "tbtype";
            this.tbtype.Size = new System.Drawing.Size(189, 20);
            this.tbtype.TabIndex = 52;
            this.tbtype.Visible = false;
            this.tbtype.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbtype_KeyPress);
            // 
            // labeltype
            // 
            this.labeltype.AutoSize = true;
            this.labeltype.Location = new System.Drawing.Point(12, 98);
            this.labeltype.Name = "labeltype";
            this.labeltype.Size = new System.Drawing.Size(53, 13);
            this.labeltype.TabIndex = 53;
            this.labeltype.Text = "Key Code";
            this.labeltype.Visible = false;
            // 
            // Changelvb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(372, 185);
            this.Controls.Add(this.labeltype);
            this.Controls.Add(this.tbtype);
            this.Controls.Add(this.changeitem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbelement);
            this.Controls.Add(this.tbidc);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Changelvb";
            this.Text = "Alterar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbidc;
        private System.Windows.Forms.TextBox tbelement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button changeitem;
        private System.Windows.Forms.TextBox tbtype;
        private System.Windows.Forms.Label labeltype;
    }
}