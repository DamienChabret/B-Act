using Model;
using Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    /// <summary>
    /// Fake recipe DAO
    /// </summary>
    public class RecipeFakeDAO : IRecipeDAO
    {
        private List<Recipe> recipes = new List<Recipe>()
        {
            new Recipe() { Description = "description 1", ID = 1, Name = "name 1", Rating = 4 },
            new Recipe() { Description = "description 2", ID = 2, Name = "name 2", Rating = 5 },
            new Recipe() { Description = "description 3", ID = 3, Name = "name 3", Rating = 5 },
            new Recipe() { Description = "description 4", ID = 4, Name = "name 4", Rating = 2 },
            new Recipe() { Description = "description 5", ID = 5, Name = "name 5", Rating = 0 },
        };
        public void AddRecipe(Recipe recipe)
        {
            this.recipes.Add(recipe);
        }

        public void DeleteRecipe(int id)
        {
            this.recipes.Remove(GetRecipe(id));
        }

        public List<Recipe> GetRAllRecipe()
        {
            return this.recipes;
        }

        public Recipe GetRecipe(int id)
        {
            Recipe r = null;
            foreach(Recipe recipe in this.recipes)
            {
                if(recipe.ID == id)
                {
                    r = recipe;
                }
            }
            return r;
        }

        public Recipe UpdateRecipe(Recipe recipe)
        {
            Recipe oldRecipe = GetRecipe(recipe.ID);
            if(oldRecipe != null)
            {
                oldRecipe.Name = recipe.Name;
                oldRecipe.Description = recipe.Description;
                oldRecipe.Rating = recipe.Rating;
            }
            return oldRecipe;
        }
    }
}
