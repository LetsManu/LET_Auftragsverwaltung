using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Odbc;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace LET_Auftragsverwaltung
{
    class CS_DB
    {
        private static string login_name = "";
        private static string login_pw = "";
        private static string server_IP = "";
        private static string database = "";
        private static string port = "";
        private static OdbcConnection connection = null;
        private static bool Is_this_mb = "M80-AC016500071" == CS_System_Info.GetMotherBoardID();

        private static string Connectionstring => $"Driver={"MySQL ODBC 5.3 Unicode Driver"};Server={Server_IP};Port={Port};Database={Database};User={Login_name};Password={Login_pw};Option=3;";

        public static OdbcConnection Connection => connection ?? (connection = new OdbcConnection(Connectionstring));

        private static string Login_name => "root";

        private static string Login_pw => "cola0815";

        private static string Database => "auftrags";

        private static string Server_IP
        {
            get
            {
                if (Is_this_mb) return "localhost";
                else return "81.10.155.134";
            }
        }
        
        private static string Port
        {
            get
            {
                if (Is_this_mb) return "3306";
                else return "1337";
            }
        }
    }
}
