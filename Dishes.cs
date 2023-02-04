using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studia_programowanie_obietkowe_zaliczenie
{

    public class Dish
    {

        public enum DishType
        {
            Fish,
            Soup,
            Meat,
            Starter
        }

        public string Name { get; set; }
        public double Price { get; set; }

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
