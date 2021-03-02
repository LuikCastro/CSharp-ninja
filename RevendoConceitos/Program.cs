using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevendoConceitos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Olá ninja!");
            Console.WriteLine("Digite o seu nome.");

            string texto = Console.ReadLine();

            Console.WriteLine("Seu nome é: " + texto);
            Console.WriteLine("Só ninja programa em C#");
            Console.WriteLine(Somar(5, 5));
            Console.ReadLine();

        }

        static int Somar(int n1, int n2)
        {
            int r = n1 + n2;
            return r;
        }

    }
}
