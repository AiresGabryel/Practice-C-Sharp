using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 
// Exemplo de uso de uma classe Pessoa
namespace ExemploFundamentos.Models
{
    // Classe Pessoa
    public class Pessoa
    {
        // Propriedades da classe Pessoa
        // Nome e Idade
        public string Nome { get; set; }
        public int Idade { get; set; }


        // Método para apresentar a pessoa
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, \n tenho {Idade} anos.");
        }
    }
}  