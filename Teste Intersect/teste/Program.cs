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
            string[] word1 = { "a", "b", "c" };
            string[] word2 = { "p", "q", "r" };
            

            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0}{1}", word1[i], word2[i]);
            }
        }
    }
}
