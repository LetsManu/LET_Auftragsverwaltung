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
    public partial class UC_Best : UserControl
    {

        int a_id = 0;

        public UC_Best(int a_ID_)
        {
            a_id = a_ID_;

            InitializeComponent();
            UC_Best_Check();

        }

        private void UC_Best_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {

            }
        }

        private void btn_best_auf_Click(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                SQL_methods.SQL_exec("UPDATE ab_az SET V_Best = 1 WHERE A_ID = " + a_id);
                UC_Best_Check();
                
            }
        }

        private void btn_best_anz_Click(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                SQL_methods.SQL_exec("UPDATE ab_az SET B_Best = 1 WHERE A_ID = " + a_id);
                UC_Best_Check();
            }
        }
        private void btn_best_schl_Click(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                SQL_methods.SQL_exec("UPDATE ab_az SET S_Best = 1 WHERE A_ID = " + a_id);
                UC_Best_Check();
            }
        }


        private void UC_Best_Check()
        {
            if (!this.DesignMode)
            {
                bool check = false;

                string sql = string.Format("SELECT V_Best FROM ab_az WHERE A_ID = " + a_id);

                OdbcConnection con = DB.Connection;

                OdbcCommand cmd = new OdbcCommand(sql, con);

                SQL_methods.Open();

                OdbcDataReader sql_reader = cmd.ExecuteReader();

                sql_reader.Read();

                check = Convert.ToBoolean(sql_reader[0]);

                sql_reader.Close();

                

                if (check)
                {
                    txt_best_auf.Visible = true;
                    btn_best_auf.Enabled = false;
                }

                sql = string.Format("SELECT B_Best FROM ab_az WHERE A_ID = " + a_id);

                cmd = new OdbcCommand(sql, con);

                SQL_methods.Open();

                sql_reader = cmd.ExecuteReader();

                sql_reader.Read();

                check = Convert.ToBoolean(sql_reader[0]);

                sql_reader.Close();

                

                if (check)
                {
                    txt_best_anz.Visible = true;
                    btn_best_anz.Enabled = false;
                }

                sql = string.Format("SELECT S_Best FROM ab_az WHERE A_ID = " + a_id);

                cmd = new OdbcCommand(sql, con);

                SQL_methods.Open();

                sql_reader = cmd.ExecuteReader();

                sql_reader.Read();

                check = Convert.ToBoolean(sql_reader[0]);

                sql_reader.Close();

                

                if (check)
                {
                    txt_best_schl.Visible = true;
                    btn_best_schl.Enabled = false;
                }
            }
        }
    }
}
