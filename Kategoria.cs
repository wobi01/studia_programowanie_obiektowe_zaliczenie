using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studia_programowanie_obietkowe_zaliczenie
{
    internal class Kategoria
    {
        public string Nazwa { get; set; }
        public List<Danie> Dania { get; set; }

        public void DodajDanie(Danie danie)
        {
            Dania.Add(danie);
        }

        public void UsunDanie(Danie danie)
        {
            Dania.Remove(danie);
        }

        public List<Danie>
        WyswietlDanie()
    {
        return Dania;
    }
    }
}
