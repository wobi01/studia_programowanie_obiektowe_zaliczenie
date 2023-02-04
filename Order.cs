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

        public void AddPosition(Dish d)
        {
            positions.Add(d);
            sum += d.Price;
        }

        public void RemovePosition(int d)
        {
            sum -= positions[d - 1].Price;
            positions.RemoveAt(d - 1);
        }

        public void Summary()
        {
            int i = 1;
            Console.WriteLine("Zamówienie: ");
            foreach (Dish d in positions)
            {
                Console.WriteLine(i + ". " + d.Name + " - " + d.Price + " zł");
                i++;
            }
            Console.WriteLine("Cena całkowita zamówienia: " + sum + " zł");
        }

        public void Confirmation()
        {
            Console.Clear();
            Console.WriteLine("Zamówienie złożone, utworzono plik .txt z rachunkiem, Smacznego!");
            using (StreamWriter writer = new StreamWriter("rachunek.txt"))
            {
                writer.WriteLine("Oto twoje zamówienie: ");
                foreach (Dish d in positions)
                {
                    writer.WriteLine(d.Name + " - " + d.Price + " zł");
                }
                writer.WriteLine("Cena całkowita zamówienia: " + sum + " zł");
            }
            positions.Clear();
            sum = 0;
        }

        public void ClearOrder()
        {
            positions.Clear();
            sum = 0;
        }

        public int OrderCount()
        {
            return positions.Count();
        }
    }

}
