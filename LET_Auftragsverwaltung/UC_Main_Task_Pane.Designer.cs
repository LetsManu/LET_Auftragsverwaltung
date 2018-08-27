namespace LET_Auftragsverwaltung
{
    partial class UC_Main_Task_Pane
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aufträgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parameterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aufträgeToolStripMenuItem,
            this.parameterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(448, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aufträgeToolStripMenuItem
            // 
            this.aufträgeToolStripMenuItem.Name = "aufträgeToolStripMenuItem";
            this.aufträgeToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.aufträgeToolStripMenuItem.Text = "Aufträge";
            // 
            // parameterToolStripMenuItem
            // 
            this.parameterToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.parameterToolStripMenuItem.Name = "parameterToolStripMenuItem";
            this.parameterToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.parameterToolStripMenuItem.Text = "Parameter";
            // 
            // UC_Main_Task_Pane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.Name = "UC_Main_Task_Pane";
            this.Size = new System.Drawing.Size(448, 724);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aufträgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parameterToolStripMenuItem;
    }
}
