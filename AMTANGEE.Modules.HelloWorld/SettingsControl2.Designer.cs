namespace AMTANGEE.Modules.HelloWorld
{
    partial class SettingsControl2
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.edtValue4 = new System.Windows.Forms.TextBox();
            this.edtValue5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edtValue6 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wert #4";
            // 
            // edtValue4
            // 
            this.edtValue4.Location = new System.Drawing.Point(26, 43);
            this.edtValue4.Name = "edtValue4";
            this.edtValue4.Size = new System.Drawing.Size(252, 20);
            this.edtValue4.TabIndex = 1;
            this.edtValue4.TextChanged += new System.EventHandler(this.edtValue1_TextChanged);
            // 
            // edtValue5
            // 
            this.edtValue5.Location = new System.Drawing.Point(26, 91);
            this.edtValue5.Name = "edtValue5";
            this.edtValue5.Size = new System.Drawing.Size(252, 20);
            this.edtValue5.TabIndex = 3;
            this.edtValue5.TextChanged += new System.EventHandler(this.edtValue1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wert #5";
            // 
            // edtValue6
            // 
            this.edtValue6.Location = new System.Drawing.Point(26, 137);
            this.edtValue6.Name = "edtValue6";
            this.edtValue6.Size = new System.Drawing.Size(252, 20);
            this.edtValue6.TabIndex = 5;
            this.edtValue6.TextChanged += new System.EventHandler(this.edtValue1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Wert #6";
            // 
            // SettingsControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.edtValue6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edtValue5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edtValue4);
            this.Controls.Add(this.label1);
            this.Name = "SettingsControl2";
            this.Size = new System.Drawing.Size(452, 253);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtValue4;
        private System.Windows.Forms.TextBox edtValue5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtValue6;
        private System.Windows.Forms.Label label3;
    }
}
