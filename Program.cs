using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace JogoDaVelha
{
    public class JogoDaVelha
    {
        static void Menu()
        {
            Console.WriteLine("Digite o número da opção desejada: ");
            Console.WriteLine("1 - Adicionar jogadores");
            Console.WriteLine("2 - Pontuação do último jogo");
            Console.WriteLine("3 - Histórico de pontuações");
            Console.WriteLine("4 - Jogar");
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vindo ao Jodo da Velha!");
            adicionarJogador novoJogador = new adicionarJogador();
            Jogo jogada = new Jogo();

            int option;
            do
            {
                Menu();
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0:
                        Console.WriteLine("Jogo encerrado!");
                        break;
                    case 1:
                        novoJogador.AdicionarJogador(novoJogador.names, novoJogador.nickNames, novoJogador.ages, novoJogador.cpfs);
                        break;
                    //case 2:
                    //    ConsultarPontuacaoUltimoJogo();
                    //    break;
                    //case 3:
                    //    ConsultarHistoricoDePontuacoes();
                    //    break;
                    case 4:
                        jogada.ExecutarJogada(jogada.names);
                        break;
                }
            } while (option != 0);


        }
    }
}
