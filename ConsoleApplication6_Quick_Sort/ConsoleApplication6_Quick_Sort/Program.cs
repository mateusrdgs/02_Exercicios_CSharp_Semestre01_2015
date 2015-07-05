using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[] { 5, 8, 3, 1, 6, 2, 4, 9, 7, 5 };

            MostraVetor(numeros);

            quickSort(numeros, 0, 9);

            MostraVetor(numeros);

            Console.ReadLine();
        }

        static void MostraVetor(int[] vetor)
        {
            string vetor_escrito = "Vetor:";

            foreach (int numero in vetor)
            {
                vetor_escrito += "[" + numero + "]";
            }

            Console.WriteLine(vetor_escrito);
        }

        static void MostraVetor(int[] vetor, int inicio, int fim, string metodo, ConsoleColor cor)
        {
            string vetor_escrito = metodo + " - Vetor:";

            for (int i = inicio; i <= fim; i++)
            {
                vetor_escrito += "[" + vetor[i] + "]";
            }

            Console.ForegroundColor = cor;
            Console.WriteLine(vetor_escrito);
            Console.ResetColor();
        }

        // troca os valores de posição
        static void troca(int[] vetor, int i, int j)
        {
            int aux;
            aux = vetor[i];
            vetor[i] = vetor[j];
            vetor[j] = aux;
        }

        // divide o vetor através de um pivô
        // ordena de forma que todos os elementos à esquerda de pivô são menores que ele
        // todos os elementos à direita de pivô são maiores que ele
        static int particao(int[] vetor, int inicio, int fim)
        {
            MostraVetor(vetor, inicio, fim, "particao", ConsoleColor.Green);

            int pivo, i, j;

            // obtém o pivô
            pivo = vetor[(inicio + fim) / 2];

            i = inicio - 1;
            j = fim + 1;

            while (i < j)
            {
                do
                {
                    j--;
                } while (vetor[j] > pivo);

                do
                {
                    i++;
                } while (vetor[i] < pivo);

                if (i < j)
                {
                    troca(vetor, i, j);
                    MostraVetor(vetor, inicio, fim, "troca", ConsoleColor.Yellow);
                }
            }

            MostraVetor(vetor, inicio, fim, "particao", ConsoleColor.Green);

            return j;
        }

        static void quickSort(int[] vetor, int inicio, int fim)
        {
            MostraVetor(vetor, inicio, fim, "quickSort", ConsoleColor.Cyan);
            int pivo;
            if (inicio < fim)
            {
                pivo = particao(vetor, inicio, fim);
                quickSort(vetor, inicio, pivo);
                quickSort(vetor, pivo + 1, fim);
            }
        }
    }
}
