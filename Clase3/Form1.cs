using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase3
{
    public partial class Form1 : Form
    {

        Bitmap bmp;
        Graphics g;
        Point a, b, c, d,z,f,h,i,j,k;

        private void button3_Click(object sender, EventArgs e)
        {
            a = new Point(0, 50);
            b = new Point(50, 100);
            c = new Point(100, 50);
            d = new Point(50, 0);


            z = new Point(0, PCT_CANVAS.Height / 2);
            f = new Point(PCT_CANVAS.Width, PCT_CANVAS.Height / 2);
            i = new Point(PCT_CANVAS.Width / 2, PCT_CANVAS.Height);
            h = new Point(PCT_CANVAS.Width / 2, 0);

            g.DrawLine(Pens.Red, z, f);
            g.DrawLine(Pens.Red, i, h);

            info = int.Parse(textBox1.Text);

            Render(a, b, info);
            Render(b, c, info);
            Render(c, d, info);
            Render(d, a, info);


            PCT_CANVAS.Refresh();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = new Point(-50, -50);
            b = new Point(-50, 50);
            c = new Point(50, 50);
            d = new Point(50, -50);


            z = new Point(0, PCT_CANVAS.Height / 2);
            f = new Point(PCT_CANVAS.Width, PCT_CANVAS.Height / 2);
            i = new Point(PCT_CANVAS.Width / 2, PCT_CANVAS.Height);
            h = new Point(PCT_CANVAS.Width / 2, 0);

            g.DrawLine(Pens.Red, z, f);
            g.DrawLine(Pens.Red, i, h);

            info = int.Parse(textBox1.Text);

            Render(a, b, info);
            Render(b, c, info);
            Render(c, d, info);
            Render(d, a, info);


            PCT_CANVAS.Refresh();
        }

        int info;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = new Point(0, 0);
            b = new Point(0, 100);
            c = new Point(100, 100);
            d = new Point(100, 0);


            z = new Point(0, PCT_CANVAS.Height / 2);
            f = new Point(PCT_CANVAS.Width, PCT_CANVAS.Height / 2);
            i = new Point(PCT_CANVAS.Width/2, PCT_CANVAS.Height);
            h = new Point(PCT_CANVAS.Width /2,0);

            j = new Point(PCT_CANVAS.Width/2,PCT_CANVAS.Height/2);
            k = new Point((PCT_CANVAS.Width/2)+150, (PCT_CANVAS.Height / 2)-150);


            g.DrawLine(Pens.Red,z,f) ;
            g.DrawLine(Pens.Red, i, h);

            g.DrawLine(Pens.Blue, j, k);

            info = int.Parse(textBox1.Text);

            Render(a, b, info);
            Render(b, c, info);
            Render(c, d, info);
            Render(d, a, info);
            

            



            PCT_CANVAS.Refresh();
        }

        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            bmp = new Bitmap(PCT_CANVAS.Width, PCT_CANVAS.Height);
            g = Graphics.FromImage(bmp);
            PCT_CANVAS.Image = bmp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Render(Point a, Point b, double radiants)
        {
            PointF a2, b2;
            double angle = (radiants * Math.PI) / 180;
            int Sx = (bmp.Width / 2);
            int Sy = (bmp.Height / 2);
            a2 = new PointF(Sx + a.X, Sy - a.Y);
            b2 = new PointF(Sx + b.X, Sy - b.Y);
            a2.X = Sx + (float)((a.X * Math.Cos(angle)) - (a.Y * Math.Sin(angle)));
            a2.Y = Sy - (float)((a.X * Math.Sin(angle)) + (a.Y * Math.Cos(angle)));
            b2.X = Sx + (float)((b.X * Math.Cos(angle)) - (b.Y * Math.Sin(angle)));
            b2.Y = Sy - (float)((b.X * Math.Sin(angle)) + (b.Y * Math.Cos(angle)));
            g.DrawLine(Pens.Gray, a2, b2);
        }
    }
}
