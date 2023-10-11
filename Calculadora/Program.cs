using System;

namespace Program
{
    class calculator
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int sum = 0;

            Console.WriteLine("Escolha qual operação deseja realizar:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            int operaçao = int.Parse(Console.ReadLine());

            if (operaçao == 1)
            {
                sum = n + m;
            }
            else if (operaçao == 2)
            {
                sum = n - m;
            }
            else if (operaçao == 3)
            {
                sum = n * m;
            }
            else if (operaçao == 4)
            {
                sum = n / m;
            }

            Console.WriteLine("Resultado: " + sum);
        }
    }
}
