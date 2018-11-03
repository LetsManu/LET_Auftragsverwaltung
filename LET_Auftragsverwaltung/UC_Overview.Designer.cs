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
            this.oLV_Cl_Auftrags_Nr = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.oLV_Cl_Projektbezeichnung = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.oLV_Cl_Fertigungsstatus = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.oLV_Cl_Projektverantwortlicher_Name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.oLV_Cl_Erstell_Datum = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.oLV_Cl_Anzahlung_Datum = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.oLV_Cl_AZ_bestaetigt_Datum = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.oLV_Cl_Schlussrechnung_Date = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.oLV_Cl_Planner_Name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.oLV_Cl_Auftrags_Art = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.oLV_Cl_Stoff_Kennzahl = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.oLV_Cl_Schatten_Datum = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.oLV_Cl_Stoff_bestell_Datum = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.oLV_Cl_Persenning_bestell_Datum = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.oLV_Cl_Sonderteile_bestell_Datum = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.oLV_Cl_Stoff_liefer_Datum = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.oLV_Cl_Sonderteile_liefer_Datum = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.oLV_Cl_Persenning_liefer_Datum = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tmr_250ms = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.oLV_Overview)).BeginInit();
            this.SuspendLayout();
            // 
            // oLV_Overview
            // 
            this.oLV_Overview.AllColumns.Add(this.oLV_Cl_Auftrags_Nr);
            this.oLV_Overview.AllColumns.Add(this.oLV_Cl_Projektbezeichnung);
            this.oLV_Overview.AllColumns.Add(this.oLV_Cl_Fertigungsstatus);
            this.oLV_Overview.AllColumns.Add(this.oLV_Cl_Projektverantwortlicher_Name);
            this.oLV_Overview.AllColumns.Add(this.oLV_Cl_Erstell_Datum);
            this.oLV_Overview.AllColumns.Add(this.oLV_Cl_Anzahlung_Datum);
            this.oLV_Overview.AllColumns.Add(this.oLV_Cl_AZ_bestaetigt_Datum);
            this.oLV_Overview.AllColumns.Add(this.oLV_Cl_Schlussrechnung_Date);
            this.oLV_Overview.AllColumns.Add(this.oLV_Cl_Planner_Name);
            this.oLV_Overview.AllColumns.Add(this.oLV_Cl_Auftrags_Art);
            this.oLV_Overview.AllColumns.Add(this.oLV_Cl_Stoff_Kennzahl);
            this.oLV_Overview.AllColumns.Add(this.oLV_Cl_Schatten_Datum);
            this.oLV_Overview.AllColumns.Add(this.oLV_Cl_Stoff_bestell_Datum);
            this.oLV_Overview.AllColumns.Add(this.oLV_Cl_Persenning_bestell_Datum);
            this.oLV_Overview.AllColumns.Add(this.oLV_Cl_Sonderteile_bestell_Datum);
            this.oLV_Overview.AllColumns.Add(this.oLV_Cl_Stoff_liefer_Datum);
            this.oLV_Overview.AllColumns.Add(this.oLV_Cl_Sonderteile_liefer_Datum);
            this.oLV_Overview.AllColumns.Add(this.oLV_Cl_Persenning_liefer_Datum);
            this.oLV_Overview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oLV_Overview.CellEditUseWholeCell = false;
            this.oLV_Overview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.oLV_Cl_Auftrags_Nr,
            this.oLV_Cl_Projektbezeichnung,
            this.oLV_Cl_Fertigungsstatus,
            this.oLV_Cl_Projektverantwortlicher_Name,
            this.oLV_Cl_Erstell_Datum,
            this.oLV_Cl_Anzahlung_Datum,
            this.oLV_Cl_AZ_bestaetigt_Datum,
            this.oLV_Cl_Schlussrechnung_Date,
            this.oLV_Cl_Planner_Name,
            this.oLV_Cl_Auftrags_Art,
            this.oLV_Cl_Stoff_Kennzahl,
            this.oLV_Cl_Schatten_Datum,
            this.oLV_Cl_Stoff_bestell_Datum,
            this.oLV_Cl_Persenning_bestell_Datum,
            this.oLV_Cl_Sonderteile_bestell_Datum,
            this.oLV_Cl_Stoff_liefer_Datum,
            this.oLV_Cl_Sonderteile_liefer_Datum,
            this.oLV_Cl_Persenning_liefer_Datum});
            this.oLV_Overview.Cursor = System.Windows.Forms.Cursors.Default;
            this.oLV_Overview.Location = new System.Drawing.Point(0, 0);
            this.oLV_Overview.Name = "oLV_Overview";
            this.oLV_Overview.Size = new System.Drawing.Size(1932, 1113);
            this.oLV_Overview.TabIndex = 1;
            this.oLV_Overview.UseCompatibleStateImageBehavior = false;
            this.oLV_Overview.View = System.Windows.Forms.View.Details;
            this.oLV_Overview.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.objectListView1_FormatCell);
            this.oLV_Overview.DoubleClick += new System.EventHandler(this.objectListView1_DoubleClick);
            // 
            // oLV_Cl_Auftrags_Nr
            // 
            this.oLV_Cl_Auftrags_Nr.AspectName = "Auftrags_Nr";
            this.oLV_Cl_Auftrags_Nr.Text = "Auftrags_Nr";
            // 
            // oLV_Cl_Projektbezeichnung
            // 
            this.oLV_Cl_Projektbezeichnung.AspectName = "Projektbezeichnung";
            this.oLV_Cl_Projektbezeichnung.DisplayIndex = 8;
            this.oLV_Cl_Projektbezeichnung.Text = "Projektbezeichnung";
            // 
            // oLV_Cl_Fertigungsstatus
            // 
            this.oLV_Cl_Fertigungsstatus.AspectName = "Fertigungsstatus";
            this.oLV_Cl_Fertigungsstatus.DisplayIndex = 1;
            this.oLV_Cl_Fertigungsstatus.Text = "Fertigungsstatus";
            // 
            // oLV_Cl_Projektverantwortlicher_Name
            // 
            this.oLV_Cl_Projektverantwortlicher_Name.AspectName = "Projektverantwortlicher_Name";
            this.oLV_Cl_Projektverantwortlicher_Name.DisplayIndex = 6;
            this.oLV_Cl_Projektverantwortlicher_Name.Text = "Projektverantwortlicher_Name";
            // 
            // oLV_Cl_Erstell_Datum
            // 
            this.oLV_Cl_Erstell_Datum.AspectName = "Erstell_Datum";
            this.oLV_Cl_Erstell_Datum.AspectToStringFormat = "";
            this.oLV_Cl_Erstell_Datum.DisplayIndex = 2;
            this.oLV_Cl_Erstell_Datum.Text = "Erstell_Datum";
            // 
            // oLV_Cl_Anzahlung_Datum
            // 
            this.oLV_Cl_Anzahlung_Datum.AspectName = "Anzahlung_Datum";
            this.oLV_Cl_Anzahlung_Datum.AspectToStringFormat = "";
            this.oLV_Cl_Anzahlung_Datum.DisplayIndex = 3;
            this.oLV_Cl_Anzahlung_Datum.Text = "Anzahlung_Datum";
            // 
            // oLV_Cl_AZ_bestaetigt_Datum
            // 
            this.oLV_Cl_AZ_bestaetigt_Datum.AspectName = "AZ_bestaetigt_Datum";
            this.oLV_Cl_AZ_bestaetigt_Datum.AspectToStringFormat = "";
            this.oLV_Cl_AZ_bestaetigt_Datum.DisplayIndex = 4;
            this.oLV_Cl_AZ_bestaetigt_Datum.Text = "AZ_bestaetigt_Datum";
            // 
            // oLV_Cl_Schlussrechnung_Date
            // 
            this.oLV_Cl_Schlussrechnung_Date.AspectName = "Schlussrechnung_Date";
            this.oLV_Cl_Schlussrechnung_Date.AspectToStringFormat = "";
            this.oLV_Cl_Schlussrechnung_Date.DisplayIndex = 5;
            this.oLV_Cl_Schlussrechnung_Date.Text = "Schlussrechnung_Date";
            // 
            // oLV_Cl_Planner_Name
            // 
            this.oLV_Cl_Planner_Name.AspectName = "Planner_Name";
            this.oLV_Cl_Planner_Name.DisplayIndex = 7;
            this.oLV_Cl_Planner_Name.Text = "Planner_Name";
            // 
            // oLV_Cl_Auftrags_Art
            // 
            this.oLV_Cl_Auftrags_Art.AspectName = "Auftrags_Art";
            this.oLV_Cl_Auftrags_Art.Text = "Auftrags_Art";
            // 
            // oLV_Cl_Stoff_Kennzahl
            // 
            this.oLV_Cl_Stoff_Kennzahl.AspectName = "Stoff_Kennzahl";
            this.oLV_Cl_Stoff_Kennzahl.Text = "Stoff_Kennzahl";
            // 
            // oLV_Cl_Schatten_Datum
            // 
            this.oLV_Cl_Schatten_Datum.AspectName = "Schatten_Datum";
            this.oLV_Cl_Schatten_Datum.AspectToStringFormat = "";
            this.oLV_Cl_Schatten_Datum.Text = "Schatten_Datum";
            // 
            // oLV_Cl_Stoff_bestell_Datum
            // 
            this.oLV_Cl_Stoff_bestell_Datum.AspectName = "Stoff_bestell_Datum";
            this.oLV_Cl_Stoff_bestell_Datum.AspectToStringFormat = "";
            this.oLV_Cl_Stoff_bestell_Datum.Text = "Stoff_bestell_Datum";
            // 
            // oLV_Cl_Persenning_bestell_Datum
            // 
            this.oLV_Cl_Persenning_bestell_Datum.AspectName = "Persenning_bestell_Datum";
            this.oLV_Cl_Persenning_bestell_Datum.AspectToStringFormat = "";
            this.oLV_Cl_Persenning_bestell_Datum.DisplayIndex = 16;
            this.oLV_Cl_Persenning_bestell_Datum.Text = "Persenning_bestell_Datum";
            // 
            // oLV_Cl_Sonderteile_bestell_Datum
            // 
            this.oLV_Cl_Sonderteile_bestell_Datum.AspectName = "Sonderteile_bestell_Datum";
            this.oLV_Cl_Sonderteile_bestell_Datum.AspectToStringFormat = "";
            this.oLV_Cl_Sonderteile_bestell_Datum.Text = "Sonderteile_bestell_Datum";
            // 
            // oLV_Cl_Stoff_liefer_Datum
            // 
            this.oLV_Cl_Stoff_liefer_Datum.AspectName = "Stoff_liefer_Datum";
            this.oLV_Cl_Stoff_liefer_Datum.AspectToStringFormat = "";
            this.oLV_Cl_Stoff_liefer_Datum.DisplayIndex = 13;
            this.oLV_Cl_Stoff_liefer_Datum.Text = "Stoff_liefer_Datum";
            // 
            // oLV_Cl_Sonderteile_liefer_Datum
            // 
            this.oLV_Cl_Sonderteile_liefer_Datum.AspectName = "Sonderteile_liefer_Datum";
            this.oLV_Cl_Sonderteile_liefer_Datum.AspectToStringFormat = "";
            this.oLV_Cl_Sonderteile_liefer_Datum.DisplayIndex = 15;
            this.oLV_Cl_Sonderteile_liefer_Datum.Text = "Sonderteile_liefer_Datum";
            // 
            // oLV_Cl_Persenning_liefer_Datum
            // 
            this.oLV_Cl_Persenning_liefer_Datum.AspectName = "Persenning_liefer_Datum";
            this.oLV_Cl_Persenning_liefer_Datum.AspectToStringFormat = "";
            this.oLV_Cl_Persenning_liefer_Datum.Text = "Persenning_liefer_Datum";
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
            this.Size = new System.Drawing.Size(1920, 1080);
            ((System.ComponentModel.ISupportInitialize)(this.oLV_Overview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BrightIdeasSoftware.ObjectListView oLV_Overview;
        private BrightIdeasSoftware.OLVColumn oLV_Cl_Auftrags_Nr;
        private BrightIdeasSoftware.OLVColumn oLV_Cl_Fertigungsstatus;
        private BrightIdeasSoftware.OLVColumn oLV_Cl_Erstell_Datum;
        private BrightIdeasSoftware.OLVColumn oLV_Cl_Anzahlung_Datum;
        private BrightIdeasSoftware.OLVColumn oLV_Cl_AZ_bestaetigt_Datum;
        private BrightIdeasSoftware.OLVColumn oLV_Cl_Schlussrechnung_Date;
        private BrightIdeasSoftware.OLVColumn oLV_Cl_Projektverantwortlicher_Name;
        private BrightIdeasSoftware.OLVColumn oLV_Cl_Planner_Name;
        private BrightIdeasSoftware.OLVColumn oLV_Cl_Projektbezeichnung;
        private BrightIdeasSoftware.OLVColumn oLV_Cl_Auftrags_Art;
        private BrightIdeasSoftware.OLVColumn oLV_Cl_Stoff_Kennzahl;
        private BrightIdeasSoftware.OLVColumn oLV_Cl_Schatten_Datum;
        private BrightIdeasSoftware.OLVColumn oLV_Cl_Stoff_bestell_Datum;
        private BrightIdeasSoftware.OLVColumn oLV_Cl_Stoff_liefer_Datum;
        private BrightIdeasSoftware.OLVColumn oLV_Cl_Sonderteile_bestell_Datum;
        private BrightIdeasSoftware.OLVColumn oLV_Cl_Sonderteile_liefer_Datum;
        private BrightIdeasSoftware.OLVColumn oLV_Cl_Persenning_bestell_Datum;
        private BrightIdeasSoftware.OLVColumn oLV_Cl_Persenning_liefer_Datum;
        private System.Windows.Forms.Timer tmr_250ms;
    }
}
