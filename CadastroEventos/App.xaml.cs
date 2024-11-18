using CadastroEventos.Views;

namespace CadastroEventos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new CadastrarEvento());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 500;
            window.Height = 850;

            return window;
        }
    }
}
