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
        public int largura;
        public int altura;

        public Retangulo(int x, int y, int largura, int altura)
        {
            this.x = x;
            this.y = y;
            this.largura = largura;
            this.altura = altura;
        }

        public Imprime()
        {
            return "Retangulo [x:"+this.x+" ,y:"+this.y+" ,l:"+this.largura+" ,a:"+this.altura+"]";
        }
        static void Main(string[] args)
        {
            
        }
    }
}
