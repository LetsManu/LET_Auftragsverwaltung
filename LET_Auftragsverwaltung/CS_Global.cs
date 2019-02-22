using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LET_Auftragsverwaltung
{
    class Global
    {
        public static bool Not_filled(TextBox tbx)
        {
            if (tbx == null || tbx.Text == "" || tbx.Text == null)
            {
                MessageBox.Show("Das Feld " + tbx.Name + "ist leer, bitte Korrekte Werte eintragen.", "Warnung", MessageBoxButtons.OK);
                return true;
            }
            return false;
        }

        public static bool Not_filled(ComboBox cbx)
        {
            if (cbx == null || cbx.Text == "" || cbx.Text == null)
            {
                MessageBox.Show("Das Feld " + cbx.Name + "ist leer, bitte Korrekte Werte eintragen.", "Warnung", MessageBoxButtons.OK);
                return true;
            }
            return false;
        }
    }
}
