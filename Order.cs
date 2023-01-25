using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studia_programowanie_obietkowe_zaliczenie
{
    public class Order
    {
        private List<Dish> positions;
        private double sum;

        public Order()
        {
            positions = new List<Dish>();
            sum = 0;
        }

        public void AddPosition(Dish d){
            positions.Add(d);
            sum += d.Price;
        }
        
        public void Summary()
        {
            Console.WriteLine("Podsumowanie: ");
            foreach(Dish d in positions)
            {
                Console.WriteLine(d.Name + " - " + d.Price + " zł");
            }
            Console.WriteLine("Cena całkowita zamówienia: " + sum + " zł");
        }

        public void Confirmation()
        {
            Console.WriteLine("Czy zamówienie się zgadza i chcesz je potwierdzić? Odpowiedz 'Tak' lub 'Nie': ");
            string choice = Console.ReadLine();
            if(choice.ToLower() == "tak")
            {
                Console.WriteLine("Zamówienie złożone, utworzono plik .txt z rachunkiem, Smacznego!");
                using (StreamWriter writer = new StreamWriter("rachunek.txt"))
                {
                    writer.WriteLine("Podsumowanie: ");
                    foreach (Dish d in positions)
                    {
                        Console.WriteLine(d.Name + " - " + d.Price + " zł");
                    }
                    Console.WriteLine("Cena całkowita zamówienia: " + sum + " zł");
                }
            }
            else
            {
                Console.WriteLine("Zamówienie zostało anulowane");
            }
        }
    }
}
