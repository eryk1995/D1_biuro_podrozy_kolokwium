﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_biuro_podrozy
{
class Podroz : IData , IZarzadzaj
    {
        private DateTime dataPodrozy;
        private List<SrodekLokomocji> planPodrozy = new List<SrodekLokomocji>();
        private double koszt = 200;


        public void UstawDate(DateTime data)
        {
            dataPodrozy = data;
        }

        public bool SprawdzDate()
        {
            if (dataPodrozy > DateTime.Now) return true;
            else return false;
        }

        public void DodajExpress(int iloscMiejsc)
        {
            planPodrozy.Add(new Express(iloscMiejsc));
            int pomoc = planPodrozy.Count;
            koszt += planPodrozy[pomoc - 1].JakaCena();
        }

       public void DodajSamolot(int iloscMiejsc, int odleglosc) {
            planPodrozy.Add(new Samolot(iloscMiejsc, odleglosc));
            int pomoc = planPodrozy.Count;
            koszt += planPodrozy[pomoc - 1].JakaCena();
        } 
        public void UsunOstatni()
        {
            if (planPodrozy.Count > 0) planPodrozy.Remove(planPodrozy.Last());
            int pomoc = planPodrozy.Count;
            try
            {
                koszt -= planPodrozy[pomoc - 1].JakaCena();
            }
            catch
            {
                koszt = 200;
            }

        }

        public void Wyczysc() 
        {
         
            planPodrozy.Clear();
        }
        public override string ToString() {
            string info = "Plan podrozy: ";

            foreach (var element in planPodrozy) {
                info += Environment.NewLine + element.ToString();
            }
            info += Environment.NewLine + "Koszt: " + koszt;

            return info;
        }
    }
}
