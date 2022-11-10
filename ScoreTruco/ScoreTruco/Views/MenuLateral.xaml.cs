using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScoreTruco.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [Obsolete]
    public partial class MenuLateral : MasterDetailPage
    {
        public MenuLateral()
        {
            InitializeComponent();
        }

        private void BtResetGeral(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Principal());
            IsPresented = false;
        }

        private void BtLimpaPontos(object sender, EventArgs e)
        {

        }
    }
}