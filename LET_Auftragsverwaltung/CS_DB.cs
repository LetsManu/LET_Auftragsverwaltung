using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LET_Auftragsverwaltung

//TODO konfigurieren datei machen
{
    public static class DB
    {
        private static OdbcConnection connection = null;
        public static OdbcConnection Connection
        {
            get
            {
                if (!String.IsNullOrEmpty(Database_Name) && !String.IsNullOrEmpty(Database_IP) && !String.IsNullOrEmpty(Database_Port) && !String.IsNullOrEmpty(Database_Login_Name))
                {
                    return connection ?? (connection = new OdbcConnection(Connectionstring));
                }
                else
                {
                    throw new NoNullAllowedException("Database login Data is not complete");
                }
            }
        }

        private static string Database_Name;
        private static string Database_IP;
        private static string Database_Port;
        private static string Database_Login_Name;
        private static string Database_Login_Password;

        public static void Give_login_Data_pls_thx(string name, string ip, string port, string login_name, string login_password)
        {
            Database_Name = name;
            Database_IP = ip;
            Database_Port = port;
            Database_Login_Name = login_name;
            Database_Login_Password = login_password;
        }

        private static string Connectionstring => $"Driver={"MySQL ODBC 5.3 Unicode Driver"};Server={Database_IP};Port={Database_Port};Database={Database_Name};User={Database_Login_Name};Password={Database_Login_Password};Option=3;";
    }
}
