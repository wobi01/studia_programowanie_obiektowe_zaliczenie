using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studia_programowanie_obietkowe_zaliczenie
{
    internal class Zamow
    {
        private List<Danie> pozycje;
        private double suma;

        public Zamow()
        {
            pozycje = new List<Danie>();
            suma = 0;
        }

        public void DodajPozycje(Danie d){
            pozycje.Add(d);
            suma += d.Cena;
        }
        
        public void Podsumowanie()
        {
            Console.WriteLine("Podsumowanie: ");
            foreach(Danie d in pozycje)
            {
                Console.WriteLine(d.Nazwa + " - " + d.Cena + " zł");
            }
            Console.WriteLine("Cena całkowita zamówienia: " + suma + " zł");
        }

        public void Potwierdzenie()
        {
            Console.WriteLine("Czy zamówienie się zgadza i chcesz je potwierdzić? Odpowiedz 'Tak' lub 'Nie': ");
            string wybor = Console.ReadLine();
            if(wybor.ToLower() == "tak")
            {
                Console.WriteLine("Zamówienie złożone, utworzono plik .txt z rachunkiem, Smacznego!");
                using (StreamWriter writer = new StreamWriter("rachunek.txt"))
                {
                    writer.WriteLine("Podsumowanie: ");
                    foreach (Danie d in pozycje)
                    {
                        Console.WriteLine(d.Nazwa + " - " + d.Cena + " zł");
                    }
                    Console.WriteLine("Cena całkowita zamówienia: " + suma + " zł");
                }
            }
            else
            {
                Console.WriteLine("Zamówienie zostało anulowane");
            }
        }
    }
}
