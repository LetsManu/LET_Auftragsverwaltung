using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LET_URL_Client
{
    class Program
    {
        static void Main(string[ ] args)
        {
            //Edit_Auftrag;ID:;6;LET_SPACE;LET_ENDE
            ThreadStart childref = new ThreadStart(Timout);
            Thread childThread = new Thread(childref);
            childThread.Start();
            //Client
            var client = new NamedPipeClientStream("LET_Auftragsverwaltung_outlook_Pipe");
            client.Connect();

            if (client.IsConnected)
            {
                StreamReader reader = new StreamReader(client);
                StreamWriter writer = new StreamWriter(client);
                writer.WriteLine("Edit_Auftrag;ID:;" + args[0].ToLower().Replace("leturl:id-","") + ";LET_SPACE;LET_ENDE");
                writer.Flush();
                Console.WriteLine(reader.ReadLine());
            }
            else
            {
                Console.WriteLine("Outlook oder das LET Auftragsverwaltungs addin ist nicht gestartet. \nWenn dies nicht der Fall ist Outlook neustarten. \nBei Wiederholung Programmierer hinzuholen.\n\n\nDieses Fenster kann geschlossen werden.\nEine Taste drücken um zu Beenden.");
                Console.ReadKey();
            }
        }

        static void Timout()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Outlook oder das LET Auftragsverwaltungs addin ist nicht gestartet. \nWenn dies nicht der Fall ist Outlook neustarten. \nBei Wiederholung Programmierer hinzuholen.\n\n\nDieses Fenster kann geschlossen werden.\nEine Taste drücken um zu Beenden.");
            Thread.Sleep(15000);
            Environment.Exit(1);


            //TODO add messageboxen
        }
    }
}
