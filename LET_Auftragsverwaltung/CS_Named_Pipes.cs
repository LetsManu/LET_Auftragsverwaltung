using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace LET_Auftragsverwaltung
{
    static class Named_Pipes
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
                            var split_line = line.Split(';');
                            switch (split_line[0])
                            {
                                case "Edit_Auftrag":
                                    if (split_line.Last() == "LET_ENDE")    //All ifs are to ensure the string comes from an safe source (at least somewhat safe...)
                                    {
                                        if (split_line[3] == "LET_SPACE")
                                        {
                                            if (split_line[1] == "ID:")
                                            {
                                                if (Int32.TryParse(split_line[2], out int num))
                                                {
                                                    Ribbon_Home.ID = num;
                                                    Ribbon_Home.open_edit_auftrag = true;
                                                }
                                            }
                                        }
                                    }
                                    break;
                                default:

                                    break;
                            }
                        }
                    }
                    server.Dispose();
                }
            });
        }
    }
}
