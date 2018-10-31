namespace LET_Auftragsverwaltung
{
    partial class UC_Connect_Show
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbx_mysql = new System.Windows.Forms.PictureBox();
            this.pbx_ftp = new System.Windows.Forms.PictureBox();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_mysql)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ftp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MySQL:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "FTP:";
            // 
            // pbx_mysql
            // 
            this.pbx_mysql.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbx_mysql.Location = new System.Drawing.Point(45, -7);
            this.pbx_mysql.Name = "pbx_mysql";
            this.pbx_mysql.Size = new System.Drawing.Size(50, 50);
            this.pbx_mysql.TabIndex = 2;
            this.pbx_mysql.TabStop = false;
            this.pbx_mysql.Paint += new System.Windows.Forms.PaintEventHandler(this.pbx_mysql_Paint);
            // 
            // pbx_ftp
            // 
            this.pbx_ftp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_ftp.Location = new System.Drawing.Point(465, -7);
            this.pbx_ftp.Name = "pbx_ftp";
            this.pbx_ftp.Size = new System.Drawing.Size(50, 50);
            this.pbx_ftp.TabIndex = 3;
            this.pbx_ftp.TabStop = false;
            this.pbx_ftp.Paint += new System.Windows.Forms.PaintEventHandler(this.pbx_ftp_Paint);
            // 
            // tmr
            // 
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status";
            // 
            // UC_Connect_Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbx_ftp);
            this.Controls.Add(this.pbx_mysql);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_Connect_Show";
            this.Size = new System.Drawing.Size(506, 45);
            this.VisibleChanged += new System.EventHandler(this.UC_Connect_Show_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_mysql)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ftp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbx_mysql;
        private System.Windows.Forms.PictureBox pbx_ftp;
        private System.Windows.Forms.Label label3;
        public  System.Windows.Forms.Timer tmr;
    }
}
