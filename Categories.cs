using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static studia_programowanie_obietkowe_zaliczenie.Dish;

namespace studia_programowanie_obietkowe_zaliczenie
{
    public class Category
    {
        public string Name { get; set; }
        public List<Dish> Dishes = new List<Dish>();

        public Category(string name)
        {
            Name = name;
        }
        public void AddDish(DishType type, string name, double price)
        {
            Dish dish = new Dish();
            switch (type)
            {
                case DishType.Fish:
                    dish = new FishDish();
                    dish.Name = name;
                    dish.Price = price;
                    break;
                case DishType.Soup:
                    dish = new Soup();
                    dish.Name = name;
                    dish.Price = price;
                    break;
                case DishType.Meat:
                    dish = new MeatDish();
                    dish.Name = name;
                    dish.Price = price;
                    break;
                case DishType.Starter:
                    dish = new Starter();
                    dish.Name = name;
                    dish.Price = price;
                    break;
            }
            Dishes.Add(dish);
        }
        public void AddDish(Dish dish)
        {
            Dishes.Add(dish);
        }

        public void DeleteDish(string name)
        {
            Dishes.Remove(Dishes.Where(x => x.Name == name).ToList().First());
        }

        public void DeleteDish(int index)
        {
            Dishes.RemoveAt(index);
        }


        public string[] GetDishes()
        {
            string[] list = new string[Dishes.Count];
            for (int index = 0; index < Dishes.Count; index++)
            {
                list[index] = (index + 1) + ". " + Dishes[index].Name;

                list[index] = String.Format("{0}. {1} - {2} zł", (index + 1), Dishes[index].Name, Convert.ToString(Dishes[index].Price));
            }
            return list;
        }

        public Dish GetDish(int index)
        {
            return Dishes[index - 1];
        }

    }
}
