using Microsoft.Office.Interop.Outlook;

namespace LET_Auftragsverwaltung
{
    class CS_Email
    {
        public static void Send_Mail(string to, string subject, string body)
        {
            MailItem eMail = ( MailItem ) Globals.ThisAddIn.Application.CreateItem(OlItemType.olMailItem);

            eMail.Subject = subject;
            eMail.To = to;
            eMail.Body = body;
            eMail.Importance = OlImportance.olImportanceHigh;
            eMail.Send();
        }

        /// <summary>
        /// Sends Emails with exactly the same content to different email addresses without all email addresses in the same CC Field (meets the DSGVO) 
        /// </summary>
        /// <param name="tos">all emails in one string array</param>
        /// https://english.stackexchange.com/questions/154563/what-is-the-plural-of-how-to
        /// <param name="subject"></param>
        /// <param name="body"></param>
        public static void Send_Mail(string[] tos, string subject, string body)
        {
            foreach (var to in tos)
            {
                Send_Mail(to,subject,body);
            }
        }
    }
}
