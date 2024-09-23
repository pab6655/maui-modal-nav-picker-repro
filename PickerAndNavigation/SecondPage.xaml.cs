namespace PickerAndNavigation;

public partial class SecondPage : ContentPage
{
    public SecondPage()
    {
        InitializeComponent();
    }

    override protected async void OnAppearing()
    {
        await Task.Delay(500);

        _entry.Focus();

        base.OnAppearing();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}