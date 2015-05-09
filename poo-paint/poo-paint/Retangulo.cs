using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poo_paint
{
    public class Retangulo : Figura
    {
        
        public int largura;
        public int altura;
        private static int contador = 0;

        public Retangulo(int x, int y, int largura, int altura)
        {
            this.x = x;
            this.y = y;
            this.largura = largura;
            this.altura = altura;
            contador++;
        }

        public override string Imprime()
        {
            return "Retangulo [x:"+this.x+" y:"+this.y+" l:"+this.largura+" a:"+this.altura+"]";
        }

        public static void ZeraContador()
        {
            contador = 0;
        }

        public static int LeContador()
        {
            return contador;
        }

        static void Main(string[] args)
        {
            
        }
      
    }
}









