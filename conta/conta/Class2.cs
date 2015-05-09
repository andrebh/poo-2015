using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conta
{
    class Retangulo
    {
        private int x;
        private int y;
        private int largura;
        private int altura;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Largura
        {
            get { return largura; }
            set { largura = value; }
        }        
        public int Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public Retangulo(int x, int y, int largura, int altura)
        {
            this.x = x;
            this.y = y;
            this.largura = largura;
            this.altura = altura;
        }

        public void Imprime()
        {
            Console.WriteLine( "[x:"+this.x+"y:"this.y+"l:"+this.largura+"a:"+this.altura+"]");
        }
    }
}
