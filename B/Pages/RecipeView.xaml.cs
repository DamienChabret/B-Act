using B.ViewModel;

namespace B.Pages;

public partial class RecipeView : ContentPage
{
	public RecipeView()
	{
        InitializeComponent();

		var test = new RecipeViewModel()
		{
			Description = "etape 1 faire salut",
			ID = 1,
			Name = "nom",
			Rating = 3
		};

		BindingContext = test;
	}
}