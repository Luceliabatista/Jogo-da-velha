using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    class adicionarJogador
    {
        public List<string> names = new List<string>();
        public List<string> nickNames = new List<string>();
        public List<int> ages = new List<int>();
        public List<string> cpfs = new List<string>();

        public void AdicionarJogador(List<string> names, List<string> nickNames, List<int> ages, List<string> cpfs)
        {
            Console.WriteLine("Digite seu nome: ");
            names.Add(Console.ReadLine());
            Console.WriteLine("Digite seu apelido: ");
            nickNames.Add(Console.ReadLine());
            Console.WriteLine("Digite sua Idade: ");
            ages.Add(int.Parse(Console.ReadLine()));
            Console.WriteLine("Digite seu cpf: ");
            cpfs.Add(Console.ReadLine());

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Jogador inscrito!");
            Console.WriteLine("-----------------------------------");
        }

    }
}
