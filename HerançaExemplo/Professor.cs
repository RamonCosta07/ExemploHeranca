using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerançaExemplo
{
    class Professor : Pessoa
    {
        public double Salario { get; set; }
        public override void Apresentar() // Override serve para sobreescrever um método herdado
        {
            Console.WriteLine($"Me chamo {Nome}, sou um professor, meu salário é de R$ {Salario} reais e possuo {Idade} anos");
        }
    }
}
