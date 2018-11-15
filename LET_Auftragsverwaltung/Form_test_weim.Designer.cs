namespace LET_Auftragsverwaltung
{
    partial class Form_test_weim
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
            this.uC_edit_Kauf1 = new LET_Auftragsverwaltung.UC_edit_Kauf();
            this.SuspendLayout();
            // 
            // uC_edit_Kauf1
            // 
            this.uC_edit_Kauf1.Location = new System.Drawing.Point(12, 12);
            this.uC_edit_Kauf1.Name = "uC_edit_Kauf1";
            this.uC_edit_Kauf1.Size = new System.Drawing.Size(903, 311);
            this.uC_edit_Kauf1.TabIndex = 0;
            // 
            // From_test_weim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 450);
            this.Controls.Add(this.uC_edit_Kauf1);
            this.Name = "From_test_weim";
            this.Text = "From_test_weim";
            this.ResumeLayout(false);

        }

        #endregion

        private UC_edit_Kauf uC_edit_Kauf1;
    }
}