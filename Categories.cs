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
        public List<Dish>? Dishes { get; set; }

        public void AddDish(DishType type, string name, double price)
        {
            Dish dish;
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
        }

        public void DeleteDish(string name)
        {
            Dishes.Remove(Dishes.Where(x => x.Name == name).ToList().First());
        }

        public string GetDishes()
        {

        }
    }
}
