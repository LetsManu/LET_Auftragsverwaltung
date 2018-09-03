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

            catch(Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage(Neue Auftrag: Fill CBX Auftragsart): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

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
            lbx_auftrag.Items.Add(cbx_auftrag.SelectedItem);
        }
    }
}
