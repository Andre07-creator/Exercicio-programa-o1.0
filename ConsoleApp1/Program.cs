using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("80, 20, 40");
            string[] vetor1 = Console.ReadLine().Split(' ');
            int A1 = int.Parse(vetor1[0]);
            int B1 = int.Parse(vetor1[1]);
            int C1 = int.Parse(vetor1[2]);

            string[] vetor = Console.ReadLine().Split(' ');
            int A = int.Parse(vetor[0]);
            int B = int.Parse(vetor[1]);
            int C = int.Parse(vetor[2]);
            int Total = 0;

           

            if (0 <= A && A <= 100 && 0 <= B && B <= 100 && 0 <= C && C <= 100 && 0 <= A1 && A1 <= 100 && 0 <= B1 && B1 <= 100 && 0 <= C1 && C1 <= 100)
            {
                //A += 80;
                //B += 20;
                //C += 40;
                if (A > A1)
                {
                    Total += (A - A1); 
                }

                if (B > B1)
                {
                    Total += (B - B1);
                }

                if (C > C1)
                {
                    Total += (C - C1);
                }
                Console.WriteLine(Total);
            }

            else
            {
                Console.WriteLine("Números invalidos!");
            }

        }
    }
}
