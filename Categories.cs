using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studia_programowanie_obietkowe_zaliczenie
{
    internal class Categories
    {
        public string Name { get; set; }
        public List<Dish> Dishes { get; set; }

        public void AddDish(Dish dish)
        {
            Dish.Add(dish);
        }

        public void DeleteDish(Dish dish)
        {
            Dish.Remove(dish);
        }

        public List<Dish>
        ShowDish()
    {
        return Dishes;
    }
    }
}
