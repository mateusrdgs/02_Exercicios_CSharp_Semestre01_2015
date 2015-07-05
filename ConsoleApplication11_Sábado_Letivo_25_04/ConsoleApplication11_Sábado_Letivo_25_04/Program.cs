using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11_Sábado_Letivo_25_04
{
    class Program
    {
        public struct Produto
        {
            public string nome;
            public float preço;
            public Produto(string nome, float preço)
            {
                this.nome = nome;
                this.preço = preço;
            }           
        }
        public static void bubblesort(Produto[] vetor) // Função Bubblesort
        {
            float aux = 0; // variável auxiliar
            string aux2 = " ";
            bool trocou = true; // variável bool para poupar tempo e não repetir o laço FOR desnecessáriamente
            for (int j = 0; j < vetor.Length && trocou; j++) // Esse laço FOR, repetirá o processo de organização dos elementos no vetor // A quantidade de repetição é igual ao numero de elementos do vetor
            {
                trocou = false; // variavel recebe false quando for necessário entrar no laço FOR
                for (int i = 0; i < vetor.Length - 1; i++) // E esse laço FOR, repetirá para ocorrer a mudança do elemento de lugar no vetor // Repetirá do primeiro ao penultimo numero pois quando entrar pela segunda vez nesse laço FOR, o maior numero já estará na ultima posição
                {
                    if (vetor[i].preço > vetor[i + 1].preço) // Então, quando o elemento na posição i for maior que o elemento na posição seguinte(i+1), ocorrerá os seguintes passos:
                    {
                        aux = vetor[i].preço; // 1 - Uma variavel auxiliar, receberá o valor da posição i, para que esse valor não se perca quando receber o valor de i+1
                        vetor[i].preço = vetor[i + 1].preço; // 2 - i então recebe o valor de i+1
                        vetor[i + 1].preço = aux; // 3 - E então, i+1 recebe o valor de aux (originalmente em i), com isso, os valores se organizam, movendo o maior para a ultima posição
                        aux2 = vetor[i].nome;// 4 - Uma varíavel auxiliar 2 receberá a string na posição i, para que esse valor não se perca quando receber a string em i+1
                        vetor[i].nome = vetor[i + 1].nome;//5 - i então recebe o valor de i+1
                        vetor[i + 1].nome = aux2;//6 - E então, i+1 recebe a string de aux2 (originalmente em i), com isso, os nomes se organizam de acordo com seus respectivos valores
                        trocou = true; // 7 - A variavel trocou recebe true para parar de repetir o primeiro laço FOR, poupando tempo
                    }
                }
            }
        }
        public static void mostraVetor(Produto[] vetor)
        {
            foreach (Produto prod in vetor)
            {
                Console.WriteLine("Produto: " + prod.nome + " - Preço: " + prod.preço);
            }
        }
            
        static void Main(string[] args)
        {
            Produto[] info = new Produto[5];
            string n = "";
            float p = 0;
            int i = 0;
            for (i = 0; i < info.Length; i++)
            {
                Console.Write("Produto "+(i+1)+": ");
                n = Console.ReadLine();
                Console.Write("Preço: ");
                p = Convert.ToSingle(Console.ReadLine());
                info[i] = new Produto(n, p);
                Console.Write("\n");
            }            
            bubblesort(info);
            mostraVetor(info);
            Console.Write("\nTecle ENTER para sair...");
            Console.ReadLine();
        }
    }
}
