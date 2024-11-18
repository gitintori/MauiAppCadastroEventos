using CadastroEventos.Models;

namespace CadastroEventos.Views
{
    public partial class ResumoEvento : ContentPage
    {
        public ResumoEvento(Evento evento)
        {
            InitializeComponent();

            if (evento == null)
            {
                DisplayAlert("Erro", "Evento não encontrado.", "OK");
                return;
            }

            BindingContext = evento;

            LabelDataInicio.Text = evento.DataInicio.ToString("dd/MM/yyyy");
            LabelDataTermino.Text = evento.DataTermino.ToString("dd/MM/yyyy");
        }

        private async void OnButtonVoltarClicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}
