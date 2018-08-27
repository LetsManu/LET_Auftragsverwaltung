 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;

namespace LET_Auftragsverwaltung
{
    public partial class ThisAddIn
    {
        private UC_Main_Task_Pane uC_Main_Task_Pane;
        private Microsoft.Office.Tools.CustomTaskPane CTP_Main;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            uC_Main_Task_Pane = new UC_Main_Task_Pane();
            CTP_Main = this.CustomTaskPanes.Add(uC_Main_Task_Pane, "Aufträge:");
            CTP_Main.Visible = true;
            CTP_Main.Width = 400;
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // Note: Outlook no longer raises this event. If you have code that 
            //    must run when Outlook shuts down, see https://go.microsoft.com/fwlink/?LinkId=506785
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
