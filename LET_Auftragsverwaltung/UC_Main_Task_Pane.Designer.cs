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
            this.TSMI_DB = new System.Windows.Forms.ToolStripMenuItem();
            this.tti_main_pane = new System.Windows.Forms.ToolTip(this.components);
            this.oLV_Overview = new BrightIdeasSoftware.ObjectListView();
            this.oLV_Cl_Fertigungsstatus = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.oLV_Cl_Projektbezeichnung = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.oLV_Cl_Auftrags_Nr = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tmr_250ms = new System.Windows.Forms.Timer(this.components);
            this.tmr_10s = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oLV_Overview)).BeginInit();
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
            // oLV_Overview
            // 
            this.oLV_Overview.AllColumns.Add(this.oLV_Cl_Fertigungsstatus);
            this.oLV_Overview.AllColumns.Add(this.oLV_Cl_Projektbezeichnung);
            this.oLV_Overview.AllColumns.Add(this.oLV_Cl_Auftrags_Nr);
            this.oLV_Overview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oLV_Overview.CellEditUseWholeCell = false;
            this.oLV_Overview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.oLV_Cl_Fertigungsstatus,
            this.oLV_Cl_Projektbezeichnung,
            this.oLV_Cl_Auftrags_Nr});
            this.oLV_Overview.Cursor = System.Windows.Forms.Cursors.Default;
            this.oLV_Overview.Location = new System.Drawing.Point(0, 27);
            this.oLV_Overview.Name = "oLV_Overview";
            this.oLV_Overview.Size = new System.Drawing.Size(430, 542);
            this.oLV_Overview.TabIndex = 2;
            this.oLV_Overview.UseCompatibleStateImageBehavior = false;
            this.oLV_Overview.View = System.Windows.Forms.View.Details;
            this.oLV_Overview.DoubleClick += new System.EventHandler(this.OLV_Overview_DoubleClick);
            // 
            // oLV_Cl_Fertigungsstatus
            // 
            this.oLV_Cl_Fertigungsstatus.AspectName = "Fertigungsstatus";
            this.oLV_Cl_Fertigungsstatus.Text = "Fertigungsstatus";
            this.oLV_Cl_Fertigungsstatus.Width = 101;
            // 
            // oLV_Cl_Projektbezeichnung
            // 
            this.oLV_Cl_Projektbezeichnung.AspectName = "Projektbezeichnung";
            this.oLV_Cl_Projektbezeichnung.Text = "Projektbezeichnung";
            this.oLV_Cl_Projektbezeichnung.Width = 238;
            // 
            // oLV_Cl_Auftrags_Nr
            // 
            this.oLV_Cl_Auftrags_Nr.AspectName = "Auftrags_Nr";
            this.oLV_Cl_Auftrags_Nr.Text = "Auftrags Nr";
            this.oLV_Cl_Auftrags_Nr.Width = 87;
            // 
            // tmr_250ms
            // 
            this.tmr_250ms.Enabled = true;
            this.tmr_250ms.Interval = 250;
            this.tmr_250ms.Tick += new System.EventHandler(this.Tmr_250ms_Tick);
            // 
            // tmr_10s
            // 
            this.tmr_10s.Enabled = true;
            this.tmr_10s.Interval = 10000;
            this.tmr_10s.Tick += new System.EventHandler(this.Tmr_10s_Tick);
            // 
            // UC_Main_Task_Pane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.oLV_Overview);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UC_Main_Task_Pane";
            this.Size = new System.Drawing.Size(430, 569);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oLV_Overview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Uebersicht;
        private System.Windows.Forms.ToolStripMenuItem TSMI_new_Auftrag;
        private System.Windows.Forms.ToolTip tti_main_pane;
        private System.Windows.Forms.ToolStripMenuItem TSMI_DB;
        private BrightIdeasSoftware.ObjectListView oLV_Overview;
        private BrightIdeasSoftware.OLVColumn oLV_Cl_Fertigungsstatus;
        private BrightIdeasSoftware.OLVColumn oLV_Cl_Projektbezeichnung;
        private BrightIdeasSoftware.OLVColumn oLV_Cl_Auftrags_Nr;
        private System.Windows.Forms.Timer tmr_250ms;
        private System.Windows.Forms.Timer tmr_10s;
    }
}
