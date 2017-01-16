using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_biuro_podrozy
{
    class Samolot : SrodekLokomocji
    {
        private int odleglosc;

        public override void ObliczCene()
        {
            if (this.odleglosc > 200)
                base.cenaBiletu = odleglosc * 6.41 * iloscMiejsc;
            else
                base.cenaBiletu = 33 * iloscMiejsc;
        }

        public Samolot(int iloscMiejsc, int odleglosc)
        {
            base.iloscMiejsc = iloscMiejsc;
            this.odleglosc = odleglosc;
            base.ObliczCene();
        }
        public override string ToString() {
            string temp = "Samolot: ilosc miejsc: " + Convert.ToString(base.iloscMiejsc) + ", odleglosc: " +
                Convert.ToString(this.odleglosc) + ", cena biletu: " + Convert.ToString(base.cenaBiletu);
            return temp;
        }

    }

}
