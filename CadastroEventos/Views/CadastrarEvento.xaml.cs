using CadastroEventos.Models;
using CadastroEventos.Views;
using Microsoft.Maui.Controls;

namespace CadastroEventos.Views
{
    public partial class CadastrarEvento : ContentPage
    {
        public CadastrarEvento()
        {
            InitializeComponent();
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
            DatePicker elemento = sender as DatePicker;

            DateTime data_selecionada_dataInicio = elemento.Date;

            dtpck_dataInicio.MinimumDate = data_selecionada_dataInicio.AddDays(1);
            dtpck_dataTermino.MaximumDate = data_selecionada_dataInicio.AddMonths(6);
        }
    }
}
