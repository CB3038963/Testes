using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[100];
            string input;

            for (int i = 1; i < 6; i++)
            {
                Console.Write("{0} - Nome: ",i);
                input = Console.ReadLine();

                while (input.Any(char.IsDigit) || string.IsNullOrWhiteSpace(input))
                {
                    Console.Write("Digite novamente|{0} - Nome: ",i);
                    input = Console.ReadLine();
                }
                nome[i] = input;

                
            }
            
        }
    }
}
