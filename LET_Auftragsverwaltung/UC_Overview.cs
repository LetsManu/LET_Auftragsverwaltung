using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LET_Auftragsverwaltung
{
    public partial class UC_Overview : UserControl
    {
        LinkedList<Auftrag_Data> data = new LinkedList<Auftrag_Data>();
        private static bool reload = true;

        public UC_Overview()
        {
            //BrightIdeasSoftware.TreeListView.IgnoreMissingAspects = true;
            InitializeComponent();

            oLV_Overview.FullRowSelect = true;

            oLV_Overview.SelectedRowDecoration = new TintedColumnDecoration(oLV_Cl_Planner_Name);


        }

        private OdbcConnection Connection => DB.Connection;

        private void objectListView1_DoubleClick(object sender, EventArgs e)
        {
            if (sender != null)
            {
                Form Form_EDIT = new Form_Edit_Auftrag_new(((sender as ObjectListView).SelectedItem.RowObject as Auftrag_Data).ID);
                Form_EDIT.Show();
            }
        }



        private void objectListView1_FormatCell(object sender, BrightIdeasSoftware.FormatCellEventArgs e)
        {
            /*
            ////oLV_Overview.UseCellFormatEvents = true; //this must be called somewhere so that this method gets a call.
            
            DateTime tmp = new DateTime();
            if (tmp.GetType() == e?.CellValue?.GetType() && ( DateTime ) e.CellValue == tmp)
            {
                // Add a opaque, rotated text decoration
                //TextDecoration decoration = new TextDecoration("Missing!", 255);
                //decoration.Alignment = ContentAlignment.MiddleCenter;
                //decoration.Font = new Font(this.Font.Name, this.Font.SizeInPoints + 2);
                //decoration.TextColor = Color.Crimson;
                //decoration.Rotation = -20;
                //e.SubItem.Decoration = decoration; //NB. Sets Decoration


                #region macht Felder wo nichts drinnen steht unsichtbar
                CellBorderDecoration cbd = new CellBorderDecoration();
                cbd.BorderPen = Pens.White;
                cbd.FillBrush = Brushes.White;
                cbd.CornerRounding = 4.0f;
                e.SubItem.Decorations.Add(cbd);
                #endregion
                
            }*/

        }



        public static void Update_Overview()
        {
            reload = true;
        }

        private void tmr_250ms_Tick(object sender, EventArgs e)
        {
            if (reload && !this.DesignMode)
            {
                reload = false;

                data.Clear();

                /*
                //oLV_Overview.Items.Clear();  //is nor working because then the olv never shows anything
                System.Collections.IList list = oLV_Overview.Items;
                for (int i = 0; i < list.Count; i++)
                {
                    ListViewItem result = (ListViewItem)list[i];
                    oLV_Overview.Items.Remove(result);
                }
                oLV_Overview.Update();*/


                //oLV_Overview.UseCellFormatEvents = true;
                foreach (var result in oLV_Overview.AllColumns)
                {
                    result.MinimumWidth = 30;
                    result.Width = 100;
                }

                SQL_methods.Open();

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
                    Auftrag_Data data = new Auftrag_Data();
                    data.ID = (int)(reader["ID"] == DBNull.Value ? null : reader["ID"]);
                    data.Auftrags_Nr = DB_to_string(reader["Auftrags Nr."]);
                    data.Fertigungsstatus = DB_to_string(reader["Status"]);

                    data.Erstell_Datum = DB_Date_to_string(reader["Erstelldatum"]);
                    data.Anzahlung_Datum = DB_Date_to_string(reader["Anzahlung anfordern"]);
                    data.AZ_bestaetigt_Datum = DB_Date_to_string(reader["Anzahlung bestätigt"]);

                    data.Schlussrechnung_Date = DB_Date_to_string(reader["Schlussrechnung ausgestellt am"]);
                    data.Projektverantwortlicher_Name = DB_to_string(reader["Projektverantwortlicher"]);
                    data.Planner_Name = DB_to_string(reader["Planner"]);
                    data.Projektbezeichnung = DB_to_string(reader["Projektbezeichnung"]);
                    data.Auftrags_Art = DB_to_string(reader["Auftrags Art"]);
                    data.Stoff_Kennzahl = DB_to_string(reader["Stoff"]);
                    data.Schatten_Datum = DB_Date_to_string(reader["Schatten fertig"]);
                    data.Stoff_bestell_Datum = DB_Date_to_string(reader["Stoff Bestelldatum"]);
                    data.Stoff_liefer_Datum = DB_Date_to_string(reader["Stoff Lieferdatum"]);
                    //data.Stoff_Lieferant = DB_to_string( reader["Stoff Lieferant"] );
                    data.Sonderteile_bestell_Datum = DB_Date_to_string(reader["Sonderteile Bestelldatum"]);
                    data.Sonderteile_liefer_Datum = DB_Date_to_string(reader["Sonderteile Lieferdatum"]);
                    //data.Sonderteile_Lieferant = DB_to_string(reader["Sonderteile Lieferant"] );
                    data.Persenning_bestell_Datum = DB_Date_to_string(reader["Persenning Bestelldatum"]);
                    data.Persenning_liefer_Datum = DB_Date_to_string(reader["Persenning Lieferdatum"]);
                    //data.Persenning_Lieferant = DB_to_string(reader["Persenning Lieferant"]);
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

        public string DB_Date_to_string(object db_Data)
        {
            if (db_Data == DBNull.Value)
            {
                return "";
            }
            else
            {
                return Convert.ToDateTime(db_Data).ToString("dd.MM.yyyy");
            }
        }

        public string DB_to_string(object db_Data)
        {
            if (db_Data == DBNull.Value)
            {
                return "";
            }
            else
            {
                return (string)db_Data;
            }
        }

        public void Print_OLV()
        {


            ListViewPrinter printer = new ListViewPrinter();

            printer.AlwaysCenterListHeader = true;
            printer.ListView = this.oLV_Overview;
            printer.DocumentName = "Auftragsübersicht" + DateTime.Now.ToString("dd.MMMM.yy_HH:mm");
            printer.Header = "Auftragsübersicht";
            printer.DefaultPageSettings.Margins.Top = 5;
            printer.DefaultPageSettings.Margins.Left = 5;
            printer.DefaultPageSettings.Margins.Right = 5;
            printer.IsListHeaderOnEachPage = true;
            printer.Watermark = "LET Sonnensegel";
            printer.WatermarkTransparency = 40;
            printer.Footer = "LET Sonnensegel - " + DateTime.Now.ToString("dddd, dd.MMMM yyyy HH:mm");
            printer.DefaultPageSettings.Landscape = true;
            printer.DefaultPageSettings.PaperSize.RawKind = 8;

            //printer.PageSetup();

            printer.PrintWithDialog();
        }
    }
}
