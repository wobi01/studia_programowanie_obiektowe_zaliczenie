using System;
using System.Xml.Linq;
using System.IO;
using System.Collections.Generic;

namespace studia_programowanie_obietkowe_zaliczenie
{

    public class Menu
    {
        public List<Category> categories = new List<Category>();

        public List<string> SearchByName(string name)
        {
            List<string> result = new List<string>();
            foreach (Category c in categories)
            {
                foreach (Dish d in c.Dishes)
                {
                    if (d.Name.ToLower().Contains(name))
                        result.Add(String.Format("{0} - {1} zł\n", d.Name, Convert.ToString(d.Price)));
                }
            }
            if (result.Count == 0)
            {
                Console.Write("Brak dania o podanej nazwie.\n");
            }
            return result;
        }
        public void AddCategory(string CategoryName, List<Dish> Dishes)
        {
            Category c = new Category(CategoryName);
            foreach (Dish dish in Dishes)
            {
                c.AddDish(dish);
            }
            categories.Add(c);
        }

        public void AddCategory(Category category)
        {
            categories.Add(category);
        }
        public void DeleteCategory(string name)
        {
            categories.Remove(categories.Where(x => x.Name == name).ToList().First());
        }

        public string[] GetCategories()
        {
            string[] list = new string[categories.Count];
            for (int index = 0; index < categories.Count; index++)
            {
                list[index] = (index + 1) + ". " + categories[index].Name;
            }
            return list;
        }
    }
}

