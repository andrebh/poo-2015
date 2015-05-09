using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePOO
{
    class Program
    {
        static void Main(string[] args)
        {
    
            Professor fulano = new Professor();

            fulano.Id = 10;
            fulano.Nome = "André";
            fulano.Endereco = "Rua tal ";
            fulano.Cpf = "1233435456";
            fulano.Materia = "Matemática";    
        }
    }
}
