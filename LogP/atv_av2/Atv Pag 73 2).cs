using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_pag_73_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[20];
            Random rd = new Random();
            for(int i = 0; i < 20; i++)
            {
                num[i] = rd.Next(1, 100);
            }
            Console.WriteLine("");
            Console.WriteLine("NUMEROS MAIORES QUE 50:");
            for (int f = 0; f < 20; f++)
            {
                if (num[f] > 50)
                {
                    Console.WriteLine("");
                    Console.WriteLine(num[f]);
                }
            }
            Console.ReadKey();
        }
    }
}
