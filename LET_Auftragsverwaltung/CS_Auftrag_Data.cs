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
        public string Erstell_Datum { get; set; }
        public string Anzahlung_Datum { get; set; }
        public string AZ_bestaetigt_Datum { get; set; }
        public string Schlussrechnung_Date { get; set; }
        public string Projektverantwortlicher_Name { get; set; }
        public string Planner_Name { get; set; }
        public string Projektbezeichnung { get; set; }
        public string Auftrags_Art { get; set; }
        public string Stoff_Kennzahl { get; set; }
        public string Schatten_Datum { get; set; }
        public string Stoff_bestell_Datum { get; set; }
        public string Stoff_liefer_Datum { get; set; }
        public string Stoff_Lieferant { get; set; }
        public string Sonderteile_bestell_Datum { get; set; }
        public string Sonderteile_liefer_Datum { get; set; }
        public string Sonderteile_Lieferant { get; set; }
        public string Persenning_bestell_Datum { get; set; }
        public string Persenning_liefer_Datum { get; set; }
        public string Persenning_Lieferant { get; set; }
        public string Montage_Datum { get; set; }
    }
}
