using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LET_Auftragsverwaltung
{
    public partial class UC_New_auftrag : UserControl
    {
        private OdbcConnection Connection
        {
            get
            {
                return CS_DB.Connection;

            }
        }

        public UC_New_auftrag( )
        {
            InitializeComponent();
            date_mont.Format = DateTimePickerFormat.Short;
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

        private void UC_New_auftrag_fill_cbx_verant( )
        {
            if (!this.DesignMode)
            {
                try
                {
                    
                    DataTable dtPer = CS_SQL_methods.Fill_Box("SELECT DISTINCT CONCAT(p.`Nachname`, ' ', p.`Vorname`) AS 'Name', p.P_ID FROM personal p LEFT JOIN personal_funktion pf ON p.P_ID = pf.P_ID WHERE pf.Funktion_ID = 4");
                   
                    cbx_verant.DataSource = dtPer;
                    cbx_verant.ValueMember = "P_ID";
                    cbx_verant.DisplayMember = "Name";


                    if (cbx_verant.Items.Count > 0)
                    {
                        cbx_verant.SelectedIndex = 0;
                    }
                }
                catch (Exception f)
                {
                    MessageBox.Show("Fehler in der SQL Abfrage(Neue Auftrag: Fill CBX Verant): \n\n" + f.Message,
                        "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UC_New_auftrag_fill_cbx_stoff( )
        {
            if (!this.DesignMode)
            {
                try
                {
                   
                    DataTable dtPer = CS_SQL_methods.Fill_Box("SELECT DISTINCT CONCAT(p.`Nachname`, ' ', p.`Vorname`) AS 'Name', p.P_ID FROM personal p LEFT JOIN personal_funktion pf ON p.P_ID = pf.P_ID WHERE pf.Funktion_ID = 4");

                    cbx_verant.DataSource = dtPer;
                    cbx_verant.ValueMember = "P_ID";
                    cbx_verant.DisplayMember = "Name";


                    if (cbx_verant.Items.Count > 0)
                    {
                        cbx_verant.SelectedIndex = 0;
                    }
                }
                catch (Exception f)
                {
                    MessageBox.Show("Fehler in der SQL Abfrage(Neue Auftrag: Fill CBX Stoff): \n\n" + f.Message,
                        "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UC_New_auftrag_fill_cbx_tech( )
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
                    MessageBox.Show("Fehler in der SQL Abfrage(Neue Auftrag: Fill CBX Techniker): \n\n" + f.Message,
                        "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void UC_New_auftrag_fill_cbx_auf( )
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
                    MessageBox.Show("Fehler in der SQL Abfrage(Neue Auftrag: Fill CBX Auftragsart): \n\n" + f.Message,
                        "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {

                }
            }
        }

        private void UC_New_auftrag_fill_cbx_lief( )
        {
            if (!this.DesignMode)
            {
                try
                {
                    DataTable dtLief = CS_SQL_methods.Fill_Box("SELECT L_ID, Lieferant FROM Lieferant WHERE deaktiviert<>true");

                    cbx_new_auf_lief.DataSource = dtLief;
                    cbx_new_auf_lief.ValueMember = "L_ID";
                    cbx_new_auf_lief.DisplayMember = "Lieferant";


                    if (cbx_new_auf_lief.Items.Count > 0)
                    {
                        cbx_new_auf_lief.SelectedIndex = 0;
                    }
                }
                catch (Exception f)
                {
                    MessageBox.Show("Fehler in der SQL Abfrage(Neue Auftrag: Fill CBX Lief): \n\n" + f.Message,
                        "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UC_New_auftrag_fill_cbx_stoff_lief()
        {
            if (!this.DesignMode)
            {
                if (cbx_new_auf_lief.Items.Count > 0)
                {
                    try
                    {
                        DataTable dtStoff = CS_SQL_methods.Fill_Box(string.Format(
                            "SELECT stoff.ST_ID,stoff.`Stoff` FROM stoff INNER JOIN stoff_lieferant ON stoff.ST_ID = stoff_lieferant.ST_ID WHERE stoff_lieferant.L_ID = {0}",
                            cbx_new_auf_lief.SelectedValue));

                        cbx_new_auf_stoff.DataSource = dtStoff;
                        cbx_new_auf_stoff.ValueMember = "ST_ID";
                        cbx_new_auf_stoff.DisplayMember = "Stoff";


                        if (cbx_new_auf_stoff.Items.Count > 0) cbx_new_auf_stoff.SelectedIndex = 0;
                    }
                    catch (Exception f)
                    {
                        MessageBox.Show("Fehler in der SQL Abfrage(Neue Auftrag: Fill CBX Stoff): \n\n" + f.Message,
                            "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Connection.Close();
                    }
                }
            }
        }

        private void txt_info_kauf_TextChanged(object sender, EventArgs e)
        {
            btn_new_auf_save.Enabled = true;
            if (txt_info_tech.Text == "" && txt_info_kauf.Text == "")
            {
                btn_new_auf_save.Enabled = false;
            }
        }

        private void txt_info_tech_TextChanged(object sender, EventArgs e)
        {
            btn_new_auf_save.Enabled = true;
            if (txt_info_tech.Text == "" && txt_info_kauf.Text == "")
            {
                btn_new_auf_save.Enabled = false;
            }
        }




        private void btn_auftrag_add_Click(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                try
                {
                    OdbcConnection connection = Connection;
                    connection.Open();
                    string sql = string.Format("SELECT Art_ID,Art FROM auftragsart WHERE Art_ID = {0}",
                        cbx_auftrag.SelectedValue);
                    OdbcCommand cmd = new OdbcCommand(sql, connection);
                    OdbcDataReader sqlReader = cmd.ExecuteReader();
                    sqlReader.Read();
                    Object_auf item = new Object_auf(( int ) sqlReader[0], ( string ) sqlReader[1]);
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
                    if (!added) lbx_auftrag.Items.Add(item);
                }
                else
                {
                    lbx_auftrag.Items.Add(item);
                }

                if (lbx_auftrag.Items.Count > 0) lbx_auftrag.SelectedIndex = 0;
            }

                catch (Exception f)
                {
                    MessageBox.Show("Fehler in der SQL Abfrage(Neue Auftrag: Fill CBX Auftragsart): \n\n" + f.Message,
                        "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {

                }
            }

        }


        private void btn_auftag_delete_Click(object sender, EventArgs e)
        {
            lbx_auftrag.Items.Remove(lbx_auftrag.Items[lbx_auftrag.SelectedIndex]);

        }

            private void Btn_new_auf_save_Click(object sender, EventArgs e)
            {
                if (!this.DesignMode)
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
                        int schatten_ID = Convert.ToInt32(sqlReader[0]);
                        sql = String.Format("INSERT INTO auftrags.teile_stoff (teile_stoff.ST_ID) VALUES ({0})",
                            cbx_new_auf_stoff.SelectedValue);
                        cmd = new OdbcCommand(sql, connection);
                        cmd.ExecuteNonQuery();
                        sql = "SELECT * FROM teile_stoff ORDER BY teile_stoff.T_ST_ID DESC LIMIT 1";
                        cmd = new OdbcCommand(sql, connection);
                        sqlReader = cmd.ExecuteReader();
                        sqlReader.Read();
                        int teile_stoff_ID = Convert.ToInt32(sqlReader[0]);
                        Connection.Close();


                        CS_SQL_methods.SQL_exec(string.Format(
                            "INSERT INTO auftraege (auftraege.`Auftrags_NR`, auftraege.`Fertigungsstatus`, auftraege.Projektverantwortlicher, auftraege.Planer_Techniker, auftraege.Erstelldatum, auftraege.Montage_Datum, auftraege.Projektbezeichnung, auftraege.`Schatten`,  auftraege.Notitz_Kauf, auftraege.Notitz_Tech) VALUES ('{0}', 6, {1}, {2}, '{3}', '{4}', '{5}', {6}, '{7}', '{8}')",
                            txt_auftrag_nr.Text, cbx_verant.SelectedValue, cbx_tech.SelectedValue,
                            date_erstell.Value.ToString("yyyy-MM-dd"), date_mont.Value.ToString("yyyy-MM-dd"),
                            txt_auf_proj_ken.Text, schatten_ID, txt_info_kauf.Text, txt_info_tech.Text));

                        Connection.Open();
                        string sql2 = string.Format(
                            "SELECT ID FROM auftraege WHERE auftraege.`Auftrags_NR` = '{0}' AND auftraege.`Fertigungsstatus` = {1} AND auftraege.Projektverantwortlicher = {2} AND auftraege.Planer_Techniker = {3} AND auftraege.Erstelldatum = '{4}' AND auftraege.Montage_Datum = '{5}' AND auftraege.Projektbezeichnung = '{6}' AND auftraege.`Schatten` = {7} AND auftraege.Notitz_Kauf = '{8}' AND auftraege.Notitz_Tech = '{9}'",
                            txt_auftrag_nr.Text, 6, cbx_verant.SelectedValue, cbx_tech.SelectedValue,
                            date_erstell.Value.ToString("yyyy-MM-dd"), date_mont.Value.ToString("yyyy-MM-dd"),
                            txt_auf_proj_ken.Text, schatten_ID, txt_info_kauf.Text, txt_info_tech.Text);

                        OdbcCommand cmd_read = new OdbcCommand(sql2, connection);
                        sqlReader = cmd_read.ExecuteReader();

                        sqlReader.Read();

                        int auf_id = sqlReader.GetInt32(0);
                        Connection.Close();

                        CS_SQL_methods.SQL_exec(string.Format("INSERT INTO auftrags.teile (teile.ID, teile.T_St_ID) VALUES ({0}, {1})",
                            auf_id, teile_stoff_ID));

                        
                        for (int i = 0; i < lbx_auftrag.Items.Count; i++)
                        {
                            int art_ID = (lbx_auftrag.Items[i] as Object_auf).ID;
                            CS_SQL_methods.SQL_exec(string.Format(
                                "INSERT INTO auftraege_auftragsart (ID, Art_ID) VALUES ({0}, {1})",
                                auf_id, art_ID));
                        }

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

            public override string ToString( )
            {
                return Text;
            }


        }

    }
}
