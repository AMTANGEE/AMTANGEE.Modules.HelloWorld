namespace AMTANGEE.Modules.HelloWorld
{
    partial class SettingsControl
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
            this.edtValue1 = new System.Windows.Forms.TextBox();
            this.edtValue2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edtValue3 = new System.Windows.Forms.TextBox();
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
            this.label1.Text = "Wert #1";
            // 
            // edtValue1
            // 
            this.edtValue1.Location = new System.Drawing.Point(26, 43);
            this.edtValue1.Name = "edtValue1";
            this.edtValue1.Size = new System.Drawing.Size(252, 20);
            this.edtValue1.TabIndex = 1;
            this.edtValue1.TextChanged += new System.EventHandler(this.edtValue1_TextChanged);
            // 
            // edtValue2
            // 
            this.edtValue2.Location = new System.Drawing.Point(26, 91);
            this.edtValue2.Name = "edtValue2";
            this.edtValue2.Size = new System.Drawing.Size(252, 20);
            this.edtValue2.TabIndex = 3;
            this.edtValue2.TextChanged += new System.EventHandler(this.edtValue1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wert #2";
            // 
            // edtValue3
            // 
            this.edtValue3.Location = new System.Drawing.Point(26, 137);
            this.edtValue3.Name = "edtValue3";
            this.edtValue3.Size = new System.Drawing.Size(252, 20);
            this.edtValue3.TabIndex = 5;
            this.edtValue3.TextChanged += new System.EventHandler(this.edtValue1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Wert #3";
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.edtValue3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edtValue2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edtValue1);
            this.Controls.Add(this.label1);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(452, 253);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtValue1;
        private System.Windows.Forms.TextBox edtValue2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtValue3;
        private System.Windows.Forms.Label label3;
    }
}
