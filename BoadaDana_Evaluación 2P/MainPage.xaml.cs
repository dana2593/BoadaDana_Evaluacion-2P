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
                await Navigation.PushAsync(new PaginaChistes());

            }

            private async void OnAboutButtonClicked(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new AcercaDeMi());
            }
        }
    }
