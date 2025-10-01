using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atvs_pag_73
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Escreva um Núméro:");
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("");
            Console.WriteLine("NUMEROS:");
            for (int f = 0; f < 5; f++)
            {
                Console.WriteLine("");
                Console.WriteLine(num[f]);
            }
            Console.ReadKey();
        }
    }
}
