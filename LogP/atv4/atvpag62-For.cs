using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laço_FOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double maioralt = 0;
            double menoralt = 999999;
            double altt = 0;
            double altf = 0;
            double mediaf = 0;
            double mediat = 0;
            
            for(int i = 0; i <= 50; i++)
            {
                double altura = double.Parse(Console.ReadLine());
                Console.ReadLine();
                double codigo = double.Parse(Console.ReadLine());
                Console.ReadLine();
                if(altura > maioralt)
                {
                    maioralt = altura;
                }

                if(altura < menoralt)
                {
                    menoralt = altura;
                }

                if(codigo == 2)
                {
                    altf = altf + altura;
                }

                altt = altt + altura;
            }
            mediaf = altf / 50;
            mediat = altt / 50;
            Console.WriteLine("Maior altura: " + maioralt);
            Console.WriteLine("Menor altura: " + menoralt);
            Console.WriteLine("Media altura turma: " + mediat);
            Console.WriteLine("Media altura feminina: " + mediaf);
            Console.ReadKey();


            double dias = 0;
            double tempe = 0;
            double mediatempe = 0;
            double abaixo = 0;
            double porcent = 0;
            double maiortemp = 0;

            for (int i = 0; i <= 200; i++)
            {
                double temperatura = double.Parse(Console.ReadLine());
                Console.ReadLine();

                if (temperatura >= 20 && temperatura <= 23)
                {
                    dias ++;
                }

                tempe = tempe + temperatura;

                if(temperatura < 20)
                {
                    abaixo ++;
                }

                if(temperatura > maiortemp)
                {
                    maiortemp = temperatura;
                }
            }

            mediatempe = tempe / 200;
            porcent = abaixo / 100;
            Console.WriteLine("Dias entre 20 e 23: " + dias);
            Console.WriteLine("Media Temperatura: " + mediatempe);
            Console.WriteLine("Porcentagem abaixo 20: " + porcent);
            Console.WriteLine("Maior temperatura: " + maiortemp);
            Console.ReadKey();


            for(int i = 0;i <= 50; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            for (int i = 0; i <= 50; i++)
            {
                double fahr = (i * (9 / 5)) + 32;
                Console.WriteLine(fahr);
            }
            Console.ReadKey();

        }
    }
}
