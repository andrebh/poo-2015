using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_paint
{
   
    class Retangulo
    {
        public int x;
        public int y;
        public int l;
        public int a;

        Retangulo(int direito, int esquerdo, int largura, int altura)
        {
            this.x = direito;
            this.y = esquerdo;
            this.l = largura;
            this.a = altura;
        }

       public string Imprime()
        {
            string Retangulo = "x" + x + ",y" + y + "l" + l + "a" + a;
        }

        static void Main(string[] args)
        {
            Retangulo r1 = new Retangulo();

        }
    }
}
