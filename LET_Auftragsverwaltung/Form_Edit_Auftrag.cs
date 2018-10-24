using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LET_Auftragsverwaltung
{
    public partial class Form_Edit_Auftrag : Form
    {
        public static int id;
        public Form_Edit_Auftrag(int id_)
        {
            id = id_;
            InitializeComponent();
        }
    }
}
