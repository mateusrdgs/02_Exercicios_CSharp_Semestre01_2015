using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Filmes umFilmeQualquer = new Filmes("Os Vingadores", 142);
            umFilmeQualquer.exibirduracaoEmHoras();

            Filmes meuFilmeFavorito = new Filmes("Star Wars Episódio I - A Ameaça Fantasma", 100);
            meuFilmeFavorito.exibirduracaoEmHoras();
            meuFilmeFavorito.setDuracaoEmMinutos(136);
            meuFilmeFavorito.exibirduracaoEmHoras();
                
            Console.ReadLine();

        }
    }
}
