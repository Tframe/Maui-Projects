namespace CarouselMediaSample;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    void mediaElement_HandlerChanging(System.Object sender, Microsoft.Maui.Controls.HandlerChangingEventArgs e)
    {
        Console.WriteLine($"Changing handler from {e.OldHandler} to {e.NewHandler}");
    }

    void mediaElement_StateChanged(System.Object sender, CommunityToolkit.Maui.Core.Primitives.MediaStateChangedEventArgs e)
    {
        Console.WriteLine($"Changing State from {e.PreviousState} to {e.NewState}");
    }

    void mediaElement_ParentChanging(System.Object sender, Microsoft.Maui.Controls.ParentChangingEventArgs e)
    {
        Console.WriteLine($"Changing parent from {e.OldParent} to {e.NewParent}");
    }
}


