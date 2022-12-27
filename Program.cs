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
            Console.Clear();
            Console.WriteLine("Digite o número da opção desejada: ");
            Console.WriteLine("1 - Adicionar jogadores");
            Console.WriteLine("2 - Pontuação do último jogo");
            Console.WriteLine("3 - Histórico de pontuações");
            Console.WriteLine("4 - Jogar");
            Console.WriteLine("0 - Encerrar jogo");

        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vindo ao Jodo da Velha!");
            Jogo jogoDaVelha = new Jogo();

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
                        jogoDaVelha.AdicionarJogador(jogoDaVelha.names, jogoDaVelha.ages, jogoDaVelha.cpfs);
                        break;
                    //case 2:
                    //    ConsultarPontuacaoUltimoJogo();
                    //    break;
                    //case 3:
                    //    ConsultarHistoricoDePontuacoes();
                    //    break;
                    case 4:
                        jogoDaVelha.ExecutarJogada(jogoDaVelha.names, jogoDaVelha.ages, jogoDaVelha.cpfs);
                        break;
                }
            } while (option != 0);


        }
    }
}
