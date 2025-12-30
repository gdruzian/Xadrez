namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int NumMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            Posicao = null;
            Tabuleiro = tabuleiro;
            Cor = cor;
            NumMovimentos = 0;
        }

        public void IncrementarQtdMovimentos()
        {
            NumMovimentos++;
        }

        public abstract bool[,] MovimentosPossiveis();
    }
}
