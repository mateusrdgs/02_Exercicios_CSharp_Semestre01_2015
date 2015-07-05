using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8_Gnome_Sort
{
    class Program
    {
        public static void GnomeSort(int[] a)
        {
            int i = 1;
            int j = 2;
            int aux = 0;

            while (i < a.Length)
            {
                if (a[i - 1] <= a[i])
                {
                    i = j;
                    j++;
                }
                else
                {
                    aux = a[i - 1];
                    a[i - 1] = a[i];
                    a[i] = aux;
                    i -= 1;
                    if (i == 0)
                    {
                        i = 1;
                        j = 2;
                    }
                }
            }
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
            GnomeSort(vetor);
            Console.Write("\n");
            for (i = 0; i < vetor.Length; i++)
            {
                Console.Write("[" + vetor[i] + "]");
            }

            Console.ReadLine();
        }
    }
}
