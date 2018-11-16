using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace LET_Auftragsverwaltung
{
    static class CS_Named_Pipes
    {
        public static void Start( )
        {
            Task.Factory.StartNew(( ) =>
            {
                StreamReader reader;
                StreamWriter writer;
                while (true)
                {
                    var server = new NamedPipeServerStream("LET_Auftragsverwaltung_outlook_Pipe");
                    server.WaitForConnection();
                    reader = new StreamReader(server);
                    writer = new StreamWriter(server);
                    while (server.IsConnected)
                    {
                        var line = reader.ReadLine();
                        if (line != null)
                        {
                            writer.WriteLine("Thank ya, you are our man!");
                            writer.Flush();
                        }
                    }
                    server.Dispose();
                }
            });
        }
    }
}
