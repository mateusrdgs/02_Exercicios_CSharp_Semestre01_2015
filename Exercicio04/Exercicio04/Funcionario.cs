using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Funcionario
    {
        private string nome;
        private string sobrenome;
        private int horasTrabalhadas;
        private double valorPorHora;
        

        public Funcionario(string nome, string sobrenome, int horasTrabalhadas, double valorPorHora)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.horasTrabalhadas = horasTrabalhadas;
            this.valorPorHora = valorPorHora;
        }
                
        public string getNome()
        {
            return nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getSobrenome()
        {
            return sobrenome;
        }
        public void setSobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;
        }
        public int getHorasTrabalhadas()
        {
            return horasTrabalhadas;
        }
        public void setHorasTrabalhadas(int horasTrabalhadas)
        {
            this.horasTrabalhadas = horasTrabalhadas;
        }
        public double getValorPorHora()
        {
            return valorPorHora;
        }
        public void setValorPorHora(double valorPorHora)
        {
            this.valorPorHora = valorPorHora;
        }
        public void nomeCompleto()
        {
            Console.WriteLine(nome+" "+sobrenome);
        }
        public void calcularSalario()
        {
            Console.WriteLine(horasTrabalhadas*valorPorHora); 
        }
        public void incrementarHoras(int horasTrabalhadas)
        {
            this.horasTrabalhadas += horasTrabalhadas;    
        }


    }
}
