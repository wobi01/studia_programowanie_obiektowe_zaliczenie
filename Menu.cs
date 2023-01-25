using System;
namespace studia_programowanie_obietkowe_zaliczenie
{
    public class Menu
    {

        public List<Dish> SearchByName(string name)
        {
            List<Dish> dishes = new List<Dish>();
            return dishes;
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

