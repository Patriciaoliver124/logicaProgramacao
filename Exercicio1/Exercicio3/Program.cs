using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("idade dos alunos"); 
            int idade1 = int.Parse(Console.ReadLine());
            Console.WriteLine("idade do segundo aluno");
            int idade2 = int.Parse(Console.ReadLine());
            Console.WriteLine("idade do terceiro");
            int idade3 = int.Parse(Console.ReadLine());
            Console.WriteLine("idade do quarto aluno");
            int idade4 = int.Parse(Console.ReadLine());
            Console.WriteLine("idade do quinto aluno");
            int idade5 = int.Parse(Console.ReadLine());
            int idadeMedia = (idade1 + idade2 + idade3 + idade4 + idade5)/5;
            Console.WriteLine("{0}", idadeMedia);

            Console.ReadLine(); 

            


        }
    }
}
