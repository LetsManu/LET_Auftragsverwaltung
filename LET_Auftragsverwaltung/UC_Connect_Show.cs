using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LET_Auftragsverwaltung
{
    public partial class UC_Connect_Show : UserControl
    {
        private OdbcConnection Connection => CS_DB.Connection;
        Brush b_mysql = Brushes.Green;
        Brush b_ftp = Brushes.Green;
        public UC_Connect_Show()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbx_mysql_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(b_mysql, new Rectangle(25, 25, 7, 7));
            
        }

        private void pbx_ftp_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Green, new Rectangle(25, 25, 7, 7));
        }



        private void tmr_Tick(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT COUNT(ID) FROM auftraege WHERE ID > 0";
                OdbcCommand cmd = new OdbcCommand(sql, Connection);
                Connection.Open();
                if (!cmd.ExecuteNonQuery().Equals(0))
                {
                    b_mysql = Brushes.Green;
                }

                Connection.Close();
            }
            catch
            {
                b_mysql = Brushes.Red;
            }

            try
            {
                FtpWebRequest request = null;

                request = (FtpWebRequest)WebRequest.Create("ftp://" + "81.10.155.134" + " / ");
                request.Credentials = new NetworkCredential("admin", "cola0815");
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    b_ftp = Brushes.Green;
                }
            }
            catch (WebException ex)
            {
                b_ftp = Brushes.Red;
            }
            pbx_mysql.Invalidate();
            pbx_ftp.Invalidate();
        }

        private void UC_Connect_Show_Enter(object sender, EventArgs e)
        {
            tmr.Enabled = true;
        }
    }
}
