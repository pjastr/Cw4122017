using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication58
{
    class Rower:IComparable<Rower>
    {
        private string model;
        private int przerzutki;
        private int cena;

        public Rower(string model, int przerzutki, int cena)
        {
            this.model = model;
            this.przerzutki = przerzutki;
            this.cena = cena;
        }

        public int CompareTo(Rower other)
        {
            return this.cena.CompareTo(other.cena);
        }

        public override string ToString()
        {
            return model+ " " +przerzutki+" " +cena;
        }
    }
}
