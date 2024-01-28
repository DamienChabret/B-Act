using Model;

namespace TestUnit
{
    public class RecipeManagerTest
    {
        private RecipeManager recipeManager;

        public RecipeManagerTest()
        {
            recipeManager = new RecipeManager();
        }

        [Fact]
        public void AddRecipe()
        {
            Recipe newRecipe = new Recipe() { ID = 6, Name = "New Recipe", Description = "New Description", Rating = 3 };

            recipeManager.AddRecipe(newRecipe);
            
            Assert.Contains(newRecipe, recipeManager.GetAllRecipes());
        }

        [Fact]
        public void DeleteRecipe()
        {
            Recipe newRecipe = new Recipe() { ID = 6, Name = "New Recipe", Description = "New Description", Rating = 3 };

            recipeManager.DeleteRecipe(newRecipe);

            Assert.Null(recipeManager.GetRecipe(newRecipe));
        }

        [Fact]
        public void GetRecipe()
        {
            Recipe newRecipe = new Recipe() { ID = 6, Name = "New Recipe", Description = "New Description", Rating = 3 };
            recipeManager.AddRecipe(newRecipe);

            Recipe retrievedRecipe = recipeManager.GetRecipe(newRecipe);

            Assert.NotNull(retrievedRecipe);
            Assert.Equal(newRecipe.ID, retrievedRecipe.ID);
        }

        [Fact]
        public void UpdateRecipe()
        {
            Recipe existingRecipe = new Recipe() { ID = 4, Name = "Existing Recipe", Description = "Existing Description", Rating = 2 };
            recipeManager.AddRecipe(existingRecipe);

            Recipe updatedRecipe = new Recipe() { ID = 4, Name = "Updated Recipe", Description = "Updated Description", Rating = 4 };
            
            recipeManager.UpdateRecipe(updatedRecipe);

            Recipe retrievedRecipe = recipeManager.GetRecipe(updatedRecipe);
            Assert.Equal(updatedRecipe.ID, retrievedRecipe.ID);
            Assert.Equal(updatedRecipe.Name, retrievedRecipe.Name);
            Assert.Equal(updatedRecipe.Description, retrievedRecipe.Description);
            Assert.Equal(updatedRecipe.Rating, retrievedRecipe.Rating);
        }
    }
}