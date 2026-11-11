using TipCalculadora.ViewModels;

namespace TipCalculadora.Views;

public partial class MainPage : ContentPage
{
    
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();

        }
    
}