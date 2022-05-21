using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Console.Write("Origem: ");
                    Posicao origem =  Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino=  Tela.lerPosicaoXadrez().toPosicao();

                    partida.executadaMovimento(origem,destino);
                }

                Console.ReadLine();
            }
            catch (TabuleiroException err)
            {
                Console.WriteLine(err.Message);
            }
            Console.ReadLine();
        }

    }
}
