using System;

namespace Punto2
{
    class Program
    {
        static void Main(string[] args)
        {
            char operador;
            int operacion = 0, calcOtro;
            float a, b, resultado;

            do
            {
                Console.WriteLine(
                    "Seleccione la operacion:\n" +
                    "1 - SUMA\n" +
                    "2 - RESTA\n" +
                    "3 - MULTIPLICAION\n" +
                    "4 - DIVISION");
                operacion = Convert.ToInt32(Console.ReadLine());

                while (operacion < 1 || operacion > 4)
                {
                    Console.WriteLine("\nIngrese una operacion valida");
                    operacion = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("\n--------------------------------");
                Console.WriteLine("\nIngrese el primer operando:");
                a = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("\nIngrese el segundo operando:");
                b = Convert.ToSingle(Console.ReadLine());
                
                if (operacion == 1)
                {
                    resultado = a + b;
                    operador = '+';
                }
                else if (operacion == 2)
                {
                    resultado = a - b;
                    operador = '-';
                }
                else if (operacion == 3)
                {
                    resultado = a * b;
                    operador = '*';
                }
                else
                {
                    resultado = a / b;
                    operador = '/';
                }

                Console.WriteLine("\n--------------------------------\n");
                Console.WriteLine(
                    "RESULTADO:\n" +
                    $"{a} {operador} {b} = {resultado}");

                Console.WriteLine("\n--------------------------------\n");
                Console.WriteLine(
                    "¿Desea realizar otro calculo?\n" +
                    "Presione 1 para aceptar o cualquier otro numero para salir");
                calcOtro = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("--------------------------------\n");

            } while (calcOtro == 1);
        }
    }
}
