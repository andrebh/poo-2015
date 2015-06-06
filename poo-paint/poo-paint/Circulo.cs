using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_paint
{
    public class Circulo : Figura
    {
        private int raio;
        static int contador;

        public Circulo(int x, int y, int raio)
        {
            this.x = x;
            this.y = y;
            this.raio = raio;

            contador += 1;
        }

        public override string Imprime()
        {
            return "circulo[x:" + x + ",y:" + y + ",raio:" + raio + "]";
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
            g.DrawEllipse(Pens.Black, x, y, raio * 2, raio * 2);
        }
    }
}