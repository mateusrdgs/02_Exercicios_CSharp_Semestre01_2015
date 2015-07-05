using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10_Métodos_de_Ordenação
{
    class Program
    {
        static void ShellSort(int[] vetor)
        {
            // declaração de variáveis a serem utilizadas
            int i, j, incremento, aux;
            // aqui meu incremento receberá a metade do tamanho do vetor; incremento deverá sempre ser > 0; e ao final do bloco, será dividido por 2 novamente
            for (incremento = vetor.Length/2; incremento > 0; incremento /= 2)
            {
                // i receberá incremento; i deverá ser menor que o comprimento do vetor
                for (i = incremento; i < vetor.Length; i++)
                {
                    // minha variavel auxiliar receberá o elemento de vetor na posição i
                    aux = vetor[i];
                    // j receberá i; j deverá ser maior ou igual ao incremento; j receberá o que está em j menos incremento
                    for (j = i; j >= incremento; j -= incremento)
                    {
                        // caso seja atendido o laço for, o código executará o comando if
                        //onde, se aux < vetor j - incremento, vetor na posição j receberá vetor j - incremento
                        if (aux < vetor[j - incremento])
                        {
                            vetor[j] = vetor[j - incremento];
                        }
                            //se não, interrompemos o processo
                        else
                        {
                            break;
                        }
                    }
                    //e então, vetor na posição j recebe o que estava na minha variável auxiliar
                    vetor[j] = aux;
                }
            }            
        }
        public static void GnomeSort(int[] vetor)
        {
            int i = 1;
            int j = 2;
            int aux = 0;

            //enquanto i for menor que vetor.Length, se repetirá o seguinte processo:
            while (i < vetor.Length)
            {
                // se o elemento no vetor na posição a esquerda[i-1] de vetor[i] for menor ou igual a ele, nada é trocado
                if (vetor[i - 1] <= vetor[i])
                {
                    // exceto que i recebe a proxima posição [j] e j é incrementado em 1
                    i = j;
                    j++;
                }
                // agora, caso o elemento a esquerda seja maior que o da direita 
                else
                {
                    // salvamos o elemento da esquerda em uma variável auxiliar
                    aux = vetor[i - 1];
                    // o elemento da esquerda, dá lugar ao elemento menor que ele da direita
                    vetor[i - 1] = vetor[i];
                    // e colocamos o maior elemento de volta no vetor, na posição i (agora, maior que o número que está a sua esquerda)
                    vetor[i] = aux;
                    // i recebe i-1 para voltar as posições anteriores e repetir o processo de comparação
                    i -= 1;
                    // e caso i == 0, i=1 e j=2
                    if (i == 0)
                    {
                        i = 1;
                        j = 2;
                    }
                }
            }
        }
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
        static void MostraVetor(int[] vetor)
        {
            string vetor_escrito = "Vetor:";

            foreach (int numero in vetor)
            {
                vetor_escrito += "[" + numero + "]";
            }            
            Console.Write(vetor_escrito);
        }
        static void Main(string[] args)
        {
            int tamanho, utilizado;
            Console.Write("Digite aqui o tamanho do vetor: ");
            tamanho = Convert.ToInt32(Console.ReadLine());

            int[] vetor = new int[tamanho];
            Console.Write("\n");
            int i;
            for (i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite aqui o número da " + (i+1) + "ª posição: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }            
            Console.WriteLine("\n1 - Shell Sort");
            Console.WriteLine("2 - Gnome Sort");
            Console.WriteLine("3 - Cocktail Sort\n ");
            do
            {
                Console.SetCursorPosition(0, tamanho + 7);
                Console.Write("Escolha aqui o método a ser utilizado:                    ");
                Console.SetCursorPosition(39, tamanho + 7);
                utilizado = Convert.ToInt32(Console.ReadLine());                
            } while (utilizado > 3);
            
            string used="";

            #region used
            if (utilizado == 1)
            {
                used = "Shell Sort";
            }
            else if (utilizado == 2)
            {
                used = "Gnome Sort";
            }
            else
            {
                used = "Cocktail Sort";
            }
            #endregion

            Console.WriteLine("\nVetor antes do "+used);
            MostraVetor(vetor);

            #region condições para escolha de método
            if (utilizado == 1)
            {
                ShellSort(vetor);
            }
            else if (utilizado == 2)
            {
                GnomeSort(vetor);
            }
            else
            {
                CocktailSort(vetor);
            }
            #endregion
            
            Console.WriteLine("\n\nVetor depois do " + used);
            MostraVetor(vetor);
            Console.Write("\n\nTecle ENTER para sair...");
            Console.ReadLine();
        }
    }
}
