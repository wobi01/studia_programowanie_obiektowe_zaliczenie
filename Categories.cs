using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studia_programowanie_obietkowe_zaliczenie
{
    public class Category
    {
        public string Name { get; set; }
        public List<Dish>? Dishes { get; set; }

        public void AddDish(Dish dish)
        {
            this.Dishes.Add(dish);
        }

        public void DeleteDish(Dish dish)
        {
            this.Dishes.Remove(dish);
        }

        public List<Dish>
        ShowDish() => Dishes;
    }
}
