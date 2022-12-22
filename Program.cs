using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel.Design;

/*Jogo da velha
- Adicionar jogadores (com nome)
- Pontuação total (vitórias, empates e derrotas)
- histórico das últimas partidas 
- opção jogar*/

namespace JogoDaVelha {
    public class JogoDaVelha {
        static void Menu() {
            Console.WriteLine("Digite o número da opção desejada: ");
            Console.WriteLine("1 - Adicionar jogadores");
            Console.WriteLine("2 - Pontuação do último jogo");
            Console.WriteLine("3 - Histórico de pontuações");
            Console.WriteLine("4 - Jogar");
        }

        public static void Main( string[] args ) {
            Menu();
            int option = int.Parse(Console.ReadLine());

            switch (option) {
                case 1:
                    AdicinarJogador();
                    break;
                case 2:
                    ConsultarPontuacaoUltimoJogo();
                    break;
                case 3:
                    ConsultarHistoricoDePontuacoes();
                    break;
                case 4:
                    IniciarNovoJogo()
                    break;
            }

            int resposta = int.Parse(Console.ReadLine());
            if (resposta == 1) {
                adicionarJogador novoJogador = new adicionarJogador();
                Console.WriteLine("Digite seu nome: ");
                novoJogador.NomeCompleto = Console.ReadLine();
                Console.WriteLine("Digite seu cpf: ");
                novoJogador.Cpf = Console.ReadLine();
                Console.WriteLine("Digite sua Idade: ");
                novoJogador.Idade = Console.ReadLine();

            }
            //else
            //if (resposta == 2) { }
            //else
            //if (resposta == 3) { }
            //else
            //if (resposta == 4) { 

            //}
            else { Console.WriteLine("Opção desconhecida"); }


        }
    }
}
