using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[] { 5, 4, 6, 1, 9, 4, 3, 0, 8, 7 };
            MostraVetor(numeros);
            merge(numeros, 0, numeros.Length - 1);

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

        static void MostraVetor(int[] vetor, int inicio, int fim, int meio, string metodo)
        {
            string vetor_escrito = metodo + " - Vetor 1:";

            for (int i = inicio; i <= meio; i++)
            {
                vetor_escrito += "[" + vetor[i] + "]";
            }

            vetor_escrito += "   Vetor 2:";

            for (int i = meio + 1; i <= fim; i++)
            {
                vetor_escrito += "[" + vetor[i] + "]";
            }

            Console.WriteLine(vetor_escrito);
        }

        // ordena o vetor com a ajuda de um vetor auxiliar
        static void intercala(int[] vetor, int inicio, int fim, int meio)
        {
            // cria um vetor auxiliar com o mesmo tamanho do vetor original
            int[] vetor_auxiliar = new int[vetor.Length];

            // posLivre: posição livre no vetor auxiliar
            int posLivre, inicio_vetor1, inicio_vetor2;

            // a 1ª posição livre do vetor auxiliar é
            // o valor de inicio
            posLivre = inicio;

            // faz a divisão do vetor em 2 partes
            inicio_vetor1 = inicio;
            inicio_vetor2 = meio + 1;

            MostraVetor(vetor, inicio, fim, meio, "INTERCALA");

            // intercalação
            while (inicio_vetor1 <= meio && inicio_vetor2 <= fim)
            {
                if (vetor[inicio_vetor1] <= vetor[inicio_vetor2])
                {
                    vetor_auxiliar[posLivre] = vetor[inicio_vetor1];
                    inicio_vetor1++;
                }
                else if (vetor[inicio_vetor2] <= vetor[inicio_vetor1])
                {
                    vetor_auxiliar[posLivre] = vetor[inicio_vetor2];
                    inicio_vetor2++;
                }

                posLivre++;
            }

            // se existirem valores que ainda não foram
            // intercalados vetor 1
            for (int i = inicio_vetor1; i <= meio; i++)
            {
                vetor_auxiliar[posLivre] = vetor[i];
                posLivre++;
            }

            // se existirem valores que ainda não foram
            // intercalados vetor 2
            for (int i = inicio_vetor2; i <= fim; i++)
            {
                vetor_auxiliar[posLivre] = vetor[i];
                posLivre++;
            }

            // retorna os valores do vetor auxiliar para o vetor original
            for (int i = inicio; i <= fim; i++)
            {
                vetor[i] = vetor_auxiliar[i];
            }

            MostraVetor(vetor, inicio, fim, meio, "INTERCALA");
            MostraVetor(vetor);
        }

        // método que divide o vetor e intercala os valores
        // por meio de recursividade
        static void merge(int[] vetor, int inicio, int fim)
        {
            int meio;
            if (inicio < fim)
            {
                meio = (inicio + fim) / 2;
                MostraVetor(vetor, inicio, fim, meio, "MERGE");
                merge(vetor, inicio, meio);
                merge(vetor, meio + 1, fim);
                intercala(vetor, inicio, fim, meio);
            }
        }
    }
}
