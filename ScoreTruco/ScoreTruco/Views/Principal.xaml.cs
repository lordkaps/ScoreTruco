using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScoreTruco.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Principal : ContentPage
    {
        private int pontosDuplaUm;
        //private int pontosDuplaDois = 0;

        public Principal()
        {
            InitializeComponent();
            pontosDuplaUm = 0;
        }

        private void UmPonto(object sender, EventArgs e)
        {
            pontosDuplaUm += 1;
            LblDuplaVerde.Text = pontosDuplaUm.ToString();
        }

        private void TrucoPontos(object sender, EventArgs e)
        {
            pontosDuplaUm += 3;
            LblDuplaVerde.Text = pontosDuplaUm.ToString();
        }

        private void SeisPontos(object sender, EventArgs e)
        {
            pontosDuplaUm += 6;
            LblDuplaVerde.Text = pontosDuplaUm.ToString();
        }

        private void NovePontos(object sender, EventArgs e)
        {
            pontosDuplaUm += 9;
            LblDuplaVerde.Text = pontosDuplaUm.ToString();
        }

        private void DozePontos(object sender, EventArgs e)
        {
            pontosDuplaUm += 12;
            LblDuplaVerde.Text = pontosDuplaUm.ToString();
        }


    }
}