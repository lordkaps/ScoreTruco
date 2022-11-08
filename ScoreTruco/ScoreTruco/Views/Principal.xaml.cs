using ScoreTruco.Models;
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
        PrincipalModel principalModel;

        public Principal()
        {
            InitializeComponent();
            if(BindingContext is Models.PrincipalModel model)
            {
                principalModel = model;
            }

        }
        #region botões dupla verde
        private void UmPontoVerde(object sender, EventArgs e)
        {
            principalModel.pontosDuplaUm += 1;
            LblDuplaVerde.Text = principalModel.pontosDuplaUm.ToString();
            MensagemGanhador();
        }

        private void TrucoPontosVerde(object sender, EventArgs e)
        {
            principalModel.pontosDuplaUm += 3;
            LblDuplaVerde.Text = principalModel.pontosDuplaUm.ToString();
            MensagemGanhador();
        }

        private void SeisPontosVerde(object sender, EventArgs e)
        {
            principalModel.pontosDuplaUm += 6;
            LblDuplaVerde.Text = principalModel.pontosDuplaUm.ToString();
            MensagemGanhador();
        }

        private void NovePontosVerde(object sender, EventArgs e)
        {
            principalModel.pontosDuplaUm += 9;
            LblDuplaVerde.Text = principalModel.pontosDuplaUm.ToString();
            MensagemGanhador();
        }

        private void DozePontosVerde(object sender, EventArgs e)
        {
            principalModel.pontosDuplaUm += 12;
            LblDuplaVerde.Text = principalModel.pontosDuplaUm.ToString();
            MensagemGanhador();
        }
        #endregion

        #region botões dupla azul
        private void UmPontoAzul(object sender, EventArgs e)
        {
            principalModel.pontosDuplaDois += 1;
            LblDuplaAzul.Text = principalModel.pontosDuplaDois.ToString();
            MensagemGanhador();
        }

        private void TrucoPontosAzul(object sender, EventArgs e)
        {
                principalModel.pontosDuplaDois += 3;
                LblDuplaAzul.Text = principalModel.pontosDuplaDois.ToString();
            MensagemGanhador();
        }

        private void SeisPontosAzul(object sender, EventArgs e)
        {

            principalModel.pontosDuplaDois += 6;
                LblDuplaAzul.Text = principalModel.pontosDuplaDois.ToString();
            MensagemGanhador();
        }

        private void NovePontosAzul(object sender, EventArgs e)
        {
            principalModel.pontosDuplaDois += 9;
                LblDuplaAzul.Text = principalModel.pontosDuplaDois.ToString();
            MensagemGanhador();
        }

        private void DozePontosAzul(object sender, EventArgs e)
        {
                principalModel.pontosDuplaDois += 12;
                LblDuplaAzul.Text = principalModel.pontosDuplaDois.ToString();
            MensagemGanhador();
        }
        #endregion

        protected void MensagemGanhador()
        {
            principalModel.duplaVerdeWin = principalModel.pontosDuplaUm >= 12;
            principalModel.duplaAzulWin = principalModel.pontosDuplaDois >= 12;


                if (principalModel.duplaVerdeWin || principalModel.duplaAzulWin)
                {
                    DisplayAlert("Fim de Jogo!", $@"A dupla {Ganhador()} ganhou!   
                 Verde {principalModel.pontosDuplaUm} x {principalModel.pontosDuplaDois} Azul",
                    "Ok");
                    FimPartida();
                }
            
        }

        protected string Ganhador()
        {
                if (principalModel.duplaVerdeWin)
                {
                    return "Verde";
                }
                if (principalModel.duplaAzulWin)
                {
                    return "Azul";
                }
            principalModel.duplaAzulWin = false;
            principalModel.duplaVerdeWin = false;
            return "";
        }

        protected void FimPartida()
        {
            ResetScore();
            if (principalModel.duplaVerdeWin) principalModel.vitoriasVerde++;
            if (principalModel.duplaAzulWin) principalModel.vitoriasAzul++;

            LblVitoriasAzul.Text = principalModel.vitoriasAzul.ToString();
            LblVitoriasVerde.Text = principalModel.vitoriasVerde.ToString();
        }
        public void ResetScore(bool resetgeral = false)
        {
            principalModel.pontosDuplaUm = 0;
            principalModel.pontosDuplaDois = 0;
            LblDuplaAzul.Text = "0";
            LblDuplaVerde.Text = "0";

            if (resetgeral)
            {
                principalModel.vitoriasAzul = 0;
                principalModel.vitoriasVerde = 0;
            }
        }
    }
}