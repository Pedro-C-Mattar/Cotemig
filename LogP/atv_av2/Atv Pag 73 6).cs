using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_pad_73_6_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[31];
            for (int i = 1; i < 31; i++)
            {
                num[i] = i;
            }
            Console.WriteLine("Vetor:");
            for (int f = 1; f < 31; f++)
            {
                Console.WriteLine("");
                Console.WriteLine(num[f]);
            }
            Console.ReadKey();
        }
    }
}
