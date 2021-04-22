namespace ProgramManage
{
    partial class ChangeReplacelv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeReplacelv));
            this.label3 = new System.Windows.Forms.Label();
            this.tbnevalue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboldvalue = new System.Windows.Forms.TextBox();
            this.labelclassb = new System.Windows.Forms.Label();
            this.tbattr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbelementb = new System.Windows.Forms.TextBox();
            this.additembutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 116;
            this.label3.Text = "Valor novo";
            // 
            // tbnevalue
            // 
            this.tbnevalue.Location = new System.Drawing.Point(132, 146);
            this.tbnevalue.Name = "tbnevalue";
            this.tbnevalue.Size = new System.Drawing.Size(116, 20);
            this.tbnevalue.TabIndex = 115;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 114;
            this.label2.Text = "Valor velho";
            // 
            // tboldvalue
            // 
            this.tboldvalue.Location = new System.Drawing.Point(132, 102);
            this.tboldvalue.Name = "tboldvalue";
            this.tboldvalue.Size = new System.Drawing.Size(116, 20);
            this.tboldvalue.TabIndex = 113;
            // 
            // labelclassb
            // 
            this.labelclassb.AutoSize = true;
            this.labelclassb.Location = new System.Drawing.Point(12, 19);
            this.labelclassb.Name = "labelclassb";
            this.labelclassb.Size = new System.Drawing.Size(103, 13);
            this.labelclassb.TabIndex = 109;
            this.labelclassb.Text = "atributo do elemento";
            // 
            // tbattr
            // 
            this.tbattr.Location = new System.Drawing.Point(134, 12);
            this.tbattr.Name = "tbattr";
            this.tbattr.Size = new System.Drawing.Size(116, 20);
            this.tbattr.TabIndex = 108;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 106;
            this.label8.Text = "elemento";
            // 
            // tbelementb
            // 
            this.tbelementb.Location = new System.Drawing.Point(132, 49);
            this.tbelementb.Name = "tbelementb";
            this.tbelementb.Size = new System.Drawing.Size(116, 20);
            this.tbelementb.TabIndex = 105;
            // 
            // additembutton
            // 
            this.additembutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.additembutton.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.additembutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.additembutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.additembutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.additembutton.ForeColor = System.Drawing.Color.White;
            this.additembutton.Location = new System.Drawing.Point(72, 192);
            this.additembutton.Name = "additembutton";
            this.additembutton.Size = new System.Drawing.Size(167, 23);
            this.additembutton.TabIndex = 104;
            this.additembutton.Text = "Alterar ";
            this.additembutton.UseVisualStyleBackColor = true;
            this.additembutton.Click += new System.EventHandler(this.additembutton_Click);
            // 
            // ChangeReplacelv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(321, 227);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbnevalue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboldvalue);
            this.Controls.Add(this.labelclassb);
            this.Controls.Add(this.tbattr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbelementb);
            this.Controls.Add(this.additembutton);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeReplacelv";
            this.Text = "Alterar função replace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbnevalue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboldvalue;
        private System.Windows.Forms.Label labelclassb;
        private System.Windows.Forms.TextBox tbattr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbelementb;
        private System.Windows.Forms.Button additembutton;
    }
}