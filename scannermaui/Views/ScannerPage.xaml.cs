using Microsoft.Maui.Controls;
using scannermaui.ViewModels;

namespace scannermaui.Views
{
    public partial class ScannerPage : ContentPage
    {
        public ScannerPage(ScannerViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel; 
        }
    }
}