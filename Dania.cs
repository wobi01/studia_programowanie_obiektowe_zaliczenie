using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studia_programowanie_obietkowe_zaliczenie
{
    class Danie
    {
        public string Nazwa { get; set; }
        public double Cena { get; set; }

        List<Danie> listaDan = new List<Danie>();

        public void Dodaj()
        {
            Danie noweDanie = new Danie();
            Console.WriteLine("Podaj nazwę dania: ");
            noweDanie.Nazwa = Console.ReadLine();
            Console.WriteLine("Podaj cenę dania: ");
            noweDanie.Cena = double.Parse(Console.ReadLine());
            listaDan.Add(noweDanie);
        }

        public void Usun()
        {
            Console.WriteLine("Podaj nazwę dania, które chcesz usunąć: ");
            string nazwa = Console.ReadLine();
            Danie danieDoUsuniecia = listaDan.Find(x => x.Nazwa == nazwa);
            if (danieDoUsuniecia != null)
            {
                listaDan.Remove(danieDoUsuniecia);
                Console.WriteLine("Danie " + nazwa + "zostało usunięte.");
            }
            else
            {
                Console.WriteLine("Nie znaleziono dania o nazwie: " + nazwa + ", upewnij się, że wprowadziłeś poprawną nazwę.");
            }
        }

        public void Wyswietl()
        {
            // Kod do wyświetlania dania
        }
    }
}
