using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LET_Auftragsverwaltung
{
    public partial class Form_parameter : Form
    {
        public Form_parameter()
        {
            InitializeComponent();
            Fill_Database_tBx_thingys();

        }

        //Lerchner Felix
        private void Fill_Database_tBx_thingys()
        {
            tBx_DB_Name.Text = Properties.Settings.Default.Database_Name;
            tBx_IP.Text = Properties.Settings.Default.Database_IP;
            tBx_Port.Text = Properties.Settings.Default.Database_Port;
            tBx_Login_Name.Text = Properties.Settings.Default.Database_Login_Name;
            tBx_Login_Password.Text = Properties.Settings.Default.Database_Login_Password;
        }

        //Lerchner Felix
        private void btn_save_DB_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Database_Name = tBx_DB_Name.Text;
            Properties.Settings.Default.Database_IP = tBx_IP.Text;
            Properties.Settings.Default.Database_Port = tBx_Port.Text;
            Properties.Settings.Default.Database_Login_Name = tBx_Login_Name.Text;
            Properties.Settings.Default.Database_Login_Password = tBx_Login_Password.Text;
            Properties.Settings.Default.Save();
        }

        //Lerchner Felix
        private void btn_resett_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wüst du wiakle de Datenbank Daten wiakle zrucksetzen?", "Warnung", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Properties.Settings.Default.Database_Name = "auftrags";
                Properties.Settings.Default.Database_IP = "192.168.16.158";
                Properties.Settings.Default.Database_Port = "3306";
                Properties.Settings.Default.Database_Login_Name = "auftragsverwaltung";
                Properties.Settings.Default.Database_Login_Password = "aSd89+=pÜ";

                Fill_Database_tBx_thingys();
            }
        }

        //Lerchner Felix
        private void btn_check_connection_Click(object sender, EventArgs e)
        {
            DB.Give_login_Data_pls_thx(Properties.Settings.Default.Database_Name, Properties.Settings.Default.Database_IP, Properties.Settings.Default.Database_Port, Properties.Settings.Default.Database_Login_Name, Properties.Settings.Default.Database_Login_Password);
            try
            {
                SQL_methods.Open();
                MessageBox.Show("You did it\nit works\nlol", "Congrats", MessageBoxButtons.OK);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Something did not work\nSome informatione (I hope it can help):" + exception.Message, "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
