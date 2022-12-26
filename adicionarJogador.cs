using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha {
    class adicionarJogador {
        public List<string> names = new List<string>();
        public List<string> nickNames = new List<string>();
        public List<int> ages = new List<int>();
        public List<string> cpfs = new List<string>();

        public void AdicionarJogador( List<string> names, List<string> nickNames, List<int> ages, List<string> cpfs ) {
      
            for (int i = 0; i < 2; ++i) {
                Console.WriteLine($"Digite o nome do(a) {i + 1}º jogador: ");
                names.Add(Console.ReadLine());
                Console.WriteLine("Digite o apelido: ");
                nickNames.Add(Console.ReadLine());
                Console.WriteLine("Digite a Idade: ");
                ages.Add(int.Parse(Console.ReadLine()));
                Console.WriteLine("Digite o cpf: ");
                cpfs.Add(Console.ReadLine());

                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Jogador inscrito!");
                Console.WriteLine("-----------------------------------");
            }

            do {
                Console.WriteLine("Para o jogo ocorrer, é necessário haver 2 jogadores");
            } while (names.Count < 2);

        }

    }
}
