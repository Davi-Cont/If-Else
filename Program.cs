using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe seu peso:");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe sua altura:");
            double altura = double.Parse(Console.ReadLine());
            
            double imc = peso / (altura * altura);

            if (imc < 22.0)
            {
                Console.WriteLine("Magreza" +
                                    "\n seu IMC é de: " + imc);
            }

            else if (imc > 27.0)
            {
                Console.WriteLine("Execesso de peso" +
                                    "\n seu IMC é de: " + imc);
            }

            else
            {
                Console.WriteLine("Eutrofia (Peso adequado)" +
                                    "\n seu IMC é de: " + imc);
            }

            Console.ReadKey();
        }
    }
}
