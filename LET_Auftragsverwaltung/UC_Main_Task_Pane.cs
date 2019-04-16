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
    public partial class UC_Main_Task_Pane : UserControl
    {
        public UC_Main_Task_Pane( )
        {
            InitializeComponent();
        }

        private void TSMI_Overview_Click(object sender, EventArgs e)
        {
            if (Form_Overview.isopen)
            {
                Form_Overview.tofront = true;
            }
            else
            {
                Form form_Overview = new Form_Overview();
                form_Overview.Show();
                UC_Overview.Update_Overview();
            }
        }



        private void TSMI_DB_Click(object sender, EventArgs e)
        {
            Form form_DB = new Form_DB();
            form_DB.Show();
        }

        private void TSMI_new_Auftrag_Click(object sender, EventArgs e)
        {
            Form form_new_Auftrag = new Form_New_Auftrag();
            form_new_Auftrag.Show();
        }
    }
}