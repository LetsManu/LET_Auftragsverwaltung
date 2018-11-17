using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LET_Auftragsverwaltung
{
    class Explorer
    {
        private static void Open(string path)
        {
            if (Directory.Exists(path))
            {
                Process.Start("explorer.exe", path);
            }
            else
            {
                MessageBox.Show("Dieses Projekt wurde leider nicht in dem gespeicherten Pfad gefunden.\n Vielleicht wurde der Ordner verschoben / gelöscht oder nie erstellt. \nBei einer Wiederholung des Problems kontaktieren Sie bitte einen Systemadministrator","Warnung",MessageBoxButtons.OK);
            }
        }
    }
}
