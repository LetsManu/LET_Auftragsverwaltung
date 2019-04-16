using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LET_Auftragsverwaltung
{
    public partial class Form_Edit_Auftrag : Form
    {
        private int id = 0;
        private int a_id = 0;
        private bool is_startup = false;    //used for some cbx's. so their selectedindex Methode does not get triggered (or rather the code which would get executed)
        private OdbcConnection Connection
        {
            get
            {
                return DB.Connection;
            }
        }

        public Form_Edit_Auftrag(int id_)
        {
            id = id_;
            InitializeComponent();

            date_erstell.Format = DateTimePickerFormat.Custom;
            date_kauf_edit_Anzahlung.Format = DateTimePickerFormat.Custom;
            date_kauf_edit_Auftragsbestaetigng.Format = DateTimePickerFormat.Custom;
            date_kauf_edit_Schlussrechnung.Format = DateTimePickerFormat.Custom;
            date_mont.Format = DateTimePickerFormat.Custom;

            Format_all_datetimepicker("ddd dd/MM/yyyy");

            lbl_kauf_Anzahlung_bestaetigt.Visible = false;
            lbl_kauf_Auftrag_bestaetigt.Visible = false;
            lbl_kauf_Schlussrechnung_bestaetigt.Visible = false;

            Get_a_id();
            UC_Kauf_Fill_cbx_kauf_edit_auf();
            UC_Kauf_Fill_cbx_kauf_edit_anz();
            UC_Kauf_Fill_cbx_kauf_edit_schluss();
            UC_Kauf_Date_Auf_set();
            UC_Kauf_Date_Anz_set();
            UC_Kauf_Date_Schluss_set();
            UC_Kauf_Text_Auf();
            UC_Kauf_Text_Anz();
            UC_Kauf_Text_Schluss();
            txt_check_if_requested();
            Load_title();
        }

        private void Format_all_datetimepicker(string format)
        {
            date_erstell.CustomFormat = format;               //TODO outsource to parameter class
            date_kauf_edit_Anzahlung.CustomFormat = format;
            date_kauf_edit_Auftragsbestaetigng.CustomFormat = format;
            date_kauf_edit_Schlussrechnung.CustomFormat = format;
            date_mont.CustomFormat = format;
        }

        public void Load_title()
        {
            string sql = "SELECT CONCAT(CONCAT(CONCAT(fertigungsstatus.Status, ' | '), auftraege.Projektbezeichnung, ' | '), auftraege.Auftrags_NR) AS title FROM auftraege LEFT JOIN fertigungsstatus ON auftraege.Fertigungsstatus = fertigungsstatus.F_ID WHERE auftraege.id = " + id;
            this.Text = SQL_methods.SQL_scalar(sql).ToString();
        }

        #region Allgemein Tab

        private void UC_Edit_Auftrag_fill_segel()
        {
            string sql = "SELECT segel.name AS name, segel.form AS form, stoff.Stoff AS stoff, lieferant.Lieferant AS lieferant, segel.id AS id FROM auftraege_segel INNER JOIN segel ON auftraege_segel.id_segel = segel.id INNER JOIN stoff ON segel.stoff_kennung = stoff.ST_ID INNER JOIN stoff_lieferant ON stoff.ST_ID = stoff_lieferant.ST_ID INNER JOIN lieferant ON stoff_lieferant.L_ID = lieferant.L_ID WHERE auftraege_segel.id_auftrag = " + id;
            OdbcCommand cmd = new OdbcCommand(sql, Connection);
            SQL_methods.Open();
            OdbcDataReader sqlReader = cmd.ExecuteReader();
            while (sqlReader.Read())
            {
                Segel segel = new Segel((string)sqlReader["name"], (string)sqlReader["form"], (string)sqlReader["stoff"], (string)sqlReader["lieferant"], (int)sqlReader["id"]);
                lBx_segel.Items.Add(segel);
            }
        }

        private void UC_edit_Auftrag_fill_cbx_status()
        {
            if (!this.DesignMode)
            {
                try
                {
                    SQL_methods.Open();
                    string sql = "SELECT F_ID, Status FROM fertigungsstatus WHERE deaktiviert<>true";
                    OdbcDataAdapter dc = new OdbcDataAdapter(sql, Connection);
                    DataTable dtStatus = new DataTable();
                    dc.Fill(dtStatus);



                    cbx_auftragsstatus.DataSource = dtStatus;
                    cbx_auftragsstatus.ValueMember = "F_ID";
                    cbx_auftragsstatus.DisplayMember = "Status";


                    if (cbx_auftragsstatus.Items.Count > 0)
                    {
                        cbx_auftragsstatus.SelectedIndex = 0;
                    }
                }
                catch (Exception f)
                {
                    MessageBox.Show("Fehler in der SQL Abfrage(Edit Auftrag: Fill CBX Status): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UC_Edit_Auftrag_fill_cbx_seller()
        {
            try
            {

                DataTable dtSeller = SQL_methods.Fill_Box("SELECT DISTINCT CONCAT(p.`Nachname`, ' ', p.`Vorname`) AS 'Name', p.P_ID FROM personal p LEFT JOIN personal_funktion pf ON p.P_ID = pf.P_ID WHERE pf.Funktion_ID = 7");



                cbx_seller_edit.DataSource = dtSeller;
                cbx_seller_edit.ValueMember = "P_ID";
                cbx_seller_edit.DisplayMember = "Name";


                if (cbx_seller_edit.Items.Count > 0)
                {
                    cbx_seller_edit.SelectedIndex = 0;
                }
            }
            catch (Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage(Edit Auftrag: Fill CBX Seller): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UC_Edit_Auftrag_fill_cbx_verant()
        {
            if (!this.DesignMode)
            {
                try
                {


                    DataTable dtVerant = SQL_methods.Fill_Box("SELECT DISTINCT CONCAT(p.`Nachname`, ' ', p.`Vorname`) AS 'Name', p.P_ID FROM personal p LEFT JOIN personal_funktion pf ON p.P_ID = pf.P_ID WHERE pf.Funktion_ID = 4");

                    cbx_verant.DataSource = dtVerant;
                    cbx_verant.ValueMember = "P_ID";
                    cbx_verant.DisplayMember = "Name";


                    if (cbx_verant.Items.Count > 0)
                    {
                        cbx_verant.SelectedIndex = 0;
                    }
                }
                catch (Exception f)
                {
                    MessageBox.Show("Fehler in der SQL Abfrage(Edit Auftrag: Fill CBX Verant): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UC_Editt_auftrag_fill_cbx_tech()
        {
            if (!this.DesignMode)
            {
                try
                {

                    DataTable dt = SQL_methods.Fill_Box("SELECT DISTINCT CONCAT(p.`Nachname`, ' ', p.`Vorname`) AS 'Name', p.P_ID FROM personal p LEFT JOIN personal_funktion pf ON p.P_ID = pf.P_ID WHERE pf.Funktion_ID = 1 OR pf.Funktion_ID = 2");

                    cbx_tech.DataSource = dt;
                    cbx_tech.ValueMember = "P_ID";
                    cbx_tech.DisplayMember = "Name";


                    if (cbx_verant.Items.Count > 0)
                    {
                        cbx_verant.SelectedIndex = 0;
                    }
                }
                catch (Exception f)
                {
                    MessageBox.Show("Fehler in der SQL Abfrage(Edit Auftrag: Fill CBX Techniker): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void UC_New_auftrag_fill_cbx_lief()
        {
            if (!this.DesignMode)
            {
                try
                {
                    is_startup = true;
                    cBx_stoff_hersteller.DataSource = null; //--- 
                    cBx_stoff_hersteller.Items.Clear();

                    DataTable dtLief = SQL_methods.Fill_Box("SELECT L_ID, Lieferant FROM Lieferant WHERE lieferant.deaktiviert<>true");

                    cBx_stoff_hersteller.DataSource = dtLief;
                    cBx_stoff_hersteller.ValueMember = "L_ID";
                    cBx_stoff_hersteller.DisplayMember = "Lieferant";


                    if (cBx_stoff_hersteller.Items.Count > 0)
                    {
                        cBx_stoff_hersteller.SelectedIndex = 0;
                    }
                    else
                    {
                        cBx_stoff_hersteller.Items.Clear();
                    }
                }
                catch (Exception f)
                {
                    MessageBox.Show("Fehler in der SQL Abfrage(Neue Auftrag: Fill CBX Lief): \n\n" + f.Message,
                        "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                is_startup = false;
                UC_New_auftrag_fill_cbx_stoff_kennung();
            }
        }

        private void UC_New_auftrag_fill_cbx_stoff_kennung()
        {
            if (!this.DesignMode)
            {
                if (cBx_stoff_hersteller.Items.Count > 0 && !is_startup)
                {
                    try
                    {
                        DataTable dtStoff = SQL_methods.Fill_Box(string.Format(
                            "SELECT stoff.ST_ID,stoff.`Stoff` FROM stoff INNER JOIN stoff_lieferant ON stoff.ST_ID = stoff_lieferant.ST_ID WHERE stoff_lieferant.L_ID = {0}",
                            cBx_stoff_hersteller.SelectedValue));

                        cBx_stoff_kennung.DataSource = dtStoff;
                        cBx_stoff_kennung.ValueMember = "ST_ID";
                        cBx_stoff_kennung.DisplayMember = "Stoff";


                        if (cBx_stoff_kennung.Items.Count > 0)
                        {
                            cBx_stoff_kennung.SelectedIndex = 0;
                        }
                        else
                        {
                            foreach (var item in cBx_stoff_kennung.Items)
                            {
                                cBx_stoff_kennung.Items.Remove(item);
                            }
                            cBx_stoff_kennung.Text = "";
                        }
                    }
                    catch (Exception f)
                    {
                        MessageBox.Show("Fehler in der SQL Abfrage(Neue Auftrag: Fill CBX Stoff): \n\n" + f.Message,
                                        "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void Form_Edit_Auftrag_new_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                #region FillKlassen

                UC_New_auftrag_fill_cbx_lief();
                UC_New_auftrag_fill_cbx_stoff_kennung();
                UC_edit_Auftrag_fill_cbx_status();
                UC_Edit_Auftrag_fill_cbx_verant();
                UC_Editt_auftrag_fill_cbx_tech();
                UC_Edit_Auftrag_fill_segel();
                UC_Edit_Auftrag_fill_cbx_seller();

                #endregion


                string sql = "SELECT * FROM auftraege WHERE id = " + id;
                OdbcCommand cmd = new OdbcCommand(sql, Connection);
                SQL_methods.Open();
                OdbcDataReader sqlReader = cmd.ExecuteReader();
                if (sqlReader.Read())
                {
                    txt_auftrag_nr.Text = (string)sqlReader[1];//TODO why begins with 1 and not 0? cause 0 is ID apparently
                    cbx_auftragsstatus.SelectedValue = sqlReader[2];
                    date_erstell.Value = Convert.ToDateTime(sqlReader[3]);
                    cbx_verant.SelectedValue = sqlReader[6];
                    cbx_tech.SelectedValue = sqlReader[7];
                    txt_auf_proj_ken.Text = (string)sqlReader[8];
                    date_mont.Value = Convert.ToDateTime(sqlReader[10]);
                    txt_info_kauf.Text = (string)sqlReader[11];
                    txt_info_tech.Text = (string)sqlReader[12];
                }




            }
        }

        private void Btn_save_infos_Click(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                try
                {
                    lBx_segel.Items.Clear();

                    SQL_methods.SQL_exec(string.Format(
                        "UPDATE auftraege SET Auftrags_NR = '{0}', Fertigungsstatus = {1}, Projektverantwortlicher = {2}, Planer_Techniker = {3}, Projektbezeichnung = '{4}', Montage_Datum  = '{5}', Notitz_Kauf = '{6}', Notitz_Tech = '{7}', Erstelldatum = '{8}', Verkäufer = {9} WHERE ID = {10}",
                        txt_auftrag_nr.Text,
                        cbx_auftragsstatus.SelectedValue,
                        cbx_verant.SelectedValue,
                        cbx_tech.SelectedValue,
                        txt_auf_proj_ken.Text,
                        date_mont.Value.ToString("yyyy-MM-dd"),
                        txt_info_kauf.Text,
                        txt_info_tech.Text,
                        date_erstell.Value.ToString("yyyy-MM-dd"),
                        cbx_seller_edit.SelectedValue,
                        id));

                    for (int i = 0; i < lBx_segel.Items.Count; i++)
                    {
                        int segel_ID = ((Segel)lBx_segel.Items[i]).ID;
                        SQL_methods.SQL_exec(string.Format(
                            "INSERT INTO  auftraege_segel (id_auftrag, id_segel)SELECT {0},{1} FROM dual WHERE NOT EXISTS (SELECT * FROM auftraege_segel WHERE id_auftrag = {0} AND id_segel = {1});",
                            id, segel_ID));
                    }
                }
                catch (Exception f)
                {

                    MessageBox.Show("Fehler in der SQL Abfrage(Edit Auftrag: EDIT): \n\n" + f.Message, "Fehler",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    Form_Edit_Auftrag_new_Load(sender, e);
                }
            }
        }

        private void Btn_add_segel_Click(object sender, EventArgs e)
        {
            if (!Global.Not_filled(tBx_segel_name) && !Global.Not_filled(cBx_segelform) && !Global.Not_filled(cBx_stoff_hersteller) && !Global.Not_filled(cBx_stoff_kennung))
            {
                SQL_methods.SQL_exec(string.Format("INSERT INTO segel (segel.name,segel.form,segel.stoff_hersteller,segel.stoff_kennung)VALUES ('{0}','{1}',{2},{3})", tBx_segel_name.Text, cBx_segelform.Text, cBx_stoff_hersteller.SelectedValue, cBx_stoff_kennung.SelectedValue));

                string sql = "SELECT * FROM segel ORDER BY segel.id DESC LIMIT 1";
                OdbcCommand cmd = new OdbcCommand(sql, Connection);
                SQL_methods.Open();
                OdbcDataReader sqlReader = cmd.ExecuteReader();
                sqlReader.Read();
                int segel_id = Convert.ToInt32(sqlReader[0]);
                sqlReader.Close();

                Segel segel = new Segel(tBx_segel_name.Text, cBx_segelform.Text, (int)cBx_stoff_hersteller.SelectedValue, (int)cBx_stoff_kennung.SelectedValue, segel_id);
                lBx_segel.Items.Add(segel);
            }
        }

        private void CBx_stoff_hersteller_SelectedIndexChanged(object sender, EventArgs e)
        {
            UC_New_auftrag_fill_cbx_stoff_kennung();
        }
        #endregion

        #region Kaufmänisch

        private void UC_Kauf_Text_Auf()
        {
            if (!this.DesignMode)
            {
                try
                {
                    string sql = "SELECT V_Notiz FROM ab_az WHERE A_ID = " + a_id;
                    OdbcCommand cmd2 = new OdbcCommand(sql, Connection);

                    OdbcDataReader sql_reader = cmd2.ExecuteReader();
                    sql_reader.Read();
                    tBx_kauf_edit_Auftragsbestaetigung.Text = sql_reader[0].ToString();


                }
                catch (Exception f)
                {
                    MessageBox.Show("Fehler in der SQL Abfrage(Kaufmänisch: Notiz Anzahlung): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UC_Kauf_Text_Anz()
        {
            if (!this.DesignMode)
            {
                try
                {
                    string sql = "SELECT B_Notiz FROM ab_az WHERE A_ID = " + a_id;
                    OdbcCommand cmd2 = new OdbcCommand(sql, Connection);

                    OdbcDataReader sql_reader = cmd2.ExecuteReader();
                    sql_reader.Read();
                    tBx_kauf_edit_Anzahlung.Text = sql_reader[0].ToString();


                }
                catch (Exception f)
                {
                    MessageBox.Show("Fehler in der SQL Abfrage(Kaufmänisch: Notiz Anzahlung): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UC_Kauf_Text_Schluss()
        {
            if (!this.DesignMode)
            {
                try
                {
                    string sql = "SELECT B_Notiz FROM ab_az WHERE A_ID = " + a_id;
                    OdbcCommand cmd2 = new OdbcCommand(sql, Connection);

                    OdbcDataReader sql_reader = cmd2.ExecuteReader();
                    sql_reader.Read();
                    tBx_kauf_edit_Schlussrechnung.Text = sql_reader[0].ToString();


                }
                catch (Exception f)
                {
                    MessageBox.Show("Fehler in der SQL Abfrage(Kaufmänisch: Sclussrechnung Notiz): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void UC_Kauf_Fill_cbx_kauf_edit_auf()
        {
            if (!this.DesignMode)
            {
                cbx_kauf_edit_Auftragsbestaetigung.DataSource = UC_Kauf_CBX_For_persons();
                cbx_kauf_edit_Auftragsbestaetigung.ValueMember = "P_ID";
                cbx_kauf_edit_Auftragsbestaetigung.DisplayMember = "Name";


                if (cbx_kauf_edit_Auftragsbestaetigung.Items.Count > 0)
                {
                    cbx_kauf_edit_Auftragsbestaetigung.SelectedIndex = 0;
                }
            }
        }

        private void UC_Kauf_Fill_cbx_kauf_edit_anz()
        {
            if (!this.DesignMode)
            {
                cbx_kauf_edit_Anzahlung.DataSource = UC_Kauf_CBX_For_persons();
                cbx_kauf_edit_Anzahlung.ValueMember = "P_ID";
                cbx_kauf_edit_Anzahlung.DisplayMember = "Name";


                if (cbx_kauf_edit_Auftragsbestaetigung.Items.Count > 0)
                {
                    cbx_kauf_edit_Auftragsbestaetigung.SelectedIndex = 0;
                }
            }
        }

        private void UC_Kauf_Fill_cbx_kauf_edit_schluss()
        {
            if (!this.DesignMode)
            {
                cbx_kauf_edit_Schlussrechnung.DataSource = UC_Kauf_CBX_For_persons();
                cbx_kauf_edit_Schlussrechnung.ValueMember = "P_ID";
                cbx_kauf_edit_Schlussrechnung.DisplayMember = "Name";


                if (cbx_kauf_edit_Auftragsbestaetigung.Items.Count > 0)
                {
                    cbx_kauf_edit_Auftragsbestaetigung.SelectedIndex = 0;
                }
            }
        }

        private DataTable UC_Kauf_CBX_For_persons()
        {

            if (!this.DesignMode)
            {
                try
                {
                    //TODO Cache which is active for 3 uses, or timout of under 1 sec.
                    DataTable dtPers = SQL_methods.Fill_Box("SELECT DISTINCT CONCAT(p.`Nachname`, ' ', p.`Vorname`) AS 'Name', p.P_ID FROM personal p LEFT JOIN personal_funktion pf ON p.P_ID = pf.P_ID WHERE pf.Funktion_ID = 4");

                    return dtPers;
                }
                catch (Exception f)
                {
                    MessageBox.Show("Fehler in der SQL Abfrage(Kaufmänisch: Fill CBX): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        private void Btn_save_kauf_edit_auf_Click(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                try
                {
                    string sql2 = "SELECT Projektbezeichnung FROM auftraege WHERE ID = " + id;
                    OdbcCommand cmd2 = new OdbcCommand(sql2, Connection);
                    SQL_methods.Open();
                    OdbcDataReader sql_read2 = cmd2.ExecuteReader();
                    sql_read2.Read();
                    string bez = Convert.ToString(sql_read2[0].ToString());
                    sql_read2.Close();


                    Email.Send_Mail("chaftalie@icloud.com", "[LET] Auftragsbestätigung: " + bez, "TestTest"); //TODO (SUBJEKT: [LET] AUftragsbestätigung: ProjektBet) (BODY: Mehr Infot ID ect..)

                    txt_check_if_requested();


                    btn_save_kauf_Auftragsbestaetigung.Enabled = false;
                    tmr_break.Enabled = true;

                }
                catch (Exception f)
                {
                    MessageBox.Show("Fehler in der SQL Abfrage(Edit Auftrag: INSERT AB_AZ Anfordern): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_save_kauf_edit_anz_Click(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                try
                {
                    string sql2 = "SELECT Projektbezeichnung FROM auftraege WHERE ID = " + id;
                    OdbcCommand cmd2 = new OdbcCommand(sql2, Connection);
                    SQL_methods.Open();
                    OdbcDataReader sql_read2 = cmd2.ExecuteReader();
                    sql_read2.Read();
                    string bez = Convert.ToString(sql_read2[0].ToString());
                    sql_read2.Close();

                    Email.Send_Mail("chaftalie@icloud.com", "[LET] Anzahlungsrechnung: " + bez, "TestTest"); //TODO (SUBJEKT: [LET] AUftragsbestätigung: ProjektBet) (BODY: Mehr Infot ID ect..)

                    txt_check_if_requested();


                    btn_save_kauf_Anzahlung.Enabled = false;
                    tmr_break.Enabled = true;

                }
                catch (Exception f)
                {
                    MessageBox.Show("Fehler in der SQL Abfrage(Edit Auftrag: INSERT AB_AZ Bestätigen): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_save_kauf_edit_schluss_Click(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                try
                {
                    string sql2 = "SELECT Projektbezeichnung FROM auftraege WHERE ID = " + id;
                    OdbcCommand cmd2 = new OdbcCommand(sql2, Connection);
                    SQL_methods.Open();
                    OdbcDataReader sql_read2 = cmd2.ExecuteReader();
                    sql_read2.Read();
                    string bez = Convert.ToString(sql_read2[0].ToString());
                    sql_read2.Close();

                    Email.Send_Mail("chaftalie@icloud.com", "[LET] Schlussrechnung: " + bez, "TestTest"); //TODO (SUBJEKT: [LET] AUftragsbestätigung: ProjektBet) (BODY: Mehr Infot ID ect..)

                    txt_check_if_requested();


                    btn_save_kauf_Schlussrechnung.Enabled = false;
                    tmr_break.Enabled = true;

                }
                catch (Exception f)
                {
                    MessageBox.Show("Fehler in der SQL Abfrage(Edit Auftrag: INSERT AB_AZ Schlussrechnung): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_date_kauf_edit_auf_Click(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                date_kauf_edit_Auftragsbestaetigng.Value = DateTime.Today;
                SQL_Date_Auf();
            }
        }

        private void Btn_date_kauf_edit_anz_Click(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                date_kauf_edit_Anzahlung.Value = DateTime.Today;
                SQL_Date_Anz();
            }
        }

        private void Btn_date_kauf_edit_schluss_Click(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                date_kauf_edit_Schlussrechnung.Value = DateTime.Today;
                SQL_Date_Schluss();
            }
        }

        private void Btn_best_Click(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                Form_Best f_best = new Form_Best(id);
                f_best.Show();
            }
        }

        private void UC_Kauf_Date_Auf_set()
        {
            if (!this.DesignMode)
            {
                try
                {
                    string sql = "SELECT V_Date FROM ab_az WHERE A_ID = " + a_id;
                    OdbcCommand cmd2 = new OdbcCommand(sql, Connection);
                    object obj_db = cmd2.ExecuteScalar();

                    if (obj_db != DBNull.Value)
                    {
                        OdbcDataReader sql_reader = cmd2.ExecuteReader();
                        sql_reader.Read();
                        date_kauf_edit_Auftragsbestaetigng.Value = DateTime.Parse(sql_reader[0].ToString());
                    }
                    else
                    {
                        date_kauf_edit_Auftragsbestaetigng.CustomFormat = " ";
                        date_kauf_edit_Auftragsbestaetigng.Format = DateTimePickerFormat.Custom;

                    }
                }
                catch (Exception f)
                {
                    MessageBox.Show("Fehler in der SQL Abfrage(Kaufmänisch: Datum Auftragsbestätigung): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SQL_Date_Auf()
        {
            if (!this.DesignMode)
            {
                if (date_kauf_edit_Auftragsbestaetigng.Value.Date == null)
                {
                    date_kauf_edit_Auftragsbestaetigng.Value = DateTime.Today;
                    SQL_methods.SQL_exec(string.Format("UPDATE AB_AZ SET V_DATE = '{0}' WHERE A_ID = {1}", date_kauf_edit_Auftragsbestaetigng.Value.ToString("yyyy-MM-dd"), a_id));
                    UC_Kauf_Date_Auf_set();
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Wollen sie das Datum überschreiben?", "Datums Änderung in der Datenbank", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        SQL_methods.SQL_exec(string.Format("UPDATE AB_AZ SET V_DATE = '{0}' WHERE A_ID = {1}", date_kauf_edit_Auftragsbestaetigng.Value.ToString("yyyy-MM-dd"), a_id));
                        UC_Kauf_Date_Auf_set();
                    }

                    if (dr == DialogResult.No)
                    {
                        UC_Kauf_Date_Auf_set();
                    }
                }
                txt_check_if_requested();
            }
        }

        public void txt_check_if_requested()
        {
            if (!this.DesignMode)
            {
                bool check;
                lbl_kauf_Auftrag_bestaetigt.Visible = false;
                lbl_kauf_Anzahlung_bestaetigt.Visible = false;
                lbl_kauf_Schlussrechnung_bestaetigt.Visible = false;

                string sql = string.Format("SELECT V_Best FROM ab_az WHERE A_ID = " + a_id);
                OdbcConnection con = DB.Connection;
                OdbcCommand cmd = new OdbcCommand(sql, con);
                SQL_methods.Open();
                OdbcDataReader sql_reader = cmd.ExecuteReader();
                sql_reader.Read();
                check = Convert.ToBoolean(sql_reader[0]);
                sql_reader.Close();

                if (check)
                {
                    lbl_kauf_Auftrag_bestaetigt.Visible = true;
                }

                sql = string.Format("SELECT B_Best FROM ab_az WHERE A_ID = " + a_id);
                cmd = new OdbcCommand(sql, con);
                SQL_methods.Open();
                sql_reader = cmd.ExecuteReader();
                sql_reader.Read();
                check = Convert.ToBoolean(sql_reader[0]);
                sql_reader.Close();
                con.Close();

                if (check)
                {
                    lbl_kauf_Anzahlung_bestaetigt.Visible = true;
                }

                sql = string.Format("SELECT S_Best FROM ab_az WHERE A_ID = " + a_id);
                cmd = new OdbcCommand(sql, con);
                SQL_methods.Open();
                sql_reader = cmd.ExecuteReader();
                sql_reader.Read();
                check = Convert.ToBoolean(sql_reader[0]);
                sql_reader.Close();

                if (check)
                {
                    lbl_kauf_Schlussrechnung_bestaetigt.Visible = true;
                }

            }
        }

        private void UC_Kauf_Date_Anz_set()
        {
            if (!this.DesignMode)
            {
                try
                {
                    object obj_db;
                    string sql = "SELECT AB_AZ FROM auftraege WHERE ID = " + id;
                    OdbcCommand cmd = new OdbcCommand(sql, Connection);
                    SQL_methods.Open();
                    OdbcDataReader sql_reader = cmd.ExecuteReader();
                    sql_reader.Read();
                    string sql2 = "SELECT B_Date FROM ab_az WHERE A_ID = " +
                                  Convert.ToInt32(sql_reader[0].ToString());
                    sql_reader.Close();
                    OdbcCommand cmd2 = new OdbcCommand(sql2, Connection);
                    obj_db = cmd2.ExecuteScalar();

                    if (obj_db != DBNull.Value)
                    {
                        sql_reader = cmd2.ExecuteReader();
                        sql_reader.Read();
                        date_kauf_edit_Anzahlung.Value = DateTime.Parse(sql_reader[0].ToString());
                    }
                    else
                    {
                        date_kauf_edit_Anzahlung.CustomFormat = " ";
                        date_kauf_edit_Anzahlung.Format = DateTimePickerFormat.Custom;
                    }
                }
                catch (Exception f)
                {
                    MessageBox.Show("Fehler in der SQL Abfrage(Kaufmänisch: Datum Anzahlung): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SQL_Date_Anz()
        {
            if (!this.DesignMode)
            {
                if (date_kauf_edit_Anzahlung.Value.Date == null || date_kauf_edit_Schlussrechnung.Value.Date == DateTime.Today)
                {
                    date_kauf_edit_Anzahlung.Value = DateTime.Today;
                    SQL_methods.SQL_exec(string.Format("UPDATE AB_AZ SET B_DATE = '{0}' WHERE A_ID = {1}", date_kauf_edit_Anzahlung.Value.ToString("yyyy-MM-dd"), a_id));
                    UC_Kauf_Date_Anz_set();
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Wollen sie das Datum überschreiben?",
                        "Datums Änderung in der Datenbank", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        string sql = "SELECT AB_AZ FROM auftraege WHERE ID = " + id;
                        OdbcCommand cmd = new OdbcCommand(sql, Connection);
                        SQL_methods.Open();
                        OdbcDataReader sql_reader = cmd.ExecuteReader();
                        sql_reader.Read();
                        int ab_id = Convert.ToInt32(sql_reader[0].ToString());
                        sql_reader.Close();
                        SQL_methods.SQL_exec(string.Format("UPDATE AB_AZ SET B_DATE = '{0}' WHERE A_ID = {1}", date_kauf_edit_Anzahlung.Value.ToString("yyyy-MM-dd"), ab_id));
                        UC_Kauf_Date_Anz_set();
                    }

                    if (dr == DialogResult.No)
                    {
                        UC_Kauf_Date_Anz_set();
                    }
                }
                txt_check_if_requested();
            }
        }

        private void SQL_Date_Schluss()
        {
            if (!this.DesignMode)
            {
                if (date_kauf_edit_Schlussrechnung.Value.Date == null || date_kauf_edit_Schlussrechnung.Value.Date == DateTime.Today)
                {
                    date_kauf_edit_Schlussrechnung.Value = DateTime.Today;
                    SQL_methods.SQL_exec(string.Format("UPDATE AB_AZ SET S_DATE = '{0}' WHERE A_ID = {1}", date_kauf_edit_Schlussrechnung.Value.ToString("yyyy-MM-dd"), a_id));
                    UC_Kauf_Date_Schluss_set();
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Wollen sie das Datum überschreiben?",
                        "Datums Änderung in der Datenbank", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        string sql = "SELECT AB_AZ FROM auftraege WHERE ID = " + id;
                        OdbcCommand cmd = new OdbcCommand(sql, Connection);
                        SQL_methods.Open();
                        OdbcDataReader sql_reader = cmd.ExecuteReader();
                        sql_reader.Read();
                        int ab_id = Convert.ToInt32(sql_reader[0].ToString());
                        sql_reader.Close();
                        SQL_methods.SQL_exec(string.Format("UPDATE AB_AZ SET S_DATE = '{0}' WHERE A_ID = {1}", date_kauf_edit_Schlussrechnung.Value.ToString("yyyy-MM-dd"), ab_id));
                        UC_Kauf_Date_Schluss_set();
                    }

                    if (dr == DialogResult.No)
                    {
                        UC_Kauf_Date_Schluss_set();
                    }
                }
                txt_check_if_requested();
            }
        }

        private void UC_Kauf_Date_Schluss_set()
        {
            if (!this.DesignMode)
            {
                try
                {
                    object obj_db;
                    string sql = "SELECT AB_AZ FROM auftraege WHERE ID = " + id;
                    OdbcCommand cmd = new OdbcCommand(sql, Connection);
                    SQL_methods.Open();
                    OdbcDataReader sql_reader = cmd.ExecuteReader();
                    sql_reader.Read();
                    string sql2 = "SELECT S_Date FROM ab_az WHERE A_ID = " +
                                  Convert.ToInt32(sql_reader[0].ToString());
                    sql_reader.Close();
                    OdbcCommand cmd2 = new OdbcCommand(sql2, Connection);
                    obj_db = cmd2.ExecuteScalar();

                    if (obj_db != DBNull.Value)
                    {
                        sql_reader = cmd2.ExecuteReader();
                        sql_reader.Read();
                        date_kauf_edit_Schlussrechnung.Value = DateTime.Parse(sql_reader[0].ToString());
                    }
                    else
                    {
                        date_kauf_edit_Schlussrechnung.CustomFormat = " ";
                        date_kauf_edit_Schlussrechnung.Format = DateTimePickerFormat.Custom;
                    }
                }
                catch (Exception f)
                {
                    MessageBox.Show("Fehler in der SQL Abfrage(Kaufmänisch: Datum Schlussrechnung): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void Tmr_break_Tick(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                tmr_break.Enabled = false;
                btn_save_kauf_Auftragsbestaetigung.Enabled = true;
                btn_save_kauf_Anzahlung.Enabled = true;
                btn_save_kauf_Schlussrechnung.Enabled = true;
            }
        }

        private void Get_a_id()
        {
            if (!this.DesignMode)
            {
                string sql = "SELECT AB_AZ FROM auftraege WHERE ID = " + id;
                OdbcCommand cmd = new OdbcCommand(sql, Connection);
                SQL_methods.Open();
                OdbcDataReader sql_read = cmd.ExecuteReader();
                sql_read.Read();
                a_id = Convert.ToInt32(sql_read[0]);
            }
        }

        private void Date_kauf_edit_anz_CloseUp(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                SQL_Date_Anz();
            }
        }

        private void Date_kauf_edit_schluss_CloseUp(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                SQL_Date_Schluss();
            }
        }

        private void Date_kauf_edit_auf_CloseUp(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                SQL_Date_Auf();
            }
        }

        private void Date_kauf_edit_auf_ValueChanged(object sender, EventArgs e)
        {
            Format_all_datetimepicker("ddd dd/MM/yyyy");
        }

        private void Date_kauf_edit_anz_ValueChanged(object sender, EventArgs e)
        {
            Format_all_datetimepicker("ddd dd/MM/yyyy");
        }

        private void Date_kauf_edit_schluss_ValueChanged(object sender, EventArgs e)
        {
            Format_all_datetimepicker("ddd dd/MM/yyyy");
        }

        #endregion
    }
}
