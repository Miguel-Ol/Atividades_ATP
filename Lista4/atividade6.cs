using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer6
{
    internal class atividade6
    {
        static void Main(string[] args)
        {
            byte menu;
            double num;

            do
            {
                Console.WriteLine("\nMenu\r\n1. Converter de Celsius para Fahrenheit\r\n2. Converter de Celsius para Kelvin\r\n3. Converter de Fahrenheit para Celsius\r\n4. Converter de Fahrenheit para Kelvin\r\n5. Converter de Kelvin para Celsius\r\n6. Converter de Kelvin para Fahrenheit\r\n7. Sair");
                menu = byte.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Informe a temperatura em Celsius:");
                        num = double.Parse(Console.ReadLine());
                        Console.WriteLine($"O resultado é: {(num * 1.8) + 32}ºF");
                        break;
                    case 2:
                        Console.WriteLine("Informe a temperatura em Celsius:");
                        num = double.Parse(Console.ReadLine());
                        Console.WriteLine($"O resultado é: {num + 273.15}K");
                        break;
                    case 3:
                        Console.WriteLine("Informe a temperatura em Fahrenheit:");
                        num = double.Parse(Console.ReadLine());
                        Console.WriteLine($"O resultado é: {(num - 32) * (5.0 / 9)}ºC");
                        break;
                    case 4:
                        Console.WriteLine("Informe a temperatura em Fahrenheit:");
                        num = double.Parse(Console.ReadLine());
                        Console.WriteLine($"O resultado é: {(num + 459.67) * (5.0 / 9)}K");
                        break;
                    case 5:
                        Console.WriteLine("Informe a temperatura em Kelvin:");
                        num = double.Parse(Console.ReadLine());
                        Console.WriteLine($"O resultado é: {num - 273.15}ºC");
                        break;
                    case 6:
                        Console.WriteLine("Informe a temperatura em Kelvin:");
                        num = double.Parse(Console.ReadLine());
                        Console.WriteLine($"O resultado é: {1.8 * (num - 273) + 32}ºF");
                        break;
                    case 7:
                        Console.WriteLine("Programa encerrado.");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            } while (menu != 7);
            Console.ReadLine();
        }
    }
}
