﻿using System;
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
        private static OdbcConnection connection = null;

        private static string Connectionstring
        {
            get
            {
                return $"Driver={"MySQL ODBC 5.3 Unicode Driver"};Server={Server_IP};Database={Database};User={Login_name};Option=3;";
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
            get { return "localhost"; }
        }
        private static string Database
        {
            get { return "auftrags"; }
        }

        public static string GetMotherBoardID()
        {
            string mbInfo = String.Empty;
            ManagementScope scope = new ManagementScope("\\\\" + Environment.MachineName + "\\root\\cimv2");
            scope.Connect();
            ManagementObject wmiClass = new ManagementObject(scope, new ManagementPath("Win32_BaseBoard.Tag=\"Base Board\""), new ObjectGetOptions());

            foreach (PropertyData propData in wmiClass.Properties)
            {
                if (propData.Name == "SerialNumber")
                    mbInfo = Convert.ToString(propData.Value);
            }

            return mbInfo;
        }
    }
}
