using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_biuro_podrozy
{
    abstract class SrodekLokomocji
    {
        protected int iloscMiejsc;
        protected double cenaBiletu;

        public SrodekLokomocji() { }
        public virtual void ObliczCene() 
        {
            cenaBiletu = Convert.ToInt32(iloscMiejsc * 5.23);
        }

        public double JakaCena() 
        {
            return this.cenaBiletu;
        }
    }
}
