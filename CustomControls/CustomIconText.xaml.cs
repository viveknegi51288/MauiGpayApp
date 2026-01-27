using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiGPayApp.CustomControls;

public partial class CustomIconText : ContentView
{
    public CustomIconText()
    {
        InitializeComponent();
    }
    
    public static readonly BindableProperty IconColorProperty = BindableProperty.Create(nameof(IconColor), typeof(Color), typeof(CustomIconText));
    public static readonly BindableProperty IconTextColorProperty = BindableProperty.Create(nameof(IconTextColor), typeof(Color), typeof(CustomIconText));
    public static readonly BindableProperty IconTextProperty = BindableProperty.Create(nameof(IconText), typeof(string), typeof(CustomIconText));
    public static readonly BindableProperty IconProperty = BindableProperty.Create(nameof(Icon), typeof(string), typeof(CustomIconText)); 
    public static readonly BindableProperty SelectIconCommandProperty = BindableProperty.Create(nameof(SelectIconCommand), typeof(ICommand), typeof(CustomIconText));
    
    public ICommand? SelectIconCommand
    {
        get => GetValue(SelectIconCommandProperty) as ICommand;
        set => SetValue(SelectIconCommandProperty, value);
    }
    
    public Color? IconColor
    {
        get => GetValue(IconColorProperty) as Color;
        set => SetValue(IconColorProperty, value);
    }
    
    public Color? IconTextColor
    {
        get => GetValue(IconTextColorProperty) as Color;
        set => SetValue(IconTextColorProperty, value);
    }
    
    public string? IconText
    {
        get => GetValue(IconTextProperty) as string;
        set => SetValue(IconTextProperty, value);
    }
    
    public string? Icon
    {
        get => GetValue(IconProperty) as string;
        set => SetValue(IconProperty, value);
    }
    
    
    
    
}

