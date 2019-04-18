using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BrightIdeasSoftware;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Tools;
using Microsoft.Office.Tools.Outlook;
using Microsoft.Office.Tools.Ribbon;

namespace LET_Auftragsverwaltung
{
    public partial class Ribbon_Home
    {

        public static int ID = 0;
        public static bool open_edit_auftrag = false;

        private void Ribbon_Home_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btn_open_Main_Click(object sender, RibbonControlEventArgs e)
        {
        }

        private void tmr_100_Tick(object sender, EventArgs e)
        {
            if (open_edit_auftrag)
            {
                open_edit_auftrag = false;
                Form Form_EDIT = new Form_Edit_Auftrag(ID);
                Form_EDIT.Show();
            }
        }
    }
}
