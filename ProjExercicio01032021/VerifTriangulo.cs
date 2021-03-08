using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjExercicio01032021
{
    class VerifTriangulo
    {
        static void Main(string[] args)
        {
            int[] vetLadosTriangulo = new int[3];
            
            for (int i = 0; i < vetLadosTriangulo.Length; i++)
            {
               Console.Write("informe o " + (i + 1) + " lado do triangulo:");
               vetLadosTriangulo[i] = int.Parse(Console.ReadLine());
            }

            if(vetLadosTriangulo[0] == vetLadosTriangulo [1] && vetLadosTriangulo[1] == vetLadosTriangulo[2])
            {
                Console.Write("É um triangulo equilátero");
            }else if ((vetLadosTriangulo[0] == vetLadosTriangulo[1]) || (vetLadosTriangulo[1] == vetLadosTriangulo[2]) || 
                (vetLadosTriangulo[0] == vetLadosTriangulo[2])){
				Console.Write("Triângulo Isósceles");
			}else{
				Console.Write("Triângulo Escaleno");
			}
            
            Console.ReadKey();
        }
    }
}
