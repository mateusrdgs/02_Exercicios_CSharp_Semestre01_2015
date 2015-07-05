using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Elevador
    {
        private int andarAtual, totalAndares, capacidadeElevador, pessoasDentro;

        public Elevador()
        {
            andarAtual = 0;
            totalAndares = 0;            
            capacidadeElevador = 0;
            pessoasDentro = 0;
        }

        public void setInicializa(int capacidadeElevador, int andarAtual, int totalAndares)
        {
            this.capacidadeElevador = capacidadeElevador;
            this.totalAndares = totalAndares;
            this.andarAtual = andarAtual;
        }
        public void setEntra(int entra)
        {
            if ((pessoasDentro + entra) > capacidadeElevador)
            {
                Console.Write("\nCapacidade máxima de passageiros ultrapassada");
                System.Threading.Thread.Sleep(2000);
            }
            else if ((pessoasDentro + entra) == capacidadeElevador)
            {
                pessoasDentro += entra;
                Console.Write("\nCapacidade máxima de passageiros alcançada");
                System.Threading.Thread.Sleep(2000);
            }
            else 
            { 
                pessoasDentro+=entra;
                Console.Write("\nPassageiros prontos");
                Console.ReadLine();          
            }   
        }
        public void setSai(int sai)
        {
            if (pessoasDentro == 0 || sai>pessoasDentro)
            {
                Console.Write("O elevador não tem passageiros ou o número de passageiros de saída é maior que os presentes");
                System.Threading.Thread.Sleep(2000);
            }
            else
            {
                pessoasDentro-=sai;                
                Console.Write("\nPassageiros prontos");
                Console.ReadLine();
            }
        }
        public void setSobe(int subir)
        {
            if (andarAtual <= totalAndares)
            {
                andarAtual+=subir;
                Console.Write("\nPassageiros prontos");
                Console.ReadLine();
            }            
            else
            {
                Console.Write("\nVocê já está no ultimo andar");                
                System.Threading.Thread.Sleep(2000);
            }           
        }
        public void setDesce(int desce)
        {
            if (andarAtual > 0)
            {
                andarAtual-=desce;
                Console.Write("\nPassageiros prontos");
                Console.ReadLine();
            }
            else if(desce>andarAtual)
            {
                Console.Write("\nSubterrâneo não disponível");
                System.Threading.Thread.Sleep(2000);
            }
            else 
            {
                Console.Write("\nVocê já está no térreo");
                System.Threading.Thread.Sleep(2000);
            }
        }
        public int getTotalAndares()
        {
            return totalAndares;
        }
        public int getpessoasDentro()
        {
            return pessoasDentro;
        }    
        public int getAndarAtual()
        {
            return andarAtual;
        }
    }
}
