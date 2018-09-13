using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Security.Cryptography;
using Office = Microsoft.Office.Core;
using Outlook = Microsoft.Office.Interop.Outlook;
using Exception = System.Exception;


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

        public UC_edit_Auftrag()
        {
            InitializeComponent();
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

                #endregion


                string sql = "SELECT * FROM auftraege WHERE id = " + id;
                OdbcCommand cmd = new OdbcCommand(sql, Connection);
                Connection.Open();
                OdbcDataReader sqlReader = cmd.ExecuteReader();
                sqlReader.Read();

                txt_auftrag_nr.Text = (string)sqlReader[1];
                cbx_auftragsstatus.SelectedValue = sqlReader[2];
                date_erstell.Value = Convert.ToDateTime(sqlReader[3]);
                cbx_verant.SelectedValue = sqlReader[6];
                cbx_tech.SelectedValue = sqlReader[7];
                txt_auf_proj_ken.Text = (string)sqlReader[8];
                date_mont.Value = Convert.ToDateTime(sqlReader[10]);
                txt_info_kauf.Text = (string)sqlReader[11];
                txt_info_tech.Text = (string)sqlReader[12];



                Connection.Close();
            }
        }

        #region Definition Fill Klassen

        private void UC_edit_Auftrag_fill_cbx_status()
        {
            if (!this.DesignMode)
            {
                try
                {

                    Connection.Open();
                    string sql = "SELECT F_ID, Status FROM fertigungsstatus WHERE deaktiviert<>true";
                    OdbcDataAdapter dc = new OdbcDataAdapter(sql, Connection);
                    DataTable dtStatus = new DataTable();
                    dc.Fill(dtStatus);
                    Connection.Close();


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

        private void UC_Edit_Auftrag_fill_cbx_verant()
        {
            if (!this.DesignMode)
            {
                try
                {

                    Connection.Open();
                    string sql = "SELECT DISTINCT CONCAT(p.`Nachname`, ' ', p.`Vorname`) AS 'Name', p.P_ID FROM personal p LEFT JOIN personal_funktion pf ON p.P_ID = pf.P_ID WHERE pf.Funktion_ID = 4";
                    OdbcDataAdapter dc = new OdbcDataAdapter(sql, Connection);
                    DataTable dtVerant = new DataTable();
                    dc.Fill(dtVerant);
                    Connection.Close();


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

                    Connection.Open();
                    string sql = "SELECT DISTINCT CONCAT(p.`Nachname`, ' ', p.`Vorname`) AS 'Name', p.P_ID FROM personal p LEFT JOIN personal_funktion pf ON p.P_ID = pf.P_ID WHERE pf.Funktion_ID = 1 OR pf.Funktion_ID = 2";
                    OdbcDataAdapter db = new OdbcDataAdapter(sql, Connection);
                    DataTable dt = new DataTable();
                    db.Fill(dt);
                    Connection.Close();

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

        private void UC_Edit_Auftrag_fill_lbx_auftrag()
        {
            if (!this.DesignMode)
            {
                try
                {

                    Connection.Open();
                    string sql = string.Format("SELECT auftragsart.Art_ID, auftragsart.`Art` FROM auftraege Inner JOIN auftraege_auftragsart ON auftraege.ID = auftraege_auftragsart.ID Inner JOIN auftragsart ON auftraege_auftragsart.Art_ID=auftragsart.Art_ID WHERE auftraege.ID = {0}", id);
                    OdbcDataAdapter db = new OdbcDataAdapter(sql, Connection);
                    DataTable dt = new DataTable();
                    db.Fill(dt);
                    Connection.Close();

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
                    Connection.Close();
                    MessageBox.Show("Fehler in der SQL Abfrage(Edit Auftrag: Fill LBX Auftrag): \n\n" + f.Message + "\n\n" + f.Data.Values.ToString(), "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void UC_Edit_Auftrag_fill_cbx_art()
        {
            if (!this.DesignMode)
            {
                try
                {

                    Connection.Open();
                    string sql = "SELECT Art_ID,Art FROM auftragsart WHERE deaktiviert<>true";
                    OdbcDataAdapter db = new OdbcDataAdapter(sql, Connection);
                    DataTable dtArt = new DataTable();
                    db.Fill(dtArt);
                    Connection.Close();



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

        private void UC_edit_auftrag_fill_cbx_lief()
        {
            if (!this.DesignMode)
            {
                try
                {

                    Connection.Open();
                    string sql = "SELECT L_ID, Lieferant FROM Lieferant WHERE deaktiviert<>true";
                    OdbcDataAdapter dc = new OdbcDataAdapter(sql, Connection);
                    DataTable dtLief = new DataTable();
                    dc.Fill(dtLief);
                    Connection.Close();


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

        private void UC_Edit_Auftrag_fill_lbx_stoff()
        {
            if (!this.DesignMode)
            {
                try
                {

                    Connection.Open();
                    string sql = string.Format("SELECT stoff.`ST_ID`,stoff.`Stoff` FROM auftraege INNER JOIN teile ON auftraege.`ID` = teile.`ID` INNER JOIN teile_stoff ON teile.`T_St_ID` = teile_stoff.`T_St_ID` INNER JOIN stoff ON teile_stoff.`ST_ID` = stoff.`ST_ID` WHERE auftraege.ID = 1", id);
                    OdbcDataAdapter db = new OdbcDataAdapter(sql, Connection);
                    DataTable dt = new DataTable();
                    db.Fill(dt);
                    Connection.Close();

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
                    Connection.Close();
                    MessageBox.Show("Fehler in der SQL Abfrage(Edit Auftrag: Fill LBX Auftrag): \n\n" + f.Message + "\n\n" + f.Data.Values.ToString(), "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void UC_New_auftrag_fill_cbx_stoff_lief()
        {
            if (!this.DesignMode)
            {
                if (cbx_edit_auf_lief.Items.Count > 0)
                {
                    try
                    {

                        Connection.Open();
                        string sql =
                            string.Format("SELECT stoff.ST_ID,stoff.`Stoff` FROM stoff INNER JOIN stoff_lieferant ON stoff.ST_ID = stoff_lieferant.ST_ID WHERE stoff_lieferant.L_ID = {0}", cbx_edit_auf_lief.SelectedValue);
                        OdbcDataAdapter dc = new OdbcDataAdapter(sql, Connection);
                        DataTable dtStoff = new DataTable();
                        dc.Fill(dtStoff);
                        Connection.Close();


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
                        Connection.Close();
                    }
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
                    string sql = string.Format(
                        "UPDATE auftraege SET Auftrags_NR = '{0}', Fertigungsstatus = {1}, Projektverantwortlicher = {2}, Planer_Techniker = {3}, Projektbezeichnung = '{4}', Montage_Datum  = '{5}', Notitz_Kauf = '{6}', Notitz_Tech = '{7}', Erstelldatum = '{8}' WHERE ID = {9}",
                        txt_auftrag_nr.Text, cbx_auftragsstatus.SelectedValue, cbx_verant.SelectedValue,
                        cbx_tech.SelectedValue,
                        txt_auf_proj_ken.Text, date_mont.Value.ToString("yyyy-MM-dd"), txt_info_kauf.Text,
                        txt_info_tech.Text, date_erstell.Value.ToString("yyyy-MM-dd"), id);
                    Connection.Open();
                    OdbcCommand cmd = new OdbcCommand(sql, Connection);
                    cmd.ExecuteNonQuery();
                    Connection.Close();
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
                    string sql = string.Format("DELETE FROM  auftraege_auftragsart WHERE ID = {0} AND Art_ID = {1}",
                        id,
                        (int)lbx_auftrag.SelectedValue);
                    OdbcCommand cmd = new OdbcCommand(sql, Connection);
                    Connection.Open();
                    cmd.ExecuteNonQuery();
                    Connection.Close();
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
                    string sql = string.Format("INSERT INTO auftraege_auftragsart (ID, Art_ID) VALUES ({0}, {1})",
                        id,
                        (int)cbx_auftrag.SelectedValue);
                    OdbcCommand cmd = new OdbcCommand(sql, Connection);
                    Connection.Open();
                    cmd.ExecuteNonQuery();
                    Connection.Close();
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
                    string sql = string.Format("INSERT INTO auftraege_auftragsart (ID, Art_ID) VALUES ({0}, {1})",
                        id,
                        (int)cbx_edit_auf_stoff.SelectedValue);
                    OdbcCommand cmd = new OdbcCommand(sql, Connection);
                    Connection.Open();
                    cmd.ExecuteNonQuery();
                    Connection.Close();
                    UC_Edit_Auftrag_fill_lbx_auftrag();
                }
                catch (Exception f)
                {
                    MessageBox.Show("Fehler in der SQL Abfrage(Edit Auftrag: INSERT LBX Auftrag Auftragsart): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
