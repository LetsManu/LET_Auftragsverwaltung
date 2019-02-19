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
    public partial class Form_Best : Form
    {
        public int a_ID = 0;
        public Form_Best(int a_ID_)
        {
            a_ID = a_ID_;

            InitializeComponent();
        }
    }
}
