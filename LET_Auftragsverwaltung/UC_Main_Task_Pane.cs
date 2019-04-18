using BrightIdeasSoftware;
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
    public partial class UC_Main_Task_Pane : UserControl
    {
        LinkedList<Auftrag_Data> data = new LinkedList<Auftrag_Data>();
        private static bool reload = true;
        private OdbcConnection Connection => DB.Connection;
        public UC_Main_Task_Pane( )
        {
            InitializeComponent();
            oLV_Overview.FullRowSelect = true;

            oLV_Overview.SelectedRowDecoration = new TintedColumnDecoration(oLV_Cl_Fertigungsstatus);

            oLV_Overview.TintSortColumn = true;
            oLV_Overview.SelectedColumn = oLV_Cl_Fertigungsstatus;
            oLV_Overview.Sort(oLV_Cl_Fertigungsstatus);

            oLV_Overview.SelectedColumnTint = Color.FromArgb(45, 248, 131, 121);
        }

        private void TSMI_Overview_Click(object sender, EventArgs e)
        {
            if (Form_Overview.isopen)
            {
                Form_Overview.tofront = true;
            }
            else
            {
                Form form_Overview = new Form_Overview();
                form_Overview.Show();
                UC_Overview.Update_Overview();
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



        private void TSMI_DB_Click(object sender, EventArgs e)
        {
            Form form_DB = new Form_DB();
            form_DB.Show();
        }

        private void TSMI_new_Auftrag_Click(object sender, EventArgs e)
        {
            Form form_new_Auftrag = new Form_New_Auftrag();
            form_new_Auftrag.Show();
        }

        private void Tmr_250ms_Tick(object sender, EventArgs e)
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
                    sql = $"SELECT auftraege.id,fertigungsstatus.`Status`,auftraege.`Projektbezeichnung`,auftraege.`Auftrags_NR` FROM auftraege LEFT JOIN fertigungsstatus ON auftraege.`Fertigungsstatus` = fertigungsstatus.`F_ID` WHERE id=" + auftrag_ID;
                    cmd = new OdbcCommand(sql, Connection);
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    Auftrag_Data data = new Auftrag_Data();
                    data.ID = (int)(reader["ID"] == DBNull.Value ? null : reader["ID"]);
                    data.Fertigungsstatus = DB_to_string(reader["Status"]);
                    data.Projektbezeichnung = DB_to_string(reader["Projektbezeichnung"]);
                    data.Auftrags_Nr = DB_to_string(reader["Auftrags_NR"]);
                    this.data.AddLast(data);
                }

                oLV_Overview.SetObjects(data);
            }
        }
        public static void Update_Overview()
        {
            reload = true;
        }

        private void Tmr_10s_Tick(object sender, EventArgs e)
        {
            reload = true;
        }

        private void OLV_Overview_DoubleClick(object sender, EventArgs e)
        {
            if (sender != null)
            {
                Form Form_EDIT = new Form_Edit_Auftrag(((sender as ObjectListView).SelectedItem.RowObject as Auftrag_Data).ID);
                Form_EDIT.Show();
            }
        }
    }
}