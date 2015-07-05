using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2_Bubble_Sort
{
    class Program
    {
        public static void bubblesort(int[] vetor,ref int contador) // Função Bubblesort
        {
            int aux = 0; // variável auxiliar
            bool trocou = true; // variável bool para poupar tempo e não repetir o laço FOR desnecessáriamente
            for (int j = 0; j < vetor.Length && trocou; j++) // Esse laço FOR, repetirá o processo de organização dos elementos no vetor // A quantidade de repetição é igual ao numero de elementos do vetor
            {
                trocou = false; // variavel recebe false quando for necessário entrar no laço FOR
                for (int i = 0; i < vetor.Length - 1; i++) // E esse laço FOR, repetirá para ocorrer a mudança do elemento de lugar no vetor // Repetirá do primeiro ao penultimo numero pois quando entrar pela segunda vez nesse laço FOR, o maior numero já estará na ultima posição
                {
                    if (vetor[i] > vetor[i + 1]) // Então, quando o elemento na posição i for maior que o elemento na posição seguinte(i+1), ocorrerá os seguintes passos:
                    {
                        aux = vetor[i]; // 1 - Uma variavel auxiliar, receberá o valor da posição i, para que esse valor não se perca quando receber o valor de i+1
                        vetor[i] = vetor[i + 1]; // 2 - i então recebe o valor de i+1;
                        vetor[i + 1] = aux; // 3 - E então, i+1 recebe o valor de aux (originalmente em i), com isso, os valores se organizam, movendo o maior para a ultima posição
                        trocou = true; // 4 - A variavel trocou recebe true para parar de repetir o primeiro laço FOR, poupando tempo
                    }
                    contador++;                 
                }
            }
            //return contador;
        }

        static void Main(string[] args)
        {
            int[] array = new int[5];
            int x = 0, repeticao = 0;
            string ordinal = "";    
            for (x = 0; x < array.Length; x++)// Comando FOR para repetição do pedido de digitação dos números a serem ordenados
            {
                #region If's
                if (x == 0)
                {
                    ordinal = "primeiro";
 
                }
                else if (x == 1)
                {
                    ordinal = "segundo";
                }
                else if (x == 2)
                {
                    ordinal = "terceiro";
                }
                else if (x == 3)
                {
                    ordinal = "quarto";
                }
                else if (x == 4)
                {
                    ordinal = "quinto";
                }                
                #endregion                
                Console.Write("Digite aqui o "+ ordinal +" número a ser ordenado: ");
                array[x] = Convert.ToInt32(Console.ReadLine()); 
            }           

            bubblesort(array,ref repeticao); // Aqui eu chamo a função bubblesort, passando os valores em "array" para o parâmetro "vetor" na função acima e a variavel repetição receberá um certo valor indicando quantas repetições houveram para a organização dos números no vetor
            Console.WriteLine("                                                        "); // Linha em branco para separar o bloco de numeros digitados do bloco impresso
            for (x = 0; x < array.Length; x++) // Comando FOR para repetição da impressão dos números ordenados
            {                
                Console.WriteLine("Posição "+ x +": "+ array[x]); // Impressão da posição do array e seu respectivo valor
            }
                Console.WriteLine("                                                        ");
                Console.Write("O processo foi repetido "+ repeticao +" vezes");
                Console.ReadLine();
        }
    }
}
