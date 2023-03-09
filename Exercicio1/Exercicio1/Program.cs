using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("digite seu nome");
            String nome = Console.ReadLine();
            Console.WriteLine("digite seu endereco");
            string endereco = Console.ReadLine();
            Console.WriteLine("telefone");
            string telefone = Console.ReadLine();
            Console.WriteLine("aqui estao seus dados:");
            Console.WriteLine(nome);
            Console.WriteLine(endereco);
            Console.WriteLine(telefone);
            Console.ReadKey();

            
                

             
        }
    }
}

