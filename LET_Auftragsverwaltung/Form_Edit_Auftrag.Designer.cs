namespace LET_Auftragsverwaltung
{
    partial class Form_Edit_Auftrag
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Edit_Auftrag));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Allgemein = new System.Windows.Forms.TabPage();
            this.Auftraginfos = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_add_segel = new System.Windows.Forms.Button();
            this.lBx_segel = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cBx_stoff_hersteller = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cBx_stoff_kennung = new System.Windows.Forms.ComboBox();
            this.cBx_segelform = new System.Windows.Forms.ComboBox();
            this.tBx_segel_name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_info_kauf = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_info_tech = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbx_seller_edit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Projektbezeichnung = new System.Windows.Forms.Label();
            this.cbx_auftragsstatus = new System.Windows.Forms.ComboBox();
            this.txt_auf_proj_ken = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_auftrag_nr = new System.Windows.Forms.TextBox();
            this.date_erstell = new System.Windows.Forms.DateTimePicker();
            this.date_mont = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_tech = new System.Windows.Forms.ComboBox();
            this.cbx_verant = new System.Windows.Forms.ComboBox();
            this.btn_save_infos = new System.Windows.Forms.Button();
            this.tab_kauf = new System.Windows.Forms.TabPage();
            this.btn_bestaetigungsmanager = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_date_kauf_edit_Schlussrechnung = new System.Windows.Forms.Button();
            this.lbl_kauf_Schlussrechnung_bestaetigt = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_save_kauf_Schlussrechnung = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.tBx_kauf_edit_Schlussrechnung = new System.Windows.Forms.RichTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbx_kauf_edit_Schlussrechnung = new System.Windows.Forms.ComboBox();
            this.date_kauf_edit_Schlussrechnung = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_date_kauf_edit_Anzahlung = new System.Windows.Forms.Button();
            this.lbl_kauf_Anzahlung_bestaetigt = new System.Windows.Forms.Label();
            this.btn_save_kauf_Anzahlung = new System.Windows.Forms.Button();
            this.tBx_kauf_edit_Anzahlung = new System.Windows.Forms.RichTextBox();
            this.cbx_kauf_edit_Anzahlung = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.date_kauf_edit_Anzahlung = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_date_kauf_edit_Auftragsbestaetigung = new System.Windows.Forms.Button();
            this.lbl_kauf_Auftrag_bestaetigt = new System.Windows.Forms.Label();
            this.btn_save_kauf_Auftragsbestaetigung = new System.Windows.Forms.Button();
            this.tBx_kauf_edit_Auftragsbestaetigung = new System.Windows.Forms.RichTextBox();
            this.cbx_kauf_edit_Auftragsbestaetigung = new System.Windows.Forms.ComboBox();
            this.date_kauf_edit_Auftragsbestaetigng = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tmr_break = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tab_Allgemein.SuspendLayout();
            this.Auftraginfos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tab_kauf.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Allgemein);
            this.tabControl1.Controls.Add(this.tab_kauf);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(950, 387);
            this.tabControl1.TabIndex = 36;
            // 
            // tab_Allgemein
            // 
            this.tab_Allgemein.Controls.Add(this.Auftraginfos);
            this.tab_Allgemein.Controls.Add(this.btn_save_infos);
            this.tab_Allgemein.Location = new System.Drawing.Point(4, 22);
            this.tab_Allgemein.Name = "tab_Allgemein";
            this.tab_Allgemein.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Allgemein.Size = new System.Drawing.Size(942, 361);
            this.tab_Allgemein.TabIndex = 0;
            this.tab_Allgemein.Text = "Allgemein";
            this.tab_Allgemein.UseVisualStyleBackColor = true;
            // 
            // Auftraginfos
            // 
            this.Auftraginfos.Controls.Add(this.groupBox2);
            this.Auftraginfos.Controls.Add(this.groupBox1);
            this.Auftraginfos.Controls.Add(this.groupBox3);
            this.Auftraginfos.Location = new System.Drawing.Point(6, 3);
            this.Auftraginfos.Name = "Auftraginfos";
            this.Auftraginfos.Size = new System.Drawing.Size(929, 330);
            this.Auftraginfos.TabIndex = 34;
            this.Auftraginfos.TabStop = false;
            this.Auftraginfos.Text = "Auftraginfos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_add_segel);
            this.groupBox2.Controls.Add(this.lBx_segel);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cBx_stoff_hersteller);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.cBx_stoff_kennung);
            this.groupBox2.Controls.Add(this.cBx_segelform);
            this.groupBox2.Controls.Add(this.tBx_segel_name);
            this.groupBox2.Location = new System.Drawing.Point(618, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 302);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Segel";
            // 
            // btn_add_segel
            // 
            this.btn_add_segel.Location = new System.Drawing.Point(188, 136);
            this.btn_add_segel.Name = "btn_add_segel";
            this.btn_add_segel.Size = new System.Drawing.Size(103, 23);
            this.btn_add_segel.TabIndex = 29;
            this.btn_add_segel.Text = "Hinzufügen";
            this.btn_add_segel.UseVisualStyleBackColor = true;
            this.btn_add_segel.Click += new System.EventHandler(this.Btn_add_segel_Click);
            // 
            // lBx_segel
            // 
            this.lBx_segel.FormattingEnabled = true;
            this.lBx_segel.Location = new System.Drawing.Point(6, 172);
            this.lBx_segel.Name = "lBx_segel";
            this.lBx_segel.Size = new System.Drawing.Size(285, 121);
            this.lBx_segel.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Stoff Hersteller";
            // 
            // cBx_stoff_hersteller
            // 
            this.cBx_stoff_hersteller.FormattingEnabled = true;
            this.cBx_stoff_hersteller.Location = new System.Drawing.Point(88, 84);
            this.cBx_stoff_hersteller.Name = "cBx_stoff_hersteller";
            this.cBx_stoff_hersteller.Size = new System.Drawing.Size(206, 21);
            this.cBx_stoff_hersteller.TabIndex = 26;
            this.cBx_stoff_hersteller.SelectedIndexChanged += new System.EventHandler(this.CBx_stoff_hersteller_SelectedIndexChanged);
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
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 112);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 13);
            this.label18.TabIndex = 24;
            this.label18.Text = "Stoff Kennung";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 33);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 13);
            this.label19.TabIndex = 23;
            this.label19.Text = "Segel Name";
            // 
            // cBx_stoff_kennung
            // 
            this.cBx_stoff_kennung.FormattingEnabled = true;
            this.cBx_stoff_kennung.Location = new System.Drawing.Point(88, 109);
            this.cBx_stoff_kennung.Name = "cBx_stoff_kennung";
            this.cBx_stoff_kennung.Size = new System.Drawing.Size(206, 21);
            this.cBx_stoff_kennung.TabIndex = 2;
            // 
            // cBx_segelform
            // 
            this.cBx_segelform.FormattingEnabled = true;
            this.cBx_segelform.Items.AddRange(new object[] {
            "Doppelsonnensegel",
            "Dreiecksonnensegel",
            "Trapezsonnensegel"});
            this.cBx_segelform.Location = new System.Drawing.Point(88, 57);
            this.cBx_segelform.Name = "cBx_segelform";
            this.cBx_segelform.Size = new System.Drawing.Size(206, 21);
            this.cBx_segelform.TabIndex = 1;
            // 
            // tBx_segel_name
            // 
            this.tBx_segel_name.Location = new System.Drawing.Point(87, 30);
            this.tBx_segel_name.Name = "tBx_segel_name";
            this.tBx_segel_name.Size = new System.Drawing.Size(207, 20);
            this.tBx_segel_name.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_info_kauf);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_info_tech);
            this.groupBox1.Location = new System.Drawing.Point(312, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 302);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notitzen";
            // 
            // txt_info_kauf
            // 
            this.txt_info_kauf.Location = new System.Drawing.Point(19, 179);
            this.txt_info_kauf.Name = "txt_info_kauf";
            this.txt_info_kauf.Size = new System.Drawing.Size(275, 108);
            this.txt_info_kauf.TabIndex = 5;
            this.txt_info_kauf.Text = "";
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
            this.label4.Location = new System.Drawing.Point(6, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Techniker";
            // 
            // txt_info_tech
            // 
            this.txt_info_tech.Location = new System.Drawing.Point(19, 39);
            this.txt_info_tech.Name = "txt_info_tech";
            this.txt_info_tech.Size = new System.Drawing.Size(275, 109);
            this.txt_info_tech.TabIndex = 24;
            this.txt_info_tech.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.cbx_seller_edit);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.Projektbezeichnung);
            this.groupBox3.Controls.Add(this.cbx_auftragsstatus);
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
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 302);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Allgemein";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 133);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 13);
            this.label20.TabIndex = 35;
            this.label20.Text = "Verkäufer";
            // 
            // cbx_seller_edit
            // 
            this.cbx_seller_edit.FormattingEnabled = true;
            this.cbx_seller_edit.Location = new System.Drawing.Point(124, 129);
            this.cbx_seller_edit.Name = "cbx_seller_edit";
            this.cbx_seller_edit.Size = new System.Drawing.Size(170, 21);
            this.cbx_seller_edit.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Auftragsstatus";
            // 
            // Projektbezeichnung
            // 
            this.Projektbezeichnung.AutoSize = true;
            this.Projektbezeichnung.Location = new System.Drawing.Point(6, 56);
            this.Projektbezeichnung.Name = "Projektbezeichnung";
            this.Projektbezeichnung.Size = new System.Drawing.Size(101, 13);
            this.Projektbezeichnung.TabIndex = 22;
            this.Projektbezeichnung.Text = "Projektbezeichnung";
            // 
            // cbx_auftragsstatus
            // 
            this.cbx_auftragsstatus.FormattingEnabled = true;
            this.cbx_auftragsstatus.Location = new System.Drawing.Point(124, 208);
            this.cbx_auftragsstatus.Name = "cbx_auftragsstatus";
            this.cbx_auftragsstatus.Size = new System.Drawing.Size(170, 21);
            this.cbx_auftragsstatus.TabIndex = 33;
            // 
            // txt_auf_proj_ken
            // 
            this.txt_auf_proj_ken.Location = new System.Drawing.Point(124, 49);
            this.txt_auf_proj_ken.Name = "txt_auf_proj_ken";
            this.txt_auf_proj_ken.Size = new System.Drawing.Size(170, 20);
            this.txt_auf_proj_ken.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Montagedatum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 162);
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
            // txt_auftrag_nr
            // 
            this.txt_auftrag_nr.Location = new System.Drawing.Point(124, 23);
            this.txt_auftrag_nr.Name = "txt_auftrag_nr";
            this.txt_auftrag_nr.Size = new System.Drawing.Size(170, 20);
            this.txt_auftrag_nr.TabIndex = 9;
            // 
            // date_erstell
            // 
            this.date_erstell.CustomFormat = "dd-mm-yyyy";
            this.date_erstell.Enabled = false;
            this.date_erstell.Location = new System.Drawing.Point(124, 156);
            this.date_erstell.Name = "date_erstell";
            this.date_erstell.Size = new System.Drawing.Size(170, 20);
            this.date_erstell.TabIndex = 1;
            this.date_erstell.Value = new System.DateTime(2018, 9, 3, 0, 0, 0, 0);
            // 
            // date_mont
            // 
            this.date_mont.CustomFormat = "dd-mm-yyyy";
            this.date_mont.Location = new System.Drawing.Point(124, 182);
            this.date_mont.Name = "date_mont";
            this.date_mont.Size = new System.Drawing.Size(170, 20);
            this.date_mont.TabIndex = 2;
            this.date_mont.Value = new System.DateTime(2018, 9, 3, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Verantwortlicher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Techniker";
            // 
            // cbx_tech
            // 
            this.cbx_tech.FormattingEnabled = true;
            this.cbx_tech.Location = new System.Drawing.Point(124, 102);
            this.cbx_tech.Name = "cbx_tech";
            this.cbx_tech.Size = new System.Drawing.Size(170, 21);
            this.cbx_tech.TabIndex = 17;
            // 
            // cbx_verant
            // 
            this.cbx_verant.FormattingEnabled = true;
            this.cbx_verant.Location = new System.Drawing.Point(124, 75);
            this.cbx_verant.Name = "cbx_verant";
            this.cbx_verant.Size = new System.Drawing.Size(170, 21);
            this.cbx_verant.TabIndex = 16;
            // 
            // btn_save_infos
            // 
            this.btn_save_infos.Location = new System.Drawing.Point(763, 336);
            this.btn_save_infos.Name = "btn_save_infos";
            this.btn_save_infos.Size = new System.Drawing.Size(173, 23);
            this.btn_save_infos.TabIndex = 18;
            this.btn_save_infos.Text = "Änderungen Speichern";
            this.btn_save_infos.UseVisualStyleBackColor = true;
            this.btn_save_infos.Click += new System.EventHandler(this.Btn_save_infos_Click);
            // 
            // tab_kauf
            // 
            this.tab_kauf.Controls.Add(this.btn_bestaetigungsmanager);
            this.tab_kauf.Controls.Add(this.groupBox4);
            this.tab_kauf.Controls.Add(this.groupBox5);
            this.tab_kauf.Controls.Add(this.groupBox6);
            this.tab_kauf.Location = new System.Drawing.Point(4, 22);
            this.tab_kauf.Name = "tab_kauf";
            this.tab_kauf.Size = new System.Drawing.Size(942, 361);
            this.tab_kauf.TabIndex = 5;
            this.tab_kauf.Text = "Kaufmänisch";
            this.tab_kauf.UseVisualStyleBackColor = true;
            // 
            // btn_bestaetigungsmanager
            // 
            this.btn_bestaetigungsmanager.Location = new System.Drawing.Point(6, 336);
            this.btn_bestaetigungsmanager.Name = "btn_bestaetigungsmanager";
            this.btn_bestaetigungsmanager.Size = new System.Drawing.Size(178, 23);
            this.btn_bestaetigungsmanager.TabIndex = 14;
            this.btn_bestaetigungsmanager.Text = "Bestätigungsmanager";
            this.btn_bestaetigungsmanager.UseVisualStyleBackColor = true;
            this.btn_bestaetigungsmanager.Click += new System.EventHandler(this.Btn_best_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_date_kauf_edit_Schlussrechnung);
            this.groupBox4.Controls.Add(this.lbl_kauf_Schlussrechnung_bestaetigt);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.btn_save_kauf_Schlussrechnung);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.tBx_kauf_edit_Schlussrechnung);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.cbx_kauf_edit_Schlussrechnung);
            this.groupBox4.Controls.Add(this.date_kauf_edit_Schlussrechnung);
            this.groupBox4.Location = new System.Drawing.Point(627, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(309, 327);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Schlussrechnung";
            // 
            // btn_date_kauf_edit_Schlussrechnung
            // 
            this.btn_date_kauf_edit_Schlussrechnung.Location = new System.Drawing.Point(111, 65);
            this.btn_date_kauf_edit_Schlussrechnung.Name = "btn_date_kauf_edit_Schlussrechnung";
            this.btn_date_kauf_edit_Schlussrechnung.Size = new System.Drawing.Size(178, 23);
            this.btn_date_kauf_edit_Schlussrechnung.TabIndex = 14;
            this.btn_date_kauf_edit_Schlussrechnung.Text = "Aktuelles Datum";
            this.btn_date_kauf_edit_Schlussrechnung.UseVisualStyleBackColor = true;
            this.btn_date_kauf_edit_Schlussrechnung.Click += new System.EventHandler(this.Btn_date_kauf_edit_schluss_Click);
            // 
            // lbl_kauf_Schlussrechnung_bestaetigt
            // 
            this.lbl_kauf_Schlussrechnung_bestaetigt.AutoSize = true;
            this.lbl_kauf_Schlussrechnung_bestaetigt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kauf_Schlussrechnung_bestaetigt.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_kauf_Schlussrechnung_bestaetigt.Location = new System.Drawing.Point(108, 16);
            this.lbl_kauf_Schlussrechnung_bestaetigt.Name = "lbl_kauf_Schlussrechnung_bestaetigt";
            this.lbl_kauf_Schlussrechnung_bestaetigt.Size = new System.Drawing.Size(158, 13);
            this.lbl_kauf_Schlussrechnung_bestaetigt.TabIndex = 13;
            this.lbl_kauf_Schlussrechnung_bestaetigt.Text = "Schlussrechnung ist fertig!";
            this.lbl_kauf_Schlussrechnung_bestaetigt.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Infos für Sandra";
            // 
            // btn_save_kauf_Schlussrechnung
            // 
            this.btn_save_kauf_Schlussrechnung.Location = new System.Drawing.Point(111, 298);
            this.btn_save_kauf_Schlussrechnung.Name = "btn_save_kauf_Schlussrechnung";
            this.btn_save_kauf_Schlussrechnung.Size = new System.Drawing.Size(178, 23);
            this.btn_save_kauf_Schlussrechnung.TabIndex = 7;
            this.btn_save_kauf_Schlussrechnung.Text = "Anfordern bei Sandra";
            this.btn_save_kauf_Schlussrechnung.UseVisualStyleBackColor = true;
            this.btn_save_kauf_Schlussrechnung.Click += new System.EventHandler(this.Btn_save_kauf_edit_schluss_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Anfordernde Person";
            // 
            // tBx_kauf_edit_Schlussrechnung
            // 
            this.tBx_kauf_edit_Schlussrechnung.Location = new System.Drawing.Point(111, 133);
            this.tBx_kauf_edit_Schlussrechnung.Name = "tBx_kauf_edit_Schlussrechnung";
            this.tBx_kauf_edit_Schlussrechnung.Size = new System.Drawing.Size(178, 159);
            this.tBx_kauf_edit_Schlussrechnung.TabIndex = 5;
            this.tBx_kauf_edit_Schlussrechnung.Text = "";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Rechnungs-Datum";
            // 
            // cbx_kauf_edit_Schlussrechnung
            // 
            this.cbx_kauf_edit_Schlussrechnung.FormattingEnabled = true;
            this.cbx_kauf_edit_Schlussrechnung.Location = new System.Drawing.Point(111, 106);
            this.cbx_kauf_edit_Schlussrechnung.Name = "cbx_kauf_edit_Schlussrechnung";
            this.cbx_kauf_edit_Schlussrechnung.Size = new System.Drawing.Size(178, 21);
            this.cbx_kauf_edit_Schlussrechnung.TabIndex = 4;
            // 
            // date_kauf_edit_Schlussrechnung
            // 
            this.date_kauf_edit_Schlussrechnung.Location = new System.Drawing.Point(111, 39);
            this.date_kauf_edit_Schlussrechnung.Name = "date_kauf_edit_Schlussrechnung";
            this.date_kauf_edit_Schlussrechnung.Size = new System.Drawing.Size(178, 20);
            this.date_kauf_edit_Schlussrechnung.TabIndex = 0;
            this.date_kauf_edit_Schlussrechnung.CloseUp += new System.EventHandler(this.Date_kauf_edit_schluss_CloseUp);
            this.date_kauf_edit_Schlussrechnung.ValueChanged += new System.EventHandler(this.Date_kauf_edit_schluss_ValueChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_date_kauf_edit_Anzahlung);
            this.groupBox5.Controls.Add(this.lbl_kauf_Anzahlung_bestaetigt);
            this.groupBox5.Controls.Add(this.btn_save_kauf_Anzahlung);
            this.groupBox5.Controls.Add(this.tBx_kauf_edit_Anzahlung);
            this.groupBox5.Controls.Add(this.cbx_kauf_edit_Anzahlung);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.date_kauf_edit_Anzahlung);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Location = new System.Drawing.Point(317, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(309, 327);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Anzahlungsrechnung";
            // 
            // btn_date_kauf_edit_Anzahlung
            // 
            this.btn_date_kauf_edit_Anzahlung.Location = new System.Drawing.Point(109, 65);
            this.btn_date_kauf_edit_Anzahlung.Name = "btn_date_kauf_edit_Anzahlung";
            this.btn_date_kauf_edit_Anzahlung.Size = new System.Drawing.Size(180, 23);
            this.btn_date_kauf_edit_Anzahlung.TabIndex = 13;
            this.btn_date_kauf_edit_Anzahlung.Text = "Aktuelles Datum";
            this.btn_date_kauf_edit_Anzahlung.UseVisualStyleBackColor = true;
            this.btn_date_kauf_edit_Anzahlung.Click += new System.EventHandler(this.Btn_date_kauf_edit_anz_Click);
            // 
            // lbl_kauf_Anzahlung_bestaetigt
            // 
            this.lbl_kauf_Anzahlung_bestaetigt.AutoSize = true;
            this.lbl_kauf_Anzahlung_bestaetigt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kauf_Anzahlung_bestaetigt.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_kauf_Anzahlung_bestaetigt.Location = new System.Drawing.Point(106, 16);
            this.lbl_kauf_Anzahlung_bestaetigt.Name = "lbl_kauf_Anzahlung_bestaetigt";
            this.lbl_kauf_Anzahlung_bestaetigt.Size = new System.Drawing.Size(165, 13);
            this.lbl_kauf_Anzahlung_bestaetigt.TabIndex = 12;
            this.lbl_kauf_Anzahlung_bestaetigt.Text = "Anzahlung ist schon erfolgt!";
            this.lbl_kauf_Anzahlung_bestaetigt.Visible = false;
            // 
            // btn_save_kauf_Anzahlung
            // 
            this.btn_save_kauf_Anzahlung.Location = new System.Drawing.Point(109, 298);
            this.btn_save_kauf_Anzahlung.Name = "btn_save_kauf_Anzahlung";
            this.btn_save_kauf_Anzahlung.Size = new System.Drawing.Size(180, 23);
            this.btn_save_kauf_Anzahlung.TabIndex = 6;
            this.btn_save_kauf_Anzahlung.Text = "Anfordern bei Sandra";
            this.btn_save_kauf_Anzahlung.UseVisualStyleBackColor = true;
            this.btn_save_kauf_Anzahlung.Click += new System.EventHandler(this.Btn_save_kauf_edit_anz_Click);
            // 
            // tBx_kauf_edit_Anzahlung
            // 
            this.tBx_kauf_edit_Anzahlung.Location = new System.Drawing.Point(109, 133);
            this.tBx_kauf_edit_Anzahlung.Name = "tBx_kauf_edit_Anzahlung";
            this.tBx_kauf_edit_Anzahlung.Size = new System.Drawing.Size(180, 159);
            this.tBx_kauf_edit_Anzahlung.TabIndex = 4;
            this.tBx_kauf_edit_Anzahlung.Text = "";
            // 
            // cbx_kauf_edit_Anzahlung
            // 
            this.cbx_kauf_edit_Anzahlung.FormattingEnabled = true;
            this.cbx_kauf_edit_Anzahlung.Location = new System.Drawing.Point(109, 106);
            this.cbx_kauf_edit_Anzahlung.Name = "cbx_kauf_edit_Anzahlung";
            this.cbx_kauf_edit_Anzahlung.Size = new System.Drawing.Size(180, 21);
            this.cbx_kauf_edit_Anzahlung.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 136);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Infos für Sandra";
            // 
            // date_kauf_edit_Anzahlung
            // 
            this.date_kauf_edit_Anzahlung.Location = new System.Drawing.Point(109, 39);
            this.date_kauf_edit_Anzahlung.Name = "date_kauf_edit_Anzahlung";
            this.date_kauf_edit_Anzahlung.Size = new System.Drawing.Size(180, 20);
            this.date_kauf_edit_Anzahlung.TabIndex = 1;
            this.date_kauf_edit_Anzahlung.CloseUp += new System.EventHandler(this.Date_kauf_edit_anz_CloseUp);
            this.date_kauf_edit_Anzahlung.ValueChanged += new System.EventHandler(this.Date_kauf_edit_anz_ValueChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 109);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(101, 13);
            this.label21.TabIndex = 9;
            this.label21.Text = "Anfordernde Person";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 45);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(96, 13);
            this.label22.TabIndex = 8;
            this.label22.Text = "Rechnungs-Datum";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn_date_kauf_edit_Auftragsbestaetigung);
            this.groupBox6.Controls.Add(this.lbl_kauf_Auftrag_bestaetigt);
            this.groupBox6.Controls.Add(this.btn_save_kauf_Auftragsbestaetigung);
            this.groupBox6.Controls.Add(this.tBx_kauf_edit_Auftragsbestaetigung);
            this.groupBox6.Controls.Add(this.cbx_kauf_edit_Auftragsbestaetigung);
            this.groupBox6.Controls.Add(this.date_kauf_edit_Auftragsbestaetigng);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Location = new System.Drawing.Point(7, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(309, 327);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Auftragsbestätigung";
            // 
            // btn_date_kauf_edit_Auftragsbestaetigung
            // 
            this.btn_date_kauf_edit_Auftragsbestaetigung.Location = new System.Drawing.Point(111, 65);
            this.btn_date_kauf_edit_Auftragsbestaetigung.Name = "btn_date_kauf_edit_Auftragsbestaetigung";
            this.btn_date_kauf_edit_Auftragsbestaetigung.Size = new System.Drawing.Size(178, 23);
            this.btn_date_kauf_edit_Auftragsbestaetigung.TabIndex = 12;
            this.btn_date_kauf_edit_Auftragsbestaetigung.Text = "Aktuelles Datum";
            this.btn_date_kauf_edit_Auftragsbestaetigung.UseVisualStyleBackColor = true;
            this.btn_date_kauf_edit_Auftragsbestaetigung.Click += new System.EventHandler(this.Btn_date_kauf_edit_auf_Click);
            // 
            // lbl_kauf_Auftrag_bestaetigt
            // 
            this.lbl_kauf_Auftrag_bestaetigt.AutoSize = true;
            this.lbl_kauf_Auftrag_bestaetigt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kauf_Auftrag_bestaetigt.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_kauf_Auftrag_bestaetigt.Location = new System.Drawing.Point(108, 16);
            this.lbl_kauf_Auftrag_bestaetigt.Name = "lbl_kauf_Auftrag_bestaetigt";
            this.lbl_kauf_Auftrag_bestaetigt.Size = new System.Drawing.Size(179, 13);
            this.lbl_kauf_Auftrag_bestaetigt.TabIndex = 11;
            this.lbl_kauf_Auftrag_bestaetigt.Text = "Bestätigungs ist schon erfolgt!";
            this.lbl_kauf_Auftrag_bestaetigt.Visible = false;
            // 
            // btn_save_kauf_Auftragsbestaetigung
            // 
            this.btn_save_kauf_Auftragsbestaetigung.Location = new System.Drawing.Point(111, 298);
            this.btn_save_kauf_Auftragsbestaetigung.Name = "btn_save_kauf_Auftragsbestaetigung";
            this.btn_save_kauf_Auftragsbestaetigung.Size = new System.Drawing.Size(178, 23);
            this.btn_save_kauf_Auftragsbestaetigung.TabIndex = 5;
            this.btn_save_kauf_Auftragsbestaetigung.Text = "Anfordern bei Sandra";
            this.btn_save_kauf_Auftragsbestaetigung.UseVisualStyleBackColor = true;
            this.btn_save_kauf_Auftragsbestaetigung.Click += new System.EventHandler(this.Btn_save_kauf_edit_auf_Click);
            // 
            // tBx_kauf_edit_Auftragsbestaetigung
            // 
            this.tBx_kauf_edit_Auftragsbestaetigung.Location = new System.Drawing.Point(111, 133);
            this.tBx_kauf_edit_Auftragsbestaetigung.Name = "tBx_kauf_edit_Auftragsbestaetigung";
            this.tBx_kauf_edit_Auftragsbestaetigung.Size = new System.Drawing.Size(178, 159);
            this.tBx_kauf_edit_Auftragsbestaetigung.TabIndex = 3;
            this.tBx_kauf_edit_Auftragsbestaetigung.Text = "";
            // 
            // cbx_kauf_edit_Auftragsbestaetigung
            // 
            this.cbx_kauf_edit_Auftragsbestaetigung.FormattingEnabled = true;
            this.cbx_kauf_edit_Auftragsbestaetigung.Location = new System.Drawing.Point(111, 106);
            this.cbx_kauf_edit_Auftragsbestaetigung.Name = "cbx_kauf_edit_Auftragsbestaetigung";
            this.cbx_kauf_edit_Auftragsbestaetigung.Size = new System.Drawing.Size(178, 21);
            this.cbx_kauf_edit_Auftragsbestaetigung.TabIndex = 3;
            // 
            // date_kauf_edit_Auftragsbestaetigng
            // 
            this.date_kauf_edit_Auftragsbestaetigng.Location = new System.Drawing.Point(111, 39);
            this.date_kauf_edit_Auftragsbestaetigng.Name = "date_kauf_edit_Auftragsbestaetigng";
            this.date_kauf_edit_Auftragsbestaetigng.Size = new System.Drawing.Size(178, 20);
            this.date_kauf_edit_Auftragsbestaetigng.TabIndex = 2;
            this.date_kauf_edit_Auftragsbestaetigng.CloseUp += new System.EventHandler(this.Date_kauf_edit_auf_CloseUp);
            this.date_kauf_edit_Auftragsbestaetigng.ValueChanged += new System.EventHandler(this.Date_kauf_edit_auf_ValueChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 45);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 13);
            this.label23.TabIndex = 5;
            this.label23.Text = "AB-Datum";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 109);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(101, 13);
            this.label24.TabIndex = 6;
            this.label24.Text = "Anfordernde Person";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 136);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(82, 13);
            this.label25.TabIndex = 7;
            this.label25.Text = "Infos für Sandra";
            this.label25.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tmr_break
            // 
            this.tmr_break.Interval = 2000;
            this.tmr_break.Tick += new System.EventHandler(this.Tmr_break_Tick);
            // 
            // Form_Edit_Auftrag_new
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 392);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Edit_Auftrag_new";
            this.Text = "Form_Edit_Auftrag_new";
            this.Load += new System.EventHandler(this.Form_Edit_Auftrag_new_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_Allgemein.ResumeLayout(false);
            this.Auftraginfos.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tab_kauf.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Allgemein;
        private System.Windows.Forms.GroupBox Auftraginfos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_add_segel;
        private System.Windows.Forms.ListBox lBx_segel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cBx_stoff_hersteller;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cBx_stoff_kennung;
        private System.Windows.Forms.ComboBox cBx_segelform;
        private System.Windows.Forms.TextBox tBx_segel_name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txt_info_kauf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txt_info_tech;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbx_seller_edit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Projektbezeichnung;
        private System.Windows.Forms.ComboBox cbx_auftragsstatus;
        private System.Windows.Forms.TextBox txt_auf_proj_ken;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_auftrag_nr;
        private System.Windows.Forms.DateTimePicker date_erstell;
        private System.Windows.Forms.DateTimePicker date_mont;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_tech;
        private System.Windows.Forms.ComboBox cbx_verant;
        private System.Windows.Forms.Button btn_save_infos;
        private System.Windows.Forms.TabPage tab_kauf;
        private System.Windows.Forms.Button btn_bestaetigungsmanager;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_date_kauf_edit_Schlussrechnung;
        private System.Windows.Forms.Label lbl_kauf_Schlussrechnung_bestaetigt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_save_kauf_Schlussrechnung;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox tBx_kauf_edit_Schlussrechnung;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbx_kauf_edit_Schlussrechnung;
        private System.Windows.Forms.DateTimePicker date_kauf_edit_Schlussrechnung;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_date_kauf_edit_Anzahlung;
        private System.Windows.Forms.Label lbl_kauf_Anzahlung_bestaetigt;
        private System.Windows.Forms.Button btn_save_kauf_Anzahlung;
        private System.Windows.Forms.RichTextBox tBx_kauf_edit_Anzahlung;
        private System.Windows.Forms.ComboBox cbx_kauf_edit_Anzahlung;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker date_kauf_edit_Anzahlung;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_date_kauf_edit_Auftragsbestaetigung;
        private System.Windows.Forms.Label lbl_kauf_Auftrag_bestaetigt;
        private System.Windows.Forms.Button btn_save_kauf_Auftragsbestaetigung;
        private System.Windows.Forms.RichTextBox tBx_kauf_edit_Auftragsbestaetigung;
        private System.Windows.Forms.ComboBox cbx_kauf_edit_Auftragsbestaetigung;
        private System.Windows.Forms.DateTimePicker date_kauf_edit_Auftragsbestaetigng;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Timer tmr_break;
    }
}