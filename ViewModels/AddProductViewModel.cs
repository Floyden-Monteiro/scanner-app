using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Maui.Views;
using CommunityToolkit.Maui.Alerts;
using scannermaui.Models;
using scannermaui.Services.interfaces;
using System.ComponentModel.DataAnnotations;

namespace scannermaui.ViewModels
{
    public partial class AddProductViewModel : ObservableObject
    {
        private readonly IApiService _apiService;
        private readonly Popup _popup;

        [ObservableProperty]
        private string _barcode;

        [ObservableProperty]
        private string _name;

        [ObservableProperty]
        private decimal _price;

        [ObservableProperty]
        private ImageSource _selectedImage;

        [ObservableProperty]
        private FileResult _imageFile;

        [ObservableProperty]
        private bool _isBusy;

        [ObservableProperty]
        private string _errorMessage;

        [ObservableProperty]
        private bool _isEditMode;

        [ObservableProperty]
        private string _imageUrl;

        public AddProductViewModel(IApiService apiService, Popup popup)
        {
            _apiService = apiService;
            _popup = popup;
        }

        [RelayCommand]
        private async Task Add()
        {
            if (string.IsNullOrWhiteSpace(Barcode) ||
                string.IsNullOrWhiteSpace(Name) ||
                Price <= 0)
            {
                ErrorMessage = "Please fill all required fields";
                return;
            }

            try
            {
                IsBusy = true;
                string imageUrl = null;

                if (ImageFile != null)
                {

                    using var stream = await ImageFile.OpenReadAsync();
                    imageUrl = await _apiService.UploadImageToCloudinary(stream, ImageFile.FileName);
                }
                else if (IsEditMode)
                {

                    imageUrl = ImageUrl;
                }

                var product = new Product
                {
                    Barcode = Barcode.Trim(),
                    Name = Name.Trim(),
                    Price = Price,
                    ImageUrl = imageUrl
                };

                var response = IsEditMode
                    ? await _apiService.UpdateProductAsync(Barcode, product)
                    : await _apiService.AddProductAsync(product);

                if (response.StatusCode == 200)
                {
                    await _popup.CloseAsync(true);
                }
                else
                {
                    ErrorMessage = response.Message;
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            finally
            {
                IsBusy = false;
            }
        }

        [RelayCommand]
        private async Task PickImage()
        {
            try
            {
                var result = await MediaPicker.PickPhotoAsync();
                if (result != null)
                {
                    ImageFile = result;
                    SelectedImage = ImageSource.FromFile(result.FullPath);
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }

        [RelayCommand]
        private async Task Cancel() => await _popup.CloseAsync(false);
    }
}