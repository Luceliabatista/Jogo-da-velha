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

            adicionarJogador add = new adicionarJogador();

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
                        add.AdicionarJogador(add.names, add.nickNames, add.ages, add.cpfs);
                        break;
                        //case 2:
                        //    ConsultarPontuacaoUltimoJogo();
                        //    break;
                        //case 3:
                        //    ConsultarHistoricoDePontuacoes();
                        //    break;
                        //case 4:
                        //    IniciarNovoJogo()
                        //    break;
                }
            } while (option != 0);


        }
    }
}
