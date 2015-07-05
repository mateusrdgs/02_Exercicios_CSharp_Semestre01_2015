using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace ConsoleApplication14_Serialização
{
    [Serializable]
    // Classe Funcionário
    public  class Funcionario
    {
        public string nome, estcivil;
        public int idade, departamento;

        public Funcionario()
        {
            nome = "Fulano de Tal";
            estcivil = "Solteiro";
            idade = 20;
            departamento = 0;   
        }

        // métodos

        //SERIALIZAÇÃO
        /*public void Serialização()
        {
          System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(fun);
        }*/
    }
}
