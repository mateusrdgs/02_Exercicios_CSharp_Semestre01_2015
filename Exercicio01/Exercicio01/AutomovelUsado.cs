using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class AutomovelUsado
    {
        private int ano;
        private string modelo, montadora, motor;
        private double quilometragem, tanqueCap, preco;

        #region Construtor
        public AutomovelUsado()
        {
            ano = 0000;
            modelo = "genérico";
            montadora = "genérica";
            quilometragem = 0;
            tanqueCap = 0;
            preco = 0;
            motor = "1.0";          
        }
        #endregion

        #region Métodos e Funções
        public int getAno()
        {
            return ano;
        }
        public void setAno(int ano)
        {
            this.ano = ano;
        }
        public string getModelo()
        {
            return modelo;
        }
        public void setModelo(string modelo)
        {
            this.modelo = modelo;
        }
        public string getMontadora()
        {
            return montadora;
        }
        public void setMontadora(string montadora)
        {
            this.montadora = montadora;
        }
        public string getMotor()
        {
            return motor;
        }
        public void setMotor(string motor)
        {
            this.motor = motor;
        }
        public double getQuilometragem()
        {
            return quilometragem;
        }
        public void setQuilometragem(double quilometragem)
        {
            this.quilometragem = quilometragem;
        }
        public double getTanqueCap()
        {
            return tanqueCap;
        }
        public void setTanqueCap(double tanqueCap)
        {
            this.tanqueCap = tanqueCap;
        }
        public double getPreco()
        {
            return preco;
        }
        public void setPreco(double preco)
        {
            this.preco = preco;
        }
        #endregion

        public void mostraDados() // EXIBE NA TELA AS INFORMAÇÕES DO VEÍCULO CADASTRADO
        {
            Console.WriteLine("ANO: " + ano);
            Console.WriteLine("MODELO: " + modelo);
            Console.WriteLine("MONTADORA: " + montadora);
            Console.WriteLine("QUILOMETRAGEM: " + quilometragem);
            Console.WriteLine("COMBUSTIVEL (Capacidade): " + tanqueCap + "L");
            Console.WriteLine("PREÇO: " + preco);
            Console.WriteLine("MOTOR: " + motor +"\n");
        }
    }
}
