using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetValue
{
    internal class GetValue
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                num[i] = r.Next(0, 50 + 1);
            }

            Console.WriteLine("Posição (0):" + "\n" + num.GetValue(0));
            Console.WriteLine("Posição (5):" + "\n" + num.GetValue(5));
            Console.WriteLine("Posição (8):" + "\n" + num.GetValue(8));

            Console.ReadKey();
        }
    }
}
