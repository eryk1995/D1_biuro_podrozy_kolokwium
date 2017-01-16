using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_biuro_podrozy
{
    class Express : SrodekLokomocji
    {
        public Express(int iloscMiejsc)
        {
            base.iloscMiejsc = iloscMiejsc;
            base.ObliczCene();
        }

        public override string ToString() 
        {
            string temp = "Express: ilosc miejsc: " + Convert.ToString(base.iloscMiejsc) + ", cena biletu: " + Convert.ToString(base.cenaBiletu);
            return temp;
        }


    }
}
