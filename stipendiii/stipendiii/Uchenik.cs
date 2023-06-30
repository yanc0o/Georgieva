using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace stipendiii
{
    internal abstract class Uchenik : IPrint
    {
        private string name;
        private string klas;
        private string paralelka;

        public Uchenik(string name, string klas, string paralelka)
        {
            Name = name;
            Klas = klas;
            Paralelka = paralelka;
        }
        public string Name { get { return name; } set { name = value; } }
        public string Klas { get { return klas; } set { klas = value; } }
        public string Paralelka { get { return paralelka; } set { paralelka = value; } }

        public virtual void Print() { }
    }
}
