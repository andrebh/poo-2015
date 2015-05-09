using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poo_paint
{
    public partial class AreaDeDesenho : Form
    {
        public AreaDeDesenho()
        {
            InitializeComponent();
        }

        private void Desenha(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            e.Graphics.DrawRectangle(Pens.Black, 4, 4, 100, 40);
        }
    }
}
