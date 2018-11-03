using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LET_Auftragsverwaltung
{
    public partial class UC_Overview : UserControl
    {
        LinkedList<CS_Auftrag_Data> data = new LinkedList<CS_Auftrag_Data>();
        private static bool reload = true;

        public UC_Overview( )
        {
            InitializeComponent();
        }

        private OdbcConnection Connection => CS_DB.Connection;

        private object Right_Date(DateTime date)
        {
            if (date.Year == 1)
            {
                return "";
            }

            return date;
        }

        private void objectListView1_DoubleClick(object sender, EventArgs e)
        {
            if (sender != null)
            {
                Form Form_EDIT = new Form_Edit_Auftrag(( ( sender as ObjectListView ).SelectedItem.RowObject as CS_Auftrag_Data ).ID);
                Form_EDIT.Show();
            }
        }

        private void objectListView1_FormatCell(object sender, BrightIdeasSoftware.FormatCellEventArgs e)
        {
            DateTime tmp = new DateTime();
            if (tmp.GetType() == e?.CellValue?.GetType() && ( DateTime ) e.CellValue == tmp)
            {
                // Add a opaque, rotated text decoration
                /* TextDecoration decoration = new TextDecoration("Missing!", 255);
                 decoration.Alignment = ContentAlignment.MiddleCenter;
                 decoration.Font = new Font(this.Font.Name, this.Font.SizeInPoints + 2);
                 decoration.TextColor = Color.Crimson;
                 decoration.Rotation = -20;
                 e.SubItem.Decoration = decoration; //NB. Sets Decoration*/


                #region macht Felder wo nichts drinnen steht unsichtbar
                CellBorderDecoration cbd = new CellBorderDecoration();
                cbd.BorderPen = Pens.White;
                cbd.FillBrush = Brushes.White;
                cbd.CornerRounding = 4.0f;
                e.SubItem.Decorations.Add(cbd);
                #endregion
            }
        }

        public static void Update_Overview( )
        {
            reload = true;
        }

        private void tmr_250ms_Tick(object sender, EventArgs e)
        {
            if (reload && !this.DesignMode)
            {
                reload = false;

                oLV_Overview.UseCellFormatEvents = true;
                foreach (var result in oLV_Overview.AllColumns)
                {
                    result.MinimumWidth = 30;
                    result.Width = 100;
                }

                CS_SQL_methods.Open();

                List<string> auftraege_ID = new List<string>();

                string sql = "SELECT auftraege.ID FROM auftraege";
                OdbcCommand cmd = new OdbcCommand(sql, Connection);
                OdbcDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    auftraege_ID.Add(Convert.ToString(reader["ID"]));
                }

                foreach (var auftrag_ID in auftraege_ID)
                {
                    sql = $"SELECT auftraege.`ID`, auftraege.`Auftrags_NR` AS \"Auftrags Nr.\", auftraege.Erstelldatum, fertigungsstatus.`Status`, CONCAT(p1.`Nachname`, \" \", p1.`Vorname`) AS \"Planner\", teile_stoff.`Lieferdatum` AS \"Stoff Lieferdatum\", teile_Stoff.Bestelldatum AS \"Stoff Bestelldatum\", stoff.`Stoff`, teile_persenning.`Lieferdatum` AS \"Persenning Lieferdatum\", teile_persenning.`Bestelldatum` AS \"Persenning Bestelldatum\", teile_sonder.`Lieferdatum` AS \"Sonderteile Lieferdatum\", teile_sonder.`Bestelldatum` AS \"Sonderteile Bestelldatum\", ab_az.`V_Date` AS \"Anzahlung anfordern\", ab_az.`B_Date` AS \"Anzahlung bestätigt\", auftraege.`Schlussrechnung` AS \"Schlussrechnung ausgestellt am\", CONCAT(p2.`Nachname`, \" \", p2.`Vorname`) AS \"Projektverantwortlicher\", auftraege.`Projektbezeichnung`, GROUP_CONCAT(CONCAT(auftragsart.`Art`, ' ')) AS \"Auftrags Art\", schatten.`Schattendatum` AS \"Schatten fertig\" FROM auftraege LEFT JOIN personal p1 ON auftraege.`Planer_Techniker` = p1.`P_ID` LEFT JOIN personal p2 ON auftraege.`Projektverantwortlicher` = p2.`P_ID` LEFT JOIN fertigungsstatus ON auftraege.`Fertigungsstatus` = fertigungsstatus.`F_ID` LEFT JOIN teile ON auftraege.`ID` = teile.`T_St_ID` LEFT JOIN teile_stoff ON teile_stoff.`T_ST_ID` = teile.`T_St_ID` LEFT JOIN stoff ON teile_stoff.`ST_ID` = stoff.`St_ID` LEFT JOIN teile_persenning ON teile.`T_P_ID` = teile_persenning.`T_P_ID` LEFT JOIN teile_sonder ON teile.`T_S_ID` = teile_sonder.`T_S_ID` LEFT JOIN ab_az ON auftraege.`AB_AZ` = ab_az.`A_ID` LEFT JOIN auftraege_auftragsart ON auftraege.`ID` = auftraege_auftragsart.`ID` LEFT JOIN auftragsart ON auftraege_auftragsart.`Art_ID` = auftragsart.`Art_ID` LEFT JOIN schatten ON auftraege.`Schatten` = schatten.`S_ID` WHERE auftraege.ID = '{auftrag_ID}' AND auftraege.`deaktiviert` = false ";
                    cmd = new OdbcCommand(sql, Connection);
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    CS_Auftrag_Data data = new CS_Auftrag_Data();
                    data.ID = ( int ) ( reader["ID"] == DBNull.Value ? null : reader["ID"] );
                    data.Auftrags_Nr = ( string ) ( reader["Auftrags Nr."] == DBNull.Value ? null : reader["Auftrags Nr."] );
                    data.Fertigungsstatus = ( string ) ( reader["Status"] == DBNull.Value ? null : reader["Status"] );
                    Right_Date(data.Erstell_Datum = Convert.ToDateTime(reader["Erstelldatum"] == DBNull.Value ? null : reader["Erstelldatum"]));
                    Right_Date(data.Anzahlung_Datum = Convert.ToDateTime(reader["Anzahlung anfordern"] == DBNull.Value ? null : reader["Anzahlung anfordern"]));
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
                    this.data.AddLast(data);
                }
                
                oLV_Overview.SetObjects(data);

                oLV_Overview.TintSortColumn = true;
                oLV_Overview.SelectedColumn = oLV_Cl_Projektverantwortlicher_Name;
                oLV_Overview.Sort(oLV_Cl_Projektverantwortlicher_Name);

                oLV_Overview.SelectedColumnTint = Color.FromArgb(45, 248, 131, 121);
            }
        }

        public void Print_OLV()
        {
            /*
            CS_listViewPrinter printer = new CS_listViewPrinter(oLV_Overview, new Point(50, 50), true, oLV_Overview.Groups.Count > 0, "titleText");
            printer.print();*/

            /*
            
            ListViewPrinter printer = new ListViewPrinter();
            printer.AlwaysCenterListHeader = true;
            printer.ListView = this.oLV_Overview;
            printer.DocumentName = "Fuhrpark Änderungsliste";
            printer.Header = "Fuhrpark Änderungsliste";
            printer.DefaultPageSettings.Margins.Top = 5;
            printer.DefaultPageSettings.Margins.Left = 5;
            printer.DefaultPageSettings.Margins.Right = 5;
            printer.IsListHeaderOnEachPage = true;
            printer.Watermark = "Fuhrpark";
            printer.WatermarkTransparency = 50;
            printer.Footer = "Fuhrpark - " + DateTime.Now.ToString("dddd, dd.MMMM yyyy HH:mm");
            printer.PrintPreview();*/
        }
    }
}
