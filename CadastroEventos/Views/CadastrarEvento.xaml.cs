using CadastroEventos.Models;
using System.Diagnostics;

namespace CadastroEventos.Views
{
    public partial class CadastrarEvento : ContentPage
    {
        public CadastrarEvento()
        {
            InitializeComponent();
            BindingContext = new Evento();
        }

        private async void OnCadastrarEventoClicked(object sender, EventArgs e)
        {
            try
            {
                var evento = (Evento)BindingContext;

                await Navigation.PushAsync(new ResumoEvento(evento)
                {
                    BindingContext = evento
                });
            }

            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }



        }

        private void dtpck_dataInicio_DateSelected(object sender, DateChangedEventArgs e)
        {
            try
            {
                Debug.WriteLine($"Data de Início Selecionada: {e.NewDate}"); // Verifica a data selecionada
                var evento = (Evento)BindingContext;
                evento.DataInicio = e.NewDate;

                AtualizarDuracaoEvento();
            }
            catch (Exception ex)
            {
                DisplayAlert("Erro", ex.Message, "OK");
            }
        }


        private void dtpck_dataTermino_DateSelected(object sender, DateChangedEventArgs e)
        {
            try
            {
                var evento = (Evento)BindingContext;

                evento.DataTermino = e.NewDate;

                AtualizarDuracaoEvento();
            }
            catch (Exception ex)
            {
                DisplayAlert("Erro", ex.Message, "OK");
            }
        }

        private void AtualizarDuracaoEvento()
        {
            var evento = (Evento)BindingContext;
            lblDuracaoEvento.Text = $"Duração do evento: {evento.DuracaoEvento} dias.";
        }



    }
}
