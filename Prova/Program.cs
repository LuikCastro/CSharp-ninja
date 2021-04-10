using System;

namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a base a altura do triângulo para calcular a área");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            Triangulo(x, y);
            Console.ReadLine();

            Console.WriteLine("Digite o lado do octógono para calcular o perímetro");
            double lado = double.Parse(Console.ReadLine());
            Octogono(lado);
            Console.ReadLine();

            Console.WriteLine("Digite a base maior, a base menor e a altura do trapézio para calcular a área");
            double baseMaior = double.Parse(Console.ReadLine());
            double baseMenor = double.Parse(Console.ReadLine());
            double altura = double.Parse(Console.ReadLine());
            Trapezio(baseMaior, baseMenor, altura);
            Console.ReadLine();

            Console.WriteLine("Digite a diagonal maior e a diagonal menor do losango para calcular a área");
            double diagonalMaior = double.Parse(Console.ReadLine());
            double diagonalMenor = double.Parse(Console.ReadLine());
            Losango(diagonalMaior, diagonalMenor);
            Console.ReadLine();

            Console.WriteLine("Digite a base e a altura do paralelograma para calcular a área");
            double _base = double.Parse(Console.ReadLine());
            double _altura = double.Parse(Console.ReadLine());
            Paralelogramo(_base, _altura);
            Console.ReadLine();
        }

        static void Triangulo(double b, double a)
        {
            double resposta = (b * a) / 2;
            Console.WriteLine("A área do triangulo é: " + Math.Round(resposta, 2));
        }

        static void Octogono(double lado) 
        {
            double resposta = lado * 8;
            Console.WriteLine("O perimetro do octógono é: " + Math.Round(resposta, 2));
        }

        static void Trapezio(double baseMaior, double baseMenor, double altura)
        {
            double resposta = ((baseMaior + baseMenor) * altura) / 2;
            Console.WriteLine("A área do trapézio é: " + Math.Round(resposta, 2));
        }

        static void Losango(double diagionalMaior, double diagonalMenor)
        {
            double resposta = (diagionalMaior * diagonalMenor) / 2;
            Console.WriteLine("A área do losango é: " + Math.Round(resposta, 2));
        }

        static void Paralelogramo(double _base, double altura)
        {
            double resposta = _base * altura;
            Console.WriteLine("A área do parelelogramo é: " + Math.Round(resposta, 2));
        }
    }
}

//1. Faça uma função ÚNICA que a partir da base e altura, calcule a área do triângulo.
//2.Faça uma função ÚNICA que a partir do lado, calcule o perímetro do octógono.
//3. Faça uma função ÚNICA que a partir da base maior, base menor e altura, calcule a área do trapézio.
//4. Faça uma função ÚNICA que a partir da diagonal maior e menor, calcule a área do losango.
//5. Faça uma função ÚNICA que a partir da base e altura, calcule a área do paralelogramo.