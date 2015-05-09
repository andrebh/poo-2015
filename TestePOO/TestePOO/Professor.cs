using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestePOO
{
    public class Professor: Pessoa
    {
        private string materia;
        public string Materia
        {
            get { return materia; }
            set { materia = value; }
        }

        public override void Salvar()
        {
            base.Salvar();
            StreamWriter arquivo = new StreamWriter("Professor.txt");
            arquivo.WriteLine("Materia: " + Materia);
            arquivo.Flush();
            arquivo.Close();
        }
    }
}
