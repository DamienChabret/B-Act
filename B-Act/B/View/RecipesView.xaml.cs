using Model;

namespace B.View;

public partial class RecipesView : ContentPage
{
	public RecipesView()
	{
		InitializeComponent();

		RecipeManager manager = new RecipeManager();
		Grid g = testGrid;
        foreach (Recipe r in manager.GetAllRecipes())
		{
            Button btn = new Button();
			btn.Text = r.Name;
            g.Children.Add(btn);
        }
	}


}