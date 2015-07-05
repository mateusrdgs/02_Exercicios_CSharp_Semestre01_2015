using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3_Insertion_Sort
{
    class Program
    {
        public static void insertionsort(int[] vetor)
        {
            int eleito = 0;// variavel eleito, que guardará um numero do array (parâmetro) vetor
            for (int i = 1; i < vetor.Length; i++) // Laço FOR para eleger determinado número no array
            {
                eleito = vetor[i]; // E então, eleito recebe o numero no array na posição i
                for (int j = i - 1; j >= 0 && vetor[j] > eleito; j--)//Laço FOR condicionado, onde j começa em i-1; j precisa ser maior ou igual a 0(para não estourar o array) e o elemento na posição j, precisa ser maior que o elemento eleito(para movê-lo para a direita, organizando o array em forma crescente)
                { // Caso todas as condições sejam atendidas:
                    vetor[j + 1] = vetor[j]; // vetor em j+1 recebe determinado valor maior que ele
                    vetor[j] = eleito;//e vetor em j recebe o valor em eleito (que por sinal é menor, dessa maneira ocorre a organização de forma crescente)
                    //OBS: j-- é para a posição do vetor voltar e comparar com os números a esquerda, é usado porque utiliza como coordenada o i, que sempre avança no laço FOR acima
                }
            }
        }
        static void Main(string[] args)
        {
            #region auto
            int[] array = new int[] { 5, 4, 8, 1, 2 };
            int x = 0;// repeticao = 0;
            for (x = 0; x < array.Length; x++) // Comando FOR para repetição da impressão dos números ordenados
            {
                Console.WriteLine("Posição " + x + ": " + array[x]); // Impressão da posição do array e seu respectivo valor
            }
            #endregion

            #region Digitação
            /*string ordinal = "";
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
                Console.Write("Digite aqui o " + ordinal + " número a ser ordenado: ");
                array[x] = Convert.ToInt32(Console.ReadLine());
            }*/
            #endregion

            insertionsort(array); // Aqui eu chamo a função insertionsort, passando os valores em "array" para o parâmetro "vetor" na função acima e a variavel repetição receberá um certo valor indicando quantas repetições houveram para a organização dos números no vetor
            Console.WriteLine("                                                        "); // Linha em branco para separar o bloco de numeros digitados do bloco impresso
            for (x = 0; x < array.Length; x++) // Comando FOR para repetição da impressão dos números ordenados
            {
                Console.WriteLine("Posição " + x + ": " + array[x]); // Impressão da posição do array e seu respectivo valor
            }
            Console.ReadLine();
        }
    }
}
