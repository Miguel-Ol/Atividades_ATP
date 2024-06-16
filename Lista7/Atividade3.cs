using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer3
{
    internal class Atividade3
    {
        static int Mmc(int n1, int n2) 
        {
            bool sai= false;
            int cont1, cont2,r1,r2=0;
            if (n1 > n2)
            {
                cont1 = n1;
                cont2 = n2;
            }
            else
            {
                cont1 = n2;
                cont2 = n1;
            }

            for (int i = 1;sai == false; i++)
            {
                r1= cont1*i;
                for (int j=1;r2 < r1 && sai == false; j++)
                {
                    r2 = cont2*j;

                    if (r2 == r1)
                    {
                        sai=true;
                    }
                }
            }
            return r2;
        }

        static int Mdc(int n1,int n2,int n3)
        {
            bool sai= false;
            int men,r1,r2,r3;
            if (n1 < n2 && n1 < n3)
            {
                men = n1;

            }
            else if (n2 < n1 && n2 < n3)
            {
                men = n2;

            }
            else
            {
                men = n3;
            }

            while (sai==false) 
            {
                r1 = n1 % men;
                r2 = n2 % men;
                r3 = n3 % men;

                if (r1==0 && r2==0 && r3==0) 
                    sai = true;
                else
                men--;
            }
            return men;

        }
        static void Main(string[] args)
        {
            byte esc=0;
            int num1,num2,num3;

            while (esc != 3)
            {
            Console.WriteLine("escolha\n1) Calcular MMC \r\n2) Calcular MDC \r\n3) Sair do programa ");
            esc = byte.Parse(Console.ReadLine());
                switch (esc)
                {
                    case 1:
                        Console.WriteLine("informe o primeiro número:");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("informe o segundo número:");
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("o MMC destes números é: " + Mmc(num1, num2));
                        break;
                    case 2:
                        Console.WriteLine("informe o primeiro número:");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("informe o segundo número:");
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("informe o terceiro número:");
                        num3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("o MMC destes números é: " + Mdc(num1, num2,num3));
                        break;
                    case 3:
                        Console.WriteLine("programa encerrado");
                        break;
                        default: Console.WriteLine("escolha inválida\n");
                        break;
                }
            }
            Console.ReadLine();

            /*Random r = new Random();
            //num1 = r.Next(1,100);
            num1 =  int.Parse(Console.ReadLine());
            Console.WriteLine(num1);
            //num2 = r.Next(1,100);
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num2);
            //num3 = r.Next(1, 100);
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(num3);
            Console.WriteLine("o MMC destes números é: " + Mmc(num1,num2));
            Console.WriteLine("o MDC destes números é: " + Mdc(num1, num2, num3));*/
        }
    }
}
