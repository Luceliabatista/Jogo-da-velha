using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    internal class Jogo
    {

        adicionarJogador jogadorCadastrado = new adicionarJogador();

        public List<string> names;
        public bool fimDeJogo;
        public int[] posicoes = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public string jogadorX, jogadorO, jogador;
        public int quantidadePreenchida;


        public void JogoDaVelha()
        {
            fimDeJogo = false;
            quantidadePreenchida = 0;
        }

        public void ExecutarJogada(List<string> nome)
        {
            DefinirJogador();
            while (!fimDeJogo)
            {
                RenderizarTabela();
                EscolhaDoUsuario();
                RenderizarTabela();
                VerificarFimDeJogo();
                MudarJogador();
            }
        }

        private void DefinirJogador()
        {
            Console.WriteLine($"Para iniciarmos o jogo, antes precisamos que defina quem são os usuários jogadores");
            Console.Write($"Digite o CPF do(a) jogador(a) X: ");
            jogadorX = Console.ReadLine();
            Console.Write($"Digite o CPF do(a) jogador(a) O: ");
            jogadorO = Console.ReadLine();
            jogador = jogadorX;
        }

        public void MudarJogador()
        {
            jogador = jogador == jogadorX ? jogadorO : jogadorX;
        }
        public void VerificarFimDeJogo()
        {
            if (quantidadePreenchida < 5)
                return;

            if (VitoriaDiagonal() || VitoriaHorizontal() || VitoriaVertical())
            {
                fimDeJogo = true;
                Console.WriteLine($"Fim de Jogo!! {jogador} é o vencedor");
                return;
            }

            if (quantidadePreenchida is 9)
            {
                fimDeJogo = true;
                Console.WriteLine("Fim de Jogo!! Resultado: Empate");
            }
        }
        public bool VitoriaHorizontal()
        {
            bool vitoriaLinha1 = posicoes[0] == posicoes[1] && posicoes[0] == posicoes[2];
            bool vitoriaLinha2 = posicoes[3] == posicoes[4] && posicoes[3] == posicoes[5];
            bool vitoriaLinha3 = posicoes[6] == posicoes[7] && posicoes[6] == posicoes[8];

            return vitoriaLinha1 || vitoriaLinha2 || vitoriaLinha3;
        }

        public bool VitoriaVertical()
        {
            bool vitoriaLinha1 = posicoes[0] == posicoes[3] && posicoes[0] == posicoes[6];
            bool vitoriaLinha2 = posicoes[1] == posicoes[4] && posicoes[1] == posicoes[7];
            bool vitoriaLinha3 = posicoes[2] == posicoes[5] && posicoes[2] == posicoes[8];

            return vitoriaLinha1 || vitoriaLinha2 || vitoriaLinha3;
        }

        public bool VitoriaDiagonal()
        {
            bool vitoriaLinha1 = posicoes[2] == posicoes[4] && posicoes[2] == posicoes[6];
            bool vitoriaLinha2 = posicoes[0] == posicoes[4] && posicoes[0] == posicoes[8];

            return vitoriaLinha1 || vitoriaLinha2;
        }
        public void EscolhaDoUsuario()
        {
            Console.WriteLine($"Acima estão numeradas de 1 a 9 as posições disponiveis");
            Console.WriteLine($"Jogador(a) {jogador} Agora é a sua vez de jogar, escolha uma posição de 1 a 9, que ainda esteja disponível");

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
            posicoes[indice] = int.Parse(jogador);
            quantidadePreenchida++;
        }

        public bool ValidarEscolhaDoUsuario(int posicaoEscolhida)
        {
            int indice = posicaoEscolhida - 1;

            return posicoes[indice] != 'O' && posicoes[indice] != 'X';
        }

        public void RenderizarTabela()
        {
            Console.Clear();
            Console.WriteLine(ObterTabela());
        }

        public string ObterTabela()
        {
            return $"__{posicoes[0]}__|__{posicoes[1]}__|__{posicoes[2]}__\n" +
                   $"__{posicoes[3]}__|__{posicoes[4]}__|__{posicoes[5]}__\n" +
                   $"  {posicoes[6]}  |  {posicoes[7]}  |  {posicoes[8]}  \n\n";
        }

    }
}

