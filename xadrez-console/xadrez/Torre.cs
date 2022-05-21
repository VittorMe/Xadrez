using System;
using tabuleiro;
namespace xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(cor, tab)
        {

        }

        public override string ToString()
        {
            return "T";
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
            //acima
            pos.definirValores(posicao.Linha - 1, posicao.Coluna);
            while (tab.possicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != this.cor)
                    break;
                pos.Linha = pos.Linha - 1;
            }
            //abaixo
            pos.definirValores(posicao.Linha + 1, posicao.Coluna);
            while (tab.possicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != this.cor)
                    break;
                pos.Linha = pos.Linha + 1;
            }
            //direita
            pos.definirValores(posicao.Linha, posicao.Coluna + 1);
            while (tab.possicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != this.cor)
                    break;
                pos.Coluna = pos.Coluna + 1;
            }
            //Esquerda
            pos.definirValores(posicao.Linha, posicao.Coluna - 1);
            while (tab.possicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != this.cor)
                    break;
                pos.Coluna = pos.Coluna - 1;
            }
            return mat;
        }
    }
}
