using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LET_Auftragsverwaltung
{
    public partial class UC_edit_Kauf : UserControl
    {
        //ID zur Übergabe
        private int id = 0;

        private OdbcConnection Connection
        {
            get
            {
                return DB.Connection;

            }
        }


        public UC_edit_Kauf()
        {
            if (!this.DesignMode)
            {
                InitializeComponent();
                id = 10;
                UC_Kauf_Fill_cbx_kauf_edit_auf();
                UC_Kauf_Fill_cbx_kauf_edit_anz();
                UC_Kauf_Fill_cbx_kauf_edit_schluss();
                UC_Kauf_Date_Auf_set();
                UC_Kauf_Date_Anz_set();
                UC_Kauf_Date_Schluss_set();
                UC_Kauf_Text_Auf();
                UC_Kauf_Text_Anz();
                UC_Kauf_Text_Schluss();
            }
        }


        private void cbx_kauf_edit_auf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #region CBX Fill and Defines
        private void UC_Kauf_Fill_cbx_kauf_edit_auf()
        {
            cbx_kauf_edit_auf.DataSource = UC_Kauf_CBX_For_persons();
            cbx_kauf_edit_auf.ValueMember = "P_ID";
            cbx_kauf_edit_auf.DisplayMember = "Name";


            if (cbx_kauf_edit_auf.Items.Count > 0)
            {
                cbx_kauf_edit_auf.SelectedIndex = 0;
            }
        }

        private void UC_Kauf_Fill_cbx_kauf_edit_anz()
        {
            cbx_kauf_edit_anz.DataSource = UC_Kauf_CBX_For_persons();
            cbx_kauf_edit_anz.ValueMember = "P_ID";
            cbx_kauf_edit_anz.DisplayMember = "Name";


            if (cbx_kauf_edit_auf.Items.Count > 0)
            {
                cbx_kauf_edit_auf.SelectedIndex = 0;
            }
        }

        private void UC_Kauf_Fill_cbx_kauf_edit_schluss()
        {
            cbx_kauf_edit_schluss.DataSource = UC_Kauf_CBX_For_persons();
            cbx_kauf_edit_schluss.ValueMember = "P_ID";
            cbx_kauf_edit_schluss.DisplayMember = "Name";


            if (cbx_kauf_edit_auf.Items.Count > 0)
            {
                cbx_kauf_edit_auf.SelectedIndex = 0;
            }
        }

        private DataTable UC_Kauf_CBX_For_persons()
        {
            if (!this.DesignMode)
            {
                try
                {

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
        #endregion

        #region Date Methods
        private void UC_Kauf_Date_Auf_set()
        {
            try
            {
                object obj_db;
                string sql = "SELECT AB_AZ FROM auftraege WHERE ID = " + id;
                OdbcCommand cmd = new OdbcCommand(sql, Connection);
                SQL_methods.Open();
                OdbcDataReader sql_reader = cmd.ExecuteReader();
                sql_reader.Read();
                string sql2 = "SELECT V_Date FROM ab_az WHERE A_ID = " +
                              Convert.ToInt32(sql_reader[0].ToString());
                sql_reader.Close();
                OdbcCommand cmd2 = new OdbcCommand(sql2, Connection);
                obj_db = cmd2.ExecuteScalar();

                if (obj_db != DBNull.Value)
                {
                    sql_reader = cmd2.ExecuteReader();
                    sql_reader.Read();
                    date_kauf_edit_auf.Value = DateTime.Parse(sql_reader[0].ToString());
                }
                else
                {
                    date_kauf_edit_auf.CustomFormat = " ";
                    date_kauf_edit_auf.Format = DateTimePickerFormat.Custom;

                }
            }
            catch (Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage(Kaufmänisch: Datum Auftragsbestätigung): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UC_Kauf_Date_Anz_set()
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
                    date_kauf_edit_anz.Value = DateTime.Parse(sql_reader[0].ToString());
                }
                else
                {
                    date_kauf_edit_anz.CustomFormat = " ";
                    date_kauf_edit_anz.Format = DateTimePickerFormat.Custom;
                }
            }
            catch (Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage(Kaufmänisch: Datum Anzahlung): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UC_Kauf_Date_Schluss_set()
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
                    date_kauf_edit_schluss.Value = DateTime.Parse(sql_reader[0].ToString());
                }
                else
                {
                    date_kauf_edit_schluss.CustomFormat = " ";
                    date_kauf_edit_schluss.Format = DateTimePickerFormat.Custom;
                }
            }
            catch (Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage(Kaufmänisch: Datum Schlussrechnung): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Notiz Fills

        private void UC_Kauf_Text_Auf()
        {
            try
            {
                string sql = "SELECT AB_AZ FROM auftraege WHERE ID = " + id;
                OdbcCommand cmd = new OdbcCommand(sql, Connection);
                SQL_methods.Open();
                OdbcDataReader sql_reader = cmd.ExecuteReader();
                sql_reader.Read();
                string sql2 = "SELECT V_Notiz FROM ab_az WHERE A_ID = " +
                              Convert.ToInt32(sql_reader[0].ToString());
                sql_reader.Close();
                OdbcCommand cmd2 = new OdbcCommand(sql2, Connection);

                    sql_reader = cmd2.ExecuteReader();
                    sql_reader.Read();
                    txt_kauf_edit_auf.Text = sql_reader[0].ToString();
                

            }
            catch (Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage(Kaufmänisch: Notiz Anzahlung): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UC_Kauf_Text_Anz()
        {
            try
            {
                string sql = "SELECT AB_AZ FROM auftraege WHERE ID = " + id;
                OdbcCommand cmd = new OdbcCommand(sql, Connection);
                SQL_methods.Open();
                OdbcDataReader sql_reader = cmd.ExecuteReader();
                sql_reader.Read();
                string sql2 = "SELECT B_Notiz FROM ab_az WHERE A_ID = " +
                              Convert.ToInt32(sql_reader[0].ToString());
                sql_reader.Close();
                OdbcCommand cmd2 = new OdbcCommand(sql2, Connection);
              
                    sql_reader = cmd2.ExecuteReader();
                    sql_reader.Read();
                    txt_kauf_edit_anz.Text = sql_reader[0].ToString();
                

            }
            catch (Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage(Kaufmänisch: Notiz Anzahlung): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UC_Kauf_Text_Schluss()
        {
            try
            {
                string sql = "SELECT AB_AZ FROM auftraege WHERE ID = " + id;
                OdbcCommand cmd = new OdbcCommand(sql, Connection);
                SQL_methods.Open();
                OdbcDataReader sql_reader = cmd.ExecuteReader();
                sql_reader.Read();
                string sql2 = "SELECT B_Notiz FROM ab_az WHERE A_ID = " +
                              Convert.ToInt32(sql_reader[0].ToString());
                sql_reader.Close();
                OdbcCommand cmd2 = new OdbcCommand(sql2, Connection);

                    sql_reader = cmd2.ExecuteReader();
                    sql_reader.Read();
                    txt_kauf_edit_schluss.Text = sql_reader[0].ToString();
                

            }
            catch (Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage(Kaufmänisch: Sclussrechnung Notiz): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        #region Special Methods

        private void SQL_Date_Auf()
        {
            if (date_kauf_edit_auf.Equals(null))
            {
                SQL_methods.SQL_exec(string.Format("UPDATE AB_AZ SET V_DATE = '{0}' WHERE A_ID = {1}", date_kauf_edit_auf.Value.ToString("yyyy-MM-dd"), id));
                UC_Kauf_Date_Auf_set();
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
                    SQL_methods.SQL_exec(string.Format("UPDATE AB_AZ SET V_DATE = '{0}' WHERE A_ID = {1}", date_kauf_edit_auf.Value.ToString("yyyy-MM-dd"), ab_id));
                    UC_Kauf_Date_Auf_set();
                }

                if (dr == DialogResult.No)
                {
                    UC_Kauf_Date_Auf_set();
                }
            }
        }

        private void SQL_Date_Anz()
        {
            if (date_kauf_edit_anz.Equals(null))
            {
                SQL_methods.SQL_exec(string.Format("UPDATE AB_AZ SET B_DATE = '{0}' WHERE A_ID = {1}", date_kauf_edit_anz.Value.ToString("yyyy-MM-dd"), id));
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
                    SQL_methods.SQL_exec(string.Format("UPDATE AB_AZ SET B_DATE = '{0}' WHERE A_ID = {1}", date_kauf_edit_anz.Value.ToString("yyyy-MM-dd"), ab_id));
                    UC_Kauf_Date_Anz_set();
                }

                if (dr == DialogResult.No)
                {
                    UC_Kauf_Date_Anz_set();
                }
            }
        }

        private void SQL_Date_Schluss()
        {
            if (date_kauf_edit_schluss.Equals(null))
            {
                SQL_methods.SQL_exec(string.Format("UPDATE AB_AZ SET S_DATE = '{0}' WHERE A_ID = {1}", date_kauf_edit_schluss.Value.ToString("yyyy-MM-dd"), id));
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
                    SQL_methods.SQL_exec(string.Format("UPDATE AB_AZ SET S_DATE = '{0}' WHERE A_ID = {1}", date_kauf_edit_schluss.Value.ToString("yyyy-MM-dd"), ab_id));
                    UC_Kauf_Date_Schluss_set();
                }

                if (dr == DialogResult.No)
                {
                    UC_Kauf_Date_Schluss_set();
                }
            }
        }

        private void SQL_ALL_Notiz_Save()
        {
            int a_ID = 0;

            string sql = "SELECT AB_AZ FROM auftraege Where ID = " + id;
            OdbcCommand cmd = new OdbcCommand(sql, Connection);
            SQL_methods.Open();
            OdbcDataReader sql_Reader = cmd.ExecuteReader();
            sql_Reader.Read();
            a_ID = Convert.ToInt32(sql_Reader[0].ToString());


            SQL_methods.SQL_exec($"UPDATE AB_AZ SET B_Notiz = '{txt_kauf_edit_anz.Text}', V_Notiz = '{txt_kauf_edit_auf.Text}', S_Notiz = '{txt_kauf_edit_schluss.Text}' WHERE A_ID = {a_ID}");

            UC_Kauf_Text_Auf();
            UC_Kauf_Text_Anz();
            UC_Kauf_Text_Schluss();
        }

        #endregion

        #region Form Methods

        private void date_kauf_edit_auf_ValueChanged(object sender, EventArgs e)
        {
            date_kauf_edit_auf.CustomFormat = "dd/MM/yyyy hh:mm:ss";


        }

        private void date_kauf_edit_anz_ValueChanged(object sender, EventArgs e)
        {
            date_kauf_edit_anz.CustomFormat = "dd/MM/yyyy hh:mm:ss";
        }

        private void btn_save_kauf_edit_auf_Click(object sender, EventArgs e)
        {
            try
            {
                int a_ID;
                SQL_methods.SQL_exec(string.Format("INSERT INTO AB_AZ (V_Notiz) Values ('{0}')",
                    " "));
                string sql = "SELECT A_ID FROM ab_az ORDER BY A_ID DESC LIMIT 1";
                OdbcCommand cmd = new OdbcCommand(sql, Connection);
                SQL_methods.Open();
                OdbcDataReader sql_read = cmd.ExecuteReader();
                sql_read.Read();
                a_ID = Convert.ToInt32(sql_read[0].ToString());
                sql_read.Close();

                SQL_ALL_Notiz_Save();

                SQL_methods.SQL_exec(string.Format("UPDATE auftraege SET AB_AZ = {0} WHERE ID = {1}", a_ID, id));

                sql = "SELECT Projektbezeichnung FROM auftraege WHERE ID = " + id;
                 cmd = new OdbcCommand(sql, Connection);
                SQL_methods.Open();
                sql_read = cmd.ExecuteReader();
                sql_read.Read();
                string bez = Convert.ToString(sql_read[0].ToString());
                sql_read.Close();

                Email.Send_Mail("chaftalie@icloud.com", "[LET] Auftragsbestätigung: "+ bez, "TestTest"); //TODO (SUBJEKT: [LET] AUftragsbestätigung: ProjektBet) (BODY: Mehr Infot ID ect..)



            }
            catch (Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage(Edit Auftrag: INSERT AB_AZ Anfordern): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_save_kauf_edit_anz_Click(object sender, EventArgs e)
        {
            try
            {
                int a_ID;
                SQL_methods.SQL_exec(string.Format("INSERT INTO AB_AZ (V_Notiz) Values ('{0}')",
                    " "));
                string sql = "SELECT A_ID FROM ab_az ORDER BY A_ID DESC LIMIT 1";
                OdbcCommand cmd = new OdbcCommand(sql, Connection);
                SQL_methods.Open();
                OdbcDataReader sql_read = cmd.ExecuteReader();
                sql_read.Read();
                a_ID = Convert.ToInt32(sql_read[0].ToString());
                sql_read.Close();

                SQL_ALL_Notiz_Save();

                SQL_methods.SQL_exec(string.Format("UPDATE auftraege SET AB_AZ = {0} WHERE ID = {1}", a_ID, id));

                sql = "SELECT Projektbezeichnung FROM auftraege WHERE ID = " + id;
                cmd = new OdbcCommand(sql, Connection);
                SQL_methods.Open();
                sql_read = cmd.ExecuteReader();
                sql_read.Read();
                string bez = Convert.ToString(sql_read[0].ToString());
                sql_read.Close();

                Email.Send_Mail("chaftalie@icloud.com", "[LET] Anzahlungsrechnung: " + bez, "TestTest"); //TODO (SUBJEKT: [LET] AUftragsbestätigung: ProjektBet) (BODY: Mehr Infot ID ect..)



            }
            catch (Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage(Edit Auftrag: INSERT AB_AZ Bestätigen): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void date_kauf_edit_auf_CloseUp(object sender, EventArgs e) //TODO Pro Date und Akt_Date eine neue Methode die die SQL und DialogBox behandeln soll
        {           
            SQL_Date_Auf();
        }

        private void btn_date_kauf_edit_auf_Click(object sender, EventArgs e)
        {
            date_kauf_edit_auf.Value = DateTime.Today;
            SQL_Date_Auf();
        }



        #endregion

        private void date_kauf_edit_anz_CloseUp(object sender, EventArgs e)
        {
            SQL_Date_Anz();

        }

        private void btn_date_kauf_edit_anz_Click(object sender, EventArgs e)
        {
            date_kauf_edit_anz.Value = DateTime.Today;
            SQL_Date_Auf();
        }

        private void date_kauf_edit_schluss_ValueChanged(object sender, EventArgs e)
        {
            date_kauf_edit_schluss.CustomFormat = "dd/MM/yyyy hh:mm:ss";
        }

        private void date_kauf_edit_schluss_CloseUp(object sender, EventArgs e)
        {
            SQL_Date_Schluss();
        }

        private void btn_date_kauf_edit_schluss_Click(object sender, EventArgs e)
        {
            date_kauf_edit_schluss.Value = DateTime.Today;
            SQL_Date_Schluss();
        }

        private void btn_edit_kauf_text_save_Click(object sender, EventArgs e)
        {
            SQL_ALL_Notiz_Save();
        }

        private void btn_save_kauf_edit_schluss_Click(object sender, EventArgs e)
        {
            try
            {
                int a_ID;
                SQL_methods.SQL_exec(string.Format("INSERT INTO AB_AZ (V_Notiz) Values ('{0}')",
                    " "));
                string sql = "SELECT A_ID FROM ab_az ORDER BY A_ID DESC LIMIT 1";
                OdbcCommand cmd = new OdbcCommand(sql, Connection);
                SQL_methods.Open();
                OdbcDataReader sql_read = cmd.ExecuteReader();
                sql_read.Read();
                a_ID = Convert.ToInt32(sql_read[0].ToString());
                sql_read.Close();

                SQL_ALL_Notiz_Save();

                SQL_methods.SQL_exec(string.Format("UPDATE auftraege SET AB_AZ = {0} WHERE ID = {1}", a_ID, id));

                sql = "SELECT Projektbezeichnung FROM auftraege WHERE ID = " + id;
                cmd = new OdbcCommand(sql, Connection);
                SQL_methods.Open();
                sql_read = cmd.ExecuteReader();
                sql_read.Read();
                string bez = Convert.ToString(sql_read[0].ToString());
                sql_read.Close();

                Email.Send_Mail("chaftalie@icloud.com", "[LET] Schlussrechnung: " + bez, "TestTest"); //TODO (SUBJEKT: [LET] AUftragsbestätigung: ProjektBet) (BODY: Mehr Infot ID ect..)



            }
            catch (Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage(Edit Auftrag: INSERT AB_AZ Schlussrechnung): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
