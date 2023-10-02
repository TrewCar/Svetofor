using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DrawElements
{
    class Cube : AbDraw
    {
        public Cube(Rectangle rec, Pen pen, Brush brush, TypeDraw type) :base(rec, pen, brush, type)
        {
        }
        protected override void DrawBrush(Graphics g)
        {
            g.FillRectangle(brush, rec);
        }
        protected override void DrawPen(Graphics g)
        {
            g.DrawRectangle(pen, rec);
        }
    }
}
