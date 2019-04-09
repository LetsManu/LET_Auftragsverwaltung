namespace LET_Auftragsverwaltung
{
    partial class Form_Best
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
            this.uC_Best = new LET_Auftragsverwaltung.UC_Best(a_ID);
            //this.uC_Best = new LET_Auftragsverwaltung.UC_Best(1);  
            //DESIGN Form_Best
            this.SuspendLayout();
            // 
            // uC_Best1
            // 
            this.uC_Best.Location = new System.Drawing.Point(12, 12);
            this.uC_Best.Name = "uC_Best1";
            this.uC_Best.Size = new System.Drawing.Size(401, 139);
            this.uC_Best.TabIndex = 0;
            // 
            // Form_Best
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 138);
            this.Controls.Add(this.uC_Best);
            this.Name = "Form_Best";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private UC_Best uC_Best;
    }
}