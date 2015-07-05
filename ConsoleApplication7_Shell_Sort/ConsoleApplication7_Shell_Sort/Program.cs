using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7_Shell_Sort
{
    class Program
    {
        static void ShellSort(int[] array, int elementos)
        {
            int i, j, incremento, aux;
            for (incremento = elementos / 2; incremento > 0; incremento /= 2)
            {
                for (i = incremento; i < elementos; i++)
                {
                    aux = array[i];
                    for (j = i; j >= incremento; j -= incremento)
                    {
                        if (aux < array[j - incremento])
                        {
                            array[j] = array[j - incremento];
                        }
                        else
                        {
                            break;
                        }
                    }
                    array[j] = aux;
                }
            }
        }
        static void Main(string[] args)
        {
            int tamanho;
            Console.Write("Digite aqui o tamanho do vetor: ");
            tamanho = Convert.ToInt16(Console.ReadLine());

            int[] vetor = new int[tamanho];
            int i;
            for (i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite aqui os números a serem organizados: ");
                vetor[i] = Convert.ToInt16(Console.ReadLine());
            }
            ShellSort(vetor, tamanho);

            Console.ReadLine();
        }
    }
}
