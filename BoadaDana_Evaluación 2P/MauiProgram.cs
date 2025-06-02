using Android.Content.Res;

namespace BoadaDana_Evaluación_2P
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnJokesButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new JokesPage());
        }

        private async void OnAboutButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }
    }
}