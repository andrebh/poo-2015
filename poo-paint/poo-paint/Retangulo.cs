using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_paint
{
    public class Retangulo : Figura
    {
        private int largura;
        private int altura;
        static int contador;

        public Retangulo(int x, int y, int largura, int altura)
        {
            this.x = x;
            this.y = y;
            this.largura = largura;
            this.altura = altura;

            contador += 1;
        }

        public override string Imprime()
        {
            return "retangulo[x:" + x + ",y:" + y + ",l:" + largura + ",a:" + altura + "]";
        }

        public static void ZeraContador()
        {
            contador = 0;
        }

        public static int LeContador()
        {
            return contador;
        }

        public override void Desenha(Graphics g)
        {
            g.DrawRectangle(Pens.Black, x, y, largura, altura);
        }
    }
}
