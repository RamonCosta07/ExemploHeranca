using System;

namespace HerançaExemplo
{
    class Program
    {
        /* Exemplo de utilização de Herança
         * E Polimorfismo
         * No qual um classe Pessoa será usada
         * como classe pai para as classes
         * Professor e Aluno, onde ambas
         * herdaram os atributos Nome e Idade
         * Assim como o método Apresentar()
         * O método será sobreescrito com um
         * override para que seja possível
         * personalizar o método Apresentar
         * conforme a classe que tiver herdando
         * da classe pai
         */
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            a.Nome = "João";
            a.Idade = 14;
            a.Nota = 10.0;
            a.Apresentar();
            Console.WriteLine("*****************");

            Professor p = new Professor();
            p.Nome = "Paulo";
            p.Idade = 39;
            p.Salario = 1200.00;
            p.Apresentar();
            Console.WriteLine("*****************");

            Calculadora calc = new Calculadora();
            Console.WriteLine($"Calculando com dois parâmetros: {calc.Somar(1,4)}");
            Console.WriteLine($"Calculando com três parâmetros: {calc.Somar(1, 4, 3)}");
        }
    }
}
