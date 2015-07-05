using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    class Cliente
    {
        public Endereco endereco = new Endereco();

        private string nome { get; set; }
        private char sexo;
        private int idade;
        private double credito;
        private string estadoCivil;        

        public Cliente()
        { } // CONSTRUTOR SEM CORPO

        public Cliente(string nome, char sexo, int idade, double credito, string estadoCivil)
        {
            this.nome = nome;
            this.sexo = sexo;
            this.idade = idade;
            this.credito = credito;
            this.estadoCivil = estadoCivil;            
        }

        #region get
        public string getNome()
        {
            return nome;
        }
        public char getSexo()
        {
            return sexo;
        }
        public int getIdade()
        {
            return idade;
        }
        public double getCredito()
        {
            return credito;
        }
        public string getEstadoCivil()
        {
            return estadoCivil;
        }
        public Endereco getEndereco()
        {
            return endereco;
        }
        #endregion

        #region set
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public void setSexo(char sexo)
        {
            this.sexo = sexo;
        }
        public void setIdade(int idade)
        {
            this.idade = idade;
        }
        public void setCredito(double credito)
        {
            this.credito = credito; 
        }
        public void setEstadoCivil(string estadoCivil)
        {
            this.estadoCivil = estadoCivil;
        }              
        #endregion
    }
}
