using MauiGPayApp.ViewModels;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace MauiGPayApp.Views;

public abstract class BaseContentPage : ContentPage
{
    
    public BaseContentPage(BaseViewModel viewModel, string pageTitle = "")
    {
        BindingContext = ViewModel = viewModel;
        Title = pageTitle;
    }
    
    protected BaseViewModel ViewModel { get; }

    
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await ViewModel.Initialize();
    }
    
}