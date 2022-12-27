using System;

namespace JogoDaVelha
{
    internal class Jogo
    {

        public List<string> names = new List<string>();
        public List<int> ages = new List<int>();
        public List<string> cpfs = new List<string>();
        public bool fimDeJogo;
        public char[] posicoes = new char[9];
        public string cpfJogadorX, cpfJogadorO, jogador;
        public char icone;
        public int quantidadePreenchida;

        public void AdicionarJogador(List<string> names, List<int> ages, List<string> cpfs)
        {

            Console.WriteLine($"CADASTRO DE JOGADOR(A)");
            Console.WriteLine($"Digite o nome do(a) jogador(a): ");
            names.Add(Console.ReadLine());
            Console.WriteLine("Digite a Idade: ");
            ages.Add(int.Parse(Console.ReadLine()));
            Console.WriteLine("Digite o cpf: ");
            cpfs.Add(Console.ReadLine());

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Jogador cadastrado!");
            Console.WriteLine("-----------------------------------");

        }

        public void ExecutarJogada(List<string> names, List<int> ages, List<string> cpfs)
        {
            posicoes = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            fimDeJogo = false;
            quantidadePreenchida = 0;

            DefinirJogador(names, cpfs);
            Console.Clear();
            do
            {
                RenderizarTabela();
                EscolhaDoUsuario();
                RenderizarTabela();
                VerificarFimDeJogo();
                MudarJogador();

            } while (!fimDeJogo);
        }

        public void DefinirJogador(List<string> names, List<string> cpfs)
        {

            Console.WriteLine($"Para iniciarmos o jogo, antes precisamos que defina quem são os usuários jogadores");
            Console.Write($"Digite o CPF do(a) jogador(a) X: ");
            cpfJogadorX = Console.ReadLine();
            Console.Write($"Digite o CPF do(a) jogador(a) O: ");
            cpfJogadorO = Console.ReadLine();
            jogador = cpfJogadorX;

            int indexX = cpfs.FindIndex(cpf => cpf == cpfJogadorX);
            int indexO = cpfs.FindIndex(cpf => cpf == cpfJogadorO);

            if (indexX == -1)
            {
                Console.WriteLine("Jogador X ainda não cadastrado!");
                AdicionarJogador(names, ages, cpfs);
            }
            else
            {
                cpfJogadorX = names[indexX];
            }


            if (indexO == -1)
            {
                Console.WriteLine("Jogador O ainda não cadastrado!");
                AdicionarJogador(names, ages, cpfs);
            }
            else
            {
                cpfJogadorO = names[indexO];
            }

        }

        public void MudarJogador()
        {
            jogador = jogador == cpfJogadorX ? cpfJogadorO : cpfJogadorX;
        }
        public void VerificarFimDeJogo()
        {
            if (quantidadePreenchida < 5)
                return;

            if (VitoriaDiagonal() || VitoriaHorizontal() || VitoriaVertical())
            {
                fimDeJogo = true;
                Console.WriteLine($"Fim de Jogo!! {jogador} é o vencedor\n\n");
            }

            if (quantidadePreenchida is 9)
            {
                fimDeJogo = true;
                Console.WriteLine("Fim de Jogo!! Empate");
            }
                Console.WriteLine("Para voltar ao menu principal, tecle ENTER");
                Console.ReadLine();
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

            icone = jogador == cpfJogadorX ? 'X' : 'O';

            if (jogador == cpfJogadorX)
            {
                Console.WriteLine($"Jogador(a) {cpfJogadorX} Agora é a sua vez de jogar, escolha uma posição de 1 a 9, que ainda esteja disponível");
            }
            if (jogador == cpfJogadorO)
            {
                Console.WriteLine($"Jogador(a) {cpfJogadorO} Agora é a sua vez de jogar, escolha uma posição de 1 a 9, que ainda esteja disponível");
            }
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
            posicoes[indice] = icone;
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

