using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12_POO_1
{
    class Program
    {   
        static void Main(string[] args)
        {
            Pessoa[] pessoa = new Pessoa[10];
            Carro[] carro = new Carro[10];
            int i = 0, j = 0, resp = 0;
            char repetir = ' ';
            bool repete = false;

            do
            {
                Console.Clear();
                Console.SetCursorPosition((Console.WindowWidth/2) - 5, 0);
                Console.WriteLine("Menu");
                Console.WriteLine("1. Cadastrar");
                Console.WriteLine("2. Consultar");
                Console.WriteLine("3. Editar");
                Console.WriteLine("4. Sair para o Windows");
                Console.Write("\n");
                Console.Write("Escolha: ");
                resp = Convert.ToInt32(Console.ReadLine());

            switch (resp)
            {
                case 1:
                    resp = 0;
                    Console.Clear();
                    Console.SetCursorPosition((Console.WindowWidth / 2) - 5, 0);
                    Console.WriteLine("Cadastrar");
                    Console.WriteLine("1. Cadastrar pessoa");
                    Console.WriteLine("2. Cadastrar carro");
                    Console.WriteLine("3. Voltar ao menu");
                    Console.Write("\n");
                    Console.Write("Escolha: ");
                    resp = Convert.ToInt32(Console.ReadLine());

                    #region Cadastro
                    switch (resp)
                    {
                        case 1:
                            do {

                                Console.Clear();
                                repete = false;
                                pessoa[i] = new Pessoa();
                                Console.SetCursorPosition((Console.WindowWidth / 2) - 10, 0);
                                Console.WriteLine("Cadastrar pessoa");
                                Console.Write("\n");
                                Console.Write("Escreva aqui o nome da pessoa: ");
                                pessoa[i].nome = Console.ReadLine();
                                Console.Write("Escreva aqui a idade da pessoa: ");
                                pessoa[i].idade = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Escreva aqui o peso da pessoa: ");
                                pessoa[i].peso = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Escreva aqui a altura da pessoa: ");
                                pessoa[i].altura = Convert.ToDouble(Console.ReadLine());
                                Console.Write("\n");
                                Console.Write("Deseja cadastrar mais alguém? (s/n): ");
                                repetir = Convert.ToChar(Console.ReadLine());
                                if(repetir == 's' || repetir == 'S')
                                {
                                    repete = true;
                                }

                            } while(repete);    
                                                   
                        break;

                        case 2:

                            do {

                                Console.Clear();
                                repete = false;
                                carro[i] = new Carro();                               
                                Console.SetCursorPosition((Console.WindowWidth / 2) - 10, 0);
                                Console.WriteLine("Cadastrar carro");
                                Console.Write("\n");
                                Console.Write("Escreva aqui o modelo do carro: ");
                                carro[i].modelo = Console.ReadLine();
                                Console.Write("Escreva aqui o ano do carro: ");
                                carro[i].ano = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Escreva aqui o preço do carro: ");
                                carro[i].preço = Convert.ToDouble(Console.ReadLine());
                                Console.Write("\n");
                                Console.Write("Deseja cadastrar mais algum carro? (s/n): ");
                                repetir = Convert.ToChar(Console.ReadLine());
                                if (repetir == 's' || repetir == 'S')
                                {
                                    repete = true;
                                }

                            } while(repete);                            
                                         
                        break;
                    }


                break;
                #endregion

                    #region Consulta
                case 2:                    
                    resp = 0;
                    Console.Clear();
                    Console.SetCursorPosition((Console.WindowWidth / 2) - 5, 0);
                    Console.WriteLine("Consultar");
                    Console.WriteLine("1. Consultar pessoa");
                    Console.WriteLine("2. Consultar carro");
                    Console.Write("\n");
                    Console.Write("Escolha: ");
                    resp = Convert.ToInt32(Console.ReadLine());

                    switch (resp)
                    {
                        case 1:
                            j = 0;
                            Console.Clear();                            
                            Console.SetCursorPosition((Console.WindowWidth / 2) - 10, 0);
                            Console.WriteLine("Consulta de pessoa");
                                while (j <= i)
                                {
                                    pessoa[j].MostraDadosPessoa();
                                    j++;
                                }
                                Console.ReadLine();
                            break;

                        case 2:
                            j = 0;
                            Console.Clear();
                            carro[i] = new Carro(); 
                            Console.SetCursorPosition((Console.WindowWidth / 2) - 10, 0);
                            Console.WriteLine("Consulta de carro");
                                while (j <= i)
                                {
                                    carro[j].MostraDadosCarro();
                                    j++;
                                }
                                Console.ReadLine();
                            break;
                    }
                    break;
                #endregion
            }

            } while (resp != 3 || (resp > 3 || resp < 1));
            Console.ReadLine();
        }
    }
}
