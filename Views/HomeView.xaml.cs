using MauiGPayApp.ViewModels;

namespace MauiGPayApp.Views;

public partial class HomeView
{
    public HomeView(HomeViewModel viewModel):base(viewModel)
    {
        InitializeComponent();
        ChangeTextWithAnimation();
    }
    
    async void ChangeTextWithAnimation()
    {
        List<string> texts = new()
        {
            "Pay by name",
            "Pay by phone number",
            "Search contact",
            "Enter UPI ID"
        };

        int index = 0;
        while (true)
        {
            if (string.IsNullOrEmpty(searchEntry.Text))
            {
                searchEntry.TranslationY = 12;
                searchEntry.Opacity = 0;

                searchEntry.Placeholder = texts[index];

                // Slide up + fade in
                await Task.WhenAll(
                    searchEntry.TranslateTo(0, 0, 250, Easing.CubicOut),
                    searchEntry.FadeTo(1, 250)
                );

                // Move to next text (simple, readable)
                index++;
                if (index >= texts.Count)
                    index = 0;
               
            }

            await Task.Delay(2000);
        }
    }
}