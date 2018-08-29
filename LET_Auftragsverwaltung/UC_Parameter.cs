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
                    string constrg = "Driver={MySQL ODBC 3.51 Driver};Server=192.168.16.192;Database=auftrags;User=admin;Password=cola0815;Option=3;";
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

                string sql3 = string.Format("INSERT INTO personal (Vorname, Nachname, Adr_ID, Funktion_ID) VALUES ('{0}', '{1}', {2}, {3})", txt_pers_vor.Text, txt_pers_nach.Text, adr_id, cbx_pers_funk.SelectedValue);

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
                MessageBox.Show("Fehler in der SQL Abfrage(funkt): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Fehler in der SQL Abfrage(art): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UC_Parameter_lbx_pers_fill()
        {
            
            try
            {
                OdbcConnection connection = Connection;
                connection.Open();
                string sql = "SELECT Nachname, Vorname, P_ID FROM personal WHERE deaktiviert<>true";
                OdbcDataAdapter dc = new OdbcDataAdapter(sql, connection);
                DataTable dtPers = new DataTable();
                dc.Fill(dtPers);
                connection.Close();

                //List<string> personal = new List<string>();

                /*foreach (DataRow dwPersonal in dtPers.Rows)
                {
                    lbx_pers.Items.Add(dwPersonal["Nachname"].ToString() + " " + dwPersonal["Vorname"].ToString() + " ID:" + dwPersonal["P_ID"].ToString());
                }*/


                lbx_pers.DataSource = dtPers;
                lbx_pers.DisplayMember = "Nachname";              
                lbx_pers.ValueMember = "P_ID";

                //lbv_pers.Items.AddRange(personal);


                //if (lbv_pers.Items.Count > 0) lbv_pers.SelectedIndices = 0;
            }
            catch (Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage(Personal): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            btn_pers_edit.Enabled = true;

        }
    }
}
