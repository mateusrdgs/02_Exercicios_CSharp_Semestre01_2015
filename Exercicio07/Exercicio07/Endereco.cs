using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    class Endereco
    {
        private string rua;
        private int numero;
        private string bairro;
        private string cidade;
        private string estado;

        public Endereco()
        { } // CONSTRUTOR SEM CORPO

        public Endereco(string rua, int numero, string bairro, string cidade, string estado)
        {
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
        }

        #region get
        public string getRua()
        {
            return rua;
        }
        public int getNumero()
        {
            return numero;
        }
        public string getBairro()
        {
            return bairro;
        }
        public string getCidade()
        {
            return cidade;
        }
        public string getEstado()
        {
            return estado;
        }
        #endregion

        #region set
        public void setRua(string rua)
        {
            this.rua = rua;
        }
        public void setNumero(int numero)
        {
            this.numero = numero;
        }
        public void setBairro(string bairro)
        {
            this.bairro = bairro;
        }
        public void setCidade(string cidade)
        {
            this.cidade = cidade;
        }
        public void setEstado(string estado)
        {
            this.estado = estado;
        }
        #endregion

        
    }
}
