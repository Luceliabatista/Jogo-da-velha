using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    internal class Jogo
    {

        public List<string> names;
        public List<string> ages;
        public List<string> cpfs;
        private bool fimDeJogo;
        private char[] posicoes;
        private char vez;
        private int quantidadePreenchida;


        public void JogoDaVelha()
        {
            fimDeJogo = false;
            posicoes = new[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            vez = 'X';
            quantidadePreenchida = 0;
        }

        public void ExecutarJogada(List<string> nome)
        {
            while (!fimDeJogo)
            {
                RenderizarTabela();
                EscolhaDoUsuario();
                RenderizarTabela();
                VerificarFimDeJogo();
                MudarVez();
            }
        }

    }
}

