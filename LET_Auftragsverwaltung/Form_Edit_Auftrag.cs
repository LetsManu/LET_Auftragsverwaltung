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

            if (!this.DesignMode)
            {

                this.BringToFront();

                Load_title();
            }
        }

        public void Load_title()
        {
            SQL_methods.Open();
            string sql = "SELECT CONCAT(CONCAT(CONCAT(fertigungsstatus.Status, ' | '), auftraege.Projektbezeichnung, ' | '), auftraege.Auftrags_NR) AS title FROM auftraege LEFT JOIN fertigungsstatus ON auftraege.Fertigungsstatus = fertigungsstatus.F_ID WHERE auftraege.id = " + id;
            OdbcCommand cmd = new OdbcCommand(sql, DB.Connection);
            OdbcDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                this.Text = Convert.ToString(reader[0]);
            }
        }

        private void Form_Edit_Auftrag_Leave(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                UC_Overview.Update_Overview();
            }
        }
    }
}
