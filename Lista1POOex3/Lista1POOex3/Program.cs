using System;

namespace Lista1POOex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado quad;

            quad = new Quadrado();

            Console.Write("Informe o valor da diagonal do quadrado ");
            quad.setDiag(int.Parse(Console.ReadLine()));

            quad.calcularArea();

            Console.WriteLine("A area do quadrado é {0}", quad.getArea());
        }
    }
}
