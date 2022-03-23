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
        private int pontosDuplaDois;
        protected bool duplaVerdeWin;
        protected bool duplaAzulWin;
        private int vitoriasAzul = 0;
        private int vitoriasVerde = 0;


        public Principal()
        {
            InitializeComponent();
            pontosDuplaUm = 0;
            pontosDuplaDois = 0;
            //ToolbarItems.Add(new ToolbarItem("Teste", "TXT", ResetScore(true)));
        }
        #region botões dupla verde
        private void UmPontoVerde(object sender, EventArgs e)
        {
            pontosDuplaUm += 1;
            LblDuplaVerde.Text = pontosDuplaUm.ToString();
            MensagemGanhador();
        }

        private void TrucoPontosVerde(object sender, EventArgs e)
        {
            pontosDuplaUm += 3;
            LblDuplaVerde.Text = pontosDuplaUm.ToString();
            MensagemGanhador();
        }

        private void SeisPontosVerde(object sender, EventArgs e)
        {
            pontosDuplaUm += 6;
            LblDuplaVerde.Text = pontosDuplaUm.ToString();
            MensagemGanhador();
        }

        private void NovePontosVerde(object sender, EventArgs e)
        {
            pontosDuplaUm += 9;
            LblDuplaVerde.Text = pontosDuplaUm.ToString();
            MensagemGanhador();
        }

        private void DozePontosVerde(object sender, EventArgs e)
        {
            pontosDuplaUm += 12;
            LblDuplaVerde.Text = pontosDuplaUm.ToString();
            MensagemGanhador();
        }
        #endregion

        #region botões dupla azul
        private void UmPontoAzul(object sender, EventArgs e)
        {
            pontosDuplaDois += 1;
            LblDuplaAzul.Text = pontosDuplaDois.ToString();
            MensagemGanhador();
        }

        private void TrucoPontosAzul(object sender, EventArgs e)
        {
            pontosDuplaDois += 3;
            LblDuplaAzul.Text = pontosDuplaDois.ToString();
            MensagemGanhador();
        }

        private void SeisPontosAzul(object sender, EventArgs e)
        {
            pontosDuplaDois += 6;
            LblDuplaAzul.Text = pontosDuplaDois.ToString();
            MensagemGanhador();
        }

        private void NovePontosAzul(object sender, EventArgs e)
        {
            pontosDuplaDois += 9;
            LblDuplaAzul.Text = pontosDuplaDois.ToString();
            MensagemGanhador();
        }

        private void DozePontosAzul(object sender, EventArgs e)
        {
            pontosDuplaDois += 12;
            LblDuplaAzul.Text = pontosDuplaDois.ToString();
            MensagemGanhador();
        }
        #endregion
        
        protected void MensagemGanhador()
        {
            duplaVerdeWin = pontosDuplaUm >= 12 ? true : false;
            duplaAzulWin = pontosDuplaDois >= 12 ? true : false;

            if(duplaVerdeWin || duplaAzulWin)
            {
                DisplayAlert("Fim de Jogo!", $@"A dupla {Ganhador()} ganhou!   
                 Verde {pontosDuplaUm} x {pontosDuplaDois} Azul",
                "Ok");
                FimPartida();
            }
        }

        protected string Ganhador()
        {
            if (duplaVerdeWin)
            {
                return "Verde";
            }
            if (duplaAzulWin)
            {
                return "Azul";
            }
            duplaAzulWin = false;
            duplaVerdeWin = false;
            return "";
        }

        protected void FimPartida()
        {
            ResetScore();
            if(duplaVerdeWin) vitoriasVerde++;
            if(duplaAzulWin) vitoriasAzul++;
            
            LblVitoriasAzul.Text = vitoriasAzul.ToString();
            LblVitoriasVerde.Text = vitoriasVerde.ToString();
        }
        public void ResetScore(bool resetgeral = false)
        {
            pontosDuplaUm = 0;
            pontosDuplaDois = 0;
            LblDuplaAzul.Text = "0";
            LblDuplaVerde.Text = "0";

            if (resetgeral)
            {
                vitoriasAzul = 0;
                vitoriasVerde = 0;
            }
        }
    }
}