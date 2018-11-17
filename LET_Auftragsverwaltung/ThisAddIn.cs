using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Office = Microsoft.Office.Core;
using Outlook = Microsoft.Office.Interop.Outlook;

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

            Named_Pipes.Start();
        }

        public void UC_Main_Task_Pane_Send(string betreff, string subjekt)
        {
            string subjectEmail = betreff;
            string bodyEmail = subjekt;

            this.UC_Main_Task_Pane_Create(subjectEmail, bodyEmail);

        }

        private void UC_Main_Task_Pane_Create(string subjectEmail, string bodyEmail)
        {
            Outlook.MailItem eMail = ( Outlook.MailItem )
                this.Application.CreateItem(Outlook.OlItemType.olMailItem);
            eMail.Subject = subjectEmail;
            eMail.To = "felix.lerchner@icloud.com";
            eMail.Body = bodyEmail;
            eMail.Importance = Outlook.OlImportance.olImportanceLow;
            ( ( Outlook._MailItem ) eMail ).Send();
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
        private void InternalStartup( )
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion
    }
}
