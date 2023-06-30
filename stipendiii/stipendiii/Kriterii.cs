using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stipendiii
{
    internal class Kriterii : Uchenik, IComparable<Kriterii>
    {
        private double semeendohod;
        private double drugdohod;
        private int broisemeistvo;
        public double uspeh;
        public bool nakazaniq;

        public Kriterii(string name, string klas, string paralelka,
            double semeendohod, double drugdohod, int broisemeistvo,
            double uspeh, bool nakazaniq) : base( name, klas, paralelka)
        {
            Semeendohod = semeendohod;
            Drugdohod = drugdohod;
            Broisemeistvo = broisemeistvo;
            Uspeh = uspeh;
            Nakazaniq = nakazaniq;
        }
        public double Semeendohod
        {
            get { return semeendohod; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Trqbva da e pozitivno chislo");
                }
                semeendohod = value;
            }
        }
        public double Drugdohod
        {
            get { return drugdohod; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Trqbva da e pozitivno chislo");
                }
                drugdohod = value;
            }
        }
        public int Broisemeistvo
        {
            get { return broisemeistvo; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Trqbva da e pozitivno chislo");
                }
                broisemeistvo = value;
            }
        }
        public double Uspeh
        {
            get { return uspeh; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Uspeha ne moje da e negativen");
                }
                uspeh = value;
            }
        }
        public bool Nakazaniq
        {
            get { return nakazaniq; }

            set { nakazaniq = value; }
        }

        public int CompareTo(Kriterii other)
        {
            return Semeendohod.CompareTo(other.Semeendohod);
        }
        public override void Print()
        {
            Console.WriteLine($"ime na uchenika{Name} ot {Klas} klas {Paralelka} paralelka");
            Console.WriteLine($"semeen dohod:{Semeendohod} drug dohod: {Drugdohod} " +
                $"broi na semeistvoto: {Broisemeistvo} s uspeh: {Uspeh} nakazaniq:{Nakazaniq}");

        }
    }
}
