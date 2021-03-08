using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjExercicio01032021
{
    class VerifIMC
    {
        static void Main(string[] args)
        {
            double peso, altura, imc;
            double[] vetTabelaImc = {18.5, 24.9, 29.9, 34.9, 39.9};

            Console.Write("Informe seu peso em kg:");
            peso = double.Parse(Console.ReadLine());
            Console.Write("Informe sua altura em metros (exemplo 1,85):");
            altura = double.Parse(Console.ReadLine());

            imc = (peso / (altura * altura));

            Console.Write("Seu IMC é: " + imc + "\n");

            if (imc <= vetTabelaImc[0]){
                Console.Write("Peso baixo");
            }else if(imc > vetTabelaImc[0] && imc <= vetTabelaImc[1])
            {
                Console.Write("Peso normal");
            }else if (imc > vetTabelaImc[1] && imc <= vetTabelaImc[2])
            {
                Console.Write("Sobrepeso");
            }else if (imc > vetTabelaImc[2] && imc <= vetTabelaImc[3])
            {
                Console.Write("Obesidade");
            }else if (imc > vetTabelaImc[3] && imc <= vetTabelaImc[4])
            {
                Console.Write("Obesidade severa");
            }else if (imc > vetTabelaImc[4])
            {
                Console.Write("Obesidade mórbida");
            }

            Console.ReadKey();
        }
    }
}
