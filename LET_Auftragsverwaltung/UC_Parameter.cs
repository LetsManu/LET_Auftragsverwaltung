using System;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace LET_Auftragsverwaltung
{
    public partial class UC_Parameter : UserControl
    {
        private readonly string[] extensions = {"PNG", "JPG", "TIFF", "GIF"};
        private readonly string server = "ftp://localhost/";

        private string File_Path_FTP = "";

        public UC_Parameter()
        {
            InitializeComponent();
        }


        private OdbcConnection Connection => CS_DB.Connection;

        //! Replace all the Messageboxes for information and Error with this Method and passe diese Method an damit sie damit umgehen kan alter flater.....
        private void SQL_Fehler(Exception f)
        {
            MessageBox.Show("Fehler in der SQL Abfrage(Stoff Lieferant Verbindung): \n\n" + f.Message, "Fehler",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_pers_save_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                try
                {
                    CS_SQL_methods.SQL_exec(string.Format(
                        "INSERT INTO adressen (Land, PLZ, Ort, Hausnummer, Strasse ) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                        txt_pers_land.Text, txt_pers_plz.Text, txt_pers_ort.Text, txt_pers_hnr.Text,
                        txt_pers_str.Text));
                    
                    var sql2 = string.Format(
                        "SELECT Adr_ID FROM adressen WHERE Land='{0}' AND PLZ='{1}' AND Ort='{2}' AND Hausnummer='{3}' AND Strasse='{4}' LIMIT 1",
                        txt_pers_land.Text, txt_pers_plz.Text, txt_pers_ort.Text, txt_pers_hnr.Text, txt_pers_str.Text);
                    CS_SQL_methods.Open();
                    var cmd_read = new OdbcCommand(sql2, Connection);
                    var sqlReader = cmd_read.ExecuteReader();

                    sqlReader.Read();

                    var adr_id = sqlReader.GetInt32(0);
                    
                    CS_SQL_methods.SQL_exec(string.Format("INSERT INTO personal (Vorname, Nachname, Adr_ID) VALUES ('{0}', '{1}', {2})",
                        txt_pers_vor.Text, txt_pers_nach.Text, adr_id));

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
        }

        private void btn_funk_new_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                try
                {
                    CS_SQL_methods.SQL_exec(string.Format("INSERT INTO funktion (Funktion) VALUES ('{0}')", txt_funk_new.Text));
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
        }

        private void UC_Parameter_Load(object sender, EventArgs e)
        {
            UC_Parameter_cbx_funk_fill();
            UC_Parameter_cbx_art_fill();
            UC_Parameter_cbx_fert_fill();
            UC_Parameter_lbx_pers_fill();
            UC_Parameter_lbx_lief_fill();
            UC_Parameter_lbx_pers_funk_fill();
            UC_Parameter_lbx_stoff_fill();
            UC_Parameter_cbx_stoff_lief_fill();
        }

        private void UC_Parameter_cbx_funk_fill()
        {
            if (!DesignMode)
                try
                {                    
                    var dtFunkt = CS_SQL_methods.Fill_Box("SELECT Funktion_ID,Funktion FROM funktion WHERE deaktiviert<>true");                    
                    
                    cbx_pers_funk.DataSource = dtFunkt;
                    cbx_funk.DataSource = dtFunkt;
                    cbx_funk.DisplayMember = "Funktion";
                    cbx_pers_funk.DisplayMember = "Funktion";
                    cbx_funk.ValueMember = "Funktion_ID";
                    cbx_pers_funk.ValueMember = "Funktion_ID";

                    if (cbx_funk.Items.Count > 0) cbx_funk.SelectedIndex = 0;

                    if (cbx_pers_funk.Items.Count > 0) cbx_pers_funk.SelectedIndex = 0;
                }
                catch (Exception f)
                {
                    MessageBox.Show("Fehler in der SQL Abfrage(Funtkion Fill): \n\n" + f.Message, "Fehler",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void UC_Parameter_cbx_art_fill()
        {
            if (!DesignMode)
                try
                {

                    var dtArt = CS_SQL_methods.Fill_Box("SELECT Art_ID,Art FROM auftragsart WHERE deaktiviert<>true");
                    cbx_auf.DataSource = dtArt;
                    cbx_auf.DisplayMember = "Art";
                    cbx_auf.ValueMember = "Art_ID";

                    if (cbx_auf.Items.Count > 0) cbx_auf.SelectedIndex = 0;
                }
                catch (Exception f)
                {
                    MessageBox.Show("Fehler in der SQL Abfrage(Art Fill): \n\n" + f.Message, "Fehler",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void UC_Parameter_cbx_fert_fill()
        {
            if (!DesignMode)
                try
                { 
                    
                    var dtArt = CS_SQL_methods.Fill_Box("SELECT F_ID,Status FROM fertigungsstatus WHERE deaktiviert<>true");
                    cbx_fert.DataSource = dtArt;
                    cbx_fert.DisplayMember = "Status";
                    cbx_fert.ValueMember = "F_ID";

                    if (cbx_fert.Items.Count > 0) cbx_fert.SelectedIndex = 0;
                }
                catch (Exception f)
                {
                    MessageBox.Show("Fehler in der SQL Abfrage(Art Fill): \n\n" + f.Message, "Fehler",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
        }


        private void UC_Parameter_lbx_pers_fill()
        {
            if (!DesignMode)
                try
                {
                    var dtPer = CS_SQL_methods.Fill_Box("SELECT P_ID,Nachname FROM personal WHERE deaktiviert<>true");
                    lbx_pers.DataSource = dtPer;
                    lbx_pers.ValueMember = "P_ID";
                    lbx_pers.DisplayMember = "Nachname";


                    if (lbx_pers.Items.Count > 0) lbx_pers.SelectedIndex = 0;
                }
                catch (Exception f)
                {
                    MessageBox.Show("Fehler in der SQL Abfrage(Personal Fill): \n\n" + f.Message, "Fehler",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void UC_Parameter_lbx_lief_fill()
        {
            if (!DesignMode)
                try
                {

                    var dt = CS_SQL_methods.Fill_Box("SELECT Lieferant,L_ID FROM lieferant WHERE deaktiviert<>true");
                    lbx_lief.DataSource = dt;
                    lbx_lief.ValueMember = "L_ID";
                    lbx_lief.DisplayMember = "Lieferant";


                    if (lbx_lief.Items.Count > 0) lbx_lief.SelectedIndex = 0;
                }
                catch (Exception f)
                {
                    
                    MessageBox.Show(
                        "Fehler in der SQL Abfrage(Lieferant Fill): \n\n" + f.Message + "\n\n" +
                        f.Data.Values, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void UC_Parameter_cbx_stoff_lief_fill()
        {
            if (!DesignMode)
                try
                {

                    var dt = CS_SQL_methods.Fill_Box("SELECT Lieferant,L_ID FROM lieferant WHERE deaktiviert<>true");
                    cBx_stoff_lief.DataSource = dt;
                    cBx_stoff_lief.ValueMember = "L_ID";
                    cBx_stoff_lief.DisplayMember = "Lieferant";

                    cBx_stoff_lief_02.DataSource = dt.Copy();
                    cBx_stoff_lief_02.ValueMember = "L_ID";
                    cBx_stoff_lief_02.DisplayMember = "Lieferant";

                    if (cBx_stoff_lief.Items.Count > 0) cBx_stoff_lief.SelectedIndex = 0;
                }
                catch (Exception f)
                {
                    
                    MessageBox.Show(
                        "Fehler in der SQL Abfrage(Stoff Lieferant Fill): \n\n" + f.Message + "\n\n" +
                        f.Data.Values, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void UC_Parameter_lbx_stoff_fill()
        {
            if (!DesignMode)
                try
                {
                    var dt = CS_SQL_methods.Fill_Box("SELECT Stoff,ST_ID FROM stoff WHERE deaktiviert<>true");
                    cbx_stoff_edit.DataSource = dt;
                    cbx_stoff_edit.ValueMember = "ST_ID";
                    cbx_stoff_edit.DisplayMember = "Stoff";

                    if (cbx_stoff_edit.Items.Count > 0) cbx_stoff_edit.SelectedIndex = 0;
                }
                catch (Exception f)
                {
                    
                    MessageBox.Show(
                        "Fehler in der SQL Abfrage(Stoff Fill): \n\n" + f.Message + "\n\n" +
                        f.Data.Values, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void UC_Parameter_lbx_pers_funk_fill()
        {
            if (!DesignMode)
                try
                {

                    var dt = CS_SQL_methods.Fill_Box(string.Format(
                        "SELECT DISTINCT funktion.`Funktion`, funktion.`Funktion_ID` FROM personal LEFT JOIN personal_funktion ON personal.`P_ID` = personal_funktion.`P_ID` LEFT JOIN funktion ON personal_funktion.`Funktion_ID` = funktion.`Funktion_ID` WHERE personal.`P_ID` = {0} ORDER BY funktion.`Funktion`",
                        lbx_pers.SelectedValue));

                    lbx_pers_funk.DataSource = dt;
                    lbx_pers_funk.ValueMember = "Funktion_ID";
                    lbx_pers_funk.DisplayMember = "Funktion";

                    if (lbx_pers_funk.Items.Count > 0) lbx_pers_funk.SelectedIndex = 0;
                }
                catch (Exception f)
                {
                    
                    MessageBox.Show(
                        "Fehler in der SQL Abfrage(Personal Funktion Fill): \n\n" + f.Message + "\n\n" +
                        f.Data.Values, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void btn_auf_new_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                try
                {
                    CS_SQL_methods.SQL_exec(string.Format("INSERT INTO auftragsart (Art) VALUES ('{0}')", txt_auf_new.Text));
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
            if (!DesignMode)
            {
                try
                {
                    CS_SQL_methods.SQL_exec(string.Format(
                        "UPDATE funktion SET deaktiviert = {0}, funktion = '{1}' WHERE Funktion_ID = {2}",
                        box_funk_dec.Checked, txt_funk_re.Text, cbx_funk.SelectedValue));
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
        }

        private void btn_auf_change_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                try
                {
                    CS_SQL_methods.SQL_exec(string.Format("UPDATE auftragsart SET deaktiviert = {0}, art = '{1}' WHERE Art_ID = {2}",
                        box_auf_dec.Checked, txt_auf_re.Text, cbx_auf.SelectedValue));
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

            if (btn_lief_edit.Enabled || btn_lief_delete.Enabled) btn_lief_save.Enabled = false;
        }

        private void btn_lief_save_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                try
                {
                    
                    CS_SQL_methods.SQL_exec(string.Format(
                        "INSERT INTO adressen (Land, PLZ, Ort, Hausnummer, Strasse ) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                        txt_lief_land.Text, txt_lief_plz.Text, txt_lief_ort.Text, txt_lief_hnr.Text,
                        txt_lief_str.Text));
                    
                    var sql = string.Format(
                        "SELECT Adr_ID FROM adressen WHERE Land='{0}' AND PLZ='{1}' AND Ort='{2}' AND Hausnummer='{3}' AND Strasse='{4}' LIMIT 1",
                        txt_lief_land.Text, txt_lief_plz.Text, txt_lief_ort.Text, txt_lief_hnr.Text,
                        txt_lief_str.Text);
                    CS_SQL_methods.Open();
                    var cmd_read = new OdbcCommand(sql, Connection);
                    var sqlReader = cmd_read.ExecuteReader();

                    sqlReader.Read();

                    var adr_id = sqlReader.GetInt32(0);

                    

                    CS_SQL_methods.SQL_exec(string.Format("INSERT INTO Lieferant (Lieferant, Adr_ID ) VALUES ('{0}', {1})",
                        txt_lief_ken.Text, adr_id));
                }
                catch (Exception f)
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

                UC_Parameter_lbx_lief_fill();

                cBx_stoff_lief_02.Items.Clear();
                cBx_stoff_lief.Items.Clear();
                UC_Parameter_cbx_stoff_lief_fill();
            }
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
            if (!DesignMode)
            {
                btn_pers_edit.Enabled = true;
                btn_pers_delete.Enabled = true;
                btn_pers_save.Enabled = false;
                btn_pers_funk_add.Enabled = true;
                btn_pers_funk_del.Enabled = true;

                if (lbx_pers.Items.Count > 0)
                    try
                    {
                        var sql = string.Format("SELECT * FROM personal WHERE P_ID = {0} LIMIT 1",
                            lbx_pers.SelectedValue);

                        CS_SQL_methods.Open();
                        var cmd_read = new OdbcCommand(sql, Connection);
                        var sqlReader = cmd_read.ExecuteReader();
                        sqlReader.Read();
                        txt_pers_vor.Text = Convert.ToString(sqlReader[1]);
                        txt_pers_nach.Text = Convert.ToString(sqlReader[2]);
                        var adr_ID = Convert.ToInt32(sqlReader[3]);
                        var funk_ID = Convert.ToInt32(sqlReader[4]);
                        cbx_pers_funk.SelectedValue = funk_ID;
                        sqlReader.Close();

                        var sql2 =
                            string.Format(
                                "SELECT Land,PLZ,Ort,Hausnummer,Strasse FROM adressen WHERE Adr_ID = {0} LIMIT 1",
                                adr_ID);
                        cmd_read = new OdbcCommand(sql2, Connection);
                        sqlReader = cmd_read.ExecuteReader();
                        sqlReader.Read();
                        txt_pers_land.Text = sqlReader[0].ToString();
                        txt_pers_plz.Text = sqlReader[1].ToString();
                        txt_pers_ort.Text = sqlReader[2].ToString();
                        txt_pers_hnr.Text = sqlReader[3].ToString();
                        txt_pers_str.Text = sqlReader[4].ToString();
                        sqlReader.Close();
                        
                    }

                    catch (Exception f)
                    {
                        
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
            if (!DesignMode)
                try
                {
                    CS_SQL_methods.SQL_exec(string.Format("UPDATE personal SET deaktiviert=true WHERE P_ID={0}",
                        lbx_pers.SelectedValue));
                }
                catch (Exception f)
                {
                    
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
            if (!DesignMode)
            {
                btn_lief_edit.Enabled = true;
                btn_lief_delete.Enabled = true;
                btn_lief_save.Enabled = false;

                if (lbx_pers.Items.Count > 0)
                    try
                    {
                        var sql = string.Format("SELECT * FROM lieferant WHERE L_ID = {0} LIMIT 1",
                            lbx_lief.SelectedValue);

                        CS_SQL_methods.Open();
                        var cmd_read = new OdbcCommand(sql, Connection);
                        var sqlReader = cmd_read.ExecuteReader();
                        sqlReader.Read();
                        txt_lief_ken.Text = Convert.ToString(sqlReader[1]);
                        var adr_ID = Convert.ToInt32(sqlReader[2]);
                        sqlReader.Close();

                        var sql2 =
                            string.Format(
                                "SELECT Land,PLZ,Ort,Hausnummer,Strasse FROM adressen WHERE Adr_ID = {0} LIMIT 1",
                                adr_ID);
                        cmd_read = new OdbcCommand(sql2, Connection);
                        sqlReader = cmd_read.ExecuteReader();
                        sqlReader.Read();
                        txt_lief_land.Text = sqlReader[0].ToString();
                        txt_lief_plz.Text = sqlReader[1].ToString();
                        txt_lief_ort.Text = sqlReader[2].ToString();
                        txt_lief_hnr.Text = sqlReader[3].ToString();
                        txt_lief_str.Text = sqlReader[4].ToString();
                        sqlReader.Close();
                        
                    }

                    catch (Exception f)
                    {
                        
                        MessageBox.Show("Fehler in der SQL Abfrage(lbx_pers): \n\n" + f.Message, "Fehler",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
            }
        }

        private void btn_pers_edit_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
                try
                {
                    
                    CS_SQL_methods.SQL_exec(string.Format("UPDATE personal SET Vorname= '{0}', Nachname = '{1}' WHERE P_ID = {2}",
                        txt_pers_vor.Text, txt_pers_nach.Text, lbx_pers.SelectedValue));

                  
                    var sql2 = string.Format("SELECT Adr_ID FROM personal WHERE P_ID = {0}",
                        lbx_pers.SelectedValue);
                    CS_SQL_methods.Open();
                    var cmd_read = new OdbcCommand(sql2, Connection);
                    var sqlReader = cmd_read.ExecuteReader();

                    sqlReader.Read();

                    var adr_id = sqlReader.GetInt32(0);

                    

                    CS_SQL_methods.SQL_exec(string.Format(
                        "UPDATE adressen SET Land = '{0}', PLZ = '{1}', Ort = '{2}', Hausnummer = '{3}', Strasse = '{4}' WHERE Adr_ID = {5}",
                        txt_pers_land.Text, txt_pers_plz.Text, txt_pers_ort.Text, txt_pers_hnr.Text,
                        txt_pers_str.Text,
                        adr_id));
                }
                catch (Exception f)
                {
                    
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
            if (!DesignMode)
                try
                {
                    CS_SQL_methods.SQL_exec(string.Format(
                        "UPDATE lieferant SET lieferant= '{0}' WHERE L_ID = {1}",
                        txt_lief_ken.Text, lbx_lief.SelectedValue));

                    CS_SQL_methods.Open();
                    var sql2 = string.Format("SELECT Adr_ID FROM lieferant WHERE L_ID = {0}",
                        lbx_lief.SelectedValue);
                    var cmd_read = new OdbcCommand(sql2, Connection);
                    var sqlReader = cmd_read.ExecuteReader();

                    sqlReader.Read();

                    var adr_id = sqlReader.GetInt32(0);

                    

                    CS_SQL_methods.SQL_exec(string.Format(
                        "UPDATE adressen SET Land = '{0}', PLZ = '{1}', Ort = '{2}', Hausnummer = '{3}', Strasse = '{4}' WHERE Adr_ID = {5}",
                        txt_lief_land.Text, txt_lief_plz.Text, txt_lief_ort.Text, txt_lief_hnr.Text,
                        txt_lief_str.Text,
                        adr_id));
                }
                catch (Exception f)
                {
                    
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
            if (!DesignMode)
                try
                {
                    var sql_controll =
                        string.Format(
                            "SELECT COUNT(*) FROM personal_funktion WHERE P_ID = {0} AND Funktion_ID = {1}",
                            lbx_pers.SelectedValue, cbx_pers_funk.SelectedValue);

                    var cmd_check = new OdbcCommand(sql_controll, Connection);

                    CS_SQL_methods.Open();
                    var pers_funk_ext = Convert.ToInt32(cmd_check.ExecuteScalar().ToString());
                    

                    if (pers_funk_ext > 0)
                        MessageBox.Show("Person hat Funktion schon", "Infomation", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    else
                        CS_SQL_methods.SQL_exec(string.Format("INSERT INTO personal_funktion (P_ID,Funktion_ID) VALUES ({0},{1})",
                            lbx_pers.SelectedValue, cbx_pers_funk.SelectedValue));

                    
                }

                catch (Exception f)
                {
                    
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
            if (!DesignMode)
                try
                {
                    CS_SQL_methods.SQL_exec(string.Format(
                        "DELETE FROM personal_funktion WHERE P_ID = {0} AND Funktion_ID = {1}",
                        lbx_pers.SelectedValue, lbx_pers_funk.SelectedValue));
                }
                catch (Exception f)
                {
                    
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

        private void btn_fert_save_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                try
                {
                    CS_SQL_methods.SQL_exec(string.Format("INSERT INTO fertigungsstatus (Status) VALUES ('{0}')",
                        txt_fert_new.Text));
                }
                catch (Exception f)
                {
                    MessageBox.Show("Fehler in der SQL Abfrage: \n\n" + f.Message, "Fehler", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                finally
                {
                    UC_Parameter_cbx_fert_fill();
                    txt_fert_new.Text = "";

                    MessageBox.Show("Fertigungsstatus wurde gespeichert", "Speicherung erfolgreich",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                btn_fert_save.Enabled = false;
            }
        }

        private void txt_fert_new_TextChanged(object sender, EventArgs e)
        {
            btn_fert_save.Enabled = true;
            if (txt_fert_new.Text == "") btn_fert_save.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btn_fert_edit.Enabled = !btn_fert_edit.Enabled;
        }

        private void txt_fert_edit_TextChanged(object sender, EventArgs e)
        {
            btn_fert_edit.Enabled = true;
            if (txt_fert_edit.Text == "") btn_fert_edit.Enabled = false;
        }

        private void btn_fert_edit_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                try
                {
                    CS_SQL_methods.SQL_exec(string.Format(
                        "UPDATE fertigungsstatus SET deaktiviert = {0}, status = '{1}' WHERE F_ID = {2}",
                        box_fert_dis.Checked, txt_fert_edit.Text, cbx_fert.SelectedValue));
                }
                catch (Exception f)
                {
                    MessageBox.Show("Fehler in der SQL Abfrage: \n\n" + f.Message, "Fehler", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                finally
                {
                    UC_Parameter_cbx_fert_fill();


                    MessageBox.Show("Fertigungsstatus wurde geändert", "Änderung erfolgreich", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                txt_fert_edit.Text = "";
                btn_fert_edit.Enabled = false;
                box_fert_dis.Checked = false;
            }
        }

        private void btn_lief_delete_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
                try
                {
                    CS_SQL_methods.SQL_exec(string.Format("UPDATE lieferant SET deaktiviert=true WHERE L_ID={0}",
                        lbx_lief.SelectedValue));
                }
                catch (Exception f)
                {
                    
                    MessageBox.Show("Fehler in der SQL Abfrage(Lieferant Delete): \n\n" + f.Message, "Fehler",
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


        private void button3_Click(object sender, EventArgs e)
        {
            /*
                        try
                        {
                            string sql_controll = string.Format("SELECT COUNT(*) FROM stoff_lieferant WHERE L_ID = {0} AND ST_ID = {1}", cbx_stoff_lief.SelectedValue, cbx_stoff_zu_stoff.SelectedIndex);

                            string sql = string.Format("INSERT INTO stoff_lieferant (L_ID,ST_ID) VALUES ({0},{1})", cbx_stoff_lief.SelectedValue, cbx_stoff_zu_stoff.SelectedIndex);


                            CS_SQL_methods.Open();


                            OdbcCommand cmd_check = new OdbcCommand(sql_controll, Connection);
                            int stoff_lieferant_ext = Convert.ToInt32(cmd_check.ExecuteScalar().ToString());
                            if (stoff_lieferant_ext > 0)
                            {
                                MessageBox.Show("Verbindung zwischen Lieferant und Stoff besteht schon", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                OdbcCommand cmd = new OdbcCommand(sql, Connection);
                                cmd.ExecuteNonQuery();
                            }
                            
                        }

                        catch (Exception f)
                        {
                            
                            SQL_Fehler(f);
                        }

                        finally
                        {
                            UC_Parameter_lbx_pers_funk_fill();
                        }*/
        }

        private void btn_stoff_up_Click(object sender, EventArgs e)
        {
            Search_Picture(pbx_stoff);
        }

        private void btn_stoff_up_02_Click(object sender, EventArgs e)
        {
            Search_Picture(pBx_Stoff_02);
        }

        private void Search_Picture(PictureBox pbx)
        {
            if (ofd_stoff_up.ShowDialog() == DialogResult.OK)
            {
                if (extensions.Contains(ofd_stoff_up.FileName.Substring(ofd_stoff_up.FileName.LastIndexOf('.') + 1)
                    .ToUpper()))
                {
                    pbx.Image = Image.FromFile(ofd_stoff_up.FileName);
                    pbx.Image.Tag = ofd_stoff_up.FileName.Substring(ofd_stoff_up.FileName.LastIndexOf('\\') + 1);
                    pbx.SizeMode = PictureBoxSizeMode.Zoom;
                    File_Path_FTP = ofd_stoff_up.FileName;
                }
                else
                {
                    MessageBox.Show("Bitte ein Bild mit den Endungen png, jpg, tiff, gif verwenden", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_Save_Stoff_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                var sql = string.Format("SELECT COUNT(*) FROM Stoff WHERE Bild = '{0}'",
                    pbx_stoff.Image.Tag as string);
                var cmd = new OdbcCommand(sql, Connection);

                CS_SQL_methods.Open();
                if (Convert.ToInt32(cmd.ExecuteScalar().ToString()) <= 0)
                {
                    using (var client = new WebClient())
                    {
                        client.Credentials = new NetworkCredential(CS_FTP.User, CS_FTP.Pw);
                        client.UploadFile(server + pbx_stoff.Image.Tag, WebRequestMethods.Ftp.UploadFile,
                            ofd_stoff_up.FileName);
                    }


                    CS_SQL_methods.SQL_exec(string.Format("INSERT INTO Stoff (`Stoff`,`Bild`) VALUES ('{0}','{1}')", tBx_new_stoff.Text,
                        pbx_stoff.Image.Tag as string));



                    CS_SQL_methods.Open();
                    sql = "SELECT stoff.ST_ID FROM stoff ORDER BY stoff.ST_ID DESC LIMIT 1";
                    cmd = new OdbcCommand(sql, Connection);
                    CS_SQL_methods.SQL_exec(string.Format("INSERT INTO stoff_lieferant (`ST_ID`,`L_ID`) VALUES ({0},{1})",cmd.ExecuteScalar().ToString(), cBx_stoff_lief.SelectedValue.ToString()));
                }
                else
                {
                    Message_Bild_used_in_DB();
                }

                cbx_stoff_edit.Items.Clear();
                UC_Parameter_lbx_stoff_fill();

            }
        }

        private void btn_Change_Stoff_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                if (pBx_Stoff_02?.Image?.Tag?.GetType() == typeof(string)) //Überprüfung ob Klasse string ist
                {
                    var request = (FtpWebRequest) WebRequest.Create(server + pBx_Stoff_02.Image.Tag);
                    request.Credentials = new NetworkCredential(CS_FTP.User, CS_FTP.Pw);
                    request.Method = WebRequestMethods.Ftp.GetFileSize;
                    try
                    {
                        var response = (FtpWebResponse) request.GetResponse();
                    }
                    catch (WebException ex)
                    {
                        var response = (FtpWebResponse) ex.Response;
                        if (response.StatusCode != FtpStatusCode.ActionNotTakenFileUnavailable)
                            using (var client = new WebClient())
                            {
                                client.Credentials = new NetworkCredential(CS_FTP.User, CS_FTP.Pw);
                                client.UploadFile(server + pBx_Stoff_02.Image.Tag, WebRequestMethods.Ftp.UploadFile,
                                    File_Path_FTP);
                            }
                    }
                }

                var sql = string.Format("SELECT COUNT(*) FROM Stoff WHERE Bild = '{0}' AND ST_ID <> {1}",
                    pBx_Stoff_02?.Image?.Tag as string, cbx_stoff_edit.SelectedValue);
                var cmd = new OdbcCommand(sql, Connection);

                CS_SQL_methods.Open();
                if (pBx_Stoff_02?.Image?.Tag as string == null || Convert.ToInt32(cmd.ExecuteScalar().ToString()) <= 0)
                {
                    

                    CS_SQL_methods.SQL_exec(string.Format(
                        "UPDATE Stoff SET `Stoff` = '{0}', `Bild` = '{1}', `deaktiviert` = {3} WHERE Stoff.ST_ID = {2}",
                        tBx_change_Stoff.Text, pBx_Stoff_02?.Image?.Tag as string,
                        cbx_stoff_edit.SelectedValue, Convert.ToInt32(box_delete.Checked)));

                    CS_SQL_methods.SQL_exec(string.Format("DELETE FROM stoff_lieferant WHERE ST_ID = {0}",
                        cbx_stoff_edit.SelectedValue));

                    CS_SQL_methods.SQL_exec(string.Format("INSERT INTO stoff_lieferant (`ST_ID`,`L_ID`) VALUES ({0},{1})",
                        cbx_stoff_edit.SelectedValue, cBx_stoff_lief.SelectedValue));
                }
                else
                {
                    Message_Bild_used_in_DB();
                }

            }
        }

        private void Message_Bild_used_in_DB()
        {
            MessageBox.Show(
                "Bild ist in der DB schon vorhanden, bitte ein anderes Bild (oder das Bild mit einem anderen Namen) verwenden.",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbx_stoff_edit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!DesignMode)
                if (cbx_stoff_edit.SelectedValue != null &&
                    cbx_stoff_edit.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    CS_SQL_methods.Open();
                    var sql =
                        $"SELECT * FROM stoff WHERE stoff.ST_ID = {cbx_stoff_edit.SelectedValue}";
                    var cmd = new OdbcCommand(sql, Connection);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (pBx_Stoff_02.Image != null) pBx_Stoff_02.Image.Dispose();

                        pBx_Stoff_02.Image = null;
                        tBx_change_Stoff.Text = reader["Stoff"].ToString();
                        sql =
                            $"SELECT L_ID FROM stoff_lieferant WHERE stoff_lieferant.ST_ID = {cbx_stoff_edit.SelectedValue} LIMIT 1";
                        cmd = new OdbcCommand(sql, Connection);

                        object l_ID;
                        if ((l_ID = cmd.ExecuteScalar()) != null)
                            cBx_stoff_lief_02.SelectedValue = l_ID;
                        else
                            cBx_stoff_lief_02.Text = "";


                        if (reader["Bild"].ToString() != "")
                            try
                            {
                                var client = new WebClient();
                                client.Credentials = new NetworkCredential(CS_FTP.User, CS_FTP.Pw);
                                using (var stream =
                                    new MemoryStream(client.DownloadData(server + reader["Bild"])))
                                {
                                    var ms = new MemoryStream();
                                    stream.CopyTo(
                                        ms); //Because of some funnnny stuff that could happen (if you do not do this like this (copto an other memorystream) it could probably maybe be that not all data gets their....... I know, wired
                                    Image image = ByteToImage(ms.ToArray());
                                    image.Tag = reader["Bild"].ToString();
                                    pBx_Stoff_02.Image = image;
                                    pBx_Stoff_02.SizeMode = PictureBoxSizeMode.Zoom;
                                }
                            }
                            catch (Exception exception)
                            {
                                MessageBox.Show(
                                    "Wahrscheinlich wurde das Bild nicht auf dem FTP gefunden oder Bild kaput Be Happy (;" +
                                    exception.Message);
                            }
                    }

                    
                }
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            var mStream = new MemoryStream();
            mStream.Write(blob, 0, Convert.ToInt32(blob.Length));
            var bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
    }
}