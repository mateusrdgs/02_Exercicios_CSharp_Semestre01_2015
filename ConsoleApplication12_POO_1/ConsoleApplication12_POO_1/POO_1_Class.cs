using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12_POO_1
{    
        public class Pessoa
        {
            // atributos
            public string nome;
            public int idade;
            public double peso, altura;

            //métodos
            public void AlteraNome(string novoNome)
            {
                nome = novoNome;
            }
            public void AlteraIdade(int novaIdade)
            {
                idade = novaIdade;
            }
            public void AlteraPeso(double novoPeso)
            {
                peso = novoPeso;
            }
            public void AlteraAltura(double novaAltura)
            {
                altura = novaAltura;
            }
            public string RetornaNome()
            {
                return nome;
            }
            public int RetornaIdade()
            {
                return idade; 
            }
            public double RetornaPeso()
            {
                return peso;
            }
            public double RetornaAltura()
            {
                return altura;
            }
            public void MostraDadosPessoa()
            {
                Console.WriteLine("Nome: "  + nome);
                Console.WriteLine("Idade: " + idade);
                Console.WriteLine("Peso: " + peso);
                Console.WriteLine("Altura: " + altura);
            }
            
        }
        public class Carro
        {
            // atributos
            public string modelo;
            public int ano;
            public double preço;

            //métodos
            public void AlteraModelo(string novoModelo)
            {
                modelo = novoModelo;
            }
            public void AlteraAno(int novoAno)
            {
                ano = novoAno;
            }
            public void AlteraPreço(double novoPreço)
            {
                preço = novoPreço;
            }
            public string RetornaModelo()
            {
                return modelo;
            }
            public int RetornaAno()
            {
                return ano;
            }
            public double RetornaPreço()
            {
                return preço;
            }
            public void MostraDadosCarro()
            {
                Console.WriteLine("Modelo: " + modelo);
                Console.WriteLine("Ano: " + ano);
                Console.WriteLine("Preço: " + preço);
            }
        }
}
