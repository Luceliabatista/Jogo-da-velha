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
        public bool fimDeJogo;
        public char[] posicoes;
        public char vez;
        public int quantidadePreenchida;


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
        public void LerEscolhaDoUsuario()
        {
            Console.WriteLine($"{vez} Agora é a ua ve de jogar, escolha uma posição de 1 a 9, que ainda esteja disponível");

            bool conversao = int.TryParse(Console.ReadLine(), out int posicaoEscolhida);

            while (!conversao || !ValidarEscolhaDoUsuario(posicaoEscolhida))
            {
                Console.WriteLine($"Campo inválido, por favor escolha uma posição de 1 a 9, que ainda esteja disponível");
                conversao = int.TryParse(Console.ReadLine(), out posicaoEscolhida);
            }
            PreencherEscolha(posicaoEscolhida);
        }

        public void PreencherEscolha(int posicaoEscolhida)
        {
            int indice = posicaoEscolhida - 1;
            posicoes[indice] = vez;
            quantidadePreenchida++;
        }

        public bool ValidarEscolhaDoUsuario(int posicaoEscolhida)
        {
            int indice = posicaoEscolhida - 1;

            return posicoes[indice] != 'O' && posicoes[indice] != 'X';
        }

    }
}

