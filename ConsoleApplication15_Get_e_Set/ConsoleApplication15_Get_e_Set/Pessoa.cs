using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15_Get_e_Set
{
    class Pessoa
    {
        #region Atributos
        private string nome;
        private int idade;
        #endregion

        #region Métodos Acessores
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
        #endregion
    }
}
