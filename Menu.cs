using System;
namespace studia_programowanie_obietkowe_zaliczenie
{

    public class Menu
    {
        List<Dish> dishList = new List<Dish>();

        public List<Dish> SearchByName(string name)
        {
            List<Dish> dishList = new List<Dish>();
            return dishList;
        }

        public void ShowDishes()
        {
            if (dishList.Count == 0)
            {
                Console.WriteLine("Brak dań.");
            }
            else
            {
                Console.WriteLine("Oto lista dań: ");
                foreach (Dish d in dishList)
                {
                    Console.WriteLine(d.Name + " - " + d.Price + " zł");
                }
            }
        }

        public List<Category> Category { get; set; }
        public void AddCategory(Category category)
        {
            this.Category.Add(category);
        }
        public void DeleteCategory(Category category)
        {
            Category.Remove(category);
        }
        public List<Category>
            ShowCategories()
        {
            return Category;
        }
    }
}

