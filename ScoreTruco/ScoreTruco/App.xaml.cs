using ScoreTruco.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScoreTruco
{
    public partial class App : Application
    {
        [Obsolete]
        public App()
        {
            InitializeComponent();

            var pagina = new MenuLateral();

            MainPage = pagina;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
