namespace LET_Auftragsverwaltung
{
    partial class UC_Overview
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
            this.oLV_Overview = new BrightIdeasSoftware.ObjectListView();
            this.oLV_Cl_Fertigungsstatus = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.oLV_Cl_Projektbezeichnung = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.oLV_Cl_Auftrags_Nr = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.oLV_Cl_Projektverantwortlicher_Name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.oLV_Cl_Planner_Name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.oLV_Cl_Verkäufer_Name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.oLV_Cl_Erstell_Date = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.oLV_Cl_Monatge_Date = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tmr_250ms = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.oLV_Overview)).BeginInit();
            this.SuspendLayout();
            // 
            // oLV_Overview
            // 
            this.oLV_Overview.AllColumns.Add(this.oLV_Cl_Fertigungsstatus);
            this.oLV_Overview.AllColumns.Add(this.oLV_Cl_Projektbezeichnung);
            this.oLV_Overview.AllColumns.Add(this.oLV_Cl_Auftrags_Nr);
            this.oLV_Overview.AllColumns.Add(this.oLV_Cl_Projektverantwortlicher_Name);
            this.oLV_Overview.AllColumns.Add(this.oLV_Cl_Planner_Name);
            this.oLV_Overview.AllColumns.Add(this.oLV_Cl_Verkäufer_Name);
            this.oLV_Overview.AllColumns.Add(this.oLV_Cl_Erstell_Date);
            this.oLV_Overview.AllColumns.Add(this.oLV_Cl_Monatge_Date);
            this.oLV_Overview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oLV_Overview.CellEditUseWholeCell = false;
            this.oLV_Overview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.oLV_Cl_Fertigungsstatus,
            this.oLV_Cl_Projektbezeichnung,
            this.oLV_Cl_Auftrags_Nr,
            this.oLV_Cl_Projektverantwortlicher_Name,
            this.oLV_Cl_Planner_Name,
            this.oLV_Cl_Verkäufer_Name,
            this.oLV_Cl_Erstell_Date,
            this.oLV_Cl_Monatge_Date});
            this.oLV_Overview.Cursor = System.Windows.Forms.Cursors.Default;
            this.oLV_Overview.Location = new System.Drawing.Point(-3, 0);
            this.oLV_Overview.Name = "oLV_Overview";
            this.oLV_Overview.Size = new System.Drawing.Size(911, 569);
            this.oLV_Overview.TabIndex = 1;
            this.oLV_Overview.UseCompatibleStateImageBehavior = false;
            this.oLV_Overview.View = System.Windows.Forms.View.Details;
            this.oLV_Overview.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.objectListView1_FormatCell);
            this.oLV_Overview.DoubleClick += new System.EventHandler(this.objectListView1_DoubleClick);
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
            this.oLV_Cl_Projektbezeichnung.Width = 159;
            // 
            // oLV_Cl_Auftrags_Nr
            // 
            this.oLV_Cl_Auftrags_Nr.AspectName = "Auftrags_Nr";
            this.oLV_Cl_Auftrags_Nr.Text = "Auftrags Nr";
            this.oLV_Cl_Auftrags_Nr.Width = 87;
            // 
            // oLV_Cl_Projektverantwortlicher_Name
            // 
            this.oLV_Cl_Projektverantwortlicher_Name.AspectName = "Projektverantwortlicher_Name";
            this.oLV_Cl_Projektverantwortlicher_Name.Text = "Projektverantwortlicher";
            this.oLV_Cl_Projektverantwortlicher_Name.Width = 126;
            // 
            // oLV_Cl_Planner_Name
            // 
            this.oLV_Cl_Planner_Name.AspectName = "Planner_Name";
            this.oLV_Cl_Planner_Name.Text = "Planner";
            this.oLV_Cl_Planner_Name.Width = 118;
            // 
            // oLV_Cl_Verkäufer_Name
            // 
            this.oLV_Cl_Verkäufer_Name.AspectName = "Verkäufer_Name";
            this.oLV_Cl_Verkäufer_Name.Text = "Verkäufer";
            this.oLV_Cl_Verkäufer_Name.Width = 122;
            // 
            // oLV_Cl_Erstell_Date
            // 
            this.oLV_Cl_Erstell_Date.AspectName = "Erstell_datum";
            this.oLV_Cl_Erstell_Date.Text = "Erstell Datum";
            this.oLV_Cl_Erstell_Date.Width = 88;
            // 
            // oLV_Cl_Monatge_Date
            // 
            this.oLV_Cl_Monatge_Date.AspectName = "Montage_Datum";
            this.oLV_Cl_Monatge_Date.Text = "Monatge Datum";
            this.oLV_Cl_Monatge_Date.Width = 101;
            // 
            // tmr_250ms
            // 
            this.tmr_250ms.Enabled = true;
            this.tmr_250ms.Interval = 250;
            this.tmr_250ms.Tick += new System.EventHandler(this.tmr_250ms_Tick);
            // 
            // UC_Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.oLV_Overview);
            this.Name = "UC_Overview";
            this.Size = new System.Drawing.Size(908, 569);
            ((System.ComponentModel.ISupportInitialize)(this.oLV_Overview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BrightIdeasSoftware.ObjectListView oLV_Overview;
        private BrightIdeasSoftware.OLVColumn oLV_Cl_Auftrags_Nr;
        private BrightIdeasSoftware.OLVColumn oLV_Cl_Fertigungsstatus;
        private BrightIdeasSoftware.OLVColumn oLV_Cl_Projektverantwortlicher_Name;
        private BrightIdeasSoftware.OLVColumn oLV_Cl_Planner_Name;
        private BrightIdeasSoftware.OLVColumn oLV_Cl_Projektbezeichnung;
        private BrightIdeasSoftware.OLVColumn oLV_Cl_Verkäufer_Name;
        private System.Windows.Forms.Timer tmr_250ms;
        private BrightIdeasSoftware.OLVColumn oLV_Cl_Erstell_Date;
        private BrightIdeasSoftware.OLVColumn oLV_Cl_Monatge_Date;
    }
}
