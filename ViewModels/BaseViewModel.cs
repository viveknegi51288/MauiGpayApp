using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiGPayApp.ViewModels;

public abstract class BaseViewModel : ObservableObject
{
    public bool IsConnected
    {
        get
        {
            return Connectivity.NetworkAccess == NetworkAccess.Internet;
        }
    }
    
    public BaseViewModel()
    {
    }
    
    public virtual async Task Initialize()
    {
        
    }
}