using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studia_programowanie_obietkowe_zaliczenie
{
    public class Dish
    {

        public enum DishType {
            Fish,
            Soup,
            Meat,
            Starter
        }

        public string Name { get; set; }
        public double Price { get; set; }

        List<Dish> dishList = new List<Dish>();

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

    public class FishDish : Dish
    {
        public FishDish() { }
    }

    public class Soup : Dish
    {
        public Soup() { }
    }

    public class MeatDish : Dish
    {
        public MeatDish() { }
    }

    public class Starter : Dish
    {
        public Starter() { }
    }
}
