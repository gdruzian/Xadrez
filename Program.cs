using tabuleiro;
using xadrezclass;

namespace Xadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);

            tabuleiro.InserirPeca(new Torre(tabuleiro, Cor.Preto), new Posicao(0,0));
            tabuleiro.InserirPeca(new Rei(tabuleiro, Cor.Preto), new Posicao(2,0));
            tabuleiro.InserirPeca(new Rei(tabuleiro, Cor.Branco), new Posicao(6, 7));

            Tela.ImprimirTabuleiro(tabuleiro);

            Console.WriteLine();

            Console.WriteLine();
        }
    }
}
