using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Banco
{
	class Program
	{
        
		static void Main(string[] args)
        {
            /*Console.Write("LOGIN");
            Console.WriteLine("Logar como: ");
            Console.WriteLine("1. RH");
            Console.WriteLine("2. ");*/
            #region Conta
            Conta conta = new Conta();
			//conta.mostraDados();     
			Console.SetCursorPosition(33, 0);
			Console.WriteLine("Banco HP");

			//recebe o nome do dono
			Console.Write("\n");
			Console.Write("Informe o nome do dono da conta: ");
			conta.dono = Console.ReadLine();

			//gera um nº aleatório para a conta
			Random aleatorio = new Random();
			conta.numero = aleatorio.Next(2000, 100000);
			Console.WriteLine("O número da sua conta é: " + conta.numero);
			conta.saldo = conta.numero;
			double valor;
			char resp = 'n';
			bool  repete = true;            

			int escolha = 0;

			do {
				Console.Clear();
				Console.SetCursorPosition(30, 0);
				Console.WriteLine("Banco HP");

				//recebe o nome do dono
				Console.Write("\n");
				Console.Write("Dono da conta: " + conta.dono);
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
							Console.SetCursorPosition(33, 0);
							Console.WriteLine("Banco HP");
							Console.Write("Nome: " + conta.dono + "\nNúmero: " + conta.numero + "\nSaldo: " + conta.saldo);
							Console.Write("\n\nDigite o valor do saque: ");
							conta.Saque(valor = Convert.ToDouble(Console.ReadLine()));

							do {
								Console.SetCursorPosition(0, 8);
								Console.Write("Deseja fazer outro saque? (s/n):                    ");
								Console.SetCursorPosition(33, 8);
								resp = Convert.ToChar(Console.ReadLine());
								resp = char.ToLower(resp);
								repete = resp == 's' ? true : false;

							} while ((resp != 's' && resp != 'n'));                        
						} while ((repete) && (conta.saldo > 0));
					}                             
						break;

						//depósito
					case 2:
						do
						{
							Console.Clear();
							Console.SetCursorPosition(33, 0);
							Console.WriteLine("Banco HP");
							Console.Write("Nome: " + conta.dono + "\nNúmero: " + conta.numero + "\nSaldo: " + conta.saldo);
							Console.Write("\n\nDigite o valor do depósito: ");
							conta.Deposita(valor = Convert.ToDouble(Console.ReadLine()));
							Console.WriteLine("\nSaldo: "+conta.saldo);
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
						Console.SetCursorPosition(33, 0);
						Console.WriteLine("Banco HP");
						Console.SetCursorPosition(30, 2);
						Console.WriteLine("Verificar saldo");
						Console.Write("Nome: " + conta.dono + "\nNúmero: " + conta.numero);
						Console.Write("\n\nSeu saldo: "+ conta.verificaSaldo());
						Console.Write("\n\nTecle ENTER para sair...");
						break;

						// verifica limite
					case 4: Console.Clear();
						Console.SetCursorPosition(33, 0);
						Console.WriteLine("Banco HP");
						Console.SetCursorPosition(30, 2);
						Console.WriteLine("Verificar limite");
						Console.Write("Nome: " + conta.dono + "\nNúmero: " + conta.numero);
						Console.WriteLine("\n\nLimite atual "+ conta.verificaLimite());
						Console.Write("\n\nTecle ENTER para sair...");
						break;

						// alterar limite
					case 5: Console.Clear();
						Console.SetCursorPosition(33, 0);
						Console.WriteLine("Banco HP");
						Console.SetCursorPosition(30, 2);
						Console.WriteLine("Alterar limite");
						Console.Write("Nome: " + conta.dono + "\nNúmero: " + conta.numero);
						Console.Write("\nLimite atual: "+ conta.verificaLimite());
						Console.Write("\n\nDigite o valor do novo limite: ");
						conta.alteraLimite(valor = Convert.ToDouble(Console.ReadLine()));
						Console.Write("\n\nTecle ENTER para sair...");
						break;

						// aumentar limite
					case 6: Console.Clear(); 
						Console.SetCursorPosition(33, 0);
						Console.WriteLine("Banco HP");
						Console.SetCursorPosition(30, 2);
						Console.WriteLine("Aumentar limite");
						Console.Write("Nome: " + conta.dono + "\nNúmero: " + conta.numero + "\nLimite: " + conta.limite);
						Console.Write("\n\nDigite o valor do acrescimo: ");
						conta.aumentaLimite(valor = Convert.ToDouble(Console.ReadLine()));
						break;

						// diminuir limite
					case 7: Console.Clear(); 
						Console.SetCursorPosition(33, 0);
						Console.WriteLine("Banco HP");
						Console.SetCursorPosition(30, 2);
						Console.WriteLine("Diminuir limite");
						Console.Write("Nome: " + conta.dono + "\nNúmero: " + conta.numero + "\nLimite: " + conta.limite);
						Console.Write("\nDigite o valor do decrescimo: ");
						conta.diminuiLimite(valor = Convert.ToDouble(Console.ReadLine()));
						break;

						case 8:
						Environment.Exit(0);
						break;
					}

				}
				Console.ReadLine();

			} while (true);
            #endregion
        }
	}
}