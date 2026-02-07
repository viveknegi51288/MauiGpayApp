using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiGPayApp.Views;

public partial class Testing : ContentPage
{
    public Testing()
    {
        InitializeComponent();
    }

    double startX, startY;
    private void PanGesture_PanUpdated(object? sender, PanUpdatedEventArgs e)
    {
        if (sender is not View view)
            return;

        switch (e.StatusType)
        {
            case GestureStatus.Started:
                var bounds = AbsoluteLayout.GetLayoutBounds(view);
                startX = bounds.X;
                startY = bounds.Y;
                break;

            case GestureStatus.Running:
                double newX = startX + e.TotalX;
                double newY = startY + e.TotalY;

                // Clamp to visible screen (NOT scrollable content)
                double maxX = this.Width - view.Width - 20;
                double maxY = this.Height - view.Height - 20;
                

                newX = Math.Max(10, Math.Min(newX, maxX));
                newY = Math.Max(0, Math.Min(newY, maxY));

                AbsoluteLayout.SetLayoutBounds(
                    view,
                    new Rect(newX, newY, view.Width, view.Height)
                );
                break;
        }
    }
}