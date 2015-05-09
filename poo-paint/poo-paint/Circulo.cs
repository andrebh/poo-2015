using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_paint
{
    class Circulo : Figura
    {
        
        public int raio;

        public Circulo(int x, int y, int raio)
        {
            this.x = x;
            this.y = y;
            this.raio = raio;
        }

        public override string Imprime()
        {
            return "Circulo: [x:" + x + "y:" + y + "raio:" + raio + "]";
        }

    }
}
