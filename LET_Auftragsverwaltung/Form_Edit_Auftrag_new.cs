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
    public partial class Form_Edit_Auftrag_new : Form
    {
        private int id = 0;
        private bool is_startup = false;    //used for some cbx's. so their selectedindex Methode does not get triggered (or rather the code which would get executed)
        private OdbcConnection Connection
        {
            get
            {
                return DB.Connection;

            }
        }
        public Form_Edit_Auftrag_new(int id_)
        {
            id = id_;
            InitializeComponent();
        }

        #region Definition Fill Klassen

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
        #endregion

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
                    Form_Edit_Auftrag_new_Load(sender, e);//DESIGN That even working?
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
    }
}
