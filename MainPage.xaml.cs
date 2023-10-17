using Microsoft.Maui.Controls;
using System;

namespace TareaOperacionesBasicas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSumButtonClicked(object sender, EventArgs e)
        {
            if (double.TryParse(Number1Entry.Text, out double number1) && double.TryParse(Number2Entry.Text, out double number2))
            {
                double result = number1 + number2;
                ResultLabel.Text = $"Resultado: {result}";
            }
        }

        private void OnSubtractButtonClicked(object sender, EventArgs e)
        {
            // Implementa la resta de manera similar
        }

        private void OnMultiplyButtonClicked(object sender, EventArgs e)
        {
            // Implementa la multiplicación de manera similar
        }

        private void OnDivideButtonClicked(object sender, EventArgs e)
        {
            // Implementa la división de manera similar
        }
    }
}
