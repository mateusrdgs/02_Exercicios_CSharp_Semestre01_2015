using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4_Bubble_Sort_Letras
{
    class Program
    {
        public static string bubblesort(string word)
        {
            int aux1 = ' ', x = 0;
            string word2 = "";
            int[] b = new int[word.Length];
            bool trocou = true;

            for (x = 0; x < word.Length && trocou; x++)
            {
                b[x] = Convert.ToInt32(word[x]);
            }
            for (int j = 0; j < b.Length; j++)
            {
                trocou = false;
                for (int i = 0; i < b.Length - 1; i++)
                {
                    if (b[i] > b[i + 1])
                    {
                        aux1 = b[i];
                        b[i] = b[i + 1];
                        b[i + 1] = aux1;
                        trocou = true;
                    }
                }
            }
            for (x = 0; x < word.Length; x++)
            {
                word2 += char.ConvertFromUtf32(b[x]);
            }

            return word2;
        }
        static void Main(string[] args)
        {
            string letras = "bcead", retorno = "";
            retorno = bubblesort(letras);
            Console.WriteLine("" + letras);
            Console.WriteLine("                                 ");
            Console.Write("" + retorno);
            Console.ReadLine();
        }
    }
}
