namespace LET_Auftragsverwaltung
{
    partial class UC_Chronologie
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
            this.lbx_chron = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_filt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbx_chron
            // 
            this.lbx_chron.FormattingEnabled = true;
            this.lbx_chron.Location = new System.Drawing.Point(3, 30);
            this.lbx_chron.Name = "lbx_chron";
            this.lbx_chron.Size = new System.Drawing.Size(358, 290);
            this.lbx_chron.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(240, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_filt
            // 
            this.lbl_filt.AutoSize = true;
            this.lbl_filt.Location = new System.Drawing.Point(195, 6);
            this.lbl_filt.Name = "lbl_filt";
            this.lbl_filt.Size = new System.Drawing.Size(29, 13);
            this.lbl_filt.TabIndex = 2;
            this.lbl_filt.Text = "Filter";
            // 
            // UC_Chronologie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_filt);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbx_chron);
            this.Name = "UC_Chronologie";
            this.Size = new System.Drawing.Size(366, 335);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_chron;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_filt;
    }
}
