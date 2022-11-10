using ScoreTruco.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScoreTruco.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Principal : ContentPage
    {
        PrincipalModel principalModel;

        public Principal()
        {
            InitializeComponent();
            principalModel = new PrincipalModel();
        }
        #region botões dupla verde
        private void UmPontoVerde(object sender, EventArgs e)
        {
            principalModel.PontosDuplaUm += 1;
            LblDuplaVerde.Text = principalModel.PontosDuplaUm.ToString();
            MensagemGanhador();
        }

        private void TrucoPontosVerde(object sender, EventArgs e)
        {
            principalModel.PontosDuplaUm += 3;
            LblDuplaVerde.Text = principalModel.PontosDuplaUm.ToString();
            MensagemGanhador();
        }

        private void SeisPontosVerde(object sender, EventArgs e)
        {
            principalModel.PontosDuplaUm += 6;
            LblDuplaVerde.Text = principalModel.PontosDuplaUm.ToString();
            MensagemGanhador();
        }

        private void NovePontosVerde(object sender, EventArgs e)
        {
            principalModel.PontosDuplaUm += 9;
            LblDuplaVerde.Text = principalModel.PontosDuplaUm.ToString();
            MensagemGanhador();
        }

        private void DozePontosVerde(object sender, EventArgs e)
        {
            principalModel.PontosDuplaUm += 12;
            LblDuplaVerde.Text = principalModel.PontosDuplaUm.ToString();
            MensagemGanhador();
        }
        #endregion

        #region botões dupla azul
        private void UmPontoAzul(object sender, EventArgs e)
        {
            principalModel.PontosDuplaDois += 1;
            LblDuplaAzul.Text = principalModel.PontosDuplaDois.ToString();
            MensagemGanhador();
        }

        private void TrucoPontosAzul(object sender, EventArgs e)
        {
            principalModel.PontosDuplaDois += 3;
            LblDuplaAzul.Text = principalModel.PontosDuplaDois.ToString();
            MensagemGanhador();
        }

        private void SeisPontosAzul(object sender, EventArgs e)
        {

            principalModel.PontosDuplaDois += 6;
            LblDuplaAzul.Text = principalModel.PontosDuplaDois.ToString();
            MensagemGanhador();
        }

        private void NovePontosAzul(object sender, EventArgs e)
        {
            principalModel.PontosDuplaDois += 9;
            LblDuplaAzul.Text = principalModel.PontosDuplaDois.ToString();
            MensagemGanhador();
        }

        private void DozePontosAzul(object sender, EventArgs e)
        {
            principalModel.PontosDuplaDois += 12;
            LblDuplaAzul.Text = principalModel.PontosDuplaDois.ToString();
            MensagemGanhador();
        }
        #endregion

        protected void MensagemGanhador()
        {
            principalModel.DuplaVerdeWin = principalModel.PontosDuplaUm >= 12;
            principalModel.DuplaAzulWin = principalModel.PontosDuplaDois >= 12;


            if (principalModel.DuplaVerdeWin || principalModel.DuplaAzulWin)
            {
                DisplayAlert("Fim de Jogo!", $@"A dupla {Ganhador()} ganhou!   
                 Verde {principalModel.PontosDuplaUm} x {principalModel.PontosDuplaDois} Azul",
                "Ok");
                FimPartida();
            }

        }

        protected string Ganhador()
        {
            if (principalModel.DuplaVerdeWin)
            {
                return "Verde";
            }
            if (principalModel.DuplaAzulWin)
            {
                return "Azul";
            }
            principalModel.DuplaAzulWin = false;
            principalModel.DuplaVerdeWin = false;
            return "";
        }

        protected void FimPartida()
        {
            ResetScore();
            if (principalModel.DuplaVerdeWin) principalModel.VitoriasVerde++;
            if (principalModel.DuplaAzulWin) principalModel.VitoriasAzul++;

            LblVitoriasAzul.Text = principalModel.VitoriasAzul.ToString();
            LblVitoriasVerde.Text = principalModel.VitoriasVerde.ToString();
        }

        public void ResetScore(bool resetgeral = false)
        {
            principalModel.PontosDuplaUm = 0;
            principalModel.PontosDuplaDois = 0;
            LblDuplaAzul.Text = "0";
            LblDuplaVerde.Text = "0";

            if (resetgeral)
            {
                principalModel.VitoriasAzul = 0;
                principalModel.VitoriasVerde = 0;
            }
        }
    }
}