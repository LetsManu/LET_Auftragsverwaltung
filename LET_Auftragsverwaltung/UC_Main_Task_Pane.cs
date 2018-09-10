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
        }

        private void neuerEintragToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form Form_Para = new Form_Parameter();
            Form_Para.Show();
        }

        private void aufträgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form_Over = new Form_Overview();
            Form_Over.Show();
        }

        private void neuerAuftragToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form_NEW = new Form_New_Auftrag();
            Form_NEW.Show();
        }

        private void eDITAUFTRAGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form_EDIT = new Form_Edit_Auftrag(1);
            Form_EDIT.Show();
        }
    }
}
