using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DrawElements
{
    abstract class AbDraw : IDraw
    {
        public AbDraw(Rectangle rec, Pen pen, Brush brush, TypeDraw type)
        {
            this.rec = rec;
            this.pen = pen;
            this.brush = brush;
            this.type = type;
        }
        public Rectangle rec;
        public Pen pen;
        public Brush brush;
        public TypeDraw type;
        public void Draw(Graphics g)
        {
            switch (type)
            {
                case TypeDraw.Fill:
                    DrawBrush(g);
                    break;
                case TypeDraw.Pen:
                    DrawPen(g);
                    break;
                case TypeDraw.Full:
                    DrawBrush(g);
                    DrawPen(g);
                    break;
                default:
                    break;
            }
        }

        protected abstract void DrawBrush(Graphics g);
        protected abstract void DrawPen(Graphics g);
    }
}
