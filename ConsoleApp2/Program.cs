using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe a disciplina: ");
            string disciplina = Console.ReadLine();
            Console.WriteLine("agora informe o nome do aluno(a): ");
            string aluno = Console.ReadLine();

            Console.WriteLine("informe a primeira nota: ");
            int nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("informe a segunda nota: ");
            int nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("informe a terceira nota: ");
            int nota3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("informe a quarta nota: ");
            int nota4 = Convert.ToInt32(Console.ReadLine());


            double media = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine("o aluno(a) " + aluno + " ficou com "+media+ " na media de " +disciplina);

            Console.ReadKey();

        }
    }
}
