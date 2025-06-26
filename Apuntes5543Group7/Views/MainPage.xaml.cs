namespace Apuntes5543Group7.Views;

public partial class MainPage : ContentPage
{
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnAboutClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }
}