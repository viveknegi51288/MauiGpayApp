using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiGPayApp.CustomControls;

public partial class HorizontalOptionItem : Grid
{
    public HorizontalOptionItem()
    {
        InitializeComponent();
    }
    
    public static readonly BindableProperty IconProperty = BindableProperty.Create(nameof(Icon), typeof(string), typeof(HorizontalOptionItem));
    public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(HorizontalOptionItem));
    
    public string? Icon
    {
        get => GetValue(IconProperty) as string;
        set => SetValue(IconProperty, value);
    }
    
    public string? Title
    {
        get => GetValue(TitleProperty) as string;
        set => SetValue(TitleProperty, value);
    }
    
    
}