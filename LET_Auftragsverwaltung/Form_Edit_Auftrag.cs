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
        private int test_id;
        public Form_Edit_Auftrag(int id)
        {
            test_id = id;
            InitializeComponent();
        }
    }
}
