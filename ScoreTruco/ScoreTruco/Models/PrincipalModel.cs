using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ScoreTruco.Models
{
    internal class PrincipalModel
    {
        public int pontosDuplaUm { get; set; } = 0;
        public int pontosDuplaDois { get; set; } = 0;
        public bool duplaVerdeWin { get; set; } = false;
        public bool duplaAzulWin { get; set; } = false;
        public int vitoriasAzul { get; set; } = 0;
        public int vitoriasVerde { get; set; } = 0;
    }
}
