using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite um numero inteiro: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite um numero inteiro");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" {num1 * num2}");

            Console.ReadLine();
        }
    }
}
