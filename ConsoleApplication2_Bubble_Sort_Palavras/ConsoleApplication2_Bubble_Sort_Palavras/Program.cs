using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5_Bubble_Sort_Palavras
{
    class Program
    {
        static void bubblesort(string[] words/*, string[] words2*/)
        {
            int aux1 = ' ', x = 0;
            string word = "";
            int[] b = new int[words.Length];
            string[] words2 = new string[words.Length];
            words2 = words;
            bool trocou = true;

            for (x = 0; x < words.Length && trocou; x++)
            {
                b[x] = Convert.ToInt32(words[x][0]);
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
            for (x = 0; x < words.Length; x++)
            {
                word += char.ConvertFromUtf32(b[x]);
                for (int z = 0; z < words.Length; z++)
                {
                    if (words2[z][0] == word[x])
                    {
                        words[x] = words2[z];
                    }
                }
            }
        }
        static void Main(string[] args)
        {

            string[] nomes = new string[] { "Schuldiner", "Embury", "Laiho", "Benton", "Corpsegrinder" };
            //string[] nomes2 = new string[] { "Schuldiner", "Embury", "Laiho", "Benton", "Corpsegrinder" };
            Console.WriteLine("                             ");
            bubblesort(nomes);
            for (int l = 0; l < nomes.Length; l++)
            {
                Console.WriteLine("nomes: " + nomes);
            }
            Console.ReadLine();
        }
    }
}
