using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LET_Auftragsverwaltung
{
    class FTP
    {
        private static bool Is_this_mb = "M80-AC016500071" == System_Info.GetMotherBoardID();
        internal static string[] extensions = {"PNG", "JPG", "TIFF", "GIF"};


        public static string Pw => "cola0815";
        public static string User => "Auftragsuebersicht";
        public static string[] Extensions => extensions;

        public static string Server_IP
        {
            get
            {
                if (Is_this_mb) return "localhost";
                return "81.10.155.134:815";
            }
        }

    }
}
