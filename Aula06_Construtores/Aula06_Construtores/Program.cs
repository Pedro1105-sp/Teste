using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06_Construtores
{
    // Classe Pessoa
    class Pessoa
    {
        // Atributos
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }



        // Construtor padrão - Declaração explicita - Não é obrigatório fazer a declaração, quando você cria uma classe, já vem um construtor explicito
        public Pessoa() { }






        // Sobrecarga de Métodos (method Overload)
        // Métodos que possuem a mesma assinatura (mesmo nome), porém com diferentes parâmetros, se chama Sobrecarga
        public Pessoa(string nome, double altura) {  //Sobrecarga do Primeiro método

            Nome = nome;
            Altura = altura;
                
        }

    }

    
    // Classe Principal
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar a classe
            Pessoa pessoa1 = new Pessoa();  //Construtor padrão

            Pessoa pessoa2 = new Pessoa("Pedro", 1.74);   //Utilizando o construtor de Sobrecarga

            Pessoa pessoa3 = new Pessoa
            {
                Nome = "Pedro",
                Altura = 1.74,
            };

            // Utilizando os métodos com sobrecarga
            Console.WriteLine(pessoa3.Nome + " " + pessoa3.Altura + " ");

            Console.ReadKey();

        }
    }
}
