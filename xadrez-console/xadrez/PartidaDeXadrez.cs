﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using xadrez;

namespace xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro Tab { get; private set; }
        private int Turno;
        private Cor JogadorAtual;
        public bool Terminada { get; private set; }
        
        public PartidaDeXadrez()
        {
            Tab = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminada = false;
            colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tab.retirarPeca(origem);
            p.incrementarQteMovimentos();
            Peca pecaCapturada = Tab.retirarPeca(destino);
            Tab.colocarPeca(p, destino);
        }

        private void colocarPecas()
        {
            
            Tab.colocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('c', 1).toPosicao());
            Tab.colocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('c', 2).toPosicao());
            Tab.colocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('d', 2).toPosicao());
            Tab.colocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('e', 2).toPosicao());
            Tab.colocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('e', 1).toPosicao());
            Tab.colocarPeca(new Rei(Tab, Cor.Branca), new PosicaoXadrez('d', 1).toPosicao());

            Tab.colocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('c', 7).toPosicao());
            Tab.colocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('c', 8).toPosicao());
            Tab.colocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('d', 7).toPosicao());
            Tab.colocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('e', 7).toPosicao());
            Tab.colocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('e', 8).toPosicao());
            Tab.colocarPeca(new Rei(Tab, Cor.Preta), new PosicaoXadrez('d', 8).toPosicao());

        }
    }
}
