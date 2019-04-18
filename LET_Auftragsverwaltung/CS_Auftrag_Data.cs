using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LET_Auftragsverwaltung
{
    class Auftrag_Data
    {
        public int ID { get; set; }
        public string Auftrags_Nr { get; set; }
        public string Fertigungsstatus { get; set; }
        public string Projektverantwortlicher_Name { get; set; }
        public string Planner_Name { get; set; }
        public string Projektbezeichnung { get; set; }
        public string Verkäufer_Name { get; set; }
        public string Erstell_datum { get; set; }
        public string Montage_Datum { get; set; }
    }
}
