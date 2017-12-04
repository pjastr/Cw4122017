using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication66
{
    class Sportowiec:IComparable<Sportowiec>
    {
        private string nazwisko;
        protected int liczbaMedali;
        private double rekord;

        public Sportowiec(string nazwisko, int liczbaMedali, double rekord)
        {
            this.nazwisko = nazwisko;
            this.liczbaMedali = liczbaMedali;
            this.rekord = rekord;
        }

        public int CompareTo(Sportowiec other)
        {
            return this.liczbaMedali.CompareTo(other.liczbaMedali);
        }
    }
}
