using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevador elevador = new Elevador();
            while(true)
            {
                Console.Clear();                
                Console.WriteLine("ELEVADOR");                
                Console.WriteLine("\n1. Iniciar elevador");
                Console.WriteLine("2. Entrar no elevador");
                Console.WriteLine("3. Sair do elevador");
                Console.WriteLine("4. Subir de andar");
                Console.WriteLine("5. Descer de andar");
                Console.WriteLine("6. Sair");
                Console.Write("\nEscolha: ");
                Console.SetCursorPosition(71, 2);
                Console.WriteLine("Andar: " + elevador.getAndarAtual());
                Console.SetCursorPosition(65, 3);
                Console.WriteLine("Passageiros: " + elevador.getpessoasDentro());
                Console.SetCursorPosition(9, 9);
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("INICIANDO ELEVADOR");
                        Console.Write("\nAguarde...");
                        elevador.setInicializa(8, 0, 20);
                        System.Threading.Thread.Sleep(2000);
                        Console.Write("\n\nELEVADOR LIGADO!");
                        Console.Beep();
                        Console.ReadLine();
                        break;
                    case 2:
                        if (elevador.getTotalAndares() == 0)
                        {
                            Console.Clear();
                            Console.Write("Você ainda não iniciou o elevador!");
                            System.Threading.Thread.Sleep(2000);
                            goto case 1;
                        }
                        Console.Clear();
                        Console.WriteLine("ENTRAR NO ELEVADOR");
                        Console.Write("\nDigite o número de passageiros a entrar: ");
                        int passageiro = Convert.ToInt32(Console.ReadLine());
                        elevador.setEntra(passageiro);                        
                        Console.ReadLine();
                        break;
                    case 3:
                        if (elevador.getTotalAndares() == 0)
                        {
                            Console.Clear();
                            Console.Write("Você ainda não iniciou o elevador!");
                            System.Threading.Thread.Sleep(2000);
                            goto case 1;
                        }
                        if(elevador.getpessoasDentro() == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("SAIR DO ELEVADOR");
                            Console.Write("\nO elevador está vazio");
                            System.Threading.Thread.Sleep(2000);
                            goto case 2;
                        }
                        Console.Clear();
                        passageiro = 0;
                        Console.WriteLine("SAIR DO ELEVADOR");
                        Console.Write("\nDigite o número de passageiros a sair: ");
                        passageiro = Convert.ToInt32(Console.ReadLine());
                        elevador.setSai(passageiro);
                        System.Threading.Thread.Sleep(2000);
                        Console.Write("\nPassageiros prontos");
                        Console.ReadLine();
                        break;
                    case 4:
                         if (elevador.getTotalAndares() == 0)
                        {
                            Console.Clear();
                            Console.Write("Você ainda não iniciou o elevador!");
                            System.Threading.Thread.Sleep(2000);
                            goto case 1;
                        }
                         Console.Clear();
                        Console.WriteLine("SUBIR DE ANDAR");
                        Console.Write("\nDigite o número de andares a subir: ");
                        int andar = Convert.ToInt32(Console.ReadLine());
                        elevador.setSobe(andar);
                        System.Threading.Thread.Sleep(2000);
                        Console.Write("\nPassageiros prontos");
                        Console.ReadLine();
                        break;
                    case 5:
                         if (elevador.getTotalAndares() == 0)
                        {
                            Console.Clear();
                            Console.Write("Você ainda não iniciou o elevador!");
                            System.Threading.Thread.Sleep(2000);
                            goto case 1;
                        }
                         andar = 0;
                         Console.Clear();
                        Console.WriteLine("DESCER DE ANDAR");
                        Console.Write("\nDigite o número de andares a descer: ");
                        andar = Convert.ToInt32(Console.ReadLine());
                        elevador.setDesce(andar);                        
                        break;
                    case 6:                        
                        Environment.Exit(0);
                        break;
                }
            } 
        }
    }
}
