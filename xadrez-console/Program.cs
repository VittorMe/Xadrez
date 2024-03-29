﻿using System;
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
                Tela.ImprimirApresentacao();
                while (!partida.Terminada)
                {
                    try
                    {
                        Console.Clear();
                        Tela.imprimirPartida(partida);


                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeDestino(origem,destino);

                        partida.realizaJogada(origem, destino);
                    }
                    catch (TabuleiroException err)
                    {
                        Console.WriteLine(err.Message);
                        Console.ReadLine(); 
                    }
                    catch (Exception err)
                    {
                        Console.WriteLine(err.Message);
                        Console.ReadLine();
                    }
                    
                }
                Console.Clear();
                Tela.imprimirPartida(partida);
            }
            catch (TabuleiroException err)
            {
                Console.WriteLine(err.Message);
            }
            Console.ReadLine();
        }

    }
}
