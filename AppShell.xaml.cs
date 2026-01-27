using MauiGPayApp.Views;

namespace MauiGPayApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(HomeView), typeof(HomeView));
    }
}