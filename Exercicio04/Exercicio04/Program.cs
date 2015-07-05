using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario("Luiz", "Silva", 10, 25.50);
            Funcionario funcionario2 = new Funcionario("Maria", "Costa", 40, 50);

            funcionario1.nomeCompleto();
            funcionario1.calcularSalario();
            funcionario1.incrementarHoras(8);
            funcionario1.calcularSalario();

            funcionario2.nomeCompleto();
            funcionario2.calcularSalario();
            funcionario2.incrementarHoras(20);
            funcionario2.calcularSalario();

            Console.ReadLine();
            
        }
    }
}
