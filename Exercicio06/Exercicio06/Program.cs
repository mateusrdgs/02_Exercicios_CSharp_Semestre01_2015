using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro pequenoPrincipe = new Livro("O pequeno principe");            
            pequenoPrincipe.setQtdPaginas(98);
            pequenoPrincipe.setPaginasLidas(14);            
            Console.WriteLine("O livro "+ pequenoPrincipe.getTitulo() + " possui " + pequenoPrincipe.getQtdPaginas() +" páginas");
            pequenoPrincipe.setPaginasLidas(20);
            pequenoPrincipe.verificarProgresso();
            pequenoPrincipe.setPaginasLidas(50);
            pequenoPrincipe.verificarProgresso();

            Livro meuLivro = new Livro("A origem das espécies", 641, 79);            
            Console.WriteLine("O livro " + meuLivro.getTitulo() + " possui "+meuLivro.getQtdPaginas() + " páginas");
            Console.ReadLine();

        }
    }
}
