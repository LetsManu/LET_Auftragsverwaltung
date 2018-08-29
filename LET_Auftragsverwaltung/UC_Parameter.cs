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
using System.Runtime.Remoting.Channels;

namespace LET_Auftragsverwaltung
{
    public partial class UC_Parameter : UserControl
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

        public UC_Parameter()
        {
            InitializeComponent();
            

        }

        private void btn_pers_save_Click(object sender, EventArgs e)
        {
            try
            {
                OdbcConnection connection = Connection;
                connection.Open();
                string sql = string.Format("INSERT INTO adressen (Land, PLZ, Ort, Hausnummer, Strasse ) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", txt_pers_land.Text, txt_pers_plz.Text, txt_pers_ort.Text, txt_pers_hnr.Text, txt_pers_str.Text);
                OdbcCommand cmd = new OdbcCommand(sql, connection);
                cmd.ExecuteNonQuery();
                string sql2 = string.Format("SELECT Adr_ID FROM adressen WHERE Land='{0}' AND PLZ='{1}' AND Ort='{2}' AND Hausnummer='{3}' AND Strasse='{4}' LIMIT 1", txt_pers_land.Text, txt_pers_plz.Text, txt_pers_ort.Text, txt_pers_hnr.Text, txt_pers_str.Text);
                OdbcCommand cmd_read = new OdbcCommand(sql2, connection);
                OdbcDataReader sqlReader = cmd_read.ExecuteReader();

                sqlReader.Read();

                int adr_id = sqlReader.GetInt32(0);

                string sql3 = string.Format("INSERT INTO personal (Vorname, Nachname, Adr_ID) VALUES ('{0}', '{1}', {2})", txt_pers_vor.Text, txt_pers_nach.Text, adr_id);

                OdbcCommand cmd2 = new OdbcCommand(sql3, connection);
                cmd2.ExecuteNonQuery();

                connection.Close();
            }
            catch(Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage: \n\n" + f.Message, "Fehler", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Person wurde gespeichert", "Speicherung erfolgreich", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                UC_Parameter_lbx_pers_fill();
            }

            txt_pers_vor.Text = "";
            txt_pers_nach.Text = "";
            txt_pers_hnr.Text = "";
            txt_pers_land.Text = "";
            txt_pers_ort.Text = "";
            txt_pers_str.Text = "";
            txt_pers_plz.Text = "";

            btn_pers_save.Enabled = false;

        }

