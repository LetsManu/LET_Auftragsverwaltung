﻿using System;
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
    }
}
