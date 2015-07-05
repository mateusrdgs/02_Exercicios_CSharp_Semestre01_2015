using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01_Associação
{
    class Empresa
    {        
        private string razaoSocial;
        private string cnpj;
        private Funcionario[] funcionarios = new Funcionario[5];

        public Empresa(string razaoSocial, string cnpj)
        {
            this.razaoSocial = razaoSocial;
            this.cnpj = cnpj;
        }
        public string getRazaoSocial()
        {
            return razaoSocial;
        }
        public void setRazaoSocial(string razaoSocial)
        {
            this.razaoSocial = razaoSocial;            
        }
        public string getCnpj()
        {
            return cnpj;
        }
        public void setCnpj(string cnpj)
        {
            this.cnpj = cnpj;
        }
        public Funcionario[] getFuncionarios()
        {
            return funcionarios;
        }
        public void setFuncionarios(Funcionario[] funcionarios)
        {
            this.funcionarios = funcionarios;
        }
        public Funcionario getFuncionario(int posicao)
        {
            if (posicao >= 0 && posicao < 5)
            {
                return funcionarios[posicao];
            }
            else return null;
            //return (posicao >= 0 && posicao < 5) ? funcionarios[posicao] : null;
           
        }
        public void setFuncionario(int posicao, Funcionario funcionario)
        {
            funcionarios[posicao] = funcionario;
        }
              

    }
}
