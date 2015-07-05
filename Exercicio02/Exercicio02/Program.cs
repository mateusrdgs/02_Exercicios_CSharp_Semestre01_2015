using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.mostraDados();

            pessoa.setNome("Sir Ian McKellen");
            pessoa.setIdade(76);
            pessoa.setAltura(1.80);

            pessoa.mostraDados();
            Console.Read();
        }
    }
}
