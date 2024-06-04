namespace MauiApp1;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }
    
    private void ImageSwitch_OnToggled(object? sender, ToggledEventArgs e)
    {
        MainThread.BeginInvokeOnMainThread(() => ChangeState(e.Value));
    }

    private void ChangeState(bool isVisible)
    {
        var thread = new Thread( () => VisualStateManager.GoToState(SampleImage, isVisible ? "Visible" : "Hidden"));
        thread.Start();
    }
}