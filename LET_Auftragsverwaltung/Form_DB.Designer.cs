namespace LET_Auftragsverwaltung
{
    partial class Form_DB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DB));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lBx_pers_Funktionen = new System.Windows.Forms.ListBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_pers_funk_add = new System.Windows.Forms.Button();
            this.btn_pers_funk_del = new System.Windows.Forms.Button();
            this.lbx_pers_Funktion_used = new System.Windows.Forms.ListBox();
            this.lbx_Personen = new System.Windows.Forms.ListBox();
            this.btn_pers_delete = new System.Windows.Forms.Button();
            this.btn_pers_edit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tBx_pers_Ort = new System.Windows.Forms.TextBox();
            this.tBx_pers_str = new System.Windows.Forms.TextBox();
            this.tbx_pers_Land = new System.Windows.Forms.TextBox();
            this.tBx_pers_strnum = new System.Windows.Forms.TextBox();
            this.tBx_pers_plz = new System.Windows.Forms.TextBox();
            this.tBx_pers_Nachname = new System.Windows.Forms.TextBox();
            this.tBx_pers_Vorname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_pers_save = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_lief_delete = new System.Windows.Forms.Button();
            this.lbx_Lieferanten = new System.Windows.Forms.ListBox();
            this.btn_lief_edit = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tBx_lief_Ort = new System.Windows.Forms.TextBox();
            this.tBx_lief_str = new System.Windows.Forms.TextBox();
            this.tBx_lief_Land = new System.Windows.Forms.TextBox();
            this.tBx_lief_strnum = new System.Windows.Forms.TextBox();
            this.tBx_lief_plz = new System.Windows.Forms.TextBox();
            this.tBx_lief_Kennung = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btn_lief_save = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btn_stoff_delete = new System.Windows.Forms.Button();
            this.lBx_stoff = new System.Windows.Forms.ListBox();
            this.cBx_stoff_lief_3 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cBx_stoff_lief_2 = new System.Windows.Forms.ComboBox();
            this.btn_stoff_load_file = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tBx_stoff_ID = new System.Windows.Forms.TextBox();
            this.cBx_stoff_lief_1 = new System.Windows.Forms.ComboBox();
            this.btn_stoff_save = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.tBx_stoff_name = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.toolTip_hoover = new System.Windows.Forms.ToolTip(this.components);
            this.oFD_stoff = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(852, 402);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lBx_pers_Funktionen);
            this.tabPage1.Controls.Add(this.label32);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.btn_pers_funk_add);
            this.tabPage1.Controls.Add(this.btn_pers_funk_del);
            this.tabPage1.Controls.Add(this.lbx_pers_Funktion_used);
            this.tabPage1.Controls.Add(this.lbx_Personen);
            this.tabPage1.Controls.Add(this.btn_pers_delete);
            this.tabPage1.Controls.Add(this.btn_pers_edit);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.tBx_pers_Ort);
            this.tabPage1.Controls.Add(this.tBx_pers_str);
            this.tabPage1.Controls.Add(this.tbx_pers_Land);
            this.tabPage1.Controls.Add(this.tBx_pers_strnum);
            this.tabPage1.Controls.Add(this.tBx_pers_plz);
            this.tabPage1.Controls.Add(this.tBx_pers_Nachname);
            this.tabPage1.Controls.Add(this.tBx_pers_Vorname);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_pers_save);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(844, 376);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lBx_pers_Funktionen
            // 
            this.lBx_pers_Funktionen.FormattingEnabled = true;
            this.lBx_pers_Funktionen.Location = new System.Drawing.Point(425, 58);
            this.lBx_pers_Funktionen.Name = "lBx_pers_Funktionen";
            this.lBx_pers_Funktionen.Size = new System.Drawing.Size(77, 238);
            this.lBx_pers_Funktionen.TabIndex = 43;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(656, 21);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(100, 24);
            this.label32.TabIndex = 42;
            this.label32.Text = "Personen";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(421, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 24);
            this.label12.TabIndex = 41;
            this.label12.Text = "Funktionen ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(106, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 24);
            this.label7.TabIndex = 40;
            this.label7.Text = "Hinzufügen";
            // 
            // btn_pers_funk_add
            // 
            this.btn_pers_funk_add.Location = new System.Drawing.Point(508, 59);
            this.btn_pers_funk_add.Name = "btn_pers_funk_add";
            this.btn_pers_funk_add.Size = new System.Drawing.Size(30, 23);
            this.btn_pers_funk_add.TabIndex = 13;
            this.btn_pers_funk_add.Text = "-->";
            this.btn_pers_funk_add.UseVisualStyleBackColor = true;
            this.btn_pers_funk_add.Click += new System.EventHandler(this.Btn_pers_funk_add_Click);
            // 
            // btn_pers_funk_del
            // 
            this.btn_pers_funk_del.Location = new System.Drawing.Point(508, 88);
            this.btn_pers_funk_del.Name = "btn_pers_funk_del";
            this.btn_pers_funk_del.Size = new System.Drawing.Size(30, 23);
            this.btn_pers_funk_del.TabIndex = 11;
            this.btn_pers_funk_del.Text = "<--";
            this.btn_pers_funk_del.UseVisualStyleBackColor = true;
            this.btn_pers_funk_del.Click += new System.EventHandler(this.Btn_pers_funk_del_Click);
            // 
            // lbx_pers_Funktion_used
            // 
            this.lbx_pers_Funktion_used.FormattingEnabled = true;
            this.lbx_pers_Funktion_used.Location = new System.Drawing.Point(544, 59);
            this.lbx_pers_Funktion_used.Name = "lbx_pers_Funktion_used";
            this.lbx_pers_Funktion_used.Size = new System.Drawing.Size(77, 238);
            this.lbx_pers_Funktion_used.TabIndex = 10;
            // 
            // lbx_Personen
            // 
            this.lbx_Personen.FormattingEnabled = true;
            this.lbx_Personen.Location = new System.Drawing.Point(660, 58);
            this.lbx_Personen.Name = "lbx_Personen";
            this.lbx_Personen.ScrollAlwaysVisible = true;
            this.lbx_Personen.Size = new System.Drawing.Size(178, 238);
            this.lbx_Personen.TabIndex = 14;
            this.lbx_Personen.DoubleClick += new System.EventHandler(this.Lbx_Personen_DoubleClick);
            // 
            // btn_pers_delete
            // 
            this.btn_pers_delete.Location = new System.Drawing.Point(729, 307);
            this.btn_pers_delete.Name = "btn_pers_delete";
            this.btn_pers_delete.Size = new System.Drawing.Size(109, 23);
            this.btn_pers_delete.TabIndex = 15;
            this.btn_pers_delete.Text = "Löschen";
            this.btn_pers_delete.UseVisualStyleBackColor = true;
            this.btn_pers_delete.Click += new System.EventHandler(this.Btn_pers_delete_Click);
            // 
            // btn_pers_edit
            // 
            this.btn_pers_edit.Location = new System.Drawing.Point(279, 349);
            this.btn_pers_edit.Name = "btn_pers_edit";
            this.btn_pers_edit.Size = new System.Drawing.Size(109, 23);
            this.btn_pers_edit.TabIndex = 9;
            this.btn_pers_edit.Text = "Bearbeiten";
            this.btn_pers_edit.UseVisualStyleBackColor = true;
            this.btn_pers_edit.Click += new System.EventHandler(this.Btn_pers_edit_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 352);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "* Pflichtfelder";
            // 
            // tBx_pers_Ort
            // 
            this.tBx_pers_Ort.Location = new System.Drawing.Point(255, 187);
            this.tBx_pers_Ort.Name = "tBx_pers_Ort";
            this.tBx_pers_Ort.Size = new System.Drawing.Size(138, 20);
            this.tBx_pers_Ort.TabIndex = 6;
            // 
            // tBx_pers_str
            // 
            this.tBx_pers_str.Location = new System.Drawing.Point(110, 148);
            this.tBx_pers_str.Name = "tBx_pers_str";
            this.tBx_pers_str.Size = new System.Drawing.Size(112, 20);
            this.tBx_pers_str.TabIndex = 3;
            // 
            // tbx_pers_Land
            // 
            this.tbx_pers_Land.Location = new System.Drawing.Point(110, 227);
            this.tbx_pers_Land.Name = "tbx_pers_Land";
            this.tbx_pers_Land.Size = new System.Drawing.Size(283, 20);
            this.tbx_pers_Land.TabIndex = 7;
            // 
            // tBx_pers_strnum
            // 
            this.tBx_pers_strnum.Location = new System.Drawing.Point(303, 148);
            this.tBx_pers_strnum.Name = "tBx_pers_strnum";
            this.tBx_pers_strnum.Size = new System.Drawing.Size(90, 20);
            this.tBx_pers_strnum.TabIndex = 4;
            // 
            // tBx_pers_plz
            // 
            this.tBx_pers_plz.Location = new System.Drawing.Point(110, 187);
            this.tBx_pers_plz.Name = "tBx_pers_plz";
            this.tBx_pers_plz.Size = new System.Drawing.Size(112, 20);
            this.tBx_pers_plz.TabIndex = 5;
            // 
            // tBx_pers_Nachname
            // 
            this.tBx_pers_Nachname.Location = new System.Drawing.Point(110, 105);
            this.tBx_pers_Nachname.Name = "tBx_pers_Nachname";
            this.tBx_pers_Nachname.Size = new System.Drawing.Size(283, 20);
            this.tBx_pers_Nachname.TabIndex = 2;
            // 
            // tBx_pers_Vorname
            // 
            this.tBx_pers_Vorname.Location = new System.Drawing.Point(110, 59);
            this.tBx_pers_Vorname.Name = "tBx_pers_Vorname";
            this.tBx_pers_Vorname.Size = new System.Drawing.Size(283, 20);
            this.tBx_pers_Vorname.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(228, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Ort";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Hausnummer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Land";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Straße";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "PLZ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nachname*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vorname*";
            // 
            // btn_pers_save
            // 
            this.btn_pers_save.Location = new System.Drawing.Point(279, 307);
            this.btn_pers_save.Name = "btn_pers_save";
            this.btn_pers_save.Size = new System.Drawing.Size(109, 23);
            this.btn_pers_save.TabIndex = 8;
            this.btn_pers_save.Text = "Neu Anlegen";
            this.btn_pers_save.UseVisualStyleBackColor = true;
            this.btn_pers_save.Click += new System.EventHandler(this.Btn_pers_save_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.btn_lief_delete);
            this.tabPage3.Controls.Add(this.lbx_Lieferanten);
            this.tabPage3.Controls.Add(this.btn_lief_edit);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.tBx_lief_Ort);
            this.tabPage3.Controls.Add(this.tBx_lief_str);
            this.tabPage3.Controls.Add(this.tBx_lief_Land);
            this.tabPage3.Controls.Add(this.tBx_lief_strnum);
            this.tabPage3.Controls.Add(this.tBx_lief_plz);
            this.tabPage3.Controls.Add(this.tBx_lief_Kennung);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.btn_lief_save);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(844, 376);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Lieferant";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(421, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 24);
            this.label8.TabIndex = 40;
            this.label8.Text = "Lieferanten";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(106, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 24);
            this.label9.TabIndex = 39;
            this.label9.Text = "Hinzufügen";
            // 
            // btn_lief_delete
            // 
            this.btn_lief_delete.Location = new System.Drawing.Point(540, 347);
            this.btn_lief_delete.Name = "btn_lief_delete";
            this.btn_lief_delete.Size = new System.Drawing.Size(109, 23);
            this.btn_lief_delete.TabIndex = 10;
            this.btn_lief_delete.Text = "Löschen";
            this.btn_lief_delete.UseVisualStyleBackColor = true;
            this.btn_lief_delete.Click += new System.EventHandler(this.Btn_lief_delete_Click);
            // 
            // lbx_Lieferanten
            // 
            this.lbx_Lieferanten.FormattingEnabled = true;
            this.lbx_Lieferanten.Location = new System.Drawing.Point(425, 59);
            this.lbx_Lieferanten.Name = "lbx_Lieferanten";
            this.lbx_Lieferanten.Size = new System.Drawing.Size(224, 277);
            this.lbx_Lieferanten.TabIndex = 36;
            this.lbx_Lieferanten.DoubleClick += new System.EventHandler(this.Lbx_Lieferanten_DoubleClick);
            // 
            // btn_lief_edit
            // 
            this.btn_lief_edit.Location = new System.Drawing.Point(279, 350);
            this.btn_lief_edit.Name = "btn_lief_edit";
            this.btn_lief_edit.Size = new System.Drawing.Size(109, 23);
            this.btn_lief_edit.TabIndex = 8;
            this.btn_lief_edit.Text = "Bearbeiten";
            this.btn_lief_edit.UseVisualStyleBackColor = true;
            this.btn_lief_edit.Click += new System.EventHandler(this.Btn_lief_edit_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 352);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "* Pflichtfelder";
            // 
            // tBx_lief_Ort
            // 
            this.tBx_lief_Ort.Location = new System.Drawing.Point(255, 148);
            this.tBx_lief_Ort.Name = "tBx_lief_Ort";
            this.tBx_lief_Ort.Size = new System.Drawing.Size(138, 20);
            this.tBx_lief_Ort.TabIndex = 5;
            // 
            // tBx_lief_str
            // 
            this.tBx_lief_str.Location = new System.Drawing.Point(110, 105);
            this.tBx_lief_str.Name = "tBx_lief_str";
            this.tBx_lief_str.Size = new System.Drawing.Size(112, 20);
            this.tBx_lief_str.TabIndex = 2;
            // 
            // tBx_lief_Land
            // 
            this.tBx_lief_Land.Location = new System.Drawing.Point(110, 187);
            this.tBx_lief_Land.Name = "tBx_lief_Land";
            this.tBx_lief_Land.Size = new System.Drawing.Size(283, 20);
            this.tBx_lief_Land.TabIndex = 6;
            // 
            // tBx_lief_strnum
            // 
            this.tBx_lief_strnum.Location = new System.Drawing.Point(303, 105);
            this.tBx_lief_strnum.Name = "tBx_lief_strnum";
            this.tBx_lief_strnum.Size = new System.Drawing.Size(90, 20);
            this.tBx_lief_strnum.TabIndex = 3;
            // 
            // tBx_lief_plz
            // 
            this.tBx_lief_plz.Location = new System.Drawing.Point(110, 148);
            this.tBx_lief_plz.Name = "tBx_lief_plz";
            this.tBx_lief_plz.Size = new System.Drawing.Size(112, 20);
            this.tBx_lief_plz.TabIndex = 4;
            // 
            // tBx_lief_Kennung
            // 
            this.tBx_lief_Kennung.Location = new System.Drawing.Point(110, 59);
            this.tBx_lief_Kennung.Name = "tBx_lief_Kennung";
            this.tBx_lief_Kennung.Size = new System.Drawing.Size(283, 20);
            this.tBx_lief_Kennung.TabIndex = 1;
            this.toolTip_hoover.SetToolTip(this.tBx_lief_Kennung, "Lieferantenkennung (Name)");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(228, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Ort";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(228, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Hausnummer";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 190);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Land";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 108);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "Straße";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 151);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "PLZ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 62);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 13);
            this.label20.TabIndex = 20;
            this.label20.Text = "Kennung*";
            this.toolTip_hoover.SetToolTip(this.label20, "Lieferantenkennung (Name)");
            // 
            // btn_lief_save
            // 
            this.btn_lief_save.Location = new System.Drawing.Point(279, 307);
            this.btn_lief_save.Name = "btn_lief_save";
            this.btn_lief_save.Size = new System.Drawing.Size(109, 23);
            this.btn_lief_save.TabIndex = 7;
            this.btn_lief_save.Text = "Neu Anlegen";
            this.btn_lief_save.UseVisualStyleBackColor = true;
            this.btn_lief_save.Click += new System.EventHandler(this.Btn_lief_save_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btn_stoff_delete);
            this.tabPage6.Controls.Add(this.lBx_stoff);
            this.tabPage6.Controls.Add(this.cBx_stoff_lief_3);
            this.tabPage6.Controls.Add(this.groupBox1);
            this.tabPage6.Controls.Add(this.label19);
            this.tabPage6.Controls.Add(this.groupBox7);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(844, 376);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Stoff";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btn_stoff_delete
            // 
            this.btn_stoff_delete.Location = new System.Drawing.Point(347, 339);
            this.btn_stoff_delete.Name = "btn_stoff_delete";
            this.btn_stoff_delete.Size = new System.Drawing.Size(109, 23);
            this.btn_stoff_delete.TabIndex = 6;
            this.btn_stoff_delete.Text = "Löschen";
            this.btn_stoff_delete.UseVisualStyleBackColor = true;
            this.btn_stoff_delete.Click += new System.EventHandler(this.Btn_stoff_delete_Click);
            // 
            // lBx_stoff
            // 
            this.lBx_stoff.FormattingEnabled = true;
            this.lBx_stoff.Location = new System.Drawing.Point(232, 55);
            this.lBx_stoff.Name = "lBx_stoff";
            this.lBx_stoff.Size = new System.Drawing.Size(224, 277);
            this.lBx_stoff.TabIndex = 37;
            // 
            // cBx_stoff_lief_3
            // 
            this.cBx_stoff_lief_3.FormattingEnabled = true;
            this.cBx_stoff_lief_3.Location = new System.Drawing.Point(322, 23);
            this.cBx_stoff_lief_3.Name = "cBx_stoff_lief_3";
            this.cBx_stoff_lief_3.Size = new System.Drawing.Size(134, 21);
            this.cBx_stoff_lief_3.TabIndex = 6;
            this.cBx_stoff_lief_3.SelectedIndexChanged += new System.EventHandler(this.CBx_stoff_lief_3_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.cBx_stoff_lief_2);
            this.groupBox1.Controls.Add(this.btn_stoff_load_file);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Location = new System.Drawing.Point(7, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 230);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Neue Einträge";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(1, 54);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(218, 117);
            this.label22.TabIndex = 5;
            this.label22.Text = resources.GetString("label22.Text");
            // 
            // cBx_stoff_lief_2
            // 
            this.cBx_stoff_lief_2.FormattingEnabled = true;
            this.cBx_stoff_lief_2.Location = new System.Drawing.Point(99, 19);
            this.cBx_stoff_lief_2.Name = "cBx_stoff_lief_2";
            this.cBx_stoff_lief_2.Size = new System.Drawing.Size(109, 21);
            this.cBx_stoff_lief_2.TabIndex = 4;
            // 
            // btn_stoff_load_file
            // 
            this.btn_stoff_load_file.Location = new System.Drawing.Point(101, 199);
            this.btn_stoff_load_file.Name = "btn_stoff_load_file";
            this.btn_stoff_load_file.Size = new System.Drawing.Size(109, 23);
            this.btn_stoff_load_file.TabIndex = 4;
            this.btn_stoff_load_file.Text = "Datei laden";
            this.btn_stoff_load_file.UseVisualStyleBackColor = true;
            this.btn_stoff_load_file.Click += new System.EventHandler(this.Btn_stoff_load_file_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 23);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 13);
            this.label21.TabIndex = 3;
            this.label21.Text = "Auswahl Lieferant";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(229, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 13);
            this.label19.TabIndex = 5;
            this.label19.Text = "Auswahl Lieferant";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label23);
            this.groupBox7.Controls.Add(this.tBx_stoff_ID);
            this.groupBox7.Controls.Add(this.cBx_stoff_lief_1);
            this.groupBox7.Controls.Add(this.btn_stoff_save);
            this.groupBox7.Controls.Add(this.label26);
            this.groupBox7.Controls.Add(this.tBx_stoff_name);
            this.groupBox7.Controls.Add(this.label30);
            this.groupBox7.Location = new System.Drawing.Point(7, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(216, 128);
            this.groupBox7.TabIndex = 16;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Neuer Eintrag";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 46);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(18, 13);
            this.label23.TabIndex = 10;
            this.label23.Text = "ID";
            // 
            // tBx_stoff_ID
            // 
            this.tBx_stoff_ID.Location = new System.Drawing.Point(99, 43);
            this.tBx_stoff_ID.Name = "tBx_stoff_ID";
            this.tBx_stoff_ID.Size = new System.Drawing.Size(109, 20);
            this.tBx_stoff_ID.TabIndex = 9;
            // 
            // cBx_stoff_lief_1
            // 
            this.cBx_stoff_lief_1.FormattingEnabled = true;
            this.cBx_stoff_lief_1.Location = new System.Drawing.Point(99, 69);
            this.cBx_stoff_lief_1.Name = "cBx_stoff_lief_1";
            this.cBx_stoff_lief_1.Size = new System.Drawing.Size(109, 21);
            this.cBx_stoff_lief_1.TabIndex = 4;
            // 
            // btn_stoff_save
            // 
            this.btn_stoff_save.Location = new System.Drawing.Point(99, 96);
            this.btn_stoff_save.Name = "btn_stoff_save";
            this.btn_stoff_save.Size = new System.Drawing.Size(109, 23);
            this.btn_stoff_save.TabIndex = 4;
            this.btn_stoff_save.Text = "Speichern";
            this.btn_stoff_save.UseVisualStyleBackColor = true;
            this.btn_stoff_save.Click += new System.EventHandler(this.Btn_stoff_save_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 20);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(35, 13);
            this.label26.TabIndex = 8;
            this.label26.Text = "Name";
            // 
            // tBx_stoff_name
            // 
            this.tBx_stoff_name.Location = new System.Drawing.Point(99, 17);
            this.tBx_stoff_name.Name = "tBx_stoff_name";
            this.tBx_stoff_name.Size = new System.Drawing.Size(109, 20);
            this.tBx_stoff_name.TabIndex = 3;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 73);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(91, 13);
            this.label30.TabIndex = 3;
            this.label30.Text = "Auswahl Lieferant";
            // 
            // toolTip_hoover
            // 
            this.toolTip_hoover.AutoPopDelay = 5000;
            this.toolTip_hoover.InitialDelay = 250;
            this.toolTip_hoover.ReshowDelay = 100;
            this.toolTip_hoover.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // oFD_stoff
            // 
            this.oFD_stoff.Filter = "CSV tabellen|*.csv";
            this.oFD_stoff.InitialDirectory = "%Desktop%";
            // 
            // Form_DB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 404);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_DB";
            this.Text = "Parameter";
            this.Load += new System.EventHandler(this.Form_DB_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_pers_funk_add;
        private System.Windows.Forms.Button btn_pers_funk_del;
        private System.Windows.Forms.ListBox lbx_pers_Funktion_used;
        private System.Windows.Forms.ListBox lbx_Personen;
        private System.Windows.Forms.Button btn_pers_delete;
        private System.Windows.Forms.Button btn_pers_edit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tBx_pers_Ort;
        private System.Windows.Forms.TextBox tBx_pers_str;
        private System.Windows.Forms.TextBox tbx_pers_Land;
        private System.Windows.Forms.TextBox tBx_pers_strnum;
        private System.Windows.Forms.TextBox tBx_pers_plz;
        private System.Windows.Forms.TextBox tBx_pers_Nachname;
        private System.Windows.Forms.TextBox tBx_pers_Vorname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_pers_save;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_lief_delete;
        private System.Windows.Forms.ListBox lbx_Lieferanten;
        private System.Windows.Forms.Button btn_lief_edit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tBx_lief_Ort;
        private System.Windows.Forms.TextBox tBx_lief_str;
        private System.Windows.Forms.TextBox tBx_lief_Land;
        private System.Windows.Forms.TextBox tBx_lief_strnum;
        private System.Windows.Forms.TextBox tBx_lief_plz;
        private System.Windows.Forms.TextBox tBx_lief_Kennung;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btn_lief_save;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox cBx_stoff_lief_1;
        private System.Windows.Forms.Button btn_stoff_save;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox tBx_stoff_name;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ToolTip toolTip_hoover;
        private System.Windows.Forms.ListBox lBx_pers_Funktionen;
        private System.Windows.Forms.ComboBox cBx_stoff_lief_3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cBx_stoff_lief_2;
        private System.Windows.Forms.Button btn_stoff_load_file;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn_stoff_delete;
        private System.Windows.Forms.ListBox lBx_stoff;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tBx_stoff_ID;
        private System.Windows.Forms.OpenFileDialog oFD_stoff;
    }
}