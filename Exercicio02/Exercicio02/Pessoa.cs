using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Pessoa
    {
        #region Atributos

        private string nome;
        private int idade;
        private double altura;

        #endregion

        #region Construtor
        public Pessoa()
        {
            nome = "Christopher Lee";
            idade = 93;
            altura = 1.96;
        }
        #endregion

        #region Métodos e Funções

        public string getNome()
        {
            return nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public int getIdade()
        {
            return idade;
        }
        public void setIdade(int idade)
        {
            this.idade = idade;
        }
        public double getAltura()
        {
            return altura;
        }
        public void setAltura(double altura)
        {
            this.altura = altura;
        }

        public void mostraDados()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura + "\n");
        }
        #endregion
    }
}
