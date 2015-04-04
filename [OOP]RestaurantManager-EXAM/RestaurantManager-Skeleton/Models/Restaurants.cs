using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{

    public class Restaurants : IRestaurant
    {
        private string name;
        private string location;

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name");
                }
                name = value;
            }
        }

        public string Location
        {
            get { return location; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Location");
                }
                location = value;
            }
        }

        public IList<IRecipe> Recipes { get; private set; }

        public Restaurants(string name, string location)
        {
            this.Name = name;
            this.Location = location;
            this.Recipes = new List<IRecipe>();
        }

        public void AddRecipe(IRecipe recipe)
        {
            this.Recipes.Add(recipe);
        }

        public void RemoveRecipe(IRecipe recipe)
        {
            for (int i = 0; i < this.Recipes.Count; i++)
            {
                this.Recipes.Remove(recipe);
            }
        }

        public string PrintMenu()
        {
            StringBuilder menu = new StringBuilder(string.Format("***** {0} - {1} *****", this.Name, this.Location));

            if (this.Recipes.Count == 0)
            {
                menu.Append("\nNo recipes... yet");
            }
            else
            {
                var drinks = this.Recipes.Where(recipe => recipe.GetType().Name == "Drink").ToList();

                if (drinks.Count != 0)
                {
                    menu.Append("\n~~~~~ DRINKS ~~~~~");
                    foreach (var drink in drinks)
                    {
                        menu.Append("\n"+drink);
                    }
                }

                var salads = this.Recipes.Where(recipe => recipe.GetType().Name == "Salad").ToList();
                if (salads.Count != 0)
                {
                    menu.Append("\n~~~~~ SALADS ~~~~~");
                    foreach (var salad in salads)
                    {
                        menu.Append("\n" + salad);
                    } 
                }
                
                var mainCourses = this.Recipes.Where(recipe => recipe.GetType().Name == "MainCourse").ToList();

                if (mainCourses.Count != 0)
                {
                    menu.Append("\n~~~~~ MAIN COURSES ~~~~~");
                    foreach (var mainCourse in mainCourses)
                    {
                        menu.Append("\n" + mainCourse);
                    }
                }
                

                var desserts = this.Recipes.Where(recipe => recipe.GetType().Name == "Dessert").ToList();
                if (desserts.Count != 0)
                {
                    menu.Append("\n~~~~~ DESSERTS ~~~~~");
                    foreach (var dessert in desserts)
                    {
                        menu.Append("\n" + dessert);
                    }  
                }
            }
            return menu.ToString();
        }
    }
}
