using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LET_URL_Client
{
    class Program
    {
        static void Main(string[ ] args)
        {
            //Edit_Auftrag;ID:;6;LET_SPACE;LET_ENDE

            //Client
            var client = new NamedPipeClientStream("LET_Auftragsverwaltung_outlook_Pipe");
            client.Connect();

            if (client.IsConnected)
            {
                StreamReader reader = new StreamReader(client);
                StreamWriter writer = new StreamWriter(client);

                writer.WriteLine("Edit_Auftrag;ID:;" + args[0].Replace("ID-","") + ";LET_SPACE;LET_ENDE");
                writer.Flush();
                Console.WriteLine(reader.ReadLine());
            }
            else
            {
                Console.WriteLine("Outlook oder das LET Auftragsverwaltungs addin ist nicht gestartet. \nWenn dies nicht der Fall ist Outlook neustarten. \nBei Wiederholung Programmierer hinzuholen.\n\n\nDieses Fenster kann geschlossen werden.\nEine Taste drücken um zu Beenden.");
                Console.ReadKey();
            }
        }
    }
}
