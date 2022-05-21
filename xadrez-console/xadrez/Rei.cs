using System;
using tabuleiro;
namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(cor, tab)
        {

        }
        public override string ToString()
        {
            return "R";
        }
        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos.Linha, pos.Coluna);
            return p == null || p.cor != this.cor;
        }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];
            Posicao pos = new Posicao(0, 0);
            // acima
            pos.definirValores(posicao.Linha - 1, posicao.Coluna);
            if (tab.possicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            // diagonal superior direita
            pos.definirValores(posicao.Linha - 1, posicao.Coluna + 1);
            if (tab.possicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            // direita
            pos.definirValores(posicao.Linha, posicao.Coluna + 1);
            if (tab.possicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            // diagonal inferior direita
            pos.definirValores(posicao.Linha + 1, posicao.Coluna + 1);
            if (tab.possicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            // abaixo
            pos.definirValores(posicao.Linha + 1, posicao.Coluna);
            if (tab.possicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            // diagonal inferior esquerda
            pos.definirValores(posicao.Linha + 1, posicao.Coluna - 1);
            if (tab.possicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            // Esquerda
            pos.definirValores(posicao.Linha , posicao.Coluna - 1);
            if (tab.possicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            // diagonal superior esquerda
            pos.definirValores(posicao.Linha - 1, posicao.Coluna - 1);
            if (tab.possicaoValida(pos) && podeMover(pos))
                mat[pos.Linha, pos.Coluna] = true;

            return mat;
        }
    }
}
