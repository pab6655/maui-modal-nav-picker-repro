namespace PickerAndNavigation;

public partial class FirstPage : ContentPage
{
    public FirstPage()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new SecondPage());
    }
}