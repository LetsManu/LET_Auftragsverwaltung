using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LET_Auftragsverwaltung
{
    class Segel
    {
        private string name;
        private string shape;
        private int id_hersteller;
        private int id_stoff;
        private int id;

        public Segel( )
        {
        }

        public Segel(string name_, string shape_, int id_hersteller_, int id_stoff_, int id_)
        {
            ID = id_;
            Name = name_ ?? throw new ArgumentNullException(nameof(name_));
            Shape = shape_ ?? throw new ArgumentNullException(nameof(shape_));
            Id_hersteller = id_hersteller_;
            Id_stoff = id_stoff_;
        }

        public string Name { get => name; set => name = value; }
        public string Shape { get => shape; set => shape = value; }
        public int Id_hersteller { get => id_hersteller; set => id_hersteller = value; }
        public int Id_stoff { get => id_stoff; set => id_stoff = value; }
        public int ID { get => id; set => id = value; }

        public override string ToString( )
        {
            //return Name + ", " + Shape;
            return Name + ", " + Shape + ", " + Id_hersteller.ToString() + ", " + Id_stoff.ToString() + ", " + ID.ToString();
        }
    }
}
