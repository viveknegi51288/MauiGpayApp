namespace MauiGPayApp.Models;

public class People
{
    public string FullName { get; set; }
    public string Initials =>
        string.IsNullOrWhiteSpace(FullName)
            ? ""
            : string.Join("", FullName
                .Trim()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Take(2) 
                .Select(x => char.ToUpper(x[0])));
    
    
    public Color BackGroundColor => GetFixedColor(FullName);
    
    private static readonly Color[] Palette =
    {
        Color.FromArgb("#F44336"), // Red
        Color.FromArgb("#E91E63"), // Pink
        Color.FromArgb("#9C27B0"), // Purple
        Color.FromArgb("#673AB7"), // Deep Purple
        Color.FromArgb("#3F51B5"), // Indigo
        Color.FromArgb("#2196F3"), // Blue
        Color.FromArgb("#03A9F4"), // Light Blue
        Color.FromArgb("#009688"), // Teal
        Color.FromArgb("#4CAF50"), // Green
        Color.FromArgb("#8BC34A"), // Light Green
        Color.FromArgb("#FF9800"), // Orange
        Color.FromArgb("#FF5722"), // Deep Orange
        Color.FromArgb("#795548"), // Brown
        Color.FromArgb("#607D8B"), // Blue Grey
    };

    private static Color GetFixedColor(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            return Colors.Gray;

        int index = Math.Abs(name.Trim().ToLower().GetHashCode()) % Palette.Length;
        return Palette[index];
    }
    
    public string IconImage {get; set;}
}