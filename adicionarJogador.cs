using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha {
    internal class adicionarJogador {
        public string NomeCompleto;
        public string Cpf;
        public string Idade;

        public string[,] AdicionarJogador( string nome, string cpf, string idade, string nome2, string cpf2, string idade2 ) {
            string[,] lista = new string[2, 3];
            lista[0, 0] = nome;
            lista[1, 0] = cpf;
            lista[2, 0] = idade;
            lista[0, 1] = nome2;
            lista[1, 1] = cpf2;
            lista[2, 1] = idade2;
            return lista[0,0], lista[0,1];
        }

    }
}
