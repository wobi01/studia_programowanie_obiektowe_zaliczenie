using System;
namespace studia_programowanie_obietkowe_zaliczenie
{
    public class Menu
    {

        public List<Dish> SearchByName(string name)
        {
            // Code for searching dish by name
        }

        public List<Categories> Category { get; set; }
        public void AddCategory(Categories Category)
        {
            Category.Add(Category);
        }
        public void DeleteCategory(Categories Category)
        {
            Category.Remove(Category);
        }
        public List<Categories>
            ShowCategories()
        {
            return Categories;
        }
    }
}

