using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_paint
{
    public class Figura
    {
        protected int x;
        protected int y;

        public virtual string Imprime()
        {
            return "figura[x:" + x + ",y:" + y + "]";
        }

        public virtual void Desenha(Graphics g)
        {
        }
    }
}
