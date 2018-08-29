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
            this.auftragsDataSet = new LET_Auftragsverwaltung.auftragsDataSet();
            this.auftragsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.auftragsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auftragsDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // auftragsDataSet
            // 
            this.auftragsDataSet.DataSetName = "auftragsDataSet";
            this.auftragsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // auftragsDataSetBindingSource
            // 
            this.auftragsDataSetBindingSource.DataSource = this.auftragsDataSet;
            this.auftragsDataSetBindingSource.Position = 0;
            // 
            // UC_Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UC_Overview";
            this.Size = new System.Drawing.Size(837, 464);
            ((System.ComponentModel.ISupportInitialize)(this.auftragsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auftragsDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource auftragsDataSetBindingSource;
        private auftragsDataSet auftragsDataSet;
    }
}
