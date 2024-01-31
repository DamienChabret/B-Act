using CommunityToolkit.Mvvm.ComponentModel;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.ViewModel
{
    /// <summary>
    /// ViewModel of the Recipe Model
    /// </summary>
    public partial class RecipeViewModel : ObservableObject
    {
        [ObservableProperty]
        private int recipeId;
        [ObservableProperty]
        private string recipeName;
        [ObservableProperty]
        private string recipeDescription;
        [ObservableProperty]
        private int recipeRating;

        public RecipeViewModel(Recipe recipe)
        {
            recipeId = recipe.ID;
            recipeName = recipe.Name;
            recipeDescription = recipe.Description;
            recipeRating = recipe.Rating;
        }
    }
}
