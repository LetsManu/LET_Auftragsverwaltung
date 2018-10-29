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

        private static string Connectionstring
        {
            get
            {
                return $"Driver={"MySQL ODBC 5.3 Unicode Driver"};Server={Server_IP};Port={Port};Database={Database};User={Login_name};Password={Login_pw};Option=3;";
            }
        }
        
        public static OdbcConnection Connection
        {
            get { return connection ?? (connection = new OdbcConnection(Connectionstring)); }
        }

        private static string Login_name
        {
            get { return "root"; }
        }
        private static string Login_pw
        {
            get { return "cola0815"; }
        }
        private static string Server_IP
        {
            get { return "81.10.155.134"; }
        }
        private static string Database
        {
            get { return "auftrags"; }
        }
        private static string Port
        {
            get { return "1337"; }
        }
    }
}
