using Microsoft.Maui.Controls;

namespace OperacionesApp
{
    public partial class MainTabbedPage : TabbedPage
    {
        public MainTabbedPage()
        {
            InitializeComponent();
        }

        private void CalCuadrado(object sender, EventArgs e)
        {
            if (double.TryParse(lCuadrado.Text, out double lado))
            {
                double area = lado * lado;
                resCuadrado.Text = $" El Área del Cuadrado es: {area}";
            }
            else
            {
                DisplayAlert("Error", "Por favor, introduce un valor válido para el lado.", "OK");
            }
        }

        private void LimpiarCuadrado(object sender, EventArgs e)
        {
            lCuadrado.Text = string.Empty;
            resCuadrado.Text = string.Empty;
        }

        private void CalcCirculo(object sender, EventArgs e)
        {
            if (double.TryParse(raCirculo.Text, out double radio))
            {
                double area = Math.PI * radio * radio;
                resCirculo.Text = $"Área del Círculo: {area}";
            }
            else
            {
                DisplayAlert("Error", "Por favor, introduce un valor válido para el radio.", "OK");
            }
        }

        private void LimpiarCirculo(object sender, EventArgs e)
        {
            raCirculo.Text = string.Empty;
            resCirculo.Text = string.Empty;
        }

        private void CalcRectangulo(object sender, EventArgs e)
        {
            if (double.TryParse(baRectangulo.Text, out double baseRectangulo) &&
                double.TryParse(altRectangulo.Text, out double altura))
            {
                double area = baseRectangulo * altura;
                resRectangulo.Text = $"El Área del Rectángulo es: {area}";
            }
            else
            {
                DisplayAlert("Error", "Por favor, introduce valores válidos para la base y la altura.", "OK");
            }
        }

        private void OnLimpiarCamposRectanguloClicked(object sender, EventArgs e)
        {
            baRectangulo.Text = string.Empty;
            altRectangulo.Text = string.Empty;
            resRectangulo.Text = string.Empty;
        }
    }
}
