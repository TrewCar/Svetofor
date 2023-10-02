using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DrawElements;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Graphics g;
        int rad = 425 / 3;
        ManedgerNumber menedgerNumber;
        ManedgerDraw menedgerDraw;
        public Form1()
        {
            InitializeComponent();
            menedgerNumber = new ManedgerNumber(1,11);

            menedgerDraw = new ManedgerDraw(picture);
            timer1.Start();

            menedgerDraw.AddObject("Wall+", new Cube(new Rectangle(new Point(picture.Width / 2 - 200, picture.Height - rad), new Size(400, rad)), new Pen(Color.Black, 2), Brushes.Gray, TypeDraw.Full));
            menedgerDraw.AddObject("Wall", new Cube(new Rectangle(new Point(picture.Width / 2 - 200, 0),new Size(200, picture.Height)),new Pen(Color.Black,2),Brushes.Gray,TypeDraw.Full));
            menedgerDraw.AddObject("Red", new Elipse(new Rectangle(new Point(picture.Width / 2 - rad / 2 - 100, 0), new Size(rad, rad)), new Pen(Color.Black, 2), Brushes.Red, TypeDraw.Full));
            menedgerDraw.AddObject("Yellow", new Elipse(new Rectangle(new Point(picture.Width / 2 - rad / 2 - 100, (picture.Height - rad) / 2), new Size(rad, rad)), new Pen(Color.Black, 2), Brushes.Yellow, TypeDraw.Full));
            menedgerDraw.AddObject("Green", new Elipse(new Rectangle(new Point(picture.Width / 2 - rad / 2 - 100, picture.Height - rad), new Size(rad, rad)), new Pen(Color.Black, 2), Brushes.Green, TypeDraw.Full));
            menedgerDraw.AddObject("Green+", new Elipse(new Rectangle(new Point(picture.Width / 2 - rad / 2 + 100, picture.Height - rad), new Size(rad, rad)), new Pen(Color.Black, 2), Brushes.Green, TypeDraw.Full));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            menedgerNumber.Step();
            if (menedgerNumber.Now >= 1 && menedgerNumber.Now <= 3)
            {
                menedgerDraw.Object["Red"].type = TypeDraw.Full;
                menedgerDraw.Object["Yellow"].type = TypeDraw.Pen;
                menedgerDraw.Object["Green"].type = TypeDraw.Pen;           //Красный
                menedgerDraw.Object["Green+"].type = TypeDraw.Pen;
            }
            else if (menedgerNumber.Now >= 4 && menedgerNumber.Now <= 5)
            {
                menedgerDraw.Object["Red"].type = TypeDraw.Full;
                menedgerDraw.Object["Yellow"].type = TypeDraw.Full;
                menedgerDraw.Object["Green"].type = TypeDraw.Pen;           //Желтый+Красный
                menedgerDraw.Object["Green+"].type = TypeDraw.Pen;
            }
            else if (menedgerNumber.Now >= 6 && menedgerNumber.Now <= 9)
            {
                menedgerDraw.Object["Red"].type = TypeDraw.Pen;
                menedgerDraw.Object["Yellow"].type = TypeDraw.Pen;
                menedgerDraw.Object["Green"].type = TypeDraw.Full;          //Зеленый
                menedgerDraw.Object["Green+"].type = TypeDraw.Full;
            }
            else if (menedgerNumber.Now >= 10 && menedgerNumber.Now <= 11)
            {
                menedgerDraw.Object["Red"].type = TypeDraw.Pen;
                menedgerDraw.Object["Yellow"].type = TypeDraw.Full;
                menedgerDraw.Object["Green"].type = TypeDraw.Pen;
                menedgerDraw.Object["Green+"].type = TypeDraw.Pen;
            }
                menedgerDraw.Procces();

        }
    }
}
