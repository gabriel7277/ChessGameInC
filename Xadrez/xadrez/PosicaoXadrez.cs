﻿using System;
using xadrez;
using tabuleiro;


namespace xadrez
{
    internal class PosicaoXadrez
    {
        public Char coluna {  get; set; }
        public int linha { get; set; }



        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha; 
        }

        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a');
        }

        public override string ToString()
        {
            return "" + coluna + linha;
        }

    }
}
