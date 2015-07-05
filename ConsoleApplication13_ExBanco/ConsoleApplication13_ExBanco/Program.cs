using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13_ExBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            //conta.mostraDados();     
            Console.SetCursorPosition(37, 0);
            Console.WriteLine("Banco HP");
                        
            //recebe o nome do dono
            Console.Write("\n");
            Console.Write("Informe o nome do dono da conta: ");
            conta.Dono = Console.ReadLine();

            //gera um nº aleatório para a conta
            Random aleatorio = new Random();
            conta.Numero = aleatorio.Next(2000, 100000);
            Console.WriteLine("O número da sua conta é: " + conta.Numero);
            conta.Saldo = conta.Numero;
            double valor = 0;
            char resp = 'n';
            bool depositou = false, repete = true;            

            int escolha = 0;

            do {
                Console.Clear();
                Console.SetCursorPosition(37, 0);
                Console.WriteLine("Banco HP");

                //recebe o nome do dono
                Console.Write("\n");
                Console.Write("Dono da Conta: " + conta.Dono);
                Console.SetCursorPosition(39, 3);
                Console.WriteLine("MENU");
                Console.WriteLine("\n1 - Saque");
                Console.WriteLine("2 - Depósito");
                Console.WriteLine("3 - Verificar Saldo");
                Console.WriteLine("4 - Verificar Limite");
                Console.WriteLine("5 - Alterar Limite");
                Console.WriteLine("6 - Aumentar Limite");
                Console.WriteLine("7 - Diminuir Limite");
                Console.WriteLine("8 - Sair\n");
                Console.Write("Escolha: ");

                if (int.TryParse(Console.ReadLine(), out escolha))
                {
                    switch (escolha)
                    {
                        //saque                            
                        case 1:
                            {
                                do
                                {
                                    repete = true;
                                    Console.Clear();                                    
                                    Console.SetCursorPosition(37, 0);
                                    Console.WriteLine("Banco HP");
                                    Console.Write("Nome: " + conta.Dono + "\nNúmero: " + conta.Numero + "\nSaldo: " + conta.Saldo);
                                    Console.Write("\n\nDigite o valor do saque: ");
                                    conta.Saque(valor = Convert.ToDouble(Console.ReadLine()));
                                    do
                                    {
                                        Console.SetCursorPosition(0, 8);
                                        Console.Write("Deseja fazer outro saque? (s/n):                    ");
                                        Console.SetCursorPosition(33, 8);
                                        resp = Convert.ToChar(Console.ReadLine());
                                        resp = char.ToLower(resp);
                                        repete = resp == 's' ? true : false;
                                    } while ((resp != 's' && resp != 'n'));                              
                                } while ((repete) && (conta.Saldo > valor));
                            }                             
                            break;
                            
                        //depósito
                        case 2:
                            do
                            {
                                Console.Clear();
                                Console.SetCursorPosition(37, 0);
                                Console.WriteLine("Banco HP");
                                Console.Write("Nome: " + conta.Dono + "\nNúmero: " + conta.Numero + "\nSaldo: " + conta.Saldo);
                                Console.Write("\n\nDigite o valor do depósito: ");
                                conta.Deposita(valor = Convert.ToDouble(Console.ReadLine()));
                                Console.WriteLine("\nSaldo: "+conta.Saldo);
                                do
                                {
                                    Console.SetCursorPosition(0, 9);
                                    Console.WriteLine("Deseja fazer outro deposito? (s/n):                    ");
                                    Console.SetCursorPosition(36, 9);
                                    resp = Convert.ToChar(Console.ReadLine());
                                    resp = char.ToLower(resp);
                                    repete = resp == 's' ? true : false;
                                } while ((resp != 's' && resp != 'n'));
                            } while (repete);
                                            
                        break;
                            
                        //verfica saldo
                        case 3:Console.Clear(); 
                        Console.Write("Seu saldo: "+ conta.verificaSaldo());
                        break;

                        // verifica limite
                        case 4: Console.Clear();
                        Console.WriteLine("Seu limite "+ conta.verificaLimite());
                        break;

                        // alterar limite
                        case 5: Console.Write("Digite o valor do novo limite: ");
                        conta.alteraLimite(valor = Convert.ToDouble(Console.ReadLine()));
                        break;

                        // aumentar limite
                        case 6: Console.Write("Digite o valor do acrescimo: ");
                        conta.aumentaLimite(valor = Convert.ToDouble(Console.ReadLine()));
                        break;

                        // diminuir limite
                        case 7: Console.WriteLine("Digite o valor do decrescimo: ");
                        conta.diminuiLimite(valor = Convert.ToDouble(Console.ReadLine()));
                        break;
                        
                        case 8:
                        Environment.Exit(0);
                        break;
                    }

                }

                else Console.WriteLine("Opção inválida...");

                Console.ReadLine();

            } while (true);
        }
    }
}
