using TipCalculadora.ViewModels;

namespace TipCalculadora
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}
