using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_avali_p2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] notas = new int[25];
            int[] notas2 = new int[25];
            int[] notas3 = new int[25];
            Random r = new Random();
            Random ra = new Random();
            Random ran = new Random();
            int maior = 0;
            int mai18 = 0;
            int som = 0;
            double media = 0;
            int ma1 = 0;
            int ma2 = 0;

            for(int i = 0; i < notas.Length; i++)
            {
                notas[i] = r.Next(0,35);
                if(notas[i] > 0)
                {
                    maior = i;
                }
                if(notas[i] >= 18)
                {
                    mai18++;
                }

                som = som + notas[i];
            }
            for (int j = 0; j < notas2.Length; j++)
            {
                notas2[j] = ra.Next(0, 7);
                if (notas2[j] > 0)
                {
                    ma1 = j;
                }
            }
            for (int k = 0; k < notas3.Length; k++)
            {
                notas3[k] = ran.Next(0, 14);
                if (notas3[k] > 0)
                {
                    ma2 = k;
                }
            }
            media = som / 25;

            Console.WriteLine("Numero do aluno com maior nota: " + maior);
            Console.WriteLine("Numero de alunos com nota maior ou igual que 18: " + mai18);
            Console.WriteLine("Media das notas é: " + media);
            Console.WriteLine("Maior nota prova 1: " + ma1);
            Console.WriteLine("Maior nota prova 2: " + ma2);
            Console.ReadKey();


        }
    }
}
