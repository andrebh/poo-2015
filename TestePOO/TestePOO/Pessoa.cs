using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestePOO
{
    public class Pessoa
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string endereco;
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        private string cpf;
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public virtual void Salvar()
        {
            StreamWriter arquivo = new StreamWriter("Pessoa.txt");

            arquivo.WriteLine("ID: "+id.ToString());
            arquivo.WriteLine("Nome: " + nome);
            arquivo.WriteLine("Endereço: " + endereco);
            arquivo.WriteLine("Cpd: " + cpf);
            arquivo.Flush();
            arquivo.Close();
        }
    }
}
