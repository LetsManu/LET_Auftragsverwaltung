namespace LET_Auftragsverwaltung
{
    partial class Form_Edit_Auftrag
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
            this.uC_edit_Auftrag2 = new LET_Auftragsverwaltung.UC_edit_Auftrag(this.test_id);
            this.SuspendLayout();
            // 
            // uC_edit_Auftrag2
            // 
            this.uC_edit_Auftrag2.Location = new System.Drawing.Point(-1, -2);
            this.uC_edit_Auftrag2.Name = "uC_edit_Auftrag2";
            this.uC_edit_Auftrag2.Size = new System.Drawing.Size(1190, 398);
            this.uC_edit_Auftrag2.TabIndex = 0;
            // 
            // Form_Edit_Auftrag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 396);
          //TODO  this.Controls.Add(this.uC_edit_Auftrag2);
            this.Name = "Form_Edit_Auftrag";
            this.Text = "Form_Edit_Auftrag";
            this.Leave += new System.EventHandler(this.Form_Edit_Auftrag_Leave);
            this.ResumeLayout(false);

        }

        #endregion

        private UC_edit_Auftrag uC_edit_Auftrag1;
        private UC_edit_Auftrag uC_edit_Auftrag2;
    }
}