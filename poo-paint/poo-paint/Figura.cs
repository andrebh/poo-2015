using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace poo_paint
{
    class Figura
    {
        public int x;
        public int y;

        public virtual string Imprime()
        {
            return "[x: y: l: a: raio:]";
        }
    }
}
