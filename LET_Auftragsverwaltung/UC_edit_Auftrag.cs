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
     

    //TODO ObjectListView ID 


        public partial class UC_edit_Auftrag : UserControl
    {
        private OdbcConnection connection = null;

        private OdbcConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    string constrg =
                        "Driver={MySQL ODBC 5.3 Unicode Driver};Server=192.168.16.192;Database=auftrags;User=admin;Password=cola0815;Option=3;";
                    connection = new OdbcConnection(constrg);
                }

                return connection;
            }
        }

        private int test_ID = 18;
        public UC_edit_Auftrag()
        {
            InitializeComponent();
        }

        private void UC_edit_Auftrag_Load(object sender, EventArgs e)
        {
            #region FillKlassen

            UC_edit_Auftrag_fill_cbx_status();
            UC_Edit_Auftrag_fill_cbx_verant();
            UC_Editt_auftrag_fill_cbx_tech();

            #endregion


            string sql = "SELECT * FROM auftraege WHERE id = " + test_ID;
            OdbcCommand cmd = new OdbcCommand(sql, Connection);
            Connection.Open();
            OdbcDataReader sqlReader = cmd.ExecuteReader();
            sqlReader.Read();

            txt_auftrag_nr.Text = (string)sqlReader[1];
            cbx_auftragsstatus.SelectedValue = sqlReader[2];
            date_erstell.Value = Convert.ToDateTime(sqlReader[3]);
            cbx_verant.SelectedValue = sqlReader[6];
            cbx_tech.SelectedValue = sqlReader[7];

            Connection.Close();
            
        }

        #region Definition Fill Klassen

        private void UC_edit_Auftrag_fill_cbx_status()
        {

            try
            {
                OdbcConnection connection = Connection;
                connection.Open();
                string sql = "SELECT F_ID, Status FROM fertigungsstatus WHERE deaktiviert<>true";
                OdbcDataAdapter dc = new OdbcDataAdapter(sql, connection);
                DataTable dtStatus = new DataTable();
                dc.Fill(dtStatus);
                connection.Close();


                cbx_auftragsstatus.DataSource = dtStatus;
                cbx_auftragsstatus.ValueMember = "F_ID";
                cbx_auftragsstatus.DisplayMember = "Status";


                if (cbx_auftragsstatus.Items.Count > 0) cbx_auftragsstatus.SelectedIndex = 0;
            }
            catch (Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage(Edit Auftrag: Fill CBX Status): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UC_Edit_Auftrag_fill_cbx_verant() { 
            try
            {
                OdbcConnection connection = Connection;
                connection.Open();
                string sql = "SELECT DISTINCT CONCAT(p.`Nachname`, ' ', p.`Vorname`) AS 'Name', p.P_ID FROM personal p LEFT JOIN personal_funktion pf ON p.P_ID = pf.P_ID WHERE pf.Funktion_ID = 4";
                OdbcDataAdapter dc = new OdbcDataAdapter(sql, connection);
                DataTable dtVerant = new DataTable();
                dc.Fill(dtVerant);
                connection.Close();


                cbx_verant.DataSource = dtVerant;
                cbx_verant.ValueMember = "P_ID";
                cbx_verant.DisplayMember = "Name";


                if (cbx_verant.Items.Count > 0) cbx_verant.SelectedIndex = 0;
            }
            catch (Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage(Edit Auftrag: Fill CBX Verant): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UC_Editt_auftrag_fill_cbx_tech()
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
                MessageBox.Show("Fehler in der SQL Abfrage(Edit Auftrag: Fill CBX Techniker): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        private void btn_edit_infos_Click(object sender, EventArgs e)
        {

        }
        
    }
}
