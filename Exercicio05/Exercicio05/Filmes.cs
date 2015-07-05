using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Filmes
    {
        private string nome;
        private int duracaoEmMinutos;

        public Filmes(string nome, int duracaoEmMinutos )
        {
            this.nome = nome;
            this.duracaoEmMinutos = duracaoEmMinutos; 
        }
        public string getTitulo()
        {
            return nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public int getDuracaoEmMinutos()
        {
            return duracaoEmMinutos;
        }
        public void setDuracaoEmMinutos(int duracaoEmMinutos)
        {
            this.duracaoEmMinutos = duracaoEmMinutos;
        }
        public void exibirduracaoEmHoras()
        {
            Console.WriteLine("O filme "+ nome + " possui " + (duracaoEmMinutos / 60) + " horas " + (duracaoEmMinutos % 60)+" minutos de duração"); 
        }
    }
}
