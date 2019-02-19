namespace LET_Auftragsverwaltung
{
    partial class UC_Best
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
            this.btn_best_auf = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_best_anz = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_best_schl = new System.Windows.Forms.Button();
            this.txt_best_auf = new System.Windows.Forms.Label();
            this.txt_best_anz = new System.Windows.Forms.Label();
            this.txt_best_schl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_best_auf
            // 
            this.btn_best_auf.Location = new System.Drawing.Point(6, 77);
            this.btn_best_auf.Name = "btn_best_auf";
            this.btn_best_auf.Size = new System.Drawing.Size(116, 23);
            this.btn_best_auf.TabIndex = 0;
            this.btn_best_auf.Text = "Auftragsbestätigung";
            this.btn_best_auf.UseVisualStyleBackColor = true;
            this.btn_best_auf.Click += new System.EventHandler(this.btn_best_auf_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_best_auf);
            this.groupBox1.Controls.Add(this.btn_best_auf);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 109);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auftragsbestätigung";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_best_anz);
            this.groupBox2.Controls.Add(this.btn_best_anz);
            this.groupBox2.Location = new System.Drawing.Point(137, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 109);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Anzahlungsrechnung";
            // 
            // btn_best_anz
            // 
            this.btn_best_anz.Location = new System.Drawing.Point(0, 77);
            this.btn_best_anz.Name = "btn_best_anz";
            this.btn_best_anz.Size = new System.Drawing.Size(121, 23);
            this.btn_best_anz.TabIndex = 0;
            this.btn_best_anz.Text = "Anzahlungsrechnung";
            this.btn_best_anz.UseVisualStyleBackColor = true;
            this.btn_best_anz.Click += new System.EventHandler(this.btn_best_anz_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_best_schl);
            this.groupBox3.Controls.Add(this.btn_best_schl);
            this.groupBox3.Location = new System.Drawing.Point(270, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(121, 109);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Schlussrechnung";
            // 
            // btn_best_schl
            // 
            this.btn_best_schl.Location = new System.Drawing.Point(6, 77);
            this.btn_best_schl.Name = "btn_best_schl";
            this.btn_best_schl.Size = new System.Drawing.Size(109, 23);
            this.btn_best_schl.TabIndex = 0;
            this.btn_best_schl.Text = "Schlussrechnung";
            this.btn_best_schl.UseVisualStyleBackColor = true;
            this.btn_best_schl.Click += new System.EventHandler(this.btn_best_schl_Click);
            // 
            // txt_best_auf
            // 
            this.txt_best_auf.AutoSize = true;
            this.txt_best_auf.BackColor = System.Drawing.Color.Transparent;
            this.txt_best_auf.ForeColor = System.Drawing.Color.Green;
            this.txt_best_auf.Location = new System.Drawing.Point(6, 16);
            this.txt_best_auf.Name = "txt_best_auf";
            this.txt_best_auf.Size = new System.Drawing.Size(114, 13);
            this.txt_best_auf.TabIndex = 1;
            this.txt_best_auf.Text = "Wurde schon bestätigt";
            this.txt_best_auf.Visible = false;
            // 
            // txt_best_anz
            // 
            this.txt_best_anz.AutoSize = true;
            this.txt_best_anz.ForeColor = System.Drawing.Color.Green;
            this.txt_best_anz.Location = new System.Drawing.Point(6, 16);
            this.txt_best_anz.Name = "txt_best_anz";
            this.txt_best_anz.Size = new System.Drawing.Size(114, 13);
            this.txt_best_anz.TabIndex = 2;
            this.txt_best_anz.Text = "Wurde schon bestätigt";
            this.txt_best_anz.Visible = false;
            // 
            // txt_best_schl
            // 
            this.txt_best_schl.AutoSize = true;
            this.txt_best_schl.ForeColor = System.Drawing.Color.Green;
            this.txt_best_schl.Location = new System.Drawing.Point(6, 16);
            this.txt_best_schl.Name = "txt_best_schl";
            this.txt_best_schl.Size = new System.Drawing.Size(114, 13);
            this.txt_best_schl.TabIndex = 3;
            this.txt_best_schl.Text = "Wurde schon bestätigt";
            this.txt_best_schl.Visible = false;
            // 
            // UC_Best
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_Best";
            this.Size = new System.Drawing.Size(401, 139);
            this.Load += new System.EventHandler(this.UC_Best_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_best_auf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_best_anz;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_best_schl;
        private System.Windows.Forms.Label txt_best_auf;
        private System.Windows.Forms.Label txt_best_anz;
        private System.Windows.Forms.Label txt_best_schl;
    }
}
