using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studia_programowanie_obietkowe_zaliczenie
{
    public class Dish
    {
        public string Name { get; set; }
        public double Price { get; set; }

        List<Dish> dishList = new List<Dish>();

        public void Add()
        {
            Dish newDish = new Dish();
            Console.WriteLine("Podaj nazwę dania: ");
            newDish.Name = Console.ReadLine();
            Console.WriteLine("Podaj cenę dania: ");
            newDish.Price = double.Parse(Console.ReadLine());
            dishList.Add(newDish);
        }

        public void Remove()
        {
            Console.WriteLine("Podaj nazwę dania, które chcesz usunąć: ");
            string name = Console.ReadLine();
            Dish dishToDelete = dishList.Find(x => x.Name == name);
            if (dishToDelete != null)
            {
                dishList.Remove(dishToDelete);
                Console.WriteLine("Danie " + name + "zostało usunięte.");
            }
            else
            {
                Console.WriteLine("Nie znaleziono dania o nazwie: " + name + ", upewnij się, że wprowadziłeś poprawną nazwę.");
            }
        }

        public void ShowDishes()
        {
            if(dishList.Count == 0)
            {
                Console.WriteLine("Brak dań.");
            }
            else
            {
                Console.WriteLine("Oto lista dań: ");
                foreach(Dish d in dishList) {
                    Console.WriteLine(d.Name + " - " + d.Price + " zł");
                }
            }
        }

        public void SearchForDish(string name)
        {
            Dish foundDish = dishList.Find(x => x.Name == name);
            if(foundDish != null)
            {
                Console.WriteLine("Znaleziono danie: " + foundDish.Name + " w cenie " + foundDish.Price + " zł");
            }
            else
            {
                Console.WriteLine("Nie znaleziono dania o wprowadzonej nazwie: " + name + " :(");
            }
        }
    }
}
