using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01_Associação
{
    class Funcionario
    {
        private string nome;
        private string cpf;
        private double salario;

        public Funcionario(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }        
        public string getCpf()
        {
            return cpf;
        }
        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public double getSalario()
        {
            return salario;
        }
        public void setSalario(double salario)
        {
            this.salario = salario;
        }


    }       
}
