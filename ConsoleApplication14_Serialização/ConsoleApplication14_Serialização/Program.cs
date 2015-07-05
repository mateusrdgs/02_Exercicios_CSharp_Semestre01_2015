using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace ConsoleApplication14_Serialização
{
    class Program 
    {
        static void Main(string[] args)
        {
            /*
            Funcionario funcionario = new Funcionario();            
            char serializar = ' ';
            Console.WriteLine("Cadastro de funcionário");
            Console.Write("\nNome: ");
            funcionario.nome = Console.ReadLine();
            Console.Write("Idade: ");
            funcionario.idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Estado Civil: ");
            funcionario.estcivil = Console.ReadLine();
            Console.Write("Departamento: ");
            funcionario.departamento = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nDeseja serializar as informações do funcionário? (s/n): ");
            serializar = Convert.ToChar(Console.ReadLine());

            if (serializar == 's' || serializar == 'S')
            {    
                //Criação do arquivo    
                FileStream fs = new FileStream(@"C: \Funcionario.xml", FileMode.Create);

                //Criação de objeto XmlSerializer para efetuar a serialização em formato XML
                XmlSerializer xs = new XmlSerializer(typeof(Funcionario));

                //Uso do objeto XmlSerializer para serializar os dados no arquivo
                xs.Serialize(fs, funcionario);

                //Fecha o arquivo
                fs.Close();
            }
*/
            Console.WriteLine("Desserializando");
            FileStream fo = new FileStream(@"C: \Funcionario.xml", FileMode.Open);
            XmlSerializer xo = new XmlSerializer(typeof(Funcionario));
            Funcionario funcionario2 = (Funcionario)xo.Deserialize(fo);
            Console.WriteLine("Nome: " + funcionario2.nome);
            Console.WriteLine("Idade: " + funcionario2.idade);
            Console.WriteLine("Estado civil: " + funcionario2.estcivil);
            Console.WriteLine("Departamento: " +  funcionario2.departamento);
            Console.ReadLine();
        }
    }
}
