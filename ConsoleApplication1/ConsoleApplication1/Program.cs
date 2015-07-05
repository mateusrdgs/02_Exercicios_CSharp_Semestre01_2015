using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1245, milhar=0, centena=0, dezena=0, unidade = 0;
            unidade = numero % 10;
            numero = numero / 10;
            dezena = numero % 10;
            numero = numero / 10;
            centena = numero % 10;
            milhar = numero / 10;

            Console.WriteLine(" "+milhar+" "+ centena+" "+ dezena+" "+unidade);
            Console.ReadLine();
        }
    }
}
