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
    public partial class Form_Edit_Auftrag : Form
    {
        private int id;
        public Form_Edit_Auftrag(int id_)
        {
            id = id_;

            InitializeComponent();

            this.BringToFront();

            SQL_methods.Open();
            string sql = "SELECT concat(concat(auftraege.Auftrags_NR, ', '), auftraege.Projektbezeichnung) AS title FROM auftraege WHERE auftraege.id = " + id;
            OdbcCommand cmd = new OdbcCommand(sql, DB.Connection);
            OdbcDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                this.Text = Convert.ToString(reader[0]);
            }
        }

        private void Form_Edit_Auftrag_Leave(object sender, EventArgs e)
        {
            UC_Overview.Update_Overview();
        }
    }
}
