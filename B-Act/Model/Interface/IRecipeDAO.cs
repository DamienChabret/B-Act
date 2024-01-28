using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interface
{
    /// <summary>
    /// Interface for interact with the database
    /// </summary>
    public interface IRecipeDAO
    {
        /// <summary>
        /// add a new recipe
        /// </summary>
        /// <param name="recipe"> recipe to add</param>
        public void AddRecipe(Recipe recipe);

        /// <summary>
        /// Delete a recipe
        /// </summary>
        /// <param name="id"> id of the recipe to delete </param>
        public void DeleteRecipe(int id);

        /// <summary>
        /// Update a recipe
        /// </summary>
        /// <param name="recipe"> recipe to update </param>
        public void UpdateRecipe(Recipe recipe);

        /// <summary>
        /// Get one recipe
        /// </summary>
        /// <param name="id"> id of the recipe </param>
        /// <returns> A recipe </returns>
        public Recipe GetRecipe(int id);

        /// <summary>
        /// Get all the recipes
        /// </summary>
        /// <returns> all recipe existing </returns>
        public List<Recipe> GetRAllRecipe();
    }
}
