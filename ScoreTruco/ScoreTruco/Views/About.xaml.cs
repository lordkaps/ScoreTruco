using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScoreTruco.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class About : ContentPage
    {

        public About()
        {
            InitializeComponent();
        }

        private async void Btlink(object sender, EventArgs e)
        {
            if (BindingContext is Models.AboutModel about)
                    await Launcher.OpenAsync(about.MoreInfoUrl);
        }
    }
}