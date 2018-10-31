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
            this.date_erstell = new System.Windows.Forms.DateTimePicker();
            this.date_mont = new System.Windows.Forms.DateTimePicker();
            this.txt_info_kauf = new System.Windows.Forms.RichTextBox();
            this.lbx_auftrag = new System.Windows.Forms.ListBox();
            this.txt_auftrag_nr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_auftrag = new System.Windows.Forms.ComboBox();
            this.btn_auftrag_add = new System.Windows.Forms.Button();
            this.btn_auftag_delete = new System.Windows.Forms.Button();
            this.cbx_verant = new System.Windows.Forms.ComboBox();
            this.cbx_tech = new System.Windows.Forms.ComboBox();
            this.btn_new_auf_save = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Projektbezeichnung = new System.Windows.Forms.Label();
            this.txt_auf_proj_ken = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_info_tech = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pbx_new_auf = new System.Windows.Forms.PictureBox();
            this.cbx_new_auf_stoff = new System.Windows.Forms.ComboBox();
            this.cbx_new_auf_lief = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_new_auf)).BeginInit();
            this.SuspendLayout();
            // 
            // date_erstell
            // 
            this.date_erstell.CustomFormat = "dd-mm-yyyy";
            this.date_erstell.Location = new System.Drawing.Point(113, 209);
            this.date_erstell.Name = "date_erstell";
            this.date_erstell.Size = new System.Drawing.Size(144, 20);
            this.date_erstell.TabIndex = 1;
            this.date_erstell.Value = new System.DateTime(2018, 9, 5, 14, 26, 25, 0);
            // 
            // date_mont
            // 
            this.date_mont.CustomFormat = "MM-dd-yy";
            this.date_mont.Location = new System.Drawing.Point(113, 259);
            this.date_mont.Name = "date_mont";
            this.date_mont.Size = new System.Drawing.Size(144, 20);
            this.date_mont.TabIndex = 2;
            // 
            // txt_info_kauf
            // 
            this.txt_info_kauf.Location = new System.Drawing.Point(19, 39);
            this.txt_info_kauf.Name = "txt_info_kauf";
            this.txt_info_kauf.Size = new System.Drawing.Size(257, 66);
            this.txt_info_kauf.TabIndex = 5;
            this.txt_info_kauf.Text = "";
            // 
            // lbx_auftrag
            // 
            this.lbx_auftrag.FormattingEnabled = true;
            this.lbx_auftrag.Location = new System.Drawing.Point(6, 68);
            this.lbx_auftrag.Name = "lbx_auftrag";
            this.lbx_auftrag.Size = new System.Drawing.Size(188, 95);
            this.lbx_auftrag.TabIndex = 6;
            // 
            // txt_auftrag_nr
            // 
            this.txt_auftrag_nr.Location = new System.Drawing.Point(113, 23);
            this.txt_auftrag_nr.Name = "txt_auftrag_nr";
            this.txt_auftrag_nr.Size = new System.Drawing.Size(144, 20);
            this.txt_auftrag_nr.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Verantwortlicher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Techniker";
            // 
            // cbx_auftrag
            // 
            this.cbx_auftrag.FormattingEnabled = true;
            this.cbx_auftrag.Location = new System.Drawing.Point(6, 174);
            this.cbx_auftrag.Name = "cbx_auftrag";
            this.cbx_auftrag.Size = new System.Drawing.Size(188, 21);
            this.cbx_auftrag.TabIndex = 13;
            // 
            // btn_auftrag_add
            // 
            this.btn_auftrag_add.Location = new System.Drawing.Point(6, 201);
            this.btn_auftrag_add.Name = "btn_auftrag_add";
            this.btn_auftrag_add.Size = new System.Drawing.Size(188, 23);
            this.btn_auftrag_add.TabIndex = 14;
            this.btn_auftrag_add.Text = "Hinzufügen";
            this.btn_auftrag_add.UseVisualStyleBackColor = true;
            this.btn_auftrag_add.Click += new System.EventHandler(this.btn_auftrag_add_Click);
            // 
            // btn_auftag_delete
            // 
            this.btn_auftag_delete.Location = new System.Drawing.Point(6, 23);
            this.btn_auftag_delete.Name = "btn_auftag_delete";
            this.btn_auftag_delete.Size = new System.Drawing.Size(188, 23);
            this.btn_auftag_delete.TabIndex = 15;
            this.btn_auftag_delete.Text = "Löschen";
            this.btn_auftag_delete.UseVisualStyleBackColor = true;
            this.btn_auftag_delete.Click += new System.EventHandler(this.btn_auftag_delete_Click);
            // 
            // cbx_verant
            // 
            this.cbx_verant.FormattingEnabled = true;
            this.cbx_verant.Location = new System.Drawing.Point(113, 105);
            this.cbx_verant.Name = "cbx_verant";
            this.cbx_verant.Size = new System.Drawing.Size(144, 21);
            this.cbx_verant.TabIndex = 16;
            // 
            // cbx_tech
            // 
            this.cbx_tech.FormattingEnabled = true;
            this.cbx_tech.Location = new System.Drawing.Point(113, 155);
            this.cbx_tech.Name = "cbx_tech";
            this.cbx_tech.Size = new System.Drawing.Size(144, 21);
            this.cbx_tech.TabIndex = 17;
            // 
            // btn_new_auf_save
            // 
            this.btn_new_auf_save.Location = new System.Drawing.Point(584, 362);
            this.btn_new_auf_save.Name = "btn_new_auf_save";
            this.btn_new_auf_save.Size = new System.Drawing.Size(192, 23);
            this.btn_new_auf_save.TabIndex = 19;
            this.btn_new_auf_save.Text = "Speichern";
            this.btn_new_auf_save.UseVisualStyleBackColor = true;
            this.btn_new_auf_save.Click += new System.EventHandler(this.Btn_new_auf_save_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbx_auftrag);
            this.groupBox2.Controls.Add(this.cbx_auftrag);
            this.groupBox2.Controls.Add(this.btn_auftrag_add);
            this.groupBox2.Controls.Add(this.btn_auftag_delete);
            this.groupBox2.Location = new System.Drawing.Point(288, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 230);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Auftragsart";
            // 
            // groupBox3
            // 
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
            // Projektbezeichnung
            // 
            this.Projektbezeichnung.AutoSize = true;
            this.Projektbezeichnung.Location = new System.Drawing.Point(6, 72);
            this.Projektbezeichnung.Name = "Projektbezeichnung";
            this.Projektbezeichnung.Size = new System.Drawing.Size(101, 13);
            this.Projektbezeichnung.TabIndex = 22;
            this.Projektbezeichnung.Text = "Projektbezeichnung";
            // 
            // txt_auf_proj_ken
            // 
            this.txt_auf_proj_ken.Location = new System.Drawing.Point(113, 65);
            this.txt_auf_proj_ken.Name = "txt_auf_proj_ken";
            this.txt_auf_proj_ken.Size = new System.Drawing.Size(144, 20);
            this.txt_auf_proj_ken.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Montagedatum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Erstelldatum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Auftragsnummer";
            // 
            // txt_info_tech
            // 
            this.txt_info_tech.Location = new System.Drawing.Point(19, 148);
            this.txt_info_tech.Name = "txt_info_tech";
            this.txt_info_tech.Size = new System.Drawing.Size(257, 66);
            this.txt_info_tech.TabIndex = 24;
            this.txt_info_tech.Text = "";
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
            this.label4.Location = new System.Drawing.Point(6, 132);
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
            this.groupBox1.Location = new System.Drawing.Point(494, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 230);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notitzen";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pbx_new_auf);
            this.groupBox4.Controls.Add(this.cbx_new_auf_stoff);
            this.groupBox4.Controls.Add(this.cbx_new_auf_lief);
            this.groupBox4.Location = new System.Drawing.Point(289, 285);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(487, 62);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Stoffauswahl";
            // 
            // pbx_new_auf
            // 
            this.pbx_new_auf.Location = new System.Drawing.Point(308, 12);
            this.pbx_new_auf.Name = "pbx_new_auf";
            this.pbx_new_auf.Size = new System.Drawing.Size(173, 44);
            this.pbx_new_auf.TabIndex = 2;
            this.pbx_new_auf.TabStop = false;
            // 
            // cbx_new_auf_stoff
            // 
            this.cbx_new_auf_stoff.Enabled = false;
            this.cbx_new_auf_stoff.FormattingEnabled = true;
            this.cbx_new_auf_stoff.Location = new System.Drawing.Point(167, 35);
            this.cbx_new_auf_stoff.Name = "cbx_new_auf_stoff";
            this.cbx_new_auf_stoff.Size = new System.Drawing.Size(121, 21);
            this.cbx_new_auf_stoff.TabIndex = 1;
            // 
            // cbx_new_auf_lief
            // 
            this.cbx_new_auf_lief.FormattingEnabled = true;
            this.cbx_new_auf_lief.Location = new System.Drawing.Point(6, 35);
            this.cbx_new_auf_lief.Name = "cbx_new_auf_lief";
            this.cbx_new_auf_lief.Size = new System.Drawing.Size(121, 21);
            this.cbx_new_auf_lief.TabIndex = 0;
            this.cbx_new_auf_lief.DropDownClosed += new System.EventHandler(this.cbx_new_auf_lief_DropDownClosed);
            // 
            // UC_New_auftrag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_new_auf_save);
            this.Name = "UC_New_auftrag";
            this.Size = new System.Drawing.Size(781, 393);
            this.Load += new System.EventHandler(this.UC_New_auftrag_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_new_auf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker date_erstell;
        private System.Windows.Forms.DateTimePicker date_mont;
        private System.Windows.Forms.RichTextBox txt_info_kauf;
        private System.Windows.Forms.ListBox lbx_auftrag;
        private System.Windows.Forms.TextBox txt_auftrag_nr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_auftrag;
        private System.Windows.Forms.Button btn_auftrag_add;
        private System.Windows.Forms.Button btn_auftag_delete;
        private System.Windows.Forms.ComboBox cbx_verant;
        private System.Windows.Forms.ComboBox cbx_tech;
        private System.Windows.Forms.Button btn_new_auf_save;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pbx_new_auf;
        private System.Windows.Forms.ComboBox cbx_new_auf_stoff;
        private System.Windows.Forms.ComboBox cbx_new_auf_lief;
    }
}
