using System;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            Array.Sort(s);
            Array.Reverse(s);
            double a = double.Parse(s[0]);
            double b = double.Parse(s[1]);
            double c = double.Parse(s[2]);
            double quadradoA = Math.Pow(a, 2);
            double quadradoB = Math.Pow(b, 2);
            double quadradoC = Math.Pow(c, 2);
            Console.WriteLine(quadradoC);

            //continue a solucao
            if (a >= (b + c))
                Console.WriteLine("NAO FORMA TRIANGULO");
            else if (quadradoA == (quadradoB + quadradoC))
                Console.WriteLine("TRIANGULO RETANGULO");
            else if (quadradoA > (quadradoB + quadradoC))
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            else if (quadradoA < (quadradoB + quadradoC))
                Console.WriteLine("TRIANGULO ACUTANGULO");
            if (a == b && b == c)
                Console.WriteLine("TRIANGULO EQUILATERO");
            if ((a == b && a != c) || (a == c && a != b) || (b == c && b != a))
                Console.WriteLine("TRIANGULO ISOSCELES");

        }
    }
}
