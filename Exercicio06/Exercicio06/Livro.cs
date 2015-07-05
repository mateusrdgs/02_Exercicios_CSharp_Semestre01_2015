using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    class Livro
    {
        private string titulo;
        private int qtdPaginas;
        private int paginasLidas;

        public Livro()
        { }
        public Livro(string titulo)
        {
            this.titulo = titulo; 
        }
        public Livro(string titulo, int qtdPaginas, int paginasLidas)
        {
            this.titulo = titulo;
            this.qtdPaginas = qtdPaginas;
            this.paginasLidas = paginasLidas;
        }
        public string getTitulo()
        {
            return titulo;
        }
        public void setTitulo(string titulo)
        {
            this.titulo = titulo;
        }
        public int getQtdPaginas()
        {
            return qtdPaginas;
        }
        public void setQtdPaginas(int qtdPaginas)
        {
            this.qtdPaginas = qtdPaginas;
        }
        public int getPaginasLidas()
        {
            return paginasLidas;
        }
        public void setPaginasLidas(int paginasLidas)
        {
            this.paginasLidas = paginasLidas;
        }
        public void verificarProgresso()
        {
            int porcentagem;
            Console.WriteLine("Progresso da leitura: " + (porcentagem = ((paginasLidas * 100) / qtdPaginas)) + " %");
        }

    }
}
