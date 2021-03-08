using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjExercicio01032021
{
    class Eq2Grau
    {
        static void Main()
        {
            int a = 0, b = 0, c = 0;
            double x1 = 0, x2 = 0;

            Console.Write("Informe os valores da equação de 2 grau!");
            
            for(int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.Write("Informe aX ao quadrado:");
                        a = int.Parse(Console.ReadLine());
                        break;
                    case 1:
                        Console.Write("Informe bX:");
                        b = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        Console.Write("Informe c:");
                        c = int.Parse(Console.ReadLine());
                        break;
                    default:
                        break;
                }
            }
            
            double delta = Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);
           // Console.WriteLine(delta);

            x1 = (Math.Pow(-b, 2) - delta) / 2 * a;
            x2 = (Math.Pow(-b, 2) + delta) / 2 * a;

            Console.WriteLine(x1 + " e " + x2);

            Console.ReadKey();
        }
    }
}
