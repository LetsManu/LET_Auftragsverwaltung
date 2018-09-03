using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LET_Auftragsverwaltung
{
    public partial class UC_Overview : UserControl
    {
        LinkedList<CS_Auftrag_Data> datar = new LinkedList<CS_Auftrag_Data>();
        private OdbcConnection connection = null;

        private OdbcConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    string constrg = "Driver={MySQL ODBC 5.3 Unicode Driver};Server=192.168.16.192;Database=auftrags;User=admin;Password=cola0815;Option=3;";
                    connection = new OdbcConnection(constrg);
                }
                return connection;
            }
        }
        public UC_Overview( )
        {
            InitializeComponent();
            Connection.Open();


            string sql = "SELECT auftraege.`ID`, auftraege.`Auftrags_NR` AS \"Auftrags Nr.\", auftraege.Erstelldatum, fertigungsstatus.`Status`, CONCAT(p1.`Nachname`, \" \", p1.`Vorname`) AS \"Planner\", teile_stoff.`Lieferdatum` AS \"Stoff Lieferdatum\", teile_Stoff.Bestelldatum AS \"Stoff Bestelldatum\", stoff.`Stoff`, teile_persenning.`Lieferdatum` AS \"Persenning Lieferdatum\", teile_persenning.`Bestelldatum` AS \"Persenning Bestelldatum\", teile_sonder.`Lieferdatum` AS \"Sonderteile Lieferdatum\", teile_sonder.`Bestelldatum` AS \"Sonderteile Bestelldatum\", ab_az.`V_Date` AS \"Anzahlung anfordern\", ab_az.`B_Date` AS \"Anzahlung bestätigt\", auftraege.`Schlussrechnung` AS \"Schlussrechnung ausgestellt am\", CONCAT(p2.`Nachname`, \" \", p2.`Vorname`) AS \"Projektverantwortlicher\", auftraege.`Projektbezeichnung`, GROUP_CONCAT(CONCAT(auftragsart.`Art`, ' ')) AS \"Auftrags Art\", schatten.`Schattendatum` AS \"Schatten fertig\" FROM auftraege LEFT JOIN personal p1 ON auftraege.`Planer_Techniker` = p1.`P_ID` LEFT JOIN personal p2 ON auftraege.`Projektverantwortlicher` = p2.`P_ID` LEFT JOIN fertigungsstatus ON auftraege.`Fertigungsstatus` = fertigungsstatus.`F_ID` LEFT JOIN teile ON auftraege.`Teile` = teile.`T_St_ID` LEFT JOIN teile_stoff ON teile_stoff.`T_ST_ID` = teile.`T_St_ID` LEFT JOIN stoff ON teile_stoff.`ST_ID` = stoff.`St_ID` LEFT JOIN teile_persenning ON teile.`T_P_ID` = teile_persenning.`T_P_ID` LEFT JOIN teile_sonder ON teile.`T_S_ID` = teile_sonder.`T_S_ID` LEFT JOIN ab_az ON auftraege.`AB_AZ` = ab_az.`A_ID` LEFT JOIN auftraege_auftragsart ON auftraege.`Auftragsart` = auftraege_auftragsart.`ID` LEFT JOIN auftragsart ON auftraege_auftragsart.`Art_ID` = auftragsart.`Art_ID` LEFT JOIN schatten ON auftraege.`Schatten` = schatten.`S_ID` WHERE auftragsart.`deaktiviert` = FALSE AND fertigungsstatus.`deaktiviert` = FALSE";
            OdbcCommand cmd = new OdbcCommand(sql, Connection);
            OdbcDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CS_Auftrag_Data data = new CS_Auftrag_Data();
                data.Auftrags_Nr = ( string ) ( reader["Auftrags Nr."] == DBNull.Value ? null : reader["Auftrags Nr."] );
                data.Fertigungsstatus = ( string ) ( reader["Status"] == DBNull.Value ? null : reader["Status"] );
                data.Erstell_Datum = Convert.ToDateTime(reader["Erstelldatum"] == DBNull.Value ? null : reader["Erstelldatum"]);
                data.Anzahlung_Datum = Convert.ToDateTime(reader["Anzahlung anfordern"] == DBNull.Value ? null : reader["Anzahlung anfordern"]);
                data.AZ_bestaetigt_Datum = Convert.ToDateTime(reader["Anzahlung bestätigt"] == DBNull.Value ? null : reader["Anzahlung bestätigt"]);
                data.Schlussrechnung_Date = Convert.ToDateTime(reader["Schlussrechnung ausgestellt am"] == DBNull.Value ? null : reader["Schlussrechnung ausgestellt am"]);
                data.Projektverantwortlicher_Name = ( string ) ( reader["Projektverantwortlicher"] == DBNull.Value ? null : reader["Projektverantwortlicher"] );
                data.Planner_Name = ( string ) ( reader["Planner"] == DBNull.Value ? null : reader["Planner"] );
                data.Projektbezeichnung = ( string ) ( reader["Projektbezeichnung"] == DBNull.Value ? null : reader["Projektbezeichnung"] );
                data.Auftrags_Art = ( string ) ( reader["Auftrags Art"] == DBNull.Value ? null : reader["Auftrags Art"] );
                data.Stoff_Kennzahl = ( string ) ( reader["Stoff"] == DBNull.Value ? null : reader["Stoff"] );
                data.Schatten_Datum = Convert.ToDateTime(reader["Schatten fertig"] == DBNull.Value ? null : reader["Schatten fertig"]);
                data.Stoff_bestell_Datum = Convert.ToDateTime(reader["Stoff Bestelldatum"] == DBNull.Value ? null : reader["Stoff Bestelldatum"]);
                data.Stoff_liefer_Datum = Convert.ToDateTime(reader["Stoff Lieferdatum"] == DBNull.Value ? null : reader["Stoff Lieferdatum"]);
                //data.Stoff_Lieferant = ( string ) ( reader["Stoff Lieferant"] == DBNull.Value ? null : reader["Stoff Lieferant"] );
                data.Sonderteile_bestell_Datum = Convert.ToDateTime(reader["Sonderteile Bestelldatum"] == DBNull.Value ? null : reader["Sonderteile Bestelldatum"]);
                data.Sonderteile_liefer_Datum = Convert.ToDateTime(reader["Sonderteile Lieferdatum"] == DBNull.Value ? null : reader["Sonderteile Lieferdatum"]);
                //data.Sonderteile_Lieferant = ( string ) ( reader["Sonderteile Lieferant"] == DBNull.Value ? null : reader["Sonderteile Lieferant"] );
                data.Persenning_bestell_Datum = Convert.ToDateTime(reader["Persenning Bestelldatum"] == DBNull.Value ? null : reader["Persenning Bestelldatum"]);
                data.Persenning_liefer_Datum = Convert.ToDateTime(reader["Persenning Lieferdatum"] == DBNull.Value ? null : reader["Persenning Lieferdatum"]);
                //data.Persenning_Lieferant = ( string ) reader["Persenning Lieferant"];
                //data.Montage_Datum = Convert.ToDateTime(reader[""];
                datar.AddLast(data);
            }

            Connection.Close();
            objectListView1.SetObjects(datar);
        }
    }
}
