using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_avali
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 35, 85, 96, 80, 45, 75, 85, 78 };
            int m5 = 0;
            string par = "";
            for (int j = 0; j != 1; j++)
            {
                if (num[j] % 5 == 0)
                {
                    m5 = num[j];
                    break;
                }
            }
            for (int i = 0; i < 8; i++)
            {
                
                if (num[i] % 2 == 0)
                {
                   par += i + " ";
                }
            }
                Console.WriteLine("O tamanho do vetor é: " + num.GetLength(0));
                Console.WriteLine("O Primeiro Multiplo de 5 é: " + m5);
                Console.WriteLine("Os indices dos pares sao: " + par);
                Console.ReadKey();
        }
    }
}
