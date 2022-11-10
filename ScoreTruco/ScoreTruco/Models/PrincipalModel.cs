namespace ScoreTruco.Models
{
    internal class PrincipalModel
    {
        public int PontosDuplaUm { get; set; } = 0;
        public int PontosDuplaDois { get; set; } = 0;
        public bool DuplaVerdeWin { get; set; } = false;
        public bool DuplaAzulWin { get; set; } = false;
        public int VitoriasAzul { get; set; } = 0;
        public int VitoriasVerde { get; set; } = 0;
    }
}
