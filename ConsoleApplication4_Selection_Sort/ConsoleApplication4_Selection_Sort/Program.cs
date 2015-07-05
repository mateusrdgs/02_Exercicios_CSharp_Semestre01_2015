using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6_Selection_Sort
{
    class Program
    {
        static void SelectionSort(int[] vetor)
        {
            /* variáveis para armazenar os valores do número eleito,
            do menor número à direita de eleito e sua posição */
            int eleito = 0, menor = 0, pos = 0;

            // percorre do 1º ao penúltimo elemento
            for (int i = 0; i < vetor.Length - 1; i++)
            {
                // recebe eleito
                eleito = vetor[i];
                // menor recebe primeiramente o primeiro elemento à direita do elemento eleito
                menor = vetor[i + 1];

                // pos recebe a posição do primeiro elemento à direita do elemento eleito
                pos = i + 1;

                // percorre o restante do vetor para procurar o menor número
                for (int j = i + 2; j < vetor.Length; j++)
                {
                    // se encontrar um número menor
                    if (vetor[j] < menor)
                    {
                        // atualiza os valores de menor e pos
                        menor = vetor[j];
                        pos = j;
                    }
                }
                // se o menor valor encontrado for menor que o valor eleito
                if (menor < eleito)
                {
                    // menor vai para a posição de eleito
                    // e eleito vai para a posição de menor(pos)   
                    vetor[i] = menor;
                    vetor[pos] = eleito;
                }
            }

            MostraVetor(vetor);
        }

        static void MostraVetor(int[] vetor)
        {
            string vetor_escrito = "Vetor: ";
            foreach (int numero in vetor)
            {
                vetor_escrito += "[" + numero + "]";
            }
            Console.WriteLine(vetor_escrito);
        }

        static void Main(string[] args)
        {
            int tamanho = 0;
            Console.Write("Digite o tamanho do vetor: ");
            tamanho = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("                        ");
            int[] vetor = new int[tamanho];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite o valor da posição " + i + ": ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("                                     ");
            MostraVetor(vetor);
            SelectionSort(vetor);

            Console.WriteLine("                    ");
            Console.Write("Tecle ENTER para sair...");
            Console.ReadLine();
        }
    }
}
