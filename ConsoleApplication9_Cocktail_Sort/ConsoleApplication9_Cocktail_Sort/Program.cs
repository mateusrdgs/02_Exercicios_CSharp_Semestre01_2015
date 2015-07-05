using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9_Cocktail_Sort
{
    class Program
    {
        public static void CocktailSort(int[] vetor)
        {
            bool trocou;
            do
            {
                trocou = false;
                for (int i = 0; i <= vetor.Length - 2; i++)
                {
                    if (vetor[i] > vetor[i + 1])
                    {
                        //testa se os dois elementos estão na ordem errada
                        int aux = vetor[i];
                        vetor[i] = vetor[i + 1];
                        vetor[i + 1] = aux;
                        trocou = true;
                    }
                }
                if (!trocou)
                {
                    // aqui podemos sair do loop se não ocorreram trocas.
                    break;
                }
                trocou = false;
                for (int i = vetor.Length - 2; i >= 0; i--)
                {
                    if (vetor[i] > vetor[i + 1])
                    {
                        int aux = vetor[i];
                        vetor[i] = vetor[i + 1];
                        vetor[i + 1] = aux;
                        trocou = true;
                    }
                }
                //se nenhum elemento foi trocado, então a lista está organizada
            } while (trocou);
        }
        static void Main(string[] args)
        {
            int tamanho;
            Console.Write("Digite aqui o tamanho do vetor: ");
            tamanho = Convert.ToInt16(Console.ReadLine());

            int[] vetor = new int[tamanho];
            Console.Write("\n");
            int i;
            for (i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite aqui os números a serem organizados: ");
                vetor[i] = Convert.ToInt16(Console.ReadLine());
            }
            CocktailSort(vetor);
            Console.Write("\n");
            for (i = 0; i < vetor.Length; i++)
            {
                Console.Write("[" + vetor[i] + "]");
            }

            Console.ReadLine();
        }
    }
}
