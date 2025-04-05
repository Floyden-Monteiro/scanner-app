using scannermaui.Models;
using scannermaui.ViewModels;

namespace scannermaui.Views;

public partial class SearchPage : ContentPage
{
    private SearchViewModel ViewModel => BindingContext as SearchViewModel;

    public SearchPage(SearchViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

}