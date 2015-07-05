using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13_ExBanco
{
    public class Conta
    {
        // atributos
        public string Dono;
        public int Numero;
        public double Saldo, Limite;

        // construtor
        public Conta()
        {
            Dono = "Fulano";
            Numero = 123;
            Saldo = 0;
            Limite = 5000;
        }
        // métodos
        public void Saque(double quantidade)
        {
            if (quantidade <= Saldo && quantidade <= Limite)
            {
                Saldo -= quantidade;
                Console.Write("Operação realizada com sucesso...");
            }
            else
            {
                if (Saldo == 0) {
                    Console.Write("Você tem 0 Dilmas");
                }
                else
                    Console.Write("Saldo ou limite insuficiente, você tem " + Saldo + " Dilmas"); 
            }
        }
        public void Deposita(double quantidade)
        {
            Saldo += quantidade;
        }
        public double verificaSaldo()
        {
            return Saldo;
        }
        public double verificaLimite()
        {
            return Limite;
        }
        public void alteraLimite(double novoLimite)
        {
            Limite = novoLimite;
        }
        public void aumentaLimite(double quantidade)
        {
            Limite += quantidade;
        }
        public void diminuiLimite(double quantidade)
        {
            Limite -= quantidade;
        }

        public void mostraDados()
        {
            Console.WriteLine("Nome: " + Dono);
            Console.WriteLine("Número: " + Numero);
            Console.WriteLine("Saldo: " + Saldo);
            Console.WriteLine("Limite: " + Limite);
        }
    }
}
