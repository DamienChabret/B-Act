using Data;
using Model.Interface;
namespace Model
{
    public class RecipeManager
    {
        private IRecipeDAO recipeDAO = new RecipeFakeDAO();
        private List<Recipe> recipes;

        /// <summary>
        /// Natural constructor of the manager
        /// </summary>
        public RecipeManager()
        {
            recipes = new List<Recipe>();
        }

        /// <summary>
        /// add a new recipe
        /// </summary>
        /// <param name="recipe"> recipe to add</param>
        public void AddRecipe(Recipe recipe)
        {
            this.recipeDAO.AddRecipe(recipe);
            recipes.Add(recipe);
        }

        /// <summary>
        /// Delete a recipe
        /// </summary>
        /// <param name="id"> id of the recipe to delete </param>
        public void DeleteRecipe(Recipe recipe)
        {
            this.recipeDAO.DeleteRecipe(recipe.ID);
            recipes.Remove(recipe);
        }

        /// <summary>
        /// Update a recipe
        /// </summary>
        /// <param name="recipe"> recipe to update </param>
        public Recipe UpdateRecipe(Recipe recipe)
        {
            Recipe updatedRecipe = this.recipeDAO.UpdateRecipe(recipe);
            Recipe r = this.GetRecipe(recipe);
            if (r != null)
            {
                r.Name = updatedRecipe.Name;
                r.Description = updatedRecipe.Description;
                r.Rating = updatedRecipe.Rating;
            }
            return r;
        }

        /// <summary>
        /// Get one recipe
        /// </summary>
        /// <param name="id"> id of the recipe </param>
        /// <returns> A recipe </returns>
        public Recipe GetRecipe(Recipe recipe)
        {
            return this.recipeDAO.GetRecipe(recipe.ID);
        }

        /// <summary>
        /// Get all the recipes
        /// </summary>
        /// <returns> all recipe existing </returns>
        public List<Recipe> GetAllRecipes()
        {
            return recipes;
        }
    }
}
