using B.ViewModel;

namespace B.View;

public partial class RecipeView : ContentPage
{
	public RecipeView()
	{
		InitializeComponent();

        var recipe = new RecipeViewModel()
        {
            Description = "etape 1 faire salut",
            ID = 1,
            Name = "nom",
            Rating = 3
        };

        BindingContext = recipe;
    }
}