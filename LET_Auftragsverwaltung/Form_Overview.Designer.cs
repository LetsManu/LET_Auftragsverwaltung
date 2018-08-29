namespace LET_Auftragsverwaltung
{
    partial class Form_Overview
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
            this.uC_Overview1 = new LET_Auftragsverwaltung.UC_Overview();
            this.SuspendLayout();
            // 
            // uC_Overview1
            // 
            this.uC_Overview1.Location = new System.Drawing.Point(1, 1);
            this.uC_Overview1.Name = "uC_Overview1";
            this.uC_Overview1.Size = new System.Drawing.Size(1920, 1080);
            this.uC_Overview1.TabIndex = 0;
            // 
            // Form_Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.uC_Overview1);
            this.Name = "Form_Overview";
            this.Text = "Form_Overview";
            this.ResumeLayout(false);

        }

        #endregion

        private UC_Overview uC_Overview1;
    }
}