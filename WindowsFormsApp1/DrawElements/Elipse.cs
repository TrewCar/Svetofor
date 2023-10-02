using System.Drawing;

namespace WindowsFormsApp1.DrawElements
{
    class Elipse : AbDraw
    {
        public Elipse(Rectangle rec, Pen pen, Brush brush, TypeDraw type) : base(rec, pen, brush, type)
        {
        }

        protected override void DrawBrush(Graphics g)
        {
            g.FillEllipse(brush, rec);
        }

        protected override void DrawPen(Graphics g)
        { 
            g.DrawEllipse(pen, rec);
        }
    }
}
