using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApp1.DrawElements;

namespace WindowsFormsApp1
{
    class ManedgerDraw
    {
        public ManedgerDraw(PictureBox box)
        {
            this.box = box;
            this.box.Image = new Bitmap(this.box.Width, this.box.Height);
            g = Graphics.FromImage(box.Image);
        }
        private PictureBox box;
        private Graphics g;
        public Dictionary<string, AbDraw> Object = new Dictionary<string, AbDraw>();
        public void Procces()
        {
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, box.Width, box.Height);
            foreach (var item in Object.Values)
            {
                item.Draw(g);
            }
            box.Invalidate();
        }
        public void AddObject(string name, AbDraw obj)
        {
            if (!Object.ContainsKey(name))
                Object.Add(name, obj);
            else
                throw new System.Exception("Обьект с данным именем уже существует");
        }
    }
}
