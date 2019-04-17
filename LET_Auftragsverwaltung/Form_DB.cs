using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LET_Auftragsverwaltung
{
    public partial class Form_DB : Form
    {
        private bool is_startup = false;
        private OdbcConnection Connection => DB.Connection;
        public Form_DB()
        {
            is_startup = true;
            InitializeComponent();
            is_startup = false;
        }

        private void Form_DB_Load(object sender, EventArgs e)
        {
            is_startup = true;
            UC_Parameter_lbx_pers_fill();
            UC_Parameter_lbx_lief_fill();
            UC_Parameter_lbx_pers_funk_fill();
            UC_Parameter_cbx_stoff_lief_fill();
            UC_Parameter_cbx_funk_fill();
            is_startup = false;
            UC_Parameter_lbx_stoff_fill();
        }

        #region Fill Methods

        private void UC_Parameter_cbx_funk_fill()
        {
            if (!DesignMode)
                try
                {
                    var dtFunkt = SQL_methods.Fill_Box("SELECT Funktion_ID,Funktion FROM funktion WHERE deaktiviert<>true");

                    lBx_pers_Funktionen.DataSource = dtFunkt;
                    lBx_pers_Funktionen.DisplayMember = "Funktion";
                    lBx_pers_Funktionen.ValueMember = "Funktion_ID";


                    if (lBx_pers_Funktionen.Items.Count > 0) lBx_pers_Funktionen.SelectedIndex = 0;
                }
                catch (Exception f)
                {
                    MessageBox.Show("Fehler in der SQL Abfrage(Funtkion Fill): \n\n" + f.Message, "Fehler",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void UC_Parameter_lbx_pers_fill()
        {
            if (!DesignMode)
                try
                {
                    var dtPer = SQL_methods.Fill_Box("SELECT P_ID,CONCAT(CONCAT(Nachname,' '),Vorname) AS Name FROM personal WHERE deaktiviert<>true");
                    lbx_Personen.DataSource = dtPer;
                    lbx_Personen.ValueMember = "P_ID";
                    lbx_Personen.DisplayMember = "Name";


                    if (lbx_Personen.Items.Count > 0) lbx_Personen.SelectedIndex = 0;
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

                    var dt = SQL_methods.Fill_Box("SELECT Lieferant,L_ID FROM lieferant WHERE deaktiviert<>true");
                    lbx_Lieferanten.DataSource = dt;
                    lbx_Lieferanten.ValueMember = "L_ID";
                    lbx_Lieferanten.DisplayMember = "Lieferant";


                    if (lbx_Lieferanten.Items.Count > 0) lbx_Lieferanten.SelectedIndex = 0;
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

                    var dt = SQL_methods.Fill_Box("SELECT Lieferant,L_ID FROM lieferant WHERE deaktiviert<>true");
                    cBx_stoff_lief_1.DataSource = dt;
                    cBx_stoff_lief_1.ValueMember = "L_ID";
                    cBx_stoff_lief_1.DisplayMember = "Lieferant";

                    cBx_stoff_lief_2.DataSource = dt.Copy();
                    cBx_stoff_lief_2.ValueMember = "L_ID";
                    cBx_stoff_lief_2.DisplayMember = "Lieferant";

                    cBx_stoff_lief_3.DataSource = dt.Copy();
                    cBx_stoff_lief_3.ValueMember = "L_ID";
                    cBx_stoff_lief_3.DisplayMember = "Lieferant";

                    if (cBx_stoff_lief_1.Items.Count > 0) cBx_stoff_lief_1.SelectedIndex = 0;
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
            if (!DesignMode && !is_startup)
            {
                try
                {

                    var dt = SQL_methods.Fill_Box("SELECT CONCAT(CONCAT(stoff.ID,', '),stoff.name) AS Stoff,stoff.ST_ID,stoff_lieferant.L_ID FROM stoff LEFT JOIN stoff_lieferant ON stoff.ST_ID = stoff_lieferant.ST_ID WHERE deaktiviert<>true");


                    var tmp = dt.AsEnumerable().Where(x => x.Field<int>("L_ID") == Convert.ToInt32(cBx_stoff_lief_3.SelectedValue));
                    if (tmp.Count() > 0)
                    {
                        lBx_stoff.DataSource = tmp.CopyToDataTable();
                        btn_stoff_delete.Enabled = true;
                        lBx_stoff.ValueMember = "ST_ID";
                        lBx_stoff.DisplayMember = "Stoff";
                    }
                    else
                    {
                        lBx_stoff.DataSource = new List<string>(new string[] { "Diesem Lieferanten sind keine Stoffe zugewiesen" });
                        btn_stoff_delete.Enabled = false;
                    }
                }
                catch (Exception f)
                {
                    MessageBox.Show("Fehler in der SQL Abfrage(Stoff Fill): \n\n" + f.Message + "\n\n" + f.Data.Values, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UC_Parameter_lbx_pers_funk_fill()
        {
            if (!DesignMode)
                try
                {

                    var dt = SQL_methods.Fill_Box(string.Format(
                        "SELECT DISTINCT funktion.`Funktion`, funktion.`Funktion_ID` FROM personal LEFT JOIN personal_funktion ON personal.`P_ID` = personal_funktion.`P_ID` LEFT JOIN funktion ON personal_funktion.`Funktion_ID` = funktion.`Funktion_ID` WHERE personal.`P_ID` = {0} ORDER BY funktion.`Funktion`",
                        lbx_Personen.SelectedValue));

                    lbx_pers_Funktion_used.DataSource = dt;
                    lbx_pers_Funktion_used.ValueMember = "Funktion_ID";
                    lbx_pers_Funktion_used.DisplayMember = "Funktion";

                    if (lbx_pers_Funktion_used.Items.Count > 0) lbx_pers_Funktion_used.SelectedIndex = 0;
                }
                catch (Exception f)
                {

                    MessageBox.Show(
                        "Fehler in der SQL Abfrage(Personal Funktion Fill): \n\n" + f.Message + "\n\n" +
                        f.Data.Values, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        #endregion

        private void Btn_pers_save_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                if (!string.IsNullOrEmpty(tBx_pers_Nachname.Text) && !string.IsNullOrEmpty(tBx_pers_Vorname.Text))
                {
                    try
                    {
                        SQL_methods.SQL_exec(string.Format(
                            "INSERT INTO adressen (Land, PLZ, Ort, Hausnummer, Strasse ) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                            tbx_pers_Land.Text, tBx_pers_plz.Text, tBx_pers_Ort.Text, tBx_pers_strnum.Text,
                            tBx_pers_str.Text));

                        var sql2 = string.Format(
                            "SELECT Adr_ID FROM adressen WHERE Land='{0}' AND PLZ='{1}' AND Ort='{2}' AND Hausnummer='{3}' AND Strasse='{4}' LIMIT 1",
                            tbx_pers_Land.Text, tBx_pers_plz.Text, tBx_pers_Ort.Text, tBx_pers_strnum.Text, tBx_pers_str.Text);
                        SQL_methods.Open();
                        var cmd_read = new OdbcCommand(sql2, Connection);
                        var sqlReader = cmd_read.ExecuteReader();

                        sqlReader.Read();

                        var adr_id = sqlReader.GetInt32(0);

                        SQL_methods.SQL_exec(string.Format("INSERT INTO personal (Vorname, Nachname, Adr_ID) VALUES ('{0}', '{1}', {2})",
                            tBx_pers_Vorname.Text, tBx_pers_Nachname.Text, adr_id));
                        MessageBox.Show("Person wurde gespeichert", "Speicherung erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UC_Parameter_lbx_pers_fill();
                    }
                    catch (Exception f)
                    {
                        MessageBox.Show("Fehler in der SQL Abfrage: \n\n" + f.Message, "Fehler", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }


                    tBx_pers_Vorname.Text = "";
                    tBx_pers_Nachname.Text = "";
                    tBx_pers_strnum.Text = "";
                    tbx_pers_Land.Text = "";
                    tBx_pers_Ort.Text = "";
                    tBx_pers_str.Text = "";
                    tBx_pers_plz.Text = "";

                }
                else
                {
                    MessageBox.Show("Vor- und Nachname sind Pflichtfelder", "Warnung", MessageBoxButtons.OK);
                }
            }
        }

        private void Btn_pers_edit_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
                if (!string.IsNullOrEmpty(tBx_pers_Nachname.Text) && !string.IsNullOrEmpty(tBx_pers_Vorname.Text))
                {
                    try
                    {

                        SQL_methods.SQL_exec(string.Format("UPDATE personal SET Vorname= '{0}', Nachname = '{1}' WHERE P_ID = {2}",
                            tBx_pers_Vorname.Text, tBx_pers_Nachname.Text, lbx_Personen.SelectedValue));


                        var sql2 = string.Format("SELECT Adr_ID FROM personal WHERE P_ID = {0}",
                            lbx_Personen.SelectedValue);
                        SQL_methods.Open();
                        var cmd_read = new OdbcCommand(sql2, Connection);
                        var sqlReader = cmd_read.ExecuteReader();

                        sqlReader.Read();

                        var adr_id = sqlReader.GetInt32(0);



                        SQL_methods.SQL_exec(string.Format(
                            "UPDATE adressen SET Land = '{0}', PLZ = '{1}', Ort = '{2}', Hausnummer = '{3}', Strasse = '{4}' WHERE Adr_ID = {5}",
                            tbx_pers_Land.Text, tBx_pers_plz.Text, tBx_pers_Ort.Text, tBx_pers_strnum.Text,
                            tBx_pers_str.Text,
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
                        tBx_pers_Vorname.Text = "";
                        tBx_pers_Nachname.Text = "";
                        tbx_pers_Land.Text = "";
                        tBx_pers_plz.Text = "";
                        tBx_pers_Ort.Text = "";
                        tBx_pers_strnum.Text = "";
                        tBx_pers_str.Text = "";

                        UC_Parameter_lbx_pers_fill();
                    }
                }
        }

        private void Btn_pers_funk_del_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
                try
                {
                    SQL_methods.SQL_exec(string.Format(
                        "DELETE FROM personal_funktion WHERE P_ID = {0} AND Funktion_ID = {1}",
                        lbx_Personen.SelectedValue, lbx_pers_Funktion_used.SelectedValue));
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

        private void Btn_pers_funk_add_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
                try
                {
                    var sql_controll =
                        string.Format(
                            "SELECT COUNT(*) FROM personal_funktion WHERE P_ID = {0} AND Funktion_ID = {1}",
                            lbx_Personen.SelectedValue, lBx_pers_Funktionen.SelectedValue);

                    var cmd_check = new OdbcCommand(sql_controll, Connection);

                    SQL_methods.Open();
                    var pers_funk_ext = Convert.ToInt32(cmd_check.ExecuteScalar().ToString());


                    if (pers_funk_ext > 0)
                        MessageBox.Show("Person hat Funktion schon", "Infomation", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    else
                        SQL_methods.SQL_exec(string.Format("INSERT INTO personal_funktion (P_ID,Funktion_ID) VALUES ({0},{1})",
                            lbx_Personen.SelectedValue, lBx_pers_Funktionen.SelectedValue));


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

        private void Btn_pers_delete_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
                try
                {
                    SQL_methods.SQL_exec(string.Format("UPDATE personal SET deaktiviert=true WHERE P_ID={0}",
                        lbx_Personen.SelectedValue));
                }
                catch (Exception f)
                {

                    MessageBox.Show("Fehler in der SQL Abfrage(Personal Delete): \n\n" + f.Message, "Fehler",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                finally
                {
                    tBx_pers_Vorname.Text = "";
                    tBx_pers_Nachname.Text = "";
                    tbx_pers_Land.Text = "";
                    tBx_pers_plz.Text = "";
                    tBx_pers_Ort.Text = "";
                    tBx_pers_strnum.Text = "";
                    tBx_pers_str.Text = "";

                    UC_Parameter_lbx_pers_fill();
                }
        }

        private void Btn_lief_save_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                if (!string.IsNullOrEmpty(tBx_lief_Kennung.Text))
                {
                    try
                    {

                        SQL_methods.SQL_exec(string.Format(
                            "INSERT INTO adressen (Land, PLZ, Ort, Hausnummer, Strasse ) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                            tBx_lief_Land.Text, tBx_lief_plz.Text, tBx_lief_Ort.Text, tBx_lief_strnum.Text,
                            tBx_lief_str.Text));

                        var sql = string.Format(
                            "SELECT Adr_ID FROM adressen WHERE Land='{0}' AND PLZ='{1}' AND Ort='{2}' AND Hausnummer='{3}' AND Strasse='{4}' LIMIT 1",
                            tBx_lief_Land.Text, tBx_lief_plz.Text, tBx_lief_Ort.Text, tBx_lief_strnum.Text,
                            tBx_lief_str.Text);
                        SQL_methods.Open();
                        var cmd_read = new OdbcCommand(sql, Connection);
                        var sqlReader = cmd_read.ExecuteReader();

                        sqlReader.Read();

                        var adr_id = sqlReader.GetInt32(0);



                        SQL_methods.SQL_exec(string.Format("INSERT INTO Lieferant (Lieferant, Adr_ID ) VALUES ('{0}', {1})",
                            tBx_lief_Kennung.Text, adr_id));

                        MessageBox.Show("Lieferant wurde gespeichert", "Speicherung erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception f)
                    {
                        MessageBox.Show("Fehler in der SQL Abfrage: \n\n" + f.Message, "Fehler", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }


                    tBx_lief_Kennung.Text = "";
                    tBx_lief_strnum.Text = "";
                    tBx_lief_Land.Text = "";
                    tBx_lief_Ort.Text = "";
                    tBx_lief_plz.Text = "";
                    tBx_lief_str.Text = "";

                    UC_Parameter_lbx_lief_fill();

                    UC_Parameter_cbx_stoff_lief_fill();
                }
            }
        }

        private void Btn_lief_edit_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
                if (!string.IsNullOrEmpty(tBx_lief_Kennung.Text))
                {
                    try
                    {
                        SQL_methods.SQL_exec(string.Format(
                            "UPDATE lieferant SET lieferant= '{0}' WHERE L_ID = {1}",
                            tBx_lief_Kennung.Text, lbx_Lieferanten.SelectedValue));

                        SQL_methods.Open();
                        var sql2 = string.Format("SELECT Adr_ID FROM lieferant WHERE L_ID = {0}",
                            lbx_Lieferanten.SelectedValue);
                        var cmd_read = new OdbcCommand(sql2, Connection);
                        var sqlReader = cmd_read.ExecuteReader();

                        sqlReader.Read();

                        var adr_id = sqlReader.GetInt32(0);



                        SQL_methods.SQL_exec(string.Format(
                            "UPDATE adressen SET Land = '{0}', PLZ = '{1}', Ort = '{2}', Hausnummer = '{3}', Strasse = '{4}' WHERE Adr_ID = {5}",
                            tBx_lief_Land.Text, tBx_lief_plz.Text, tBx_lief_Ort.Text, tBx_lief_strnum.Text,
                            tBx_lief_str.Text,
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
                        tBx_lief_Kennung.Text = "";
                        tBx_lief_Land.Text = "";
                        tBx_lief_plz.Text = "";
                        tBx_lief_Ort.Text = "";
                        tBx_lief_strnum.Text = "";
                        tBx_lief_str.Text = "";

                        UC_Parameter_lbx_lief_fill();
                    }
                }
        }

        private void Btn_lief_delete_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
                try
                {
                    SQL_methods.SQL_exec(string.Format("UPDATE lieferant SET deaktiviert=true WHERE L_ID={0}",
                        lbx_Lieferanten.SelectedValue));
                }
                catch (Exception f)
                {

                    MessageBox.Show("Fehler in der SQL Abfrage(Lieferant Delete): \n\n" + f.Message, "Fehler",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                finally
                {
                    tBx_lief_Kennung.Text = "";
                    tBx_lief_Land.Text = "";
                    tBx_lief_plz.Text = "";
                    tBx_lief_Ort.Text = "";
                    tBx_lief_strnum.Text = "";
                    tBx_lief_str.Text = "";

                    UC_Parameter_lbx_lief_fill();
                    UC_Parameter_cbx_stoff_lief_fill();
                }
        }

        private void Lbx_Personen_DoubleClick(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                if (lbx_Personen.Items.Count > 0)
                    try
                    {
                        var sql = string.Format("SELECT * FROM personal WHERE P_ID = {0} LIMIT 1",
                            lbx_Personen.SelectedValue);

                        SQL_methods.Open();
                        var cmd_read = new OdbcCommand(sql, Connection);
                        var sqlReader = cmd_read.ExecuteReader();
                        sqlReader.Read();
                        tBx_pers_Vorname.Text = Convert.ToString(sqlReader[1]);
                        tBx_pers_Nachname.Text = Convert.ToString(sqlReader[2]);
                        var adr_ID = Convert.ToInt32(sqlReader[3]);
                        var funk_ID = Convert.ToInt32(sqlReader[4]);
                        lBx_pers_Funktionen.SelectedValue = funk_ID;
                        sqlReader.Close();

                        var sql2 = string.Format("SELECT Land,PLZ,Ort,Hausnummer,Strasse FROM adressen WHERE Adr_ID = {0} LIMIT 1", adr_ID);
                        cmd_read = new OdbcCommand(sql2, Connection);
                        sqlReader = cmd_read.ExecuteReader();
                        sqlReader.Read();
                        tbx_pers_Land.Text = sqlReader[0].ToString();
                        tBx_pers_plz.Text = sqlReader[1].ToString();
                        tBx_pers_Ort.Text = sqlReader[2].ToString();
                        tBx_pers_str.Text = sqlReader[3].ToString();
                        tBx_pers_strnum.Text = sqlReader[4].ToString();
                        sqlReader.Close();
                    }
                    catch (Exception f)
                    {
                        MessageBox.Show("Fehler in der SQL Abfrage(lbx_pers): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    finally
                    {
                        UC_Parameter_lbx_pers_funk_fill();
                    }
            }
        }


        #region Lieferant

        #endregion

        private void Lbx_Lieferanten_DoubleClick(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                if (lbx_Lieferanten.Items.Count > 0)
                    try
                    {
                        var sql = string.Format("SELECT * FROM lieferant WHERE L_ID = {0} LIMIT 1",
                            lbx_Lieferanten.SelectedValue);

                        SQL_methods.Open();
                        var cmd_read = new OdbcCommand(sql, Connection);
                        var sqlReader = cmd_read.ExecuteReader();
                        sqlReader.Read();
                        tBx_lief_Kennung.Text = Convert.ToString(sqlReader[1]);
                        var adr_ID = Convert.ToInt32(sqlReader[2]);
                        sqlReader.Close();

                        var sql2 = string.Format("SELECT Land,PLZ,Ort,Hausnummer,Strasse FROM adressen WHERE Adr_ID = {0} LIMIT 1", adr_ID);
                        cmd_read = new OdbcCommand(sql2, Connection);
                        sqlReader = cmd_read.ExecuteReader();
                        sqlReader.Read();
                        tBx_lief_Land.Text = sqlReader[0].ToString();
                        tBx_lief_plz.Text = sqlReader[1].ToString();
                        tBx_lief_Ort.Text = sqlReader[2].ToString();
                        tBx_lief_strnum.Text = sqlReader[3].ToString();
                        tBx_lief_str.Text = sqlReader[4].ToString();
                        sqlReader.Close();
                    }

                    catch (Exception f)
                    {
                        MessageBox.Show("Fehler in der SQL Abfrage(lbx_pers): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_stoff_save_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                Save_Stoff_to_DB(tBx_stoff_name.Text, tBx_stoff_ID.Text, cBx_stoff_lief_1.SelectedValue.ToString());

                UC_Parameter_lbx_stoff_fill();

            }
        }

        private void Save_Stoff_to_DB(string name, string id, string Lieferanten_ID)
        {
            SQL_methods.SQL_exec(string.Format("INSERT INTO Stoff (`name`,`ID`) VALUES ('{0}','{1}')", name, id));

            SQL_methods.SQL_exec(string.Format("INSERT INTO stoff_lieferant (`ST_ID`,`L_ID`) VALUES ((SELECT stoff.ST_ID FROM stoff ORDER BY stoff.ST_ID DESC LIMIT 1),{0})", Lieferanten_ID));
        }

        private void Btn_stoff_load_file_Click(object sender, EventArgs e)
        {
            if (oFD_stoff.ShowDialog() == DialogResult.OK)
            {
                var stoffe = File.ReadLines(oFD_stoff.FileName)
                               .Select(line => line.Split(';'))
                               .Select(tokens => new Stoff { ID = tokens[0], name = tokens[1] });
                //.ToList(); //did not use for better performance

                foreach (Stoff stoff in stoffe)
                {
                    Save_Stoff_to_DB(stoff.name, stoff.ID, cBx_stoff_lief_2.SelectedValue.ToString());
                }
            }
        }

        private void Btn_stoff_delete_Click(object sender, EventArgs e)
        {
            if (lBx_stoff.SelectedItem != null)
            {
                SQL_methods.SQL_exec(string.Format("UPDATE stoff SET deaktiviert = TRUE WHERE ST_ID = {0}", lBx_stoff.SelectedValue));
                UC_Parameter_lbx_stoff_fill();
            }
        }

        private void CBx_stoff_lief_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            UC_Parameter_lbx_stoff_fill();
        }
    }
    class Stoff
    {
        public string ID = "";
        public string name = "";
    }
}
