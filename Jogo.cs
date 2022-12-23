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
        public void ExecutarJogada(List<string> nome)
        {
            adicionarJogador novoJogador = new adicionarJogador();
            novoJogador.AdicionarJogador(novoJogador.names, novoJogador.nickNames, novoJogador.ages, novoJogador.cpfs);

            Console.WriteLine("Agora vamos lá!! Que comecem os jogos!! ");

            Console.WriteLine("-----------------------------------------------------------");

            Console.Write("___");
            Console.Write("|");
            Console.Write("___");
            Console.Write("|");
            Console.WriteLine("___");
            Console.Write("___");
            Console.Write("|");
            Console.Write("___");
            Console.Write("|");
            Console.WriteLine("___");
            Console.Write("___");
            Console.Write("|");
            Console.Write("___");
            Console.Write("|");
            Console.WriteLine("___");
            Console.Write("   ");
            Console.Write("|");
            Console.Write("   ");
            Console.Write("|");
            Console.WriteLine("   ");

            Console.WriteLine("Digite a jogada, na seguinte ordem, linha coluna(ex.: 1 2): ");
            string[] jogada = Console.ReadLine().Split(' ');
            int linha = int.Parse(jogada[0]);
            int coluna = int.Parse(jogada[1]);
            Console.WriteLine(linha + " " + coluna);

        }
    }
}
