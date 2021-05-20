using System;

namespace Punto1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, invertido = 0;
            
            do
            {
                Console.WriteLine("Ingrese un numero entero positivo");
                num = Convert.ToInt32(Console.ReadLine());
            } while (num <= 0);

            while (num > 0)
            {
                invertido = invertido * 10 + num % 10;
                num /= 10;
            }

            Console.WriteLine($"El numero invertido es: {invertido}");
        }
    }
}
