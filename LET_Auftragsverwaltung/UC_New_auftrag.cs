using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.SqlClient;

namespace LET_Auftragsverwaltung
{
    public partial class UC_New_auftrag : UserControl
    {
        private OdbcConnection connection = null;

        private OdbcConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    string constrg = "Driver={MySQL ODBC 5.3 Unicode Driver};Server=192.168.16.192;Database=auftrags;User=admin;Password=cola0815;Option=3;";
                    connection = new OdbcConnection(constrg);
                }
                return connection;
            }
        }

        public UC_New_auftrag()
        {
            InitializeComponent();
        }

        private void UC_New_auftrag_Load(object sender, EventArgs e)
        {
            UC_New_auftrag_fill_cbx_verant();
            UC_New_auftrag_fill_cbx_tech();
            UC_New_auftrag_fill_cbx_auf();
            UC_New_auftrag_fill_cbx_lief();
            date_erstell.Value = DateTime.Today;
            date_mont.Value = DateTime.Today.AddDays(28);
        }

        private void UC_New_auftrag_fill_cbx_verant()
        {
            try
            {
                OdbcConnection connection = Connection;
                connection.Open();
                string sql = "SELECT DISTINCT CONCAT(p.`Nachname`, ' ', p.`Vorname`) AS 'Name', p.P_ID FROM personal p LEFT JOIN personal_funktion pf ON p.P_ID = pf.P_ID WHERE pf.Funktion_ID = 4";
                OdbcDataAdapter dc = new OdbcDataAdapter(sql, connection);
                DataTable dtPer = new DataTable();
                dc.Fill(dtPer);
                connection.Close();


                cbx_verant.DataSource = dtPer;
                cbx_verant.ValueMember = "P_ID";
                cbx_verant.DisplayMember = "Name";


                if (cbx_verant.Items.Count > 0) cbx_verant.SelectedIndex = 0;
            }
            catch (Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage(Neue Auftrag: Fill CBX Verant): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UC_New_auftrag_fill_cbx_stoff()
        {
            try
            {
                OdbcConnection connection = Connection;
                connection.Open();
                string sql = "SELECT DISTINCT CONCAT(p.`Nachname`, ' ', p.`Vorname`) AS 'Name', p.P_ID FROM personal p LEFT JOIN personal_funktion pf ON p.P_ID = pf.P_ID WHERE pf.Funktion_ID = 4";
                OdbcDataAdapter dc = new OdbcDataAdapter(sql, connection);
                DataTable dtPer = new DataTable();
                dc.Fill(dtPer);
                connection.Close();


                cbx_verant.DataSource = dtPer;
                cbx_verant.ValueMember = "P_ID";
                cbx_verant.DisplayMember = "Name";


                if (cbx_verant.Items.Count > 0) cbx_verant.SelectedIndex = 0;
            }
            catch (Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage(Neue Auftrag: Fill CBX Stoff): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UC_New_auftrag_fill_cbx_tech()
        {
            try
            {
                OdbcConnection connection = Connection;
                connection.Open();
                string sql = "SELECT DISTINCT CONCAT(p.`Nachname`, ' ', p.`Vorname`) AS 'Name', p.P_ID FROM personal p LEFT JOIN personal_funktion pf ON p.P_ID = pf.P_ID WHERE pf.Funktion_ID = 1 OR pf.Funktion_ID = 2";
                OdbcDataAdapter db = new OdbcDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                db.Fill(dt);
                connection.Close();

                cbx_tech.DataSource = dt;
                cbx_tech.ValueMember = "P_ID";
                cbx_tech.DisplayMember = "Name";


                if (cbx_verant.Items.Count > 0) cbx_verant.SelectedIndex = 0;
            }
            catch (Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage(Neue Auftrag: Fill CBX Techniker): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UC_New_auftrag_fill_cbx_auf()
        {
            try
            {
                OdbcConnection connection = Connection;
                connection.Open();
                string sql = "SELECT Art_ID,Art FROM auftragsart WHERE deaktiviert<>true";
                OdbcDataAdapter db = new OdbcDataAdapter(sql, connection);
                DataTable dtArt = new DataTable();
                db.Fill(dtArt);
                connection.Close();



                cbx_auftrag.DataSource = dtArt;
                cbx_auftrag.DisplayMember = "Art";
                cbx_auftrag.ValueMember = "Art_ID";

                if (cbx_auftrag.Items.Count > 0) cbx_auftrag.SelectedIndex = 0;
            }

            catch (Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage(Neue Auftrag: Fill CBX Auftragsart): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        private void UC_New_auftrag_fill_cbx_lief()
        {
            try
            {
                OdbcConnection connection = Connection;
                connection.Open();
                string sql = "SELECT L_ID, Lieferant FROM Lieferant WHERE deaktiviert<>true";
                OdbcDataAdapter dc = new OdbcDataAdapter(sql, connection);
                DataTable dtLief = new DataTable();
                dc.Fill(dtLief);
                connection.Close();


                cbx_new_auf_lief.DataSource = dtLief;
                cbx_new_auf_lief.ValueMember = "L_ID";
                cbx_new_auf_lief.DisplayMember = "Lieferant";


                if (cbx_new_auf_lief.Items.Count > 0) cbx_new_auf_lief.SelectedIndex = 0;
            }
            catch (Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage(Neue Auftrag: Fill CBX Lief): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UC_New_auftrag_fill_cbx_stoff_lief()
        {
            if (cbx_new_auf_lief.Items.Count > 0)
            {
                try
                {
                    OdbcConnection connection = Connection;
                    connection.Open();
                    string sql =
                        string.Format("SELECT stoff.ST_ID,stoff.`Stoff` FROM stoff INNER JOIN stoff_lieferant ON stoff.ST_ID = stoff_lieferant.ST_ID WHERE stoff_lieferant.L_ID = {0}", cbx_new_auf_lief.SelectedValue);
                    OdbcDataAdapter dc = new OdbcDataAdapter(sql, connection);
                    DataTable dtStoff = new DataTable();
                    dc.Fill(dtStoff);
                    connection.Close();


                    cbx_new_auf_stoff.DataSource = dtStoff;
                    cbx_new_auf_stoff.ValueMember = "ST_ID";
                    cbx_new_auf_stoff.DisplayMember = "Stoff";


                    if (cbx_new_auf_stoff.Items.Count > 0) cbx_new_auf_stoff.SelectedIndex = 0;
                }
                catch (Exception f)
                {
                    MessageBox.Show("Fehler in der SQL Abfrage(Neue Auftrag: Fill CBX Stoff): \n\n" + f.Message,
                        "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                }
            }
        }

        private void txt_info_kauf_TextChanged(object sender, EventArgs e)
        {
            btn_new_auf_save.Enabled = true;
            if (txt_info_tech.Text == "" && txt_info_kauf.Text == "") btn_new_auf_save.Enabled = false;
        }

        private void txt_info_tech_TextChanged(object sender, EventArgs e)
        {
            btn_new_auf_save.Enabled = true;
            if (txt_info_tech.Text == "" && txt_info_kauf.Text == "") btn_new_auf_save.Enabled = false;
        }




        private void btn_auftrag_add_Click(object sender, EventArgs e)
        {
            try
            {
            OdbcConnection connection = Connection;
            connection.Open();
            string sql = string.Format("SELECT Art_ID,Art FROM auftragsart WHERE Art_ID = {0}", cbx_auftrag.SelectedValue);
            OdbcCommand cmd = new OdbcCommand(sql, connection);
            OdbcDataReader sqlReader = cmd.ExecuteReader();
            sqlReader.Read();
            Object_auf item = new Object_auf((int)sqlReader[0], (string)sqlReader[1]);
            bool added = false;
            connection.Close();

            if (lbx_auftrag.Items.Count != 0)
            {
                for (int i = 0; i < lbx_auftrag.Items.Count; i++)
                {
                    if (lbx_auftrag.Items[i].ToString() == item.ToString())
                    {
                        MessageBox.Show("Auswahl ist schon vorhanden", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        added = true;
                    }
                }
                if(!added) lbx_auftrag.Items.Add(item);
            }
            else
            {
                lbx_auftrag.Items.Add(item);
            }

            if (lbx_auftrag.Items.Count > 0) lbx_auftrag.SelectedIndex = 0;
            }

            catch (Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage(Neue Auftrag: Fill CBX Auftragsart): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }

        }


        private void btn_auftag_delete_Click(object sender, EventArgs e)
        {
            lbx_auftrag.Items.Remove(lbx_auftrag.Items[lbx_auftrag.SelectedIndex]);

        }

        private void Btn_new_auf_save_Click(object sender, EventArgs e)
        {
            try
            {
                OdbcConnection connection = Connection;
                connection.Open();
                string sql = "INSERT INTO auftrags.schatten (schatten.Notitz) VALUES ('')";
                OdbcCommand cmd = new OdbcCommand(sql, connection);
                cmd.ExecuteNonQuery();
                sql = "SELECT * FROM schatten ORDER BY schatten.S_ID DESC LIMIT 1";
                cmd = new OdbcCommand(sql, connection);
                OdbcDataReader sqlReader = cmd.ExecuteReader();
                sqlReader.Read();
                int schatten_ID = Convert.ToInt32(sqlReader.ToString());
                sql = string.Format(
                    "INSERT INTO auftraege a (a.Auftrags_NR, a.Fertigungsstatus a.Projektverantwortlicher, a.Planer_Techniker, a.Erstelldatum, a.Montage_Datum, a.Projektbezeichnung, a.Schatten,  a.Notitz_Kauf, a.Notitz_Tech) VALUES ('{0}', 6, {1}, {2}, '{3}', '{4}', '{5}', '{6}', '{7}')",
                    txt_auftrag_nr.Text, cbx_verant.SelectedValue, cbx_tech.SelectedValue, date_erstell.Text, date_mont.Text, txt_auf_proj_ken.Text, schatten_ID, txt_info_kauf.Text, txt_info_tech.Text);

                cmd = new OdbcCommand(sql, connection);
                cmd.ExecuteNonQuery();

                string sql2 = string.Format(
                    "SELECT a.ID FROM auftraege a WHERE a.Auftrags_Nr = '{0}' AND a.Projektverantwortlicher = {1} AND a.Planer_Techniker = {2} AND a.Erstelldatum = '{3}' AND a.Montage_Datum = '{4]' AND a.Projektbezeichnung = '{5}' AND a.Notitz_Kauf = '{6}' AND a.Notitz_Tech = '{7}'",
                    txt_auftrag_nr.Text, cbx_verant.SelectedValue, cbx_tech.SelectedValue, date_erstell.Text,
                    date_mont.Text, txt_auf_proj_ken.Text, txt_info_kauf.Text, txt_info_tech.Text);

                OdbcCommand cmd_read = new OdbcCommand(sql2, connection);
                sqlReader = cmd_read.ExecuteReader();

                sqlReader.Read();

                int auf_id = sqlReader.GetInt32(0);

                for (int i = 0; i < lbx_auftrag.Items.Count; i++)
                {
                    int art_ID = (lbx_auftrag.Items[i] as Object_auf).ID;


                    string sql3 = string.Format("INSERT INTO auftraege_auftragsart a (a.ID, a.Art_ID) VALUES ({0}, {1})",
                        auf_id, art_ID);
                    OdbcCommand cmd2 = new OdbcCommand(sql3, connection);
                    cmd2.ExecuteNonQuery();
                }




                connection.Close();
            }
            catch (Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage: \n\n" + f.Message, "Fehler", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Person wurde gespeichert", "Speicherung erfolgreich", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
        }

        private void cbx_new_auf_lief_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void cbx_new_auf_lief_Click(object sender, EventArgs e)
        {
            
        }

        private void cbx_new_auf_lief_SelectedIndexChanged(object sender, EventArgs e)
        {

            



        }

        private void cbx_new_auf_lief_Validated(object sender, EventArgs e)
        {
            
        }

        private void cbx_new_auf_lief_DropDownClosed(object sender, EventArgs e)
        {
            cbx_new_auf_stoff.Enabled = true;
            UC_New_auftrag_fill_cbx_stoff_lief();
        }

        public class Object_auf
        {
            public int ID;
            public string Text;

            public Object_auf(int num, string art)
            {
                ID = num;
                Text = art;
            }

            public override string ToString()
            {
                return Text;
            }


        }

    }
}
