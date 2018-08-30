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
        }

        private void UC_New_auftrag_fill_cbx_verant()
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


                cbx_verant.DataSource = dtPer;
                cbx_verant.ValueMember = "P_ID";
                cbx_verant.DisplayMember = "Nachname";


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
                
                string sql_funk = "SELECT Funktion_ID FROM funktion WHERE Funktion='Planer' OR Funktion='Techniker'";
                
                OdbcCommand cmd = new OdbcCommand(sql_funk, connection);
                OdbcCommand cmd_pers_funk;
                OdbcCommand cmd_pers;
                connection.Open();
                OdbcDataReader sqlReader = cmd.ExecuteReader();
                OdbcDataReader sqlReader_pers_funk;
                OdbcDataReader sqlReader_pers;

                DataTable dt = new DataTable("personal");
                dt.Columns.Add("Nachname", typeof(string));
                dt.Columns.Add("P_ID", typeof(int));
                DataRow pers_row;
                List<int> funk = new List<int>();
                List<int> pers= new List<int>();
                int controll_list = 0;

                while (sqlReader.Read())
                {
                    funk.Add((int)sqlReader[0]);
                }
                sqlReader.Close();

                for (int i = 0; i<=funk.Count-1; i++)
                {
                    string sql_pers_funk =
                        string.Format(
                            "SELECT P_ID FROM personal_funktion WHERE Funktion_ID = {0}",funk[i]);
                    cmd_pers_funk = new OdbcCommand(sql_pers_funk, connection);
                    sqlReader_pers_funk = cmd_pers_funk.ExecuteReader();
                    sqlReader_pers_funk.Read();
                    pers.Add((int)sqlReader_pers_funk[0]);
                    while (sqlReader_pers_funk.Read())
                    {
                        for (int j = 0; j <= pers.Count - 1; j++)
                        {
                            if ((int)sqlReader_pers_funk[0] != pers[j])
                            {
                                pers.Add((int)sqlReader_pers_funk[0]);
                            }
                        }
                    }

                    for (int j = 0; j <= pers.Count - 1; j++)
                    {
                        string sql_pers = string.Format("SELECT P_ID,Nachname FROM personal WHERE P_ID = {0}",
                            (int) pers[j]);
                        cmd_pers = new OdbcCommand(sql_pers, connection);
                        sqlReader_pers = cmd_pers.ExecuteReader();
                        
                        if (dt.Rows.Count == 0)
                        {
                            sqlReader_pers.Read();
                            pers_row = dt.NewRow();
                            pers_row["Nachname"] = sqlReader_pers[1];
                            pers_row["P_ID"] = sqlReader_pers[0];
                            dt.Rows.Add(pers_row);
                        }
                        else
                        {
                            sqlReader_pers.Read();
                            controll_list = 1;
                        }

                        if (controll_list == 1)
                        {
                            
                                    pers_row = dt.NewRow();
                                    pers_row["Nachname"] = sqlReader_pers[1];
                                    pers_row["P_ID"] = sqlReader_pers[0];
                                    dt.Rows.Add(pers_row);
                                
                            }
                        

                        sqlReader_pers.Close();
                    }
                }
                

                connection.Close();


                cbx_tech.DataSource = dt;
                cbx_tech.ValueMember = "P_ID";
                cbx_tech.DisplayMember = "Nachname";


                if (cbx_verant.Items.Count > 0) cbx_verant.SelectedIndex = 0;
            }
            catch (Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage(Neue Auftrag: Fill CBX Techniker): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
