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
            if (disposing && ( components != null ))
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
        private void InitializeComponent( )
        {
            this.components = new System.ComponentModel.Container();
            this.btn_print = new System.Windows.Forms.Button();
            this.tmr_100ms = new System.Windows.Forms.Timer(this.components);
            this.uC_Overview1 = new LET_Auftragsverwaltung.UC_Overview();
            this.SuspendLayout();
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(1720, 973);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(152, 26);
            this.btn_print.TabIndex = 1;
            this.btn_print.Text = "Drucken / PDF";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // tmr_100ms
            // 
            this.tmr_100ms.Enabled = true;
            this.tmr_100ms.Tick += new System.EventHandler(this.tmr_100ms_Tick);
            // 
            // uC_Overview1
            // 
            this.uC_Overview1.Location = new System.Drawing.Point(-1, -1);
            this.uC_Overview1.Name = "uC_Overview1";
            this.uC_Overview1.Size = new System.Drawing.Size(1885, 1013);
            this.uC_Overview1.TabIndex = 0;
            // 
            // Form_Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1884, 1011);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.uC_Overview1);
            this.Name = "Form_Overview";
            this.Text = "Overview";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Overview_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Overview_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private UC_Overview uC_Overview1;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Timer tmr_100ms;
    }
}