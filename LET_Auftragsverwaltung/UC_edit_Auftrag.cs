using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exception = System.Exception;
using Office = Microsoft.Office.Core;
using Outlook = Microsoft.Office.Interop.Outlook;


namespace LET_Auftragsverwaltung
{


    //TODO ObjectListView ID 


    public partial class UC_edit_Auftrag : UserControl
    {
        private OdbcConnection Connection
        {
            get
            {
                return CS_DB.Connection;

            }
        }

        //ID zur Übergabe
        private int id = 0;

        public UC_edit_Auftrag(int id_)
        {
            InitializeComponent();
            id = id_;

        }

        private void UC_edit_Auftrag_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                #region FillKlassen

                UC_edit_Auftrag_fill_cbx_status();
                UC_Edit_Auftrag_fill_cbx_verant();
                UC_Editt_auftrag_fill_cbx_tech();
                UC_Edit_Auftrag_fill_lbx_auftrag();
                UC_Edit_Auftrag_fill_cbx_art();
                UC_edit_auftrag_fill_cbx_lief();
                UC_Edit_Auftrag_fill_lbx_stoff();
                UC_Edit_Auftrag_fill_cbx_schatten_pers();

                #endregion


                string sql = "SELECT * FROM auftraege WHERE id = " + id;
                OdbcCommand cmd = new OdbcCommand(sql, Connection);
                CS_SQL_methods.Open();
                OdbcDataReader sqlReader = cmd.ExecuteReader();
                if (sqlReader.Read())
                {
                    txt_auftrag_nr.Text = ( string ) sqlReader[1];
                    cbx_auftragsstatus.SelectedValue = sqlReader[2];
                    date_erstell.Value = Convert.ToDateTime(sqlReader[3]);
                    cbx_verant.SelectedValue = sqlReader[6];
                    cbx_tech.SelectedValue = sqlReader[7];
                    txt_auf_proj_ken.Text = ( string ) sqlReader[8];
                    date_mont.Value = Convert.ToDateTime(sqlReader[10]);
                    txt_info_kauf.Text = ( string ) sqlReader[11];
                    txt_info_tech.Text = ( string ) sqlReader[12];
                }




            }
        }

        #region Definition Fill Klassen

        private void UC_edit_Auftrag_fill_cbx_status( )
        {
            if (!this.DesignMode)
            {
                try
                {

                    CS_SQL_methods.Open();
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

        private void UC_Edit_Auftrag_fill_cbx_verant( )
        {
            if (!this.DesignMode)
            {
                try
                {


                    DataTable dtVerant = CS_SQL_methods.Fill_Box("SELECT DISTINCT CONCAT(p.`Nachname`, ' ', p.`Vorname`) AS 'Name', p.P_ID FROM personal p LEFT JOIN personal_funktion pf ON p.P_ID = pf.P_ID WHERE pf.Funktion_ID = 4");

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

        private void UC_Editt_auftrag_fill_cbx_tech( )
        {
            if (!this.DesignMode)
            {
                try
                {

                    DataTable dt = CS_SQL_methods.Fill_Box("SELECT DISTINCT CONCAT(p.`Nachname`, ' ', p.`Vorname`) AS 'Name', p.P_ID FROM personal p LEFT JOIN personal_funktion pf ON p.P_ID = pf.P_ID WHERE pf.Funktion_ID = 1 OR pf.Funktion_ID = 2");

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

        private void UC_Edit_Auftrag_fill_lbx_auftrag( )
        {
            if (!this.DesignMode)
            {
                try
                {
                    DataTable dt = CS_SQL_methods.Fill_Box(string.Format("SELECT auftragsart.Art_ID, auftragsart.`Art` FROM auftraege Inner JOIN auftraege_auftragsart ON auftraege.ID = auftraege_auftragsart.ID Inner JOIN auftragsart ON auftraege_auftragsart.Art_ID=auftragsart.Art_ID WHERE auftraege.ID = {0}", id));

                    lbx_auftrag.DataSource = dt;
                    lbx_auftrag.ValueMember = "Art_ID";
                    lbx_auftrag.DisplayMember = "Art";

                    if (lbx_auftrag.Items.Count > 0)
                    {
                        lbx_auftrag.SelectedIndex = 0;
                    }
                }
                catch (Exception f)
                {

                    MessageBox.Show("Fehler in der SQL Abfrage(Edit Auftrag: Fill LBX Auftrag): \n\n" + f.Message + "\n\n" + f.Data.Values.ToString(), "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void UC_Edit_Auftrag_fill_cbx_art( )
        {
            if (!this.DesignMode)
            {
                try
                {
                    DataTable dtArt = CS_SQL_methods.Fill_Box("SELECT Art_ID,Art FROM auftragsart WHERE deaktiviert<>true");

                    cbx_auftrag.DataSource = dtArt;
                    cbx_auftrag.DisplayMember = "Art";
                    cbx_auftrag.ValueMember = "Art_ID";

                    if (cbx_auftrag.Items.Count > 0)
                    {
                        cbx_auftrag.SelectedIndex = 0;
                    }
                }

                catch (Exception f)
                {
                    MessageBox.Show("Fehler in der SQL Abfrage(Edit Auftrag: Fill CBX Auftragsart): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {

                }
            }
        }

        private void UC_edit_auftrag_fill_cbx_lief( )
        {
            if (!this.DesignMode)
            {
                try
                {
                    DataTable dtLief = CS_SQL_methods.Fill_Box("SELECT L_ID, Lieferant FROM Lieferant WHERE deaktiviert<>true");

                    cbx_edit_auf_lief.DataSource = dtLief;
                    cbx_edit_auf_lief.ValueMember = "L_ID";
                    cbx_edit_auf_lief.DisplayMember = "Lieferant";


                    if (cbx_edit_auf_lief.Items.Count > 0)
                    {
                        cbx_edit_auf_lief.SelectedIndex = 0;
                    }
                }
                catch (Exception f)
                {
                    MessageBox.Show("Fehler in der SQL Abfrage(Neue Auftrag: Fill CBX Lief): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UC_Edit_Auftrag_fill_lbx_stoff( )
        {
            if (!this.DesignMode)
            {
                try
                {
                    DataTable dt = CS_SQL_methods.Fill_Box(string.Format("SELECT stoff.`ST_ID`,stoff.`Stoff` FROM auftraege INNER JOIN teile ON auftraege.`ID` = teile.`ID` INNER JOIN teile_stoff ON teile.`T_St_ID` = teile_stoff.`T_St_ID` INNER JOIN stoff ON teile_stoff.`ST_ID` = stoff.`ST_ID` WHERE auftraege.ID = 1", id));

                    lbx_stoff.DataSource = dt;
                    lbx_stoff.ValueMember = "ST_ID";
                    lbx_stoff.DisplayMember = "Stoff";


                    if (lbx_auftrag.Items.Count > 0)
                    {
                        lbx_auftrag.SelectedIndex = 0;
                    }
                }
                catch (Exception f)
                {

                    MessageBox.Show("Fehler in der SQL Abfrage(Edit Auftrag: Fill LBX Auftrag): \n\n" + f.Message + "\n\n" + f.Data.Values.ToString(), "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void UC_New_auftrag_fill_cbx_stoff_lief( )
        {
            if (!this.DesignMode)
            {
                if (cbx_edit_auf_lief.Items.Count > 0)
                {
                    try
                    {
                        DataTable dtStoff = CS_SQL_methods.Fill_Box(string.Format("SELECT stoff.ST_ID,stoff.`Stoff` FROM stoff INNER JOIN stoff_lieferant ON stoff.ST_ID = stoff_lieferant.ST_ID WHERE stoff_lieferant.L_ID = {0}", cbx_edit_auf_lief.SelectedValue));

                        cbx_edit_auf_stoff.DataSource = dtStoff;
                        cbx_edit_auf_stoff.ValueMember = "ST_ID";
                        cbx_edit_auf_stoff.DisplayMember = "Stoff";


                        if (cbx_edit_auf_stoff.Items.Count > 0)
                        {
                            cbx_edit_auf_stoff.SelectedIndex = 0;
                        }
                    }
                    catch (Exception f)
                    {
                        MessageBox.Show("Fehler in der SQL Abfrage(EDIT Auftrag: Fill CBX Stoff): \n\n" + f.Message,
                            "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void UC_Edit_Auftrag_fill_cbx_schatten_pers( )
        {
            if (!this.DesignMode)
            {
                try
                {
                    DataTable dt_pers = CS_SQL_methods.Fill_Box(
                        "SELECT DISTINCT CONCAT(p.`Nachname`, ' ', p.`Vorname`) AS 'Name', p.P_ID FROM personal p LEFT JOIN personal_funktion pf ON p.P_ID = pf.P_ID");

                    cbx_schatten_pers.DataSource = dt_pers;
                    cbx_schatten_pers.ValueMember = "P_ID";
                    cbx_schatten_pers.DisplayMember = "Name";

                }
                catch (Exception f)
                {
                    MessageBox.Show("Fehler in der SQL Abfrage(Edit Auftrag: Fill CBX Schatten Pers): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region Button Methoden




        private void btn_edit_infos_Click(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                try
                {
                    CS_SQL_methods.SQL_exec(string.Format(
                        "UPDATE auftraege SET Auftrags_NR = '{0}', Fertigungsstatus = {1}, Projektverantwortlicher = {2}, Planer_Techniker = {3}, Projektbezeichnung = '{4}', Montage_Datum  = '{5}', Notitz_Kauf = '{6}', Notitz_Tech = '{7}', Erstelldatum = '{8}' WHERE ID = {9}",
                        txt_auftrag_nr.Text, cbx_auftragsstatus.SelectedValue, cbx_verant.SelectedValue,
                        cbx_tech.SelectedValue,
                        txt_auf_proj_ken.Text, date_mont.Value.ToString("yyyy-MM-dd"), txt_info_kauf.Text,
                        txt_info_tech.Text, date_erstell.Value.ToString("yyyy-MM-dd"), id));
                }
                catch (Exception f)
                {

                    MessageBox.Show("Fehler in der SQL Abfrage(Edit Auftrag: EDIT): \n\n" + f.Message, "Fehler",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    UC_edit_Auftrag_Load(sender, e);
                }
            }
        }

        private void tab_Allgemein_Click(object sender, EventArgs e)
        {
        }

        private void btn_auftag_delete_Click(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                try
                {
                    CS_SQL_methods.SQL_exec(string.Format("DELETE FROM  auftraege_auftragsart WHERE ID = {0} AND Art_ID = {1}",
                        id,
                        ( int ) lbx_auftrag.SelectedValue));
                    UC_Edit_Auftrag_fill_lbx_auftrag();
                }
                catch (Exception f)
                {
                    MessageBox.Show("Fehler in der SQL Abfrage(Edit Auftrag: Delete LBX Auftrag Auftragsart): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btn_auftrag_add_Click(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                try
                {
                    CS_SQL_methods.SQL_exec(string.Format("INSERT INTO auftraege_auftragsart (ID, Art_ID) VALUES ({0}, {1})",
                        id,
                        ( int ) cbx_auftrag.SelectedValue));
                    UC_Edit_Auftrag_fill_lbx_auftrag();
                }
                catch (Exception f)
                {
                    MessageBox.Show("Fehler in der SQL Abfrage(Edit Auftrag: INSERT LBX Auftrag Auftragsart): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void cbx_edit_auf_lief_DropDownClosed(object sender, EventArgs e)
        {

            cbx_edit_auf_stoff.Enabled = true;
            UC_New_auftrag_fill_cbx_stoff_lief();

        }


        #endregion

        private void btn_add_stoff_Click(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                try
                {
                    CS_SQL_methods.SQL_exec(string.Format("INSERT INTO auftraege_auftragsart (ID, Art_ID) VALUES ({0}, {1})",
                        id,
                        ( int ) cbx_edit_auf_stoff.SelectedValue));
                    UC_Edit_Auftrag_fill_lbx_auftrag();
                }
                catch (Exception f)
                {
                    MessageBox.Show("Fehler in der SQL Abfrage(Edit Auftrag: INSERT LBX Auftrag Auftragsart): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_ab_az_an_Click(object sender, EventArgs e)
        {
            try
            {
                int a_ID;
                CS_SQL_methods.SQL_exec(string.Format("INSERT INTO AB_AZ (V_Date) Values ('{0}')",
                    DateTime.Now.Date.ToString("yyyy-MM-dd")));
                string sql = "SELECT A_ID FROM ab_az ORDER BY A_ID DESC LIMIT 1";
                OdbcCommand cmd = new OdbcCommand(sql, Connection);
                CS_SQL_methods.Open();
                OdbcDataReader sql_read = cmd.ExecuteReader();
                sql_read.Read();
                a_ID = Convert.ToInt32(sql_read[0].ToString());

                CS_SQL_methods.SQL_exec(string.Format("UPDATE auftraege SET AB_AZ = {0} WHERE ID = {1}", a_ID, id));

                AB_AZ_Controll();

            }
            catch (Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage(Edit Auftrag: INSERT AB_AZ Anfordern): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int a_ID = 0;

                string sql = "SELECT AB_AZ FROM auftraege Where ID = " + id;
                OdbcCommand cmd = new OdbcCommand(sql, Connection);
                CS_SQL_methods.Open();
                OdbcDataReader sql_Reader = cmd.ExecuteReader();
                sql_Reader.Read();
                a_ID = Convert.ToInt32(sql_Reader[0].ToString());


                CS_SQL_methods.SQL_exec(string.Format("UPDATE AB_AZ SET B_DATE = '{0}' WHERE A_ID = {1}", DateTime.Now.Date.ToString("yyyy-MM-dd"), a_ID));

                AB_AZ_Controll();

            }
            catch (Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage(Edit Auftrag: INSERT AB_AZ Bestätigen): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int s_ID = 0;
                string sql = "SELECT Schatten FROM auftraege WHERE ID = " + id;
                OdbcCommand cmd = new OdbcCommand(sql, Connection);
                CS_SQL_methods.Open();
                OdbcDataReader sql_reader = cmd.ExecuteReader();
                sql_reader.Read();
                s_ID = Convert.ToInt32(sql_reader[0].ToString());

                CS_SQL_methods.SQL_exec(string.Format("UPDATE schatten SET Schattendatum = '{0}', P_ID = {1}, Notiz = '{2}' WHERE S_ID = {3}", dtp_schatten.Value.ToString("yyyy-MM-dd"), cbx_schatten_pers.SelectedValue, rtx_schatten.Text, s_ID));

                Schatten_Controll();

            }

            catch (Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage(Edit Auftrag: UPDATE Schatten BTN): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_persenning_save_Click(object sender, EventArgs e)
        {
            try
            {
                int p_ID = 0;
                string sql = "";

                OdbcCommand cmd;
                OdbcDataReader sql_reader;

                sql = "SELECT T_P_ID FROM teile WHERE ID = " + id;
                cmd = new OdbcCommand(sql, Connection);
                CS_SQL_methods.Open();
                sql_reader = cmd.ExecuteReader();
                sql_reader.Read();

                p_ID = Convert.ToInt32(sql_reader[0].ToString());
                sql_reader.Close();


                if (p_ID != 0)
                {
                    sql = "SELECT T_P_ID FROM teile WHERE ID = " + id;
                    cmd = new OdbcCommand(sql, Connection);
                    CS_SQL_methods.Open();
                    sql_reader = cmd.ExecuteReader();
                    sql_reader.Read();
                    p_ID = Convert.ToInt32(sql_reader[0].ToString());
                    sql_reader.Close();


                    CS_SQL_methods.SQL_exec(string.Format(
                        "UPDATE teile_persenning SET Lieferdatum = '{0}', Bestelldatum = '{1}' WHERE T_P_ID = {2}",
                        dtp_persenning_lief.Value.ToString("yyyy-MM-dd"),
                        dtp_persenning_best.Value.ToString("yyyy-MM-dd"), p_ID));
                }
                else
                {
                    CS_SQL_methods.SQL_exec(string.Format(
                        "INSERT INTO teile_persenning (Lieferdatum, Bestelldatum) Values ('{0}', '{1}')",
                        dtp_persenning_lief.Value.ToString("yyyy-MM-dd"),
                        dtp_persenning_best.Value.ToString("yyyy-MM-dd")));
                    sql = "SELECT T_P_ID FROM teile_persenning ORDER BY T_P_ID DESC LIMIT 1";
                    cmd = new OdbcCommand(sql, Connection);
                    CS_SQL_methods.Open();
                    sql_reader = cmd.ExecuteReader();
                    sql_reader.Read();
                    p_ID = Convert.ToInt32(sql_reader[0].ToString());
                    sql_reader.Close();

                    CS_SQL_methods.SQL_exec(string.Format("UPDATE teile SET T_P_ID = {0} WHERE ID = {1}", p_ID, id));
                }

                Persenning_Controll();

            }
            catch (Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage(Edit Auftrag: Persenning): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_sond_save_Click(object sender, EventArgs e)
        {
            try
            {
                int s_ID = 0;
                string sql = "";

                OdbcCommand cmd;
                OdbcDataReader sql_reader;

                sql = "SELECT T_S_ID FROM teile WHERE ID = " + id;
                cmd = new OdbcCommand(sql, Connection);
                CS_SQL_methods.Open();
                sql_reader = cmd.ExecuteReader();
                sql_reader.Read();

                s_ID = Convert.ToInt32(sql_reader[0].ToString());
                sql_reader.Close();


                if (s_ID != 0)
                {
                    sql = "SELECT T_S_ID FROM teile WHERE ID = " + id;
                    cmd = new OdbcCommand(sql, Connection);
                    CS_SQL_methods.Open();
                    sql_reader = cmd.ExecuteReader();
                    sql_reader.Read();
                    s_ID = Convert.ToInt32(sql_reader[0].ToString());
                    sql_reader.Close();

                    CS_SQL_methods.SQL_exec(string.Format(
                        "UPDATE teile_sonder SET Lieferdatum = '{0}', Bestelldatum = '{1}' WHERE T_S_ID = {2}",
                        dtp_sond_lief.Value.ToString("yyyy-MM-dd"),
                        dtp_sond_best.Value.ToString("yyyy-MM-dd"), s_ID));
                }
                else
                {
                    CS_SQL_methods.SQL_exec(string.Format(
                        "INSERT INTO teile_sonder (Lieferdatum, Bestelldatum) Values ('{0}', '{1}')",
                        dtp_sond_lief.Value.ToString("yyyy-MM-dd"),
                        dtp_sond_best.Value.ToString("yyyy-MM-dd")));
                    sql = "SELECT T_S_ID FROM teile_sonder ORDER BY T_S_ID DESC LIMIT 1";
                    cmd = new OdbcCommand(sql, Connection);
                    CS_SQL_methods.Open();
                    sql_reader = cmd.ExecuteReader();
                    sql_reader.Read();
                    s_ID = Convert.ToInt32(sql_reader[0].ToString());
                    sql_reader.Close();

                    CS_SQL_methods.SQL_exec(string.Format("UPDATE teile SET T_S_ID = {0} WHERE ID = {1}", s_ID, id));
                }

                Sonderteile_Controll();

            }
            catch (Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage(Edit Auftrag: Persenning): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void AB_AZ_Controll( )
        {
            int a_ID = 0;
            string sql = "SELECT AB_AZ FROM auftraege WHERE ID = " + id;

            OdbcCommand cmd = new OdbcCommand(sql, Connection);
            CS_SQL_methods.Open();
            object obj_db = cmd.ExecuteScalar();
            if (obj_db != DBNull.Value)
            {
                a_ID = Convert.ToInt32(cmd.ExecuteScalar());
                string sql2 = "SELECT B_Date FROM ab_az WHERE A_ID = " + a_ID;
                OdbcCommand cmd2 = new OdbcCommand(sql2, Connection);
                obj_db = cmd2.ExecuteScalar();

                if (obj_db != DBNull.Value)
                {
                    btn_ab_az_an.Enabled = false;
                    btn_ab_az_be.Enabled = false;
                }
                else
                {
                    btn_ab_az_an.Enabled = false;
                    btn_ab_az_be.Enabled = true;
                }
            }
            else
            {
                btn_ab_az_an.Enabled = true;
                btn_ab_az_be.Enabled = false;
            }



        }

        private void Schatten_Controll( )
        {
            object obj_db;
            string sql = "SELECT Schatten FROM auftraege WHERE ID = " + id;
            OdbcCommand cmd = new OdbcCommand(sql, Connection);
            CS_SQL_methods.Open();
            OdbcDataReader sql_reader = cmd.ExecuteReader();
            sql_reader.Read();
            string sql2 = "SELECT Schattendatum, P_ID, Notiz FROM schatten WHERE S_ID = " +
                          Convert.ToInt32(sql_reader[0].ToString());
            sql_reader.Close();
            OdbcCommand cmd2 = new OdbcCommand(sql2, Connection);
            obj_db = cmd2.ExecuteScalar();

            if (obj_db != DBNull.Value)
            {
                sql_reader = cmd2.ExecuteReader();
                sql_reader.Read();
                dtp_schatten.Value = DateTime.Parse(sql_reader[0].ToString());
                cbx_schatten_pers.SelectedValue = Convert.ToInt32(sql_reader[1].ToString());
                rtx_schatten.Text = sql_reader[2].ToString();
            }
            else
            {
                dtp_schatten.Value = DateTime.Today.Date;
            }

        }

        private void Persenning_Controll( )
        {
            object obj_db;
            int p_ID;
            string sql = "SELECT T_P_ID FROM teile WHERE ID = " + id;
            OdbcCommand cmd = new OdbcCommand(sql, Connection);
            CS_SQL_methods.Open();
            OdbcDataReader sql_reader = cmd.ExecuteReader();
            sql_reader.Read();
            p_ID = Convert.ToInt32(sql_reader[0].ToString());
            sql_reader.Close();
            sql = "SELECT Bestelldatum FROM teile_persenning WHERE T_P_ID = " +
                  p_ID;

            cmd = new OdbcCommand(sql, Connection);

            obj_db = cmd.ExecuteScalar();

            if (obj_db != DBNull.Value && obj_db != null)
            {
                sql_reader = cmd.ExecuteReader();
                sql_reader.Read();
                dtp_persenning_best.Value = DateTime.Parse(sql_reader[0].ToString());
                sql_reader.Close();
                sql = "SELECT Lieferdatum FROM teile_persenning WHERE T_P_ID = " +
                      p_ID;
                cmd = new OdbcCommand(sql, Connection);

                obj_db = cmd.ExecuteScalar();
                if (obj_db != DBNull.Value && obj_db != null)
                {
                    sql_reader = cmd.ExecuteReader();
                    sql_reader.Read();
                    dtp_persenning_lief.Value = DateTime.Parse(sql_reader[0].ToString());
                    sql_reader.Close();
                }
                else
                {
                    dtp_persenning_lief.Value = DateTime.Today;
                }
            }
            else
            {
                dtp_persenning_lief.Value = DateTime.Today;
                dtp_persenning_best.Value = DateTime.Today;
            }



        }

        private void Sonderteile_Controll( )
        {
            object obj_db;
            int s_ID;
            string sql = "SELECT T_S_ID FROM teile WHERE ID = " + id;
            OdbcCommand cmd = new OdbcCommand(sql, Connection);
            CS_SQL_methods.Open();
            OdbcDataReader sql_reader = cmd.ExecuteReader();
            sql_reader.Read();
            s_ID = Convert.ToInt32(sql_reader[0].ToString());
            sql_reader.Close();
            sql = "SELECT Bestelldatum FROM teile_sonder WHERE T_S_ID = " +
                  s_ID;

            cmd = new OdbcCommand(sql, Connection);

            obj_db = cmd.ExecuteScalar();

            if (obj_db != DBNull.Value && obj_db != null)
            {
                sql_reader = cmd.ExecuteReader();
                sql_reader.Read();
                dtp_sond_best.Value = DateTime.Parse(sql_reader[0].ToString());
                sql_reader.Close();
                sql = "SELECT Lieferdatum FROM teile_sonder WHERE T_S_ID = " +
                      s_ID;
                cmd = new OdbcCommand(sql, Connection);

                obj_db = cmd.ExecuteScalar();
                if (obj_db != DBNull.Value && obj_db != null)
                {
                    sql_reader = cmd.ExecuteReader();
                    sql_reader.Read();
                    dtp_sond_lief.Value = DateTime.Parse(sql_reader[0].ToString());
                    sql_reader.Close();
                }
                else
                {
                    dtp_sond_lief.Value = DateTime.Today;
                }
            }
            else
            {
                dtp_sond_lief.Value = DateTime.Today;
                dtp_sond_best.Value = DateTime.Today;
            }


        }

        private void tab_schatten_Enter(object sender, EventArgs e)
        {
            Schatten_Controll();
        }

        private void tab_persennning_Enter(object sender, EventArgs e)
        {
            Persenning_Controll();
        }

        private void tab_ab_az_Enter(object sender, EventArgs e)
        {
            AB_AZ_Controll();
        }

        private void tab_sond_Enter(object sender, EventArgs e)
        {
            Sonderteile_Controll();
        }
    }
}
