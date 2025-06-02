using System.Net.Http.Json;

namespace BoadaDana_Evaluación_2P
{
    public class Joke
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Setup { get; set; }
        public string Punchline { get; set; }
    }

    public partial class JokesPage : ContentPage
    {
        private readonly HttpClient _httpClient;
        private const string API_URL = "https://official-joke-api.appspot.com/random_joke";

        public JokesPage()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
            LoadJoke();
        }

        private async void OnNewJokeClicked(object sender, EventArgs e)
        {
            await LoadJoke();
        }

        private async Task LoadJoke()
        {
            try
            {
                jokeLabel.Text = "🔄 Cargando chiste...";
                newJokeButton.IsEnabled = false;
                newJokeButton.Text = "Cargando...";

                var joke = await _httpClient.GetFromJsonAsync<Joke>(API_URL);

                if (joke != null)
                {
                    jokeLabel.Text = $"😄 {joke.Setup}\n\n🎯 {joke.Punchline}";
                }
                else
                {
                    jokeLabel.Text = "❌ No se pudo cargar el chiste. Intente nuevamente.";
                }
            }
            catch (Exception ex)
            {
                jokeLabel.Text = $"⚠️ Error al cargar chiste:\n{ex.Message}";
            }
            finally
            {
                newJokeButton.IsEnabled = true;
                newJokeButton.Text = "🎭 Otro chiste";
            }
        }
    }
}