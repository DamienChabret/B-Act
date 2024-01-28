using B.View;
using B.ViewModel;

namespace B
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new RecipesView());
        }
    }
}
