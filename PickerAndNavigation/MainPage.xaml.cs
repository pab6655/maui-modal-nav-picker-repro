namespace PickerAndNavigation
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void NavigateBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new FirstPage());
        }
    }

}
