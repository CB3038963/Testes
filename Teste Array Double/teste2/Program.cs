using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] valor = new double[10];
            string resultado;
            for (int i = 1; i < 6; i++)
            {
                Console.Write("Digite o valor do {0} Item: ", i);
                resultado = Console.ReadLine();

                if (!double.TryParse(resultado, out valor[i]))
                {
                    do
                    {
                        Console.WriteLine("Digite o valor do {0} Item novamente: ", i);
                        resultado = Console.ReadLine();
                    } while (!double.TryParse(resultado, out valor[i]));
                }
                


            }
        }
    }
}
