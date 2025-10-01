using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_pag_57_n_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            string sexo = "";
            int idade = 0;
            int time = 0;
            int contgalo = 0;
            int contpaulo = 0;
            int contmengo = 0;
            int contrinthias = 0;
            int contotros = 0;
            int contador = 0;
            double galocent = 0;
            double otrocent = 0;
            string maior = "";
            int femigalo = 0;
            int idamengo = 0;
            double mengocent = 0;
            int contdade = 0;
            double mediadade = 0;

            while(time != -1)
            {
                Console.WriteLine("Digite Nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("Digite Sexo (feminino ou masculino): ");
                sexo = Console.ReadLine();
                Console.WriteLine("Digite Idade: ");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite Time (1 - Galo, 2 - Sao Paulo, 3 - Flamengo, 4 - Corinthias, 5 - Outros) ou (-1 para sair): ");
                time = int.Parse(Console.ReadLine());

                if(time == 1)
                {
                    contgalo++;
                }
                if(time == 2)
                {
                    contpaulo++;
                }
                if(time == 3)
                {
                    contmengo++;
                }
                if(time == 4)
                {
                    contrinthias++;
                }
                if(time == 5)
                {
                    contotros++;
                }
                if(contgalo > contpaulo)
                {
                    maior = "Atletico-MG";
                }
                if(contpaulo > contgalo)
                {
                    maior = "Sao Paulo";
                }
                if(sexo == "feminino" && time == 1)
                {
                    femigalo++;
                }
                if(idade <= 30 && time == 3)
                {
                    idamengo++;
                }
                if(time == 4)
                {
                    contdade = contdade + idade;
                }

                contador++;
            }
            contador = contador - 1;
            galocent = ((double)contgalo / contador) * 100;
            otrocent = ((double)contotros / contador) * 100;
            mengocent = ((double)idamengo / contador) * 100;
            mediadade = contdade / contador;

            Console.WriteLine("Torcem para o Galo: " + contgalo + " ou " + galocent + " porcento. ");
            Console.WriteLine("Torcem para outros times: " + contotros + " ou " + otrocent + " porcento. ");
            Console.WriteLine("O time preferido é: " + maior);
            Console.WriteLine("Quantidade de atleticanas: " + femigalo);
            Console.WriteLine("Porcentagem de flamenguistas ate 30 anos: " + mengocent + " porcento. ");
            Console.WriteLine("Media das idades dos corinthianos(a) é: " + mediadade);
            Console.ReadKey();
        }
    }
}
