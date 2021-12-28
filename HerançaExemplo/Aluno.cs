using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerançaExemplo
{
    class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public override void Apresentar() // Override serve para sobreescrever um método herdado
        {
            Console.WriteLine($"Me chamo {Nome}, sou um aluno, minha nota foi {Nota} e possuo {Idade} anos");
        }
    }
}
