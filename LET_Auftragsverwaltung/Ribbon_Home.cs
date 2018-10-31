using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace LET_Auftragsverwaltung
{
    public partial class Ribbon_Home
    {
        private void Ribbon_Home_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btn_open_Main_Click(object sender, RibbonControlEventArgs e)
        {
            LET_Auftragsverwaltung.Globals.ThisAddIn.Dispose();
            LET_Auftragsverwaltung.Globals.ThisAddIn.BeginInit();
        } 
    }
}
