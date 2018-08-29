namespace LET_Auftragsverwaltung
{
    partial class Form_Parameter
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
            this.uC_Parameter1 = new LET_Auftragsverwaltung.UC_Parameter();
            this.SuspendLayout();
            // 
            // uC_Parameter1
            // 
            this.uC_Parameter1.Location = new System.Drawing.Point(2, 1);
            this.uC_Parameter1.Name = "uC_Parameter1";
            this.uC_Parameter1.Size = new System.Drawing.Size(870, 449);
            this.uC_Parameter1.TabIndex = 0;
            // 
            // Form_Parameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.uC_Parameter1);
            this.Name = "Form_Parameter";
            this.Text = "Form_Parameter";
            this.ResumeLayout(false);

        }

        #endregion

        private UC_Parameter uC_Parameter1;
    }
}