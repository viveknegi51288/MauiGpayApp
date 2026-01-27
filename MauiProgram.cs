using CommunityToolkit.Maui;
using MauiGPayApp.ViewModels;
using MauiGPayApp.Views;
using Microsoft.Extensions.Logging;

namespace MauiGPayApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("material_outlined.ttf", "MaterialOutlined");
                fonts.AddFont("material_rounded.ttf", "MaterialRounded");
                fonts.AddFont("material_sharp.ttf", "MaterialSharp");
            });
        RemoveEntryBorder();
        builder.RegisterViewModels();
        builder.RegisterViews();
        #if DEBUG
        builder.Logging.AddDebug();
        #endif
        return builder.Build();
        
      
    }
    
    
    private static void RemoveEntryBorder()
    {
        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("Borderless", (handler, view) =>
        {
#if ANDROID
            handler.PlatformView.Background = null;
            handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
#elif IOS
            handler.PlatformView.BackgroundColor = UIKit.UIColor.Clear;
            handler.PlatformView.Layer.BorderWidth = 0;
            handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#endif
        });

    }

    private static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddTransient<HomeViewModel>();
        return mauiAppBuilder;
    }
    
    private static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddTransient<HomeView>();
        return mauiAppBuilder;
    }
    
}