namespace TareaOperacionesBasicas
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Presiona {count} vez";
            else
                CounterBtn.Text = $"Presiona {count} veces";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}