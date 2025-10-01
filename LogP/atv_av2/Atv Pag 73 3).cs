using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_pag_73_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[50];
            Random rd = new Random();
            int maior = 0;
            for (int i = 0; i < 50; i++)
            {
                num[i] = rd.Next(1, 100);
            }
            Console.WriteLine("");
            Console.WriteLine("MAIOR NUMERO:");
            for (int f = 0; f < 50; f++)
            {
                if (num[f] > maior)
                {
                    maior = num[f];
                }
            }
            Console.WriteLine("");
            Console.WriteLine(maior);
            Console.ReadKey();
        }
    }
}
