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

                MessageBox.Show("Funktion wurde gespeichter", "Speicherung erfolgreich", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }



        }

        private void UC_Parameter_Load(object sender, EventArgs e)
        {
            UC_Parameter_cbx_funk_fill();
            UC_Parameter_cbx_art_fill();
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

                
                
                cbx_funk.DataSource = dtFunkt;
                cbx_funk.DisplayMember = "Funktion";
                cbx_funk.ValueMember = "Funktion_ID";
                if(cbx_funk.Items.Count>0)cbx_funk.SelectedIndex = 0;
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
                OdbcDataAdapter da = new OdbcDataAdapter(sql, connection);
                DataTable dtArt = new DataTable();
                da.Fill(dtArt);
                connection.Close();



                cbx_funk.DataSource = dtArt;
                cbx_funk.DisplayMember = "Art";
                cbx_funk.ValueMember = "Art_ID";
                if (cbx_auf.Items.Count > 0) cbx_auf.SelectedIndex = 0;
            }
            catch (Exception f)
            {
                MessageBox.Show("Fehler in der SQL Abfrage(art): \n\n" + f.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_auf_new_Click(object sender, EventArgs e)
        {
            try
            {
                OdbcConnection connection = Connection;
                connection.Open();
                string sql = string.Format("INSERT INTO auftragsart (Art) VALUES ('{0}')", txt_funk_new.Text);
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

                MessageBox.Show("Funktion wurde gespeichter", "Speicherung erfolgreich", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }


        }

        private void cbx_funk_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_funk_re_TextChanged(object sender, EventArgs e)
        {

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
                UC_Parameter_cbx_art_fill();
                

                MessageBox.Show("Funktion wurde geändert", "Änderung erfolgreich", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

        }

        private void btn_auf_change_Click(object sender, EventArgs e)
        {
            try
            {
                OdbcConnection connection = Connection;
                connection.Open();
                string sql = string.Format("UPDATE auftragsart SET deaktiviert = {0}, art = '{1}' WHERE Funktion_ID = {2}", box_auf_dec.Checked, txt_auf_re.Text, cbx_auf.SelectedValue);
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

        }
    }
}
