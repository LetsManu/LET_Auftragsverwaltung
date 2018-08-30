using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LET_Auftragsverwaltung
{
    class CS_Auftrag_Data
    {
        public string Auftrags_Nr { get; set; }
        public string Fertigungsstatus { get; set; }
        public DateTime Erstell_Datum { get; set; }
        public DateTime Anzahlung_Datum { get; set; }
        public DateTime AZ_bestaetigt_Datum { get; set; }
        public DateTime Schlussrechnung_Date { get; set; }
        public string Projektverantwortlicher_Name { get; set; }
        public string Planner_Name { get; set; }
        public string Projektbezeichnung { get; set; }
        public string Auftrags_Art { get; set; }
        public string Stoff_Kennzahl { get; set; }
        public DateTime Schatten_Datum { get; set; }
        public DateTime Stoff_bestell_Datum { get; set; }
        public DateTime Stoff_liefer_Datum { get; set; }
        public string Stoff_Lieferant { get; set; }
        public DateTime Sonderteile_bestell_Datum { get; set; }
        public DateTime Sonderteile_liefer_Datum { get; set; }
        public string Sonderteile_Lieferant { get; set; }
        public DateTime Persenning_bestell_Datum { get; set; }
        public DateTime Persenning_liefer_Datum { get; set; }
        public string Persenning_Lieferant { get; set; }
        public DateTime Montage_Datum { get; set; }
    }
}
