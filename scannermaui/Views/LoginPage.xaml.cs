using scannermaui.ViewModels;

namespace scannermaui.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage(LoginViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel; 
        }
    }
}