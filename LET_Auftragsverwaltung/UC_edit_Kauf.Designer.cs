namespace LET_Auftragsverwaltung
{
    partial class UC_edit_Kauf
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_date_kauf_edit_auf = new System.Windows.Forms.Button();
            this.txt_kauf_auf_best = new System.Windows.Forms.Label();
            this.btn_save_kauf_edit_auf = new System.Windows.Forms.Button();
            this.txt_kauf_edit_auf = new System.Windows.Forms.RichTextBox();
            this.cbx_kauf_edit_auf = new System.Windows.Forms.ComboBox();
            this.date_kauf_edit_auf = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_date_kauf_edit_anz = new System.Windows.Forms.Button();
            this.txt_kauf_anz_best = new System.Windows.Forms.Label();
            this.btn_save_kauf_edit_anz = new System.Windows.Forms.Button();
            this.txt_kauf_edit_anz = new System.Windows.Forms.RichTextBox();
            this.cbx_kauf_edit_anz = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.date_kauf_edit_anz = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_date_kauf_edit_schluss = new System.Windows.Forms.Button();
            this.txt_schluss_best = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_save_kauf_edit_schluss = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_kauf_edit_schluss = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbx_kauf_edit_schluss = new System.Windows.Forms.ComboBox();
            this.date_kauf_edit_schluss = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_edit_kauf_text_save = new System.Windows.Forms.Button();
            this.btn_best = new System.Windows.Forms.Button();
            this.tmr_break = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_date_kauf_edit_auf);
            this.groupBox1.Controls.Add(this.txt_kauf_auf_best);
            this.groupBox1.Controls.Add(this.btn_save_kauf_edit_auf);
            this.groupBox1.Controls.Add(this.txt_kauf_edit_auf);
            this.groupBox1.Controls.Add(this.cbx_kauf_edit_auf);
            this.groupBox1.Controls.Add(this.date_kauf_edit_auf);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(3, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 274);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_date_kauf_edit_auf
            // 
            this.btn_date_kauf_edit_auf.Location = new System.Drawing.Point(111, 65);
            this.btn_date_kauf_edit_auf.Name = "btn_date_kauf_edit_auf";
            this.btn_date_kauf_edit_auf.Size = new System.Drawing.Size(178, 23);
            this.btn_date_kauf_edit_auf.TabIndex = 12;
            this.btn_date_kauf_edit_auf.Text = "Aktuelles Datum";
            this.btn_date_kauf_edit_auf.UseVisualStyleBackColor = true;
            this.btn_date_kauf_edit_auf.Click += new System.EventHandler(this.btn_date_kauf_edit_auf_Click);
            // 
            // txt_kauf_auf_best
            // 
            this.txt_kauf_auf_best.AutoSize = true;
            this.txt_kauf_auf_best.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kauf_auf_best.ForeColor = System.Drawing.Color.DarkGreen;
            this.txt_kauf_auf_best.Location = new System.Drawing.Point(98, 16);
            this.txt_kauf_auf_best.Name = "txt_kauf_auf_best";
            this.txt_kauf_auf_best.Size = new System.Drawing.Size(179, 13);
            this.txt_kauf_auf_best.TabIndex = 11;
            this.txt_kauf_auf_best.Text = "Bestätigungs ist schon erfolgt!";
            this.txt_kauf_auf_best.Visible = false;
            // 
            // btn_save_kauf_edit_auf
            // 
            this.btn_save_kauf_edit_auf.Location = new System.Drawing.Point(111, 235);
            this.btn_save_kauf_edit_auf.Name = "btn_save_kauf_edit_auf";
            this.btn_save_kauf_edit_auf.Size = new System.Drawing.Size(178, 23);
            this.btn_save_kauf_edit_auf.TabIndex = 5;
            this.btn_save_kauf_edit_auf.Text = "Anfordern bei Sandra";
            this.btn_save_kauf_edit_auf.UseVisualStyleBackColor = true;
            this.btn_save_kauf_edit_auf.Click += new System.EventHandler(this.btn_save_kauf_edit_auf_Click);
            // 
            // txt_kauf_edit_auf
            // 
            this.txt_kauf_edit_auf.Location = new System.Drawing.Point(111, 133);
            this.txt_kauf_edit_auf.Name = "txt_kauf_edit_auf";
            this.txt_kauf_edit_auf.Size = new System.Drawing.Size(178, 96);
            this.txt_kauf_edit_auf.TabIndex = 3;
            this.txt_kauf_edit_auf.Text = "";
            // 
            // cbx_kauf_edit_auf
            // 
            this.cbx_kauf_edit_auf.FormattingEnabled = true;
            this.cbx_kauf_edit_auf.Location = new System.Drawing.Point(111, 106);
            this.cbx_kauf_edit_auf.Name = "cbx_kauf_edit_auf";
            this.cbx_kauf_edit_auf.Size = new System.Drawing.Size(178, 21);
            this.cbx_kauf_edit_auf.TabIndex = 3;
            this.cbx_kauf_edit_auf.SelectedIndexChanged += new System.EventHandler(this.cbx_kauf_edit_auf_SelectedIndexChanged);
            // 
            // date_kauf_edit_auf
            // 
            this.date_kauf_edit_auf.Location = new System.Drawing.Point(111, 39);
            this.date_kauf_edit_auf.Name = "date_kauf_edit_auf";
            this.date_kauf_edit_auf.Size = new System.Drawing.Size(178, 20);
            this.date_kauf_edit_auf.TabIndex = 2;
            this.date_kauf_edit_auf.CloseUp += new System.EventHandler(this.date_kauf_edit_auf_CloseUp);
            this.date_kauf_edit_auf.ValueChanged += new System.EventHandler(this.date_kauf_edit_auf_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "AB-Datum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Anfordernde Person";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Notizen";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_date_kauf_edit_anz);
            this.groupBox2.Controls.Add(this.txt_kauf_anz_best);
            this.groupBox2.Controls.Add(this.btn_save_kauf_edit_anz);
            this.groupBox2.Controls.Add(this.txt_kauf_edit_anz);
            this.groupBox2.Controls.Add(this.cbx_kauf_edit_anz);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.date_kauf_edit_anz);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(304, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 274);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btn_date_kauf_edit_anz
            // 
            this.btn_date_kauf_edit_anz.Location = new System.Drawing.Point(109, 65);
            this.btn_date_kauf_edit_anz.Name = "btn_date_kauf_edit_anz";
            this.btn_date_kauf_edit_anz.Size = new System.Drawing.Size(180, 23);
            this.btn_date_kauf_edit_anz.TabIndex = 13;
            this.btn_date_kauf_edit_anz.Text = "Aktuelles Datum";
            this.btn_date_kauf_edit_anz.UseVisualStyleBackColor = true;
            this.btn_date_kauf_edit_anz.Click += new System.EventHandler(this.btn_date_kauf_edit_anz_Click);
            // 
            // txt_kauf_anz_best
            // 
            this.txt_kauf_anz_best.AutoSize = true;
            this.txt_kauf_anz_best.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kauf_anz_best.ForeColor = System.Drawing.Color.DarkGreen;
            this.txt_kauf_anz_best.Location = new System.Drawing.Point(96, 16);
            this.txt_kauf_anz_best.Name = "txt_kauf_anz_best";
            this.txt_kauf_anz_best.Size = new System.Drawing.Size(165, 13);
            this.txt_kauf_anz_best.TabIndex = 12;
            this.txt_kauf_anz_best.Text = "Anzahlung ist schon erfolgt!";
            this.txt_kauf_anz_best.Visible = false;
            // 
            // btn_save_kauf_edit_anz
            // 
            this.btn_save_kauf_edit_anz.Location = new System.Drawing.Point(111, 235);
            this.btn_save_kauf_edit_anz.Name = "btn_save_kauf_edit_anz";
            this.btn_save_kauf_edit_anz.Size = new System.Drawing.Size(178, 23);
            this.btn_save_kauf_edit_anz.TabIndex = 6;
            this.btn_save_kauf_edit_anz.Text = "Anfordern bei Sandra";
            this.btn_save_kauf_edit_anz.UseVisualStyleBackColor = true;
            this.btn_save_kauf_edit_anz.Click += new System.EventHandler(this.btn_save_kauf_edit_anz_Click);
            // 
            // txt_kauf_edit_anz
            // 
            this.txt_kauf_edit_anz.Location = new System.Drawing.Point(111, 133);
            this.txt_kauf_edit_anz.Name = "txt_kauf_edit_anz";
            this.txt_kauf_edit_anz.Size = new System.Drawing.Size(178, 96);
            this.txt_kauf_edit_anz.TabIndex = 4;
            this.txt_kauf_edit_anz.Text = "";
            // 
            // cbx_kauf_edit_anz
            // 
            this.cbx_kauf_edit_anz.FormattingEnabled = true;
            this.cbx_kauf_edit_anz.Location = new System.Drawing.Point(109, 106);
            this.cbx_kauf_edit_anz.Name = "cbx_kauf_edit_anz";
            this.cbx_kauf_edit_anz.Size = new System.Drawing.Size(180, 21);
            this.cbx_kauf_edit_anz.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Notizen";
            // 
            // date_kauf_edit_anz
            // 
            this.date_kauf_edit_anz.Location = new System.Drawing.Point(109, 39);
            this.date_kauf_edit_anz.Name = "date_kauf_edit_anz";
            this.date_kauf_edit_anz.Size = new System.Drawing.Size(180, 20);
            this.date_kauf_edit_anz.TabIndex = 1;
            this.date_kauf_edit_anz.CloseUp += new System.EventHandler(this.date_kauf_edit_anz_CloseUp);
            this.date_kauf_edit_anz.ValueChanged += new System.EventHandler(this.date_kauf_edit_anz_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Anfordernde Person";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Rechnungs-Datum";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_date_kauf_edit_schluss);
            this.groupBox3.Controls.Add(this.txt_schluss_best);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.btn_save_kauf_edit_schluss);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txt_kauf_edit_schluss);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cbx_kauf_edit_schluss);
            this.groupBox3.Controls.Add(this.date_kauf_edit_schluss);
            this.groupBox3.Location = new System.Drawing.Point(605, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(295, 274);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // btn_date_kauf_edit_schluss
            // 
            this.btn_date_kauf_edit_schluss.Location = new System.Drawing.Point(111, 65);
            this.btn_date_kauf_edit_schluss.Name = "btn_date_kauf_edit_schluss";
            this.btn_date_kauf_edit_schluss.Size = new System.Drawing.Size(178, 23);
            this.btn_date_kauf_edit_schluss.TabIndex = 14;
            this.btn_date_kauf_edit_schluss.Text = "Aktuelles Datum";
            this.btn_date_kauf_edit_schluss.UseVisualStyleBackColor = true;
            this.btn_date_kauf_edit_schluss.Click += new System.EventHandler(this.btn_date_kauf_edit_schluss_Click);
            // 
            // txt_schluss_best
            // 
            this.txt_schluss_best.AutoSize = true;
            this.txt_schluss_best.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_schluss_best.ForeColor = System.Drawing.Color.DarkGreen;
            this.txt_schluss_best.Location = new System.Drawing.Point(104, 16);
            this.txt_schluss_best.Name = "txt_schluss_best";
            this.txt_schluss_best.Size = new System.Drawing.Size(158, 13);
            this.txt_schluss_best.TabIndex = 13;
            this.txt_schluss_best.Text = "Schlussrechnung ist fertig!";
            this.txt_schluss_best.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Notizen";
            // 
            // btn_save_kauf_edit_schluss
            // 
            this.btn_save_kauf_edit_schluss.Location = new System.Drawing.Point(111, 235);
            this.btn_save_kauf_edit_schluss.Name = "btn_save_kauf_edit_schluss";
            this.btn_save_kauf_edit_schluss.Size = new System.Drawing.Size(178, 23);
            this.btn_save_kauf_edit_schluss.TabIndex = 7;
            this.btn_save_kauf_edit_schluss.Text = "Anfordern bei Sandra";
            this.btn_save_kauf_edit_schluss.UseVisualStyleBackColor = true;
            this.btn_save_kauf_edit_schluss.Click += new System.EventHandler(this.btn_save_kauf_edit_schluss_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Anfordernde Person";
            // 
            // txt_kauf_edit_schluss
            // 
            this.txt_kauf_edit_schluss.Location = new System.Drawing.Point(111, 133);
            this.txt_kauf_edit_schluss.Name = "txt_kauf_edit_schluss";
            this.txt_kauf_edit_schluss.Size = new System.Drawing.Size(178, 96);
            this.txt_kauf_edit_schluss.TabIndex = 5;
            this.txt_kauf_edit_schluss.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Rechnungs-Datum";
            // 
            // cbx_kauf_edit_schluss
            // 
            this.cbx_kauf_edit_schluss.FormattingEnabled = true;
            this.cbx_kauf_edit_schluss.Location = new System.Drawing.Point(111, 106);
            this.cbx_kauf_edit_schluss.Name = "cbx_kauf_edit_schluss";
            this.cbx_kauf_edit_schluss.Size = new System.Drawing.Size(178, 21);
            this.cbx_kauf_edit_schluss.TabIndex = 4;
            // 
            // date_kauf_edit_schluss
            // 
            this.date_kauf_edit_schluss.Location = new System.Drawing.Point(111, 39);
            this.date_kauf_edit_schluss.Name = "date_kauf_edit_schluss";
            this.date_kauf_edit_schluss.Size = new System.Drawing.Size(178, 20);
            this.date_kauf_edit_schluss.TabIndex = 0;
            this.date_kauf_edit_schluss.CloseUp += new System.EventHandler(this.date_kauf_edit_schluss_CloseUp);
            this.date_kauf_edit_schluss.ValueChanged += new System.EventHandler(this.date_kauf_edit_schluss_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Auftragsbestätigung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Anzahlungsrechnung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(694, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Schlussrechnung";
            // 
            // btn_edit_kauf_text_save
            // 
            this.btn_edit_kauf_text_save.Location = new System.Drawing.Point(716, 300);
            this.btn_edit_kauf_text_save.Name = "btn_edit_kauf_text_save";
            this.btn_edit_kauf_text_save.Size = new System.Drawing.Size(178, 23);
            this.btn_edit_kauf_text_save.TabIndex = 5;
            this.btn_edit_kauf_text_save.Text = "Notizen speichern";
            this.btn_edit_kauf_text_save.UseVisualStyleBackColor = true;
            this.btn_edit_kauf_text_save.Click += new System.EventHandler(this.btn_edit_kauf_text_save_Click);
            // 
            // btn_best
            // 
            this.btn_best.Location = new System.Drawing.Point(3, 300);
            this.btn_best.Name = "btn_best";
            this.btn_best.Size = new System.Drawing.Size(178, 23);
            this.btn_best.TabIndex = 6;
            this.btn_best.Text = "Bestätigungsmanager";
            this.btn_best.UseVisualStyleBackColor = true;
            this.btn_best.Click += new System.EventHandler(this.btn_best_Click);
            // 
            // tmr_break
            // 
            this.tmr_break.Interval = 3000;
            this.tmr_break.Tick += new System.EventHandler(this.tmr_break_Tick);
            // 
            // UC_edit_Kauf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_best);
            this.Controls.Add(this.btn_edit_kauf_text_save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_edit_Kauf";
            this.Size = new System.Drawing.Size(903, 327);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker date_kauf_edit_auf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker date_kauf_edit_anz;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker date_kauf_edit_schluss;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txt_kauf_auf_best;
        private System.Windows.Forms.Button btn_save_kauf_edit_auf;
        private System.Windows.Forms.RichTextBox txt_kauf_edit_auf;
        private System.Windows.Forms.ComboBox cbx_kauf_edit_auf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txt_kauf_anz_best;
        private System.Windows.Forms.Button btn_save_kauf_edit_anz;
        private System.Windows.Forms.RichTextBox txt_kauf_edit_anz;
        private System.Windows.Forms.ComboBox cbx_kauf_edit_anz;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txt_schluss_best;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_save_kauf_edit_schluss;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox txt_kauf_edit_schluss;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbx_kauf_edit_schluss;
        private System.Windows.Forms.Button btn_date_kauf_edit_auf;
        private System.Windows.Forms.Button btn_date_kauf_edit_anz;
        private System.Windows.Forms.Button btn_date_kauf_edit_schluss;
        private System.Windows.Forms.Button btn_edit_kauf_text_save;
        private System.Windows.Forms.Button btn_best;
        private System.Windows.Forms.Timer tmr_break;
    }
}
