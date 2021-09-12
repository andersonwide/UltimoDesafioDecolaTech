using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            do
            {
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        alcool++;
                        break;
                    case 2:
                        gasolina++;
                        break;
                    case 3:
                        diesel++;
                        break;
                    case 4:
                        Console.WriteLine("MUITO OBRIGADO");
                        Console.WriteLine("Alcool: " + alcool);
                        Console.WriteLine("Gasolina: " + gasolina);
                        Console.WriteLine("Diesel: " + diesel);
                        break;
                    default:
                        continue;
                }
            }

            while (opcao != 4);

        }
    }
}
