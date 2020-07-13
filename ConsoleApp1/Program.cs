using ConsoleApp1.Entites;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor1 = Console.ReadLine().Split(' ');
            int a1 = int.Parse(vetor1[0]);
            int b1 = int.Parse(vetor1[1]);
            int c1 = int.Parse(vetor1[2]);

            string[] vetor = Console.ReadLine().Split(' ');
            int a = int.Parse(vetor[0]);
            int b = int.Parse(vetor[1]);
            int c = int.Parse(vetor[2]);
            Quant_atendido qtd_a = new Quant_atendido(a1, b1, c1, a, b, c);


            if (qtd_a.Calculo_Atendi())
            {
                Console.WriteLine(qtd_a.Total);
            }
            else
            {
                Console.WriteLine("Algum número não corresponde aos valores pre-determinados!");
            }
        }
    }
}
