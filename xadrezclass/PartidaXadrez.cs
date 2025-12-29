using tabuleiro;

namespace xadrezclass
{
    class PartidaXadrez
    {
        public Tabuleiro Tab { get; private set; }
        private int Turno;
        private Cor JogadorAtual;
        public bool Terminada { get; private set; }

        public PartidaXadrez()
        {
            Tab = new Tabuleiro(8, 8);
            Turno = 1;
            Terminada = false;
            JogadorAtual = Cor.Branco;
            ColocarPecas();
        }

        public void ExecutarMovimento(Posicao origem, Posicao final)
        {
            Peca p = Tab.RetirarPeca(origem);
            p.IncrementarQtdMovimentos();
            Peca PecaCapturada = Tab.RetirarPeca(final);
            Tab.InserirPeca(p, final);
        }

        private void ColocarPecas() 
        {
            Tab.InserirPeca(new Torre(Tab, Cor.Branco), new PosicaoXadrez('c', 1).ToPosicao());
        }
    }
}
