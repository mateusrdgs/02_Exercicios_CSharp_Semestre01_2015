using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15_Get_e_Set
{
    class Program
    {
        static List<Pessoa> pessoas = new List<Pessoa>();
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.Clear();
                Console.WriteLine("1. Insere Pessoa");
                Console.WriteLine("2. Busca Pessoas");
                Console.WriteLine("3. Mostra Pessoas");
                Console.WriteLine("4. Sair para o Windows");
                Console.Write("\nSua opção: ");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Pessoa p = new Pessoa();
                        Console.Clear();
                        Console.Write("Nome: ");
                        p.setNome(Console.ReadLine());
                        Console.Write("Idade: ");
                        p.setIdade(Convert.ToInt32(Console.ReadLine()));
                        pessoas.Add(p);
                        break;

                    case 3:
                        Console.Clear();
                        foreach (Pessoa pessoa in pessoas)
                        {
                            Console.WriteLine("Nome: " + pessoa.getNome() + " - Idade: "+pessoa.getIdade());                            
                                              
                        }
                        Console.ReadLine();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;

                }
            }
            
            
        }
    }
}
