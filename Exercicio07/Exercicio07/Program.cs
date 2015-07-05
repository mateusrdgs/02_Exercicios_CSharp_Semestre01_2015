using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    class Program
    {
        private static void cadastraCliente(Cliente[] cliente, int cadastrados)
        {
            Console.Clear();
            cliente[cadastrados] = new Cliente();
            Console.Write("Nome do cliente: ");
            cliente[cadastrados].setNome(Console.ReadLine());
            Console.Write("Sexo do cliente: ");
            cliente[cadastrados].setSexo(Convert.ToChar(Console.ReadLine()));
            Console.Write("Idade do cliente: ");
            cliente[cadastrados].setIdade(Convert.ToInt16(Console.ReadLine()));
            Console.Write("Crédito do cliente: ");
            cliente[cadastrados].setCredito(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Estado civil do cliente: ");
            cliente[cadastrados].setEstadoCivil(Console.ReadLine());
            Console.Write("Rua do cliente: ");
            cliente[cadastrados].endereco.setRua(Console.ReadLine());
            Console.Write("Número da casa: ");
            cliente[cadastrados].endereco.setNumero(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Bairro: ");
            cliente[cadastrados].endereco.setBairro(Console.ReadLine());
            Console.Write("Cidade: ");
            cliente[cadastrados].endereco.setCidade(Console.ReadLine());
            Console.Write("Estado: ");
            cliente[cadastrados].endereco.setEstado(Console.ReadLine());
        }

        private static int idadeMaiorOuIgual(Cliente[] cliente, int idade, int cadastrados)
        {
            int maiorOuIgual = idade, quantidade = 0, salvaIdade = 0;
            for (int cont = 0; cont < cadastrados; cont++)
            {
                salvaIdade = cliente[cont].getIdade();

                if(salvaIdade >= maiorOuIgual)
                {
                    quantidade++;
                }
            }
            return quantidade;
        }

        private static void imprimirInfos(Cliente[] cliente, int valorSalario, int idadeMenor, string estadoIgual, int cadastrados)
        {
            for (int cont = 0; cont < cadastrados; cont++)
            {
                if(cliente[cont].getCredito() > valorSalario)
                {
                    if (cliente[cont].getIdade() < idadeMenor)
                    {
                        if (cliente[cont].endereco.getEstado() == estadoIgual)
                        {
                            Console.WriteLine("\nClientes: " + cliente[cont].getNome());
                            Console.WriteLine("Idade: ");
                            Console.Write("Moram em " + estadoIgual + " : "); 
                        }
                    }
                } 
            }
        }

        static void Main(string[] args)
        {
            Cliente[] cliente = new Cliente[10];
            int contador = 0, valorSalario = 0, idadeMenor = 0;
            string estadoIgual = " ";
            while (true)
            {
                int idade = 0, quantidade = 0;
                Console.Clear();
                Console.WriteLine("MENU");
                Console.WriteLine("\n1. Cadastrar cliente");
                Console.WriteLine("2. Informar idade");
                Console.WriteLine("3. Verificar crédito");
                Console.Write("\nEscolha: ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    #region Case 1
                    case 1: Console.Clear();
                        if (contador > 9)
                        {
                            Console.WriteLine("Cadastro de cliente");
                            Console.Write("\nERRO - Você não pode cadastrar mais clientes");
                            System.Threading.Thread.Sleep(2000);
                        }
                        else
                        {
                            Console.WriteLine("Cadastro de cliente");
                            cadastraCliente(cliente, contador);
                            contador++;
                        }
                        break;
                    #endregion

                    #region Case 2
                    case 2:
                        if (contador == 0 || contador == 1)
                        {
                            if (contador == 0)
                            {
                                Console.Write("\nVocê não possui clientes cadastrados");
                                System.Threading.Thread.Sleep(2000);
                            }
                            else if (contador == 1)
                            {
                                Console.Write("\nVocê possui somente 1 cliente cadastrado");
                                System.Threading.Thread.Sleep(2000);
                            }
                        }

                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Informar idade");
                            Console.Write("Escreva a idade aqui: ");
                            idade = Convert.ToInt32(Console.ReadLine());
                            quantidade = idadeMaiorOuIgual(cliente, idade, contador);
                            Console.Write("Você possui " + quantidade + " clientes com idade igual ou superior a " + idade);
                            System.Threading.Thread.Sleep(3000);
                        }
                        break;
                    #endregion

                    #region Case 3
                    case 3:
                        Console.Write("Informar valor do salário: ");
                        valorSalario = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Informar idade a ser verificada: ");
                        idadeMenor = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Informar o estado do cliente (sigla): ");
                        estadoIgual = Console.ReadLine();
                        imprimirInfos(cliente, valorSalario, idadeMenor, estadoIgual, contador);
                        Console.ReadLine();
                        break;
                    #endregion

                }

            }
        }
    }
}

