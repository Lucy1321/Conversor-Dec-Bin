using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvDecBin
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, c, k;
            Console.WriteLine("Ingrese un numero decimal: \n");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El numero binario es: \n");

            for (c = 13;  c >= 0; c--)
            {
                k = n >> c;
                if (Convert.ToBoolean(k & 1))
                    Console.Write("1");
                else
                    Console.Write("0");
            }
            Console.ReadKey();
        }
    }
}
