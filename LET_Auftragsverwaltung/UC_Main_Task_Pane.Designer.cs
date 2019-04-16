namespace LET_Auftragsverwaltung
{
    partial class UC_Main_Task_Pane
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMI_Uebersicht = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_new_Auftrag = new System.Windows.Forms.ToolStripMenuItem();
            this.tti_main_pane = new System.Windows.Forms.ToolTip(this.components);
            this.TSMI_DB = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Uebersicht,
            this.TSMI_new_Auftrag,
            this.TSMI_DB});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(430, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMI_Uebersicht
            // 
            this.TSMI_Uebersicht.Name = "TSMI_Uebersicht";
            this.TSMI_Uebersicht.Size = new System.Drawing.Size(69, 20);
            this.TSMI_Uebersicht.Text = "Übersicht";
            this.TSMI_Uebersicht.ToolTipText = "Öffnet die Übersicht aller Auftrage.\r\nBearbeitung der Aufträge ist hier möglich.\r" +
    "\n";
            this.TSMI_Uebersicht.Click += new System.EventHandler(this.TSMI_Overview_Click);
            // 
            // TSMI_new_Auftrag
            // 
            this.TSMI_new_Auftrag.Name = "TSMI_new_Auftrag";
            this.TSMI_new_Auftrag.Size = new System.Drawing.Size(142, 20);
            this.TSMI_new_Auftrag.Text = "Neuen Auftrag anlegen";
            this.TSMI_new_Auftrag.ToolTipText = "Datebank änderung\r\nEintragung eines neuen Auftrags\r\nExport von Tabellen\r\n";
            this.TSMI_new_Auftrag.Click += new System.EventHandler(this.TSMI_new_Auftrag_Click);
            // 
            // TSMI_DB
            // 
            this.TSMI_DB.Name = "TSMI_DB";
            this.TSMI_DB.Size = new System.Drawing.Size(109, 20);
            this.TSMI_DB.Text = "Datenbankpflege";
            this.TSMI_DB.Click += new System.EventHandler(this.TSMI_DB_Click);
            // 
            // UC_Main_Task_Pane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.menuStrip1);
            this.Name = "UC_Main_Task_Pane";
            this.Size = new System.Drawing.Size(430, 569);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Uebersicht;
        private System.Windows.Forms.ToolStripMenuItem TSMI_new_Auftrag;
        private System.Windows.Forms.ToolTip tti_main_pane;
        private System.Windows.Forms.ToolStripMenuItem TSMI_DB;
    }
}
