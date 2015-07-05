using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            AutomovelUsado used = new AutomovelUsado();

            used.mostraDados();

            used.setAno(2012);
            used.setTanqueCap(47);
            used.setModelo("PALIO");
            used.setMontadora("FIAT");
            used.setMotor("1.0");
            used.setPreco(15000);
            used.setQuilometragem(80000);

            used.mostraDados();
            
            Console.ReadLine();
        }
    }
}
