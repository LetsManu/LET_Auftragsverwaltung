namespace LET_Auftragsverwaltung
{
    partial class Form_New_Auftrag
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
            this.uC_New_auftrag1 = new LET_Auftragsverwaltung.UC_New_auftrag();
            this.SuspendLayout();
            // 
            // uC_New_auftrag1
            // 
            this.uC_New_auftrag1.Location = new System.Drawing.Point(-5, -42);
            this.uC_New_auftrag1.Name = "uC_New_auftrag1";
            this.uC_New_auftrag1.Size = new System.Drawing.Size(837, 452);
            this.uC_New_auftrag1.TabIndex = 0;
            // 
            // Form_New_Auftrag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 353);
            this.Controls.Add(this.uC_New_auftrag1);
            this.Name = "Form_New_Auftrag";
            this.Text = "Form_New_Auftrag";
            this.ResumeLayout(false);

        }

        #endregion

        private UC_New_auftrag uC_New_auftrag1;
    }
}