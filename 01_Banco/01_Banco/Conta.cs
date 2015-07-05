using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Banco
{
	public class Conta
	{
		// atributos
		public string dono, agencia, conta, digitoConta;
		public int numero;
		public double saldo, limite;

		// construtor
		public Conta()
		{
			dono = "";
			numero = 0;
			saldo = 0;
			limite = 1000;
            agencia = "";
            conta = "";
            digitoConta = "";
            
		}        

		// métodos
		public void Saque(double quantidade)
		{
			if (quantidade <= saldo && quantidade <= limite)
			{
				saldo -= quantidade;
				Console.Write("Operação realizada com sucesso...");
			}
			else
			{
				if (saldo == 0) {
					Console.Write("Você tem 0 Dilmas");
				}
				else
					Console.Write("Saldo ou limite insuficiente, você tem " + saldo + " Dilmas"); 
			}
		}

		public void Deposita(double quantidade)
		{
			saldo += quantidade;
		}

		public double verificaSaldo()
		{
			return saldo;
		}

		public double verificaLimite()
		{
			return limite;
		}

		public void alteraLimite(double novoLimite)
		{
			limite = novoLimite;
			Console.WriteLine("\nLimite alterado com sucesso...");
		}

		public void aumentaLimite(double quantidade)
		{
			limite += quantidade;
			Console.Write ("\nNovo limite: "+limite);
			Console.Write("\n\nLimite alterado com sucesso...");
		}

		public void diminuiLimite(double quantidade)
		{
			limite -= quantidade;
			Console.Write ("\nNovo limite: "+limite);
			Console.Write("\n\nLimite alterado com sucesso...");
		}

        public void geraAgencia()
        {
            Random aleatorio = new Random();
            int numero  = aleatorio.Next(999, 10000);
            agencia = Convert.ToString(numero);
        }

        public void geraConta()
        {
            Random aleatorio = new Random();
            int numero = aleatorio.Next(9999, 100000);
            conta = Convert.ToString(numero);
        }

        public void geraNumeroAposDigito()
        {
            Random aleatorio = new Random();
            int numero = aleatorio.Next(-1, 10);
            digitoConta = Convert.ToString(numero); 
        }

		public void mostraDados()
		{
			Console.WriteLine("Nome: " + dono);
			Console.WriteLine("Número: " + numero);
			Console.WriteLine("Saldo: " + saldo);
			Console.WriteLine("Limite: " + limite);
		}
	}
}