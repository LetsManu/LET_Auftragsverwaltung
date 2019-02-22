namespace LET_Auftragsverwaltung
{
    partial class UC_New_auftrag
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
            this.date_erstell = new System.Windows.Forms.DateTimePicker();
            this.date_mont = new System.Windows.Forms.DateTimePicker();
            this.txt_info_kauf = new System.Windows.Forms.RichTextBox();
            this.txt_auftrag_nr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_verant = new System.Windows.Forms.ComboBox();
            this.cbx_tech = new System.Windows.Forms.ComboBox();
            this.btn_new_auf_save = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cBx_seller = new System.Windows.Forms.ComboBox();
            this.Projektbezeichnung = new System.Windows.Forms.Label();
            this.txt_auf_proj_ken = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_info_tech = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_add_segel = new System.Windows.Forms.Button();
            this.lBx_segel = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tti_new_auftrag = new System.Windows.Forms.ToolTip(this.components);
            this.tBx_segel_name = new System.Windows.Forms.TextBox();
            this.cBx_segelform = new System.Windows.Forms.ComboBox();
            this.cBx_stoff_kennung = new System.Windows.Forms.ComboBox();
            this.cBx_stoff_hersteller = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // date_erstell
            // 
            this.date_erstell.CustomFormat = "dd-mm-yyyy";
            this.date_erstell.Location = new System.Drawing.Point(113, 163);
            this.date_erstell.Name = "date_erstell";
            this.date_erstell.Size = new System.Drawing.Size(144, 20);
            this.date_erstell.TabIndex = 1;
            this.tti_new_auftrag.SetToolTip(this.date_erstell, "Datum an dem das Projekt erstellt wurde.");
            this.date_erstell.Value = new System.DateTime(2018, 9, 5, 14, 26, 25, 0);
            // 
            // date_mont
            // 
            this.date_mont.CustomFormat = "MM-dd-yy";
            this.date_mont.Location = new System.Drawing.Point(113, 189);
            this.date_mont.Name = "date_mont";
            this.date_mont.Size = new System.Drawing.Size(144, 20);
            this.date_mont.TabIndex = 2;
            this.tti_new_auftrag.SetToolTip(this.date_mont, "Montage Datum. Wird automatisch 1 Monat nach dem erstell Datum gesetz.\r\nKann auf " +
        "das gewümschte Datum geändert werden.\r\n");
            // 
            // txt_info_kauf
            // 
            this.txt_info_kauf.Location = new System.Drawing.Point(9, 39);
            this.txt_info_kauf.Name = "txt_info_kauf";
            this.txt_info_kauf.Size = new System.Drawing.Size(248, 111);
            this.txt_info_kauf.TabIndex = 5;
            this.txt_info_kauf.Text = "";
            this.tti_new_auftrag.SetToolTip(this.txt_info_kauf, "Notizen für den kaufmänischen Bereich.");
            // 
            // txt_auftrag_nr
            // 
            this.txt_auftrag_nr.Location = new System.Drawing.Point(113, 30);
            this.txt_auftrag_nr.Name = "txt_auftrag_nr";
            this.txt_auftrag_nr.Size = new System.Drawing.Size(144, 20);
            this.txt_auftrag_nr.TabIndex = 9;
            this.tti_new_auftrag.SetToolTip(this.txt_auftrag_nr, "Nummder des Auftrags, wenn nicht vorhanden kann dieser nachgetragen werden.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Verantwortlicher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Techniker";
            // 
            // cbx_verant
            // 
            this.cbx_verant.FormattingEnabled = true;
            this.cbx_verant.Location = new System.Drawing.Point(113, 109);
            this.cbx_verant.Name = "cbx_verant";
            this.cbx_verant.Size = new System.Drawing.Size(144, 21);
            this.cbx_verant.TabIndex = 16;
            this.tti_new_auftrag.SetToolTip(this.cbx_verant, "Liste aller verfügbaren Verantwortlichen");
            // 
            // cbx_tech
            // 
            this.cbx_tech.FormattingEnabled = true;
            this.cbx_tech.Location = new System.Drawing.Point(113, 136);
            this.cbx_tech.Name = "cbx_tech";
            this.cbx_tech.Size = new System.Drawing.Size(144, 21);
            this.cbx_tech.TabIndex = 17;
            this.tti_new_auftrag.SetToolTip(this.cbx_tech, "Liste aller verfügbaren Techniker.");
            // 
            // btn_new_auf_save
            // 
            this.btn_new_auf_save.Location = new System.Drawing.Point(628, 362);
            this.btn_new_auf_save.Name = "btn_new_auf_save";
            this.btn_new_auf_save.Size = new System.Drawing.Size(192, 23);
            this.btn_new_auf_save.TabIndex = 19;
            this.btn_new_auf_save.Text = "Speichern";
            this.btn_new_auf_save.UseVisualStyleBackColor = true;
            this.btn_new_auf_save.Click += new System.EventHandler(this.Btn_new_auf_save_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.cBx_seller);
            this.groupBox3.Controls.Add(this.Projektbezeichnung);
            this.groupBox3.Controls.Add(this.txt_auf_proj_ken);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_auftrag_nr);
            this.groupBox3.Controls.Add(this.date_erstell);
            this.groupBox3.Controls.Add(this.date_mont);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cbx_tech);
            this.groupBox3.Controls.Add(this.cbx_verant);
            this.groupBox3.Location = new System.Drawing.Point(19, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 299);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Allgemein";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Verkäufer";
            // 
            // cBx_seller
            // 
            this.cBx_seller.FormattingEnabled = true;
            this.cBx_seller.Location = new System.Drawing.Point(113, 82);
            this.cBx_seller.Name = "cBx_seller";
            this.cBx_seller.Size = new System.Drawing.Size(144, 21);
            this.cBx_seller.TabIndex = 24;
            this.tti_new_auftrag.SetToolTip(this.cBx_seller, "Liste aller verfügbaren Verkäufer.");
            // 
            // Projektbezeichnung
            // 
            this.Projektbezeichnung.AutoSize = true;
            this.Projektbezeichnung.Location = new System.Drawing.Point(6, 63);
            this.Projektbezeichnung.Name = "Projektbezeichnung";
            this.Projektbezeichnung.Size = new System.Drawing.Size(101, 13);
            this.Projektbezeichnung.TabIndex = 22;
            this.Projektbezeichnung.Text = "Projektbezeichnung";
            // 
            // txt_auf_proj_ken
            // 
            this.txt_auf_proj_ken.Location = new System.Drawing.Point(113, 56);
            this.txt_auf_proj_ken.Name = "txt_auf_proj_ken";
            this.txt_auf_proj_ken.Size = new System.Drawing.Size(144, 20);
            this.txt_auf_proj_ken.TabIndex = 21;
            this.tti_new_auftrag.SetToolTip(this.txt_auf_proj_ken, "Bezeichnung des Projekts, wenn nicht vorhanden kann dieser nachgetragen werden.");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Montagedatum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Erstelldatum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Auftragsnummer";
            // 
            // txt_info_tech
            // 
            this.txt_info_tech.Location = new System.Drawing.Point(9, 180);
            this.txt_info_tech.Name = "txt_info_tech";
            this.txt_info_tech.Size = new System.Drawing.Size(248, 111);
            this.txt_info_tech.TabIndex = 24;
            this.txt_info_tech.Text = "";
            this.tti_new_auftrag.SetToolTip(this.txt_info_tech, "Notizen für den technischen Bereich.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Kaufmänisch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Techniker";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_info_kauf);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_info_tech);
            this.groupBox1.Location = new System.Drawing.Point(288, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 299);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notitzen";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_add_segel);
            this.groupBox2.Controls.Add(this.lBx_segel);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cBx_stoff_hersteller);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cBx_stoff_kennung);
            this.groupBox2.Controls.Add(this.cBx_segelform);
            this.groupBox2.Controls.Add(this.tBx_segel_name);
            this.groupBox2.Location = new System.Drawing.Point(557, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 299);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Segel";
            // 
            // btn_add_segel
            // 
            this.btn_add_segel.Location = new System.Drawing.Point(170, 136);
            this.btn_add_segel.Name = "btn_add_segel";
            this.btn_add_segel.Size = new System.Drawing.Size(87, 23);
            this.btn_add_segel.TabIndex = 29;
            this.btn_add_segel.Text = "Hinzufügen";
            this.btn_add_segel.UseVisualStyleBackColor = true;
            this.btn_add_segel.Click += new System.EventHandler(this.btn_add_segel_Click);
            // 
            // lBx_segel
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Stoff Hersteller";
            this.lBx_segel.FormattingEnabled = true;
            this.lBx_segel.Location = new System.Drawing.Point(6, 172);
            this.lBx_segel.Name = "lBx_segel";
            this.lBx_segel.Size = new System.Drawing.Size(248, 121);
            this.lBx_segel.TabIndex = 28;
            // 
            // label11
            //
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Stoff Hersteller";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Segelform";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Stoff Kennung";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Segel Name";
            // 

            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Segel Name";
            // 
            // tBx_segel_name
            // 
            this.tBx_segel_name.Location = new System.Drawing.Point(87, 30);
            this.tBx_segel_name.Name = "tBx_segel_name";
            this.tBx_segel_name.Size = new System.Drawing.Size(170, 20);
            this.tBx_segel_name.TabIndex = 0;
            // 
            // cBx_segelform
            // 
            this.cBx_segelform.FormattingEnabled = true;
            this.cBx_segelform.Location = new System.Drawing.Point(88, 57);
            this.cBx_segelform.Name = "cBx_segelform";
            this.cBx_segelform.Size = new System.Drawing.Size(169, 21);
            this.cBx_segelform.TabIndex = 1;
            // 
            // cBx_stoff_kennung
            // 
            this.cBx_stoff_kennung.FormattingEnabled = true;
            this.cBx_stoff_kennung.Location = new System.Drawing.Point(88, 109);
            this.cBx_stoff_kennung.Name = "cBx_stoff_kennung";
            this.cBx_stoff_kennung.Size = new System.Drawing.Size(169, 21);
            this.cBx_stoff_kennung.TabIndex = 2;
            // 
            // cBx_stoff_hersteller
            // 
            this.cBx_stoff_hersteller.FormattingEnabled = true;
            this.cBx_stoff_hersteller.Location = new System.Drawing.Point(88, 84);
            this.cBx_stoff_hersteller.Name = "cBx_stoff_hersteller";
            this.cBx_stoff_hersteller.Size = new System.Drawing.Size(169, 21);
            this.cBx_stoff_hersteller.TabIndex = 26;
            this.cBx_stoff_hersteller.SelectedIndexChanged += new System.EventHandler(this.cBx_stoff_hersteller_SelectedIndexChanged);
            // 
            // UC_New_auftrag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_new_auf_save);
            this.Name = "UC_New_auftrag";
            this.Size = new System.Drawing.Size(832, 393);
            this.Load += new System.EventHandler(this.UC_New_auftrag_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker date_erstell;
        private System.Windows.Forms.DateTimePicker date_mont;
        private System.Windows.Forms.RichTextBox txt_info_kauf;
        private System.Windows.Forms.TextBox txt_auftrag_nr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_verant;
        private System.Windows.Forms.ComboBox cbx_tech;
        private System.Windows.Forms.Button btn_new_auf_save;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txt_info_tech;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Projektbezeichnung;
        private System.Windows.Forms.TextBox txt_auf_proj_ken;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolTip tti_new_auftrag;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cBx_seller;
        private System.Windows.Forms.ListBox lBx_segel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_add_segel;
        private System.Windows.Forms.ComboBox cBx_stoff_hersteller;
        private System.Windows.Forms.ComboBox cBx_stoff_kennung;
        private System.Windows.Forms.ComboBox cBx_segelform;
        private System.Windows.Forms.TextBox tBx_segel_name;
    }
}
