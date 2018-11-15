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
        public static bool tofront;
        public static bool isopen = false;

        public Form_Overview( )
        {
            InitializeComponent();
            this.KeyPreview = true;
            isopen = true;
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

        private void tmr_100ms_Tick(object sender, EventArgs e)
        {
            //TODO Remove this timer in favour of making the whole form static so you can call Bring to front directly
            if (tofront)
            {
                tofront = false;
                this.BringToFront();
            }
        }

        private void Form_Overview_FormClosing(object sender, FormClosingEventArgs e)
        {
            isopen = false;
        }
    }
}