        private void btn_funk_new_Click(object sender, EventArgs e)
        {
            try
            {
                OdbcConnection connection = Connection;
                connection.Open();
                string sql = string.Format("INSERT INTO funktion (Funktion) VALUES ('{0}')", txt_funk_new.Text);
                OdbcCommand cmd = new OdbcCommand(sql, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage: \n\n" + f.Message, "Fehler", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                UC_Parameter_cbx_funk_fill();
                txt_funk_new.Text = "";

                MessageBox.Show("Funktion wurde gespeichert", "Speicherung erfolgreich", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            btn_funk_new.Enabled = false;
            txt_funk_new.Text = "";
        }

        private void UC_Parameter_Load(object sender, EventArgs e)
        {
            UC_Parameter_cbx_funk_fill();
            UC_Parameter_cbx_art_fill();
            UC_Parameter_lbx_pers_fill();
            UC_Parameter_lbx_lief_fill();
            UC_Parameter_lbx_pers_funk_fill();
        }

        private void UC_Parameter_cbx_funk_fill()
        {
            
            try
            {
                OdbcConnection connection = Connection;
                connection.Open();
                string sql = "SELECT Funktion_ID,Funktion FROM funktion WHERE deaktiviert<>true";
                OdbcDataAdapter da = new OdbcDataAdapter(sql, connection);
                DataTable dtFunkt = new DataTable();
                da.Fill(dtFunkt);
                connection.Close();


                cbx_pers_funk.DataSource = dtFunkt;
                cbx_funk.DataSource = dtFunkt;
                cbx_funk.DisplayMember = "Funktion";
                cbx_pers_funk.DisplayMember = "Funktion";
                cbx_funk.ValueMember = "Funktion_ID";
                cbx_pers_funk.ValueMember = "Funktion_ID";
                
                if(cbx_funk.Items.Count>0)cbx_funk.SelectedIndex = 0;
                if (cbx_pers_funk.Items.Count > 0) cbx_pers_funk.SelectedIndex = 0;
            }
            catch (Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage(Funtkion Fill): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UC_Parameter_cbx_art_fill()
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


                
                cbx_auf.DataSource = dtArt;
                cbx_auf.DisplayMember = "Art";
                cbx_auf.ValueMember = "Art_ID";
                
                if (cbx_auf.Items.Count > 0) cbx_auf.SelectedIndex = 0;
            }
            catch (Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage(Art Fill): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UC_Parameter_lbx_pers_fill()
        {
            
            try
            {
                OdbcConnection connection = Connection;
                connection.Open();
                string sql = "SELECT P_ID,Nachname FROM personal WHERE deaktiviert<>true";
                OdbcDataAdapter dc = new OdbcDataAdapter(sql, connection);
                DataTable dtPer = new DataTable();
                dc.Fill(dtPer);
                connection.Close();


                lbx_pers.DataSource = dtPer;
                lbx_pers.ValueMember = "P_ID";
                lbx_pers.DisplayMember = "Nachname";              
                

               if (lbx_pers.Items.Count > 0) lbx_pers.SelectedIndex = 0;
            }
            catch (Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage(Personal Fill): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UC_Parameter_lbx_lief_fill()
        {

            try
            {
                OdbcConnection connection2 = Connection;
                
                string sql2 = "SELECT Lieferant,L_ID FROM lieferant WHERE deaktiviert<>true";
                OdbcDataAdapter da = new OdbcDataAdapter(sql2, connection2);
                DataTable dt = new DataTable();
                connection2.Open();
                da.Fill(dt);
                connection2.Close();


                lbx_lief.DataSource = dt;
                lbx_lief.ValueMember = "L_ID";
                lbx_lief.DisplayMember = "Lieferant";


                if (lbx_lief.Items.Count > 0) lbx_lief.SelectedIndex = 0;
            }
            catch (Exception f)
            {
                connection.Close();
                MessageBox.Show("Fehler in der SQL Abfrage(Lieferant Fill): \n\n" + f.Message + "\n\n" + f.Data.Values.ToString(), "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UC_Parameter_lbx_pers_funk_fill()
        {

            try
            {
                OdbcConnection connection = Connection;

                string sql_read = string.Format("SELECT Funktion_ID FROM personal_funktion WHERE P_ID = {0}", lbx_pers.SelectedValue);
                string sql = "";
                OdbcCommand cmd_read = new OdbcCommand(sql_read, connection);
                OdbcCommand cmd;
                connection.Open();
                OdbcDataReader sqlReader_pers = cmd_read.ExecuteReader();
                DataTable dt = new DataTable("Funktionen");
                dt.Columns.Add("Funktion", typeof(string));
                dt.Columns.Add("ID", typeof(int));
                OdbcDataReader sqlReader_funkt;
                DataRow funk_row;

                while (sqlReader_pers.Read())
                {
                    sql = string.Format("SELECT Funktion,Funktion_ID FROM funktion WHERE Funktion_ID = {0}", sqlReader_pers[0]);
                    
                    cmd = new OdbcCommand(sql, connection);
                    sqlReader_funkt = cmd.ExecuteReader();
                    sqlReader_funkt.Read();
                    funk_row = dt.NewRow();
                    funk_row["Funktion"] = sqlReader_funkt[0];
                    funk_row["ID"] = sqlReader_funkt[1];
                    dt.Rows.Add(funk_row);
                    sqlReader_funkt.Close();
                }
                sqlReader_pers.Close();
                connection.Close();


                lbx_pers_funk.DataSource = dt;
                lbx_pers_funk.ValueMember = "ID";
                lbx_pers_funk.DisplayMember = "Funktion";


                if (lbx_pers_funk.Items.Count > 0) lbx_pers_funk.SelectedIndex = 0;
            }
            catch (Exception f)
            {
                connection.Close();
                MessageBox.Show("Fehler in der SQL Abfrage(Personal Funktion Fill): \n\n" + f.Message + "\n\n" + f.Data.Values.ToString(), "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_auf_new_Click(object sender, EventArgs e)
        {
            try
            {
                OdbcConnection connection = Connection;
                connection.Open();
                string sql = string.Format("INSERT INTO auftragsart (Art) VALUES ('{0}')", txt_auf_new.Text);
                OdbcCommand cmd = new OdbcCommand(sql, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage: \n\n" + f.Message, "Fehler", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            finally
            {
                UC_Parameter_cbx_art_fill();
                txt_funk_new.Text = "";

                MessageBox.Show("Funktion wurde gespeichert", "Speicherung erfolgreich", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            btn_auf_new.Enabled = false;
            txt_auf_new.Text = "";
        }

        private void cbx_funk_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_funk_re_TextChanged(object sender, EventArgs e)
        {
            btn_funk_change.Enabled = true;

            if (txt_funk_re.Text == "") btn_funk_change.Enabled = false;
        }

        private void cbx_auf_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_funk_change_Click(object sender, EventArgs e)
        {

            try
            {
                OdbcConnection connection = Connection;
                connection.Open();
                string sql = string.Format("UPDATE funktion SET deaktiviert = {0}, funktion = '{1}' WHERE Funktion_ID = {2}",box_funk_dec.Checked, txt_funk_re.Text, cbx_funk.SelectedValue);
                OdbcCommand cmd = new OdbcCommand(sql, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage: \n\n" + f.Message, "Fehler", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            finally
            {
                UC_Parameter_cbx_funk_fill();
                

                MessageBox.Show("Funktion wurde geändert", "Änderung erfolgreich", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            txt_funk_re.Text = "";
            btn_funk_change.Enabled = false;
            box_funk_dec.Checked = false;
        }

        private void btn_auf_change_Click(object sender, EventArgs e)
        {
            try
            {
                OdbcConnection connection = Connection;
                connection.Open();
                string sql = string.Format("UPDATE auftragsart SET deaktiviert = {0}, art = '{1}' WHERE Art_ID = {2}", box_auf_dec.Checked, txt_auf_re.Text, cbx_auf.SelectedValue);
                OdbcCommand cmd = new OdbcCommand(sql, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage: \n\n" + f.Message, "Fehler", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            finally
            {
                UC_Parameter_cbx_art_fill();


                MessageBox.Show("Funktion wurde geändert", "Änderung erfolgreich", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            btn_auf_change.Enabled = false;
            txt_auf_re.Text = "";
            box_auf_dec.Checked = false;
        }

        private void txt_auf_new_TextChanged(object sender, EventArgs e)
        {
            btn_auf_new.Enabled = true;

            if (txt_auf_new.Text == "") btn_funk_new.Enabled = false;
        }

        private void txt_auf_re_TextChanged(object sender, EventArgs e)
        {
            btn_auf_change.Enabled = true;

            if (txt_auf_re.Text == "") btn_auf_change.Enabled = false;
        }

        private void txt_funk_new_TextChanged(object sender, EventArgs e)
        {
            btn_funk_new.Enabled = true;

            if (txt_funk_new.Text == "") btn_funk_new.Enabled = false;
        }

        private void box_funk_dec_EnabledChanged(object sender, EventArgs e)
        {
            
        }

        private void box_auf_dec_EnabledChanged(object sender, EventArgs e)
        {
            


        }

        private void box_auf_dec_CheckedChanged(object sender, EventArgs e)
        {
            btn_auf_change.Enabled = true;

            if (box_auf_dec.Checked == false) btn_auf_change.Enabled = false;
        }

        private void box_funk_dec_CheckedChanged(object sender, EventArgs e)
        {
            btn_funk_change.Enabled = true;

            if (box_funk_dec.Checked == false) btn_funk_change.Enabled = false;
        }

        private void txt_pers_vor_TextChanged(object sender, EventArgs e)
        {
            btn_pers_save.Enabled = true;

            if (txt_pers_vor.Text == "") btn_pers_save.Enabled = false;
            if (btn_pers_edit.Enabled) btn_pers_save.Enabled = false;
        }

        private void txt_pers_nach_TextChanged(object sender, EventArgs e)
        {
            btn_pers_save.Enabled = true;

            if (txt_pers_nach.Text == "") btn_pers_save.Enabled = false;
            if (btn_pers_edit.Enabled) btn_pers_save.Enabled = false;
        }

        private void btn_pers_save_EnabledChanged(object sender, EventArgs e)
        {
            if (txt_pers_vor.Text == "" || txt_pers_nach.Text == "") btn_pers_save.Enabled = false;
        }

        private void txt_lief_ken_TextChanged(object sender, EventArgs e)
        {
            btn_lief_save.Enabled = true;
            if (txt_lief_ken.Text == "") btn_lief_save.Enabled = false;
            if(btn_lief_edit.Enabled || btn_lief_delete.Enabled) btn_lief_save.Enabled = false;
        }

        private void btn_lief_save_Click(object sender, EventArgs e)
        {

            try { 
            OdbcConnection connection = Connection;
            connection.Open();
            string sql = string.Format("INSERT INTO adressen (Land, PLZ, Ort, Hausnummer, Strasse ) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", txt_lief_land.Text, txt_lief_plz.Text, txt_lief_ort.Text, txt_lief_hnr.Text, txt_lief_str.Text);
            OdbcCommand cmd = new OdbcCommand(sql, connection);
            cmd.ExecuteNonQuery();
            string sql2 = string.Format("SELECT Adr_ID FROM adressen WHERE Land='{0}' AND PLZ='{1}' AND Ort='{2}' AND Hausnummer='{3}' AND Strasse='{4}' LIMIT 1", txt_lief_land.Text, txt_lief_plz.Text, txt_lief_ort.Text, txt_lief_hnr.Text, txt_lief_str.Text);
            OdbcCommand cmd_read = new OdbcCommand(sql2, connection);
            OdbcDataReader sqlReader = cmd_read.ExecuteReader();

            sqlReader.Read();

            int adr_id = sqlReader.GetInt32(0);

            string sql3 = string.Format("INSERT INTO Lieferant (Lieferant, Adr_ID ) VALUES ('{0}', {1})", txt_lief_ken.Text, adr_id);

            OdbcCommand cmd2 = new OdbcCommand(sql3, connection);
            cmd2.ExecuteNonQuery();

            connection.Close();

            }
            catch(Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage: \n\n" + f.Message, "Fehler", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Lieferant wurde gespeichert", "Speicherung erfolgreich", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            txt_lief_ken.Text = "";
            txt_lief_hnr.Text = "";
            txt_lief_land.Text = "";
            txt_lief_ort.Text = "";
            txt_lief_plz.Text = "";
            txt_lief_str.Text = "";

            btn_lief_save.Enabled = false;

        }

        private void lbx_pers_SelectedValueChanged(object sender, EventArgs e)
        {           

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {


        }

        private void cbx_pers_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void lbx_pers_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void lbx_pers_DoubleClick(object sender, EventArgs e)
        {
            btn_pers_edit.Enabled = true;
            btn_pers_delete.Enabled = true;
            btn_pers_save.Enabled = false;
            btn_pers_funk_add.Enabled = true;
            btn_pers_funk_del.Enabled = true;

            if (lbx_pers.Items.Count > 0 || lbx_pers.Items.Count != null)
            {
                try
                {

                    string sql = string.Format("SELECT * FROM personal WHERE P_ID = {0} LIMIT 1", lbx_pers.SelectedValue);
                    OdbcConnection connection = Connection;
                    connection.Open();
                    OdbcCommand cmd_read = new OdbcCommand(sql, connection);
                    OdbcDataReader sqlReader = cmd_read.ExecuteReader();
                    sqlReader.Read();
                    txt_pers_vor.Text = Convert.ToString(sqlReader[1]);
                    txt_pers_nach.Text = Convert.ToString(sqlReader[2]);
                    int adr_ID = Convert.ToInt32(sqlReader[3]);
                    int funk_ID = Convert.ToInt32(sqlReader[4]);
                    cbx_pers_funk.SelectedValue = funk_ID;
                    sqlReader.Close();

                    string sql2 = string.Format("SELECT Land,PLZ,Ort,Hausnummer,Strasse FROM adressen WHERE Adr_ID = {0} LIMIT 1", adr_ID);
                    cmd_read = new OdbcCommand(sql2, connection);
                    sqlReader = cmd_read.ExecuteReader();
                    sqlReader.Read();
                    txt_pers_land.Text = sqlReader[0].ToString();
                    txt_pers_plz.Text = sqlReader[1].ToString();
                    txt_pers_ort.Text = sqlReader[2].ToString();
                    txt_pers_hnr.Text = sqlReader[3].ToString();
                    txt_pers_str.Text = sqlReader[4].ToString();
                    sqlReader.Close();
                    connection.Close();
                }

                catch (Exception f)
                {
                    connection.Close();
                    MessageBox.Show("Fehler in der SQL Abfrage(lbx_pers): \n\n" + f.Message, "Fehler",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                finally
                {
                    UC_Parameter_lbx_pers_funk_fill();
                }
            }
        }

        private void btn_pers_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("UPDATE personal SET deaktiviert=true WHERE P_ID={0}",
                    lbx_pers.SelectedValue);
                OdbcConnection connection = Connection;
                connection.Open();
                OdbcCommand cmd = new OdbcCommand(sql, connection);
                cmd.ExecuteNonQuery();
                connection.Close();

                
            }
            catch(Exception f)
            {
                connection.Close();
                MessageBox.Show("Fehler in der SQL Abfrage(Personal Delete): \n\n" + f.Message, "Fehler",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btn_pers_delete.Enabled = false;
                btn_pers_edit.Enabled = false;

                txt_pers_vor.Text = "";
                txt_pers_nach.Text = "";
                txt_pers_land.Text = "";
                txt_pers_plz.Text = "";
                txt_pers_ort.Text = "";
                txt_pers_hnr.Text = "";
                txt_pers_str.Text = "";

                UC_Parameter_lbx_pers_fill();
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            btn_lief_edit.Enabled = true;
            btn_lief_delete.Enabled = true;
            btn_lief_save.Enabled = false;

            if (lbx_pers.Items.Count > 0 || lbx_pers.Items.Count != null)
            {
                try
                {

                    string sql = string.Format("SELECT * FROM lieferant WHERE L_ID = {0} LIMIT 1", lbx_lief.SelectedValue);
                    OdbcConnection connection = Connection;
                    connection.Open();
                    OdbcCommand cmd_read = new OdbcCommand(sql, connection);
                    OdbcDataReader sqlReader = cmd_read.ExecuteReader();
                    sqlReader.Read();
                    txt_lief_ken.Text = Convert.ToString(sqlReader[1]);
                    int adr_ID = Convert.ToInt32(sqlReader[2]);
                    sqlReader.Close();

                    string sql2 = string.Format("SELECT Land,PLZ,Ort,Hausnummer,Strasse FROM adressen WHERE Adr_ID = {0} LIMIT 1", adr_ID);
                    cmd_read = new OdbcCommand(sql2, connection);
                    sqlReader = cmd_read.ExecuteReader();
                    sqlReader.Read();
                    txt_lief_land.Text = sqlReader[0].ToString();
                    txt_lief_plz.Text = sqlReader[1].ToString();
                    txt_lief_ort.Text = sqlReader[2].ToString();
                    txt_lief_hnr.Text = sqlReader[3].ToString();
                    txt_lief_str.Text = sqlReader[4].ToString();
                    sqlReader.Close();
                    connection.Close();
                }

                catch (Exception f)
                {
                    connection.Close();
                    MessageBox.Show("Fehler in der SQL Abfrage(lbx_pers): \n\n" + f.Message, "Fehler",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                finally
                {

                }
            }
        }

        private void btn_pers_edit_Click(object sender, EventArgs e)
        {
            try
            {
                OdbcConnection connection = Connection;
                connection.Open();
                string sql3 =
                    string.Format("UPDATE personal SET Vorname= '{0}', Nachname = '{1}' WHERE P_ID = {2}", txt_pers_vor.Text, txt_pers_nach.Text, lbx_pers.SelectedValue);

                OdbcCommand cmd = new OdbcCommand(sql3, connection);
                cmd.ExecuteNonQuery();
                string sql2 = string.Format("SELECT Adr_ID FROM personal WHERE P_ID = {0}", lbx_pers.SelectedValue);
                OdbcCommand cmd_read = new OdbcCommand(sql2, connection);
                OdbcDataReader sqlReader = cmd_read.ExecuteReader();

                sqlReader.Read();

                int adr_id = sqlReader.GetInt32(0);

                string sql = string.Format(
                    "UPDATE adressen SET Land = '{0}', PLZ = '{1}', Ort = '{2}', Hausnummer = '{3}', Strasse = '{4}' WHERE Adr_ID = {5}",
                    txt_pers_land.Text, txt_pers_plz.Text, txt_pers_ort.Text, txt_pers_hnr.Text, txt_pers_str.Text,
                    adr_id);
                OdbcCommand cmd2 = new OdbcCommand(sql, connection);
                cmd2.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception f)
            {
                connection.Close();
                MessageBox.Show("Fehler in der SQL Abfrage(Personal Update): \n\n" + f.Message, "Fehler",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btn_pers_delete.Enabled = false;
                btn_pers_edit.Enabled = false;

                txt_pers_vor.Text = "";
                txt_pers_nach.Text = "";
                txt_pers_land.Text = "";
                txt_pers_plz.Text = "";
                txt_pers_ort.Text = "";
                txt_pers_hnr.Text = "";
                txt_pers_str.Text = "";

                UC_Parameter_lbx_pers_fill();
            }
        }

        private void btn_lief_edit_Click(object sender, EventArgs e)
        {
            try
            {
                OdbcConnection connection = Connection;
                connection.Open();
                string sql3 =
                    string.Format(
                        "UPDATE lieferant SET lieferant= '{0}' WHERE L_ID = {1}",
                        txt_lief_ken.Text, lbx_lief.SelectedValue);

                OdbcCommand cmd = new OdbcCommand(sql3, connection);
                cmd.ExecuteNonQuery();
                string sql2 = string.Format("SELECT Adr_ID FROM lieferant WHERE L_ID = {0}", lbx_lief.SelectedValue);
                OdbcCommand cmd_read = new OdbcCommand(sql2, connection);
                OdbcDataReader sqlReader = cmd_read.ExecuteReader();

                sqlReader.Read();

                int adr_id = sqlReader.GetInt32(0);

                string sql = string.Format(
                    "UPDATE adressen SET Land = '{0}', PLZ = '{1}', Ort = '{2}', Hausnummer = '{3}', Strasse = '{4}' WHERE Adr_ID = {5}",
                    txt_lief_land.Text, txt_lief_plz.Text, txt_lief_ort.Text, txt_lief_hnr.Text, txt_lief_str.Text,
                    adr_id);
                OdbcCommand cmd2 = new OdbcCommand(sql, connection);
                cmd2.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception f)
            {
                connection.Close();
                MessageBox.Show("Fehler in der SQL Abfrage(Lieferant Update): \n\n" + f.Message, "Fehler",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btn_lief_delete.Enabled = false;
                btn_lief_edit.Enabled = false;

                txt_lief_ken.Text = "";
                txt_lief_land.Text = "";
                txt_lief_plz.Text = "";
                txt_lief_ort.Text = "";
                txt_lief_hnr.Text = "";
                txt_lief_str.Text = "";

                UC_Parameter_lbx_lief_fill();
            }

        }

        private void btn_pers_funk_add_Click(object sender, EventArgs e)
        {
            try
            {
                OdbcConnection connection = Connection;
                string sql_controll = string.Format("SELECT COUNT(*) FROM personal_funktion WHERE P_ID = {0} AND Funktion_ID = {1}", lbx_pers.SelectedValue, cbx_pers_funk.SelectedValue);
                
                string sql = string.Format("INSERT INTO personal_funktion (P_ID,Funktion_ID) VALUES ({0},{1})",
                    lbx_pers.SelectedValue, cbx_pers_funk.SelectedValue);
                OdbcCommand cmd = new OdbcCommand(sql, connection);
                OdbcCommand cmd_check = new OdbcCommand(sql_controll, connection);
                connection.Open();
                int pers_funk_ext = Convert.ToInt32(cmd_check.ExecuteScalar().ToString());
                if (pers_funk_ext > 0)
                {
                    MessageBox.Show("Person hat Funktion schon", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cmd.ExecuteNonQuery();
                }         
                connection.Close();
            }

            catch (Exception f)
            {
                connection.Close();
                MessageBox.Show("Fehler in der SQL Abfrage(Personal Funktion): \n\n" + f.Message, "Fehler",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            finally
            {
                UC_Parameter_lbx_pers_funk_fill();
            }
        }

        private void btn_pers_funk_del_Click(object sender, EventArgs e)
        {
            try
            {
                OdbcConnection connection = Connection;
                string sql = string.Format("DELETE FROM personal_funktion WHERE P_ID = {0} AND Funktion_ID = {1}",
                    lbx_pers.SelectedValue, lbx_pers_funk.SelectedValue);
                OdbcCommand cmd = new OdbcCommand(sql, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

            }
            catch (Exception f)
            {
                connection.Close();
                MessageBox.Show("Fehler in der SQL Abfrage(Personal Funktion): \n\n" + f.Message, "Fehler",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            finally
            {
                btn_pers_funk_del.Enabled = false;
                UC_Parameter_lbx_pers_funk_fill();
            }
        }

        private void lbx_pers_funk_SelectedValueChanged(object sender, EventArgs e)
        {
            btn_pers_funk_del.Enabled = true;
        }
    }
}
