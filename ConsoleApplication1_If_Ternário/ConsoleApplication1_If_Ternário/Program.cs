using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1_If_Ternário
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero = "";
            int a = 0, b = 0;
            Console.Write("1º Número: ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("2º Número: ");
            b = Convert.ToInt16(Console.ReadLine());
            numero = (a + b) % 2 == 0 ? "par" : "impar";
            Console.WriteLine(numero);
            Console.ReadLine();
        }
    }
}
