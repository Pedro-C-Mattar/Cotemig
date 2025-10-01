using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primeiro Numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Numero: ");
            int n2 = int.Parse(Console.ReadLine());
            operacaobancaria operacao = new operacaobancaria();
            Console.WriteLine("Maior Numero: " + operacao.MostrarMaior(n1, n2));
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Numero: ");
            double n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Numero + 50%: " + operacao.MostrarSoma(n3));
            Console.ReadKey();
        }
    }
}
