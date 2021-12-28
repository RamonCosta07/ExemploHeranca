using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerançaExemplo
{
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar() // virtual significa que esse método pode ser reescrito
        {
            Console.WriteLine($"Me chamo {Nome} e possuo {Idade} anos");
        }
    }
}
