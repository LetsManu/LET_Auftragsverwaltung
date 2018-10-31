using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LET_Auftragsverwaltung
{
    public partial class UC_Main_Task_Pane : UserControl
    {
        public UC_Main_Task_Pane()
        {
            InitializeComponent();
            UC_Connect_Show.tmr_timed = true;
        }

        private void TSMI_Parameter_Click(object sender, EventArgs e)
        {
            UC_Connect_Show.tmr_timed = false;
            Form form_Parameter_ = new Form_Parameter();
            form_Parameter_.Show();
        }

        private void TSMI_Overview_Click(object sender, EventArgs e)
        {
            UC_Connect_Show.tmr_timed = false;
            Form form_Overview = new Form_Overview();
            form_Overview.Show();
            UC_Overview.Update_Overview();
        }

        private void TSMI_new_Auftrag_Click(object sender, EventArgs e)
        {
            UC_Connect_Show.tmr_timed = false;
            Form form_new_Auftrag = new Form_New_Auftrag();
            form_new_Auftrag.Show();
        }

        private void eDITAUFTRAGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pbx_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void UC_Main_Task_Pane_Enter(object sender, EventArgs e)
        {
            UC_Connect_Show.tmr_timed = true;
        }
    }
}
