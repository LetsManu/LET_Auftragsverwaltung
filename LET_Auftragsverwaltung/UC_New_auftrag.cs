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
                return DB.Connection;

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
            UC_New_auftrag_fill_cbx_lief();
            //UC_New_auftrag_fill_cbx_auf();
            //UC_New_auftrag_fill_cbx_lief();
            date_erstell.Value = DateTime.Today;
            date_mont.Value = DateTime.Today.AddDays(28);
        }

        private void UC_New_auftrag_fill_cbx_verant( )
        {
            if (!this.DesignMode)
            {
                try
                {

                    DataTable dtPer = SQL_methods.Fill_Box("SELECT DISTINCT CONCAT(p.`Nachname`, ' ', p.`Vorname`) AS 'Name', p.P_ID FROM personal p LEFT JOIN personal_funktion pf ON p.P_ID = pf.P_ID WHERE pf.Funktion_ID = 4");

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

                    DataTable dtPer = SQL_methods.Fill_Box("SELECT DISTINCT CONCAT(p.`Nachname`, ' ', p.`Vorname`) AS 'Name', p.P_ID FROM personal p LEFT JOIN personal_funktion pf ON p.P_ID = pf.P_ID WHERE pf.Funktion_ID = 9");

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

                    DataTable dt = SQL_methods.Fill_Box("SELECT DISTINCT CONCAT(p.`Nachname`, ' ', p.`Vorname`) AS 'Name', p.P_ID FROM personal p LEFT JOIN personal_funktion pf ON p.P_ID = pf.P_ID WHERE pf.Funktion_ID = 1 OR pf.Funktion_ID = 8");

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

        /*
        private void UC_New_auftrag_fill_cbx_auf()
        {
            if (!this.DesignMode)
            {
                try
                {
                    DataTable dtArt = SQL_methods.Fill_Box("SELECT Art_ID,Art FROM auftragsart WHERE deaktiviert<>true");

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
        }*/
        /*
        private void UC_New_auftrag_fill_cbx_lief()
        {
            if (!this.DesignMode)
            {
                try
                {
                    DataTable dtLief = SQL_methods.Fill_Box("SELECT L_ID, Lieferant FROM Lieferant WHERE deaktiviert<>true");

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
        }*/
        /*
        private void UC_New_auftrag_fill_cbx_stoff_lief()
        {
            if (!this.DesignMode)
            {
                if (cbx_new_auf_lief.Items.Count > 0)
                {
                    try
                    {
                        DataTable dtStoff = SQL_methods.Fill_Box(string.Format(
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

                    }
                }
            }
        }
        */



        /*
    private void Btn_auftrag_add_Click(object sender, EventArgs e)
    {
        if (!this.DesignMode)
        {
            try
            {
                OdbcConnection connection = Connection;
                SQL_methods.Open();
                string sql = string.Format("SELECT Art_ID,Art FROM auftragsart WHERE Art_ID = {0}",
                    cbx_auftrag.SelectedValue);
                OdbcCommand cmd = new OdbcCommand(sql, connection);
                OdbcDataReader sqlReader = cmd.ExecuteReader();
                sqlReader.Read();
                Object_auf item = new Object_auf((int)sqlReader[0], (string)sqlReader[1]);
                bool added = false;


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

    }*/
        /*

        private void btn_auftag_delete_Click(object sender, EventArgs e)
        {
            lbx_auftrag.Items.Remove(lbx_auftrag.Items[lbx_auftrag.SelectedIndex]);

        }*/

        private void Btn_new_auf_save_Click(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                try
                {

                    int a_ID;
                    SQL_methods.SQL_exec(string.Format("INSERT INTO AB_AZ (V_Notiz) Values ('{0}')", " "));
                    string sql = "SELECT A_ID FROM ab_az ORDER BY A_ID DESC LIMIT 1";
                    OdbcCommand cmd = new OdbcCommand(sql, Connection);
                    SQL_methods.Open();
                    OdbcDataReader sql_read = cmd.ExecuteReader();
                    sql_read.Read();
                    a_ID = Convert.ToInt32(sql_read[0].ToString());

                    SQL_methods.SQL_exec("INSERT INTO auftrags.schatten (schatten.Notiz) VALUES ('')");
                    string sql2 = "SELECT * FROM schatten ORDER BY schatten.S_ID DESC LIMIT 1";
                    OdbcCommand cmd2 = new OdbcCommand(sql2, Connection);
                    SQL_methods.Open();
                    OdbcDataReader sqlReader2 = cmd2.ExecuteReader();
                    sqlReader2.Read();
                    int schatten_ID = Convert.ToInt32(sqlReader2[0]);
                    sqlReader2.Close();
                    /*SQL_methods.SQL_exec(String.Format("INSERT INTO auftrags.teile_stoff (teile_stoff.ST_ID) VALUES ({0})",
                        cbx_new_auf_stoff.SelectedValue));
                    SQL_methods.Open();*/

                    sql = "SELECT * FROM teile_stoff ORDER BY teile_stoff.T_ST_ID DESC LIMIT 1";
                    cmd = new OdbcCommand(sql, Connection);
                    sqlReader2 = cmd.ExecuteReader();
                    sqlReader2.Read();
                    int teile_stoff_ID = Convert.ToInt32(sqlReader2[0]);

                    SQL_methods.SQL_exec(string.Format(
                        "INSERT INTO auftraege (auftraege.`Auftrags_NR`, auftraege.`Fertigungsstatus`, auftraege.Projektverantwortlicher, auftraege.Planer_Techniker, auftraege.Erstelldatum, auftraege.AB_AZ, auftraege.Montage_Datum, auftraege.Projektbezeichnung, auftraege.`Schatten`,  auftraege.Notitz_Kauf, auftraege.Notitz_Tech) VALUES ('{0}', 6, {1}, {2}, '{3}', {4}, '{5}', '{6}', {7}, '{8}', '{9}')",
                        txt_auftrag_nr.Text, cbx_verant.SelectedValue, cbx_tech.SelectedValue,
                        date_erstell.Value.ToString("yyyy-MM-dd"), a_ID, date_mont.Value.ToString("yyyy-MM-dd"),
                        txt_auf_proj_ken.Text, schatten_ID, txt_info_kauf.Text, txt_info_tech.Text));

                    SQL_methods.Open();
                    sql2 = string.Format(
                        "SELECT ID FROM auftraege WHERE auftraege.`Auftrags_NR` = '{0}' AND auftraege.`Fertigungsstatus` = {1} AND auftraege.Projektverantwortlicher = {2} AND auftraege.Planer_Techniker = {3} AND auftraege.Erstelldatum = '{4}' AND auftraege.Montage_Datum = '{5}' AND auftraege.Projektbezeichnung = '{6}' AND auftraege.`Schatten` = {7} AND auftraege.Notitz_Kauf = '{8}' AND auftraege.Notitz_Tech = '{9}'",
                        txt_auftrag_nr.Text, 6, cbx_verant.SelectedValue, cbx_tech.SelectedValue,
                        date_erstell.Value.ToString("yyyy-MM-dd"), date_mont.Value.ToString("yyyy-MM-dd"),
                        txt_auf_proj_ken.Text, schatten_ID, txt_info_kauf.Text, txt_info_tech.Text);

                    OdbcCommand cmd_read = new OdbcCommand(sql2, Connection);
                    sqlReader2 = cmd_read.ExecuteReader();

                    sqlReader2.Read();

                    int auf_id = sqlReader2.GetInt32(0);


                    SQL_methods.SQL_exec(string.Format("INSERT INTO auftrags.teile (teile.ID, teile.T_St_ID) VALUES ({0}, {1})",
                        auf_id, teile_stoff_ID));

                    
                    for (int i = 0; i < lBx_segel.Items.Count; i++)
                    {
                        int segel_ID = ( (Segel)lBx_segel.Items[i]).ID;
                        SQL_methods.SQL_exec(string.Format(
                            "INSERT INTO auftraege_segel (id_auftrag,id_segel) VALUES ({0}, {1})",
                            auf_id, segel_ID));
                    }
                    


                }
                catch (Exception f)
                {
                    MessageBox.Show("Fehler in der SQL Abfrage: \n\n" + f.Message, "Fehler", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                finally
                {
                    MessageBox.Show("Auftrag wurde gespeichert", "Anfrage erfolgreich", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);

                }
            }
        }
        /*
        private void cbx_new_auf_lief_DropDownClosed(object sender, EventArgs e)
        {
            cbx_new_auf_stoff.Enabled = true;
            UC_New_auftrag_fill_cbx_stoff_lief();
        }*/
        /*
        //tets
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


        }*/

        private void UC_New_auftrag_fill_cbx_lief( )
        {
            if (!this.DesignMode)
            {
                try
                {
                    cBx_stoff_hersteller.Items.Clear();

                    DataTable dtLief = SQL_methods.Fill_Box("SELECT L_ID, Lieferant FROM Lieferant WHERE deaktiviert<>true");

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
            }
        }

        private void UC_New_auftrag_fill_cbx_stoff_kennung( )
        {
            if (!this.DesignMode)
            {
                if (cBx_stoff_hersteller.Items.Count > 0)
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

        private void btn_add_segel_Click(object sender, EventArgs e)
        {
            if (!Not_filled(tBx_segel_name) && !Not_filled(cBx_segelform) && !Not_filled(cBx_stoff_hersteller) && !Not_filled(cBx_stoff_kennung))
            {
                SQL_methods.SQL_exec(string.Format("INSERT INTO segel (segel.name,segel.form,segel.stoff_hersteller,segel.stoff_kennung)VALUES ('{0}','{1}',{2},{3})",tBx_segel_name.Text,cBx_segelform.Text,cBx_stoff_hersteller.SelectedValue,cBx_stoff_kennung.SelectedValue));

                string sql = "SELECT * FROM segel ORDER BY segel.id DESC LIMIT 1";
                OdbcCommand cmd = new OdbcCommand(sql, Connection);
                SQL_methods.Open();
                OdbcDataReader sqlReader = cmd.ExecuteReader();
                sqlReader.Read();
                int segel_id = Convert.ToInt32(sqlReader[0]);
                sqlReader.Close();

                Segel segel = new Segel(tBx_segel_name.Text, cBx_segelform.Text, ( int ) cBx_stoff_hersteller.SelectedValue, ( int ) cBx_stoff_kennung.SelectedValue, segel_id);
                lBx_segel.Items.Add(segel);
            }

        }

        private bool Not_filled(TextBox tbx)
        {
            if (tbx == null || tbx.Text == "" || tbx.Text == null)
            {
                MessageBox.Show("Das Feld " + tbx.Name + "ist leer, bitte Korrekte Werte eintragen.", "Warnung", MessageBoxButtons.OK);
                return true;
            }
            return false;
        }

        private bool Not_filled(ComboBox cbx)
        {
            if (cbx == null || cbx.Text == "" || cbx.Text == null)
            {
                MessageBox.Show("Das Feld " + cbx.Name + "ist leer, bitte Korrekte Werte eintragen.", "Warnung", MessageBoxButtons.OK);
                return true;
            }
            return false;
        }

        private void cBx_stoff_hersteller_SelectedIndexChanged(object sender, EventArgs e)
        {
            UC_New_auftrag_fill_cbx_stoff_kennung();
        }
    }

    class Segel
    {
        private string name;
        private string shape;
        private int id_hersteller;
        private int id_stoff;
        private int id;

        public Segel( )
        {
        }

        public Segel(string name_, string shape_, int id_hersteller_, int id_stoff_, int id_)
        {
            ID = id_;
            Name = name_ ?? throw new ArgumentNullException(nameof(name_));
            Shape = shape_ ?? throw new ArgumentNullException(nameof(shape_));
            Id_hersteller = id_hersteller_;
            Id_stoff = id_stoff_;
        }

        public string Name { get => name; set => name = value; }
        public string Shape { get => shape; set => shape = value; }
        public int Id_hersteller { get => id_hersteller; set => id_hersteller = value; }
        public int Id_stoff { get => id_stoff; set => id_stoff = value; }
        public int ID { get => id; set => id = value; }

        public override string ToString( )
        {
            //return Name + ", " + Shape;
            return Name + ", " + Shape + ", " + Id_hersteller.ToString() + ", " +Id_stoff.ToString() + ", " + ID.ToString();
        }
    }
}
