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
    public partial class Form_Overview : Form
    {
        public Form_Overview( )
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        

        private void Form_Overview_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                UC_Overview.Update_Overview();
                e.Handled = true;//Event nicht an andere Controls weiter leiten.
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            this.uC_Overview1.Print_OLV();
        }
    }
}
