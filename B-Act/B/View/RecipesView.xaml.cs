using Model;

namespace B.View;

public partial class RecipesView : ContentPage
{
	public RecipesView()
	{
		InitializeComponent();

		RecipeManager manager = new RecipeManager();
		StackLayout g = testGrid;
        foreach (Recipe r in manager.GetAllRecipes())
		{
            Button btn = new Button();
			btn.Text = r.Name;
            btn.Clicked += (s, e) => { NavigateToRecipeView(s, e, r); };
            g.Children.Add(btn);
        }
	}

    /// <summary>
    /// Change the page in recipeView
    /// </summary>
    /// <param name="r"> Recipe to display on the view </param>
    private void NavigateToRecipeView(object? sender, EventArgs e, Recipe r)
    {
        RecipeView recipeView = new RecipeView();
        recipeView.BindingContext = r;
        Navigation.PushAsync(recipeView);
    }


}