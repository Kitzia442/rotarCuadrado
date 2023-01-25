using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rotarCuadrado
{
    public partial class Form1 : Form
    {

        static Bitmap bmp;
        static Graphics g;
        private PointF a, b, c, d;
        private int Sx, Sy;

        private void Render(PointF a, PointF b, int degrees)
        {
            PointF a2, b2;
            double angle = Math.PI * degrees / 180.0;
            a2 = new PointF(Sx + a.X, Sy - a.Y);
            b2 = new PointF(Sx + b.X, Sy - b.Y);
            a2.X = Sx + (float)((a.X * Math.Cos(angle)) - (a.Y * Math.Sin(angle)));
            a2.Y = Sy - (float)((a.X * Math.Sin(angle)) + (a.Y * Math.Cos(angle)));
            b2.X = Sx + (float)((b.X * Math.Cos(angle)) - (b.Y * Math.Sin(angle)));
            b2.Y = Sy - (float)((b.X * Math.Sin(angle)) + (b.Y * Math.Cos(angle)));
            g.DrawLine(Pens.Blue, a2, b2);
            pictureBox1.Refresh();
        }

        public Form1()
        {
            InitializeComponent();

            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
            a = new PointF(0, pictureBox1.Height / 2);
            b = new PointF(pictureBox1.Width, pictureBox1.Height / 2);
            c = new PointF(pictureBox1.Width / 2, 0);
            d = new PointF(pictureBox1.Width / 2, pictureBox1.Height);
            g.DrawLine(Pens.Black, a, b);
            g.DrawLine(Pens.Black, c, d);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sx = (bmp.Width / 2);
            Sy = (bmp.Height / 2);
            g.FillRectangle(Brushes.White, 0, 0, pictureBox1.Width, pictureBox1.Height);
            a = new PointF(0, pictureBox1.Height / 2);
            b = new PointF(pictureBox1.Width, pictureBox1.Height / 2);
            c = new PointF(pictureBox1.Width / 2, 0);
            d = new PointF(pictureBox1.Width / 2, pictureBox1.Height);
            g.DrawLine(Pens.Black, a, b);
            g.DrawLine(Pens.Black, c, d);
            a = new PointF(0, 0);
            b = new PointF(0, 100);
            c = new PointF(100, 100);
            d = new PointF(100, 0);
            rotate(a, b, c, d);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sx = (bmp.Width / 2);
            Sy = (bmp.Height / 2);
            g.FillRectangle(Brushes.White, 0, 0, pictureBox1.Width, pictureBox1.Height);
            a = new PointF(0, pictureBox1.Height / 2);
            b = new PointF(pictureBox1.Width, pictureBox1.Height / 2);
            c = new PointF(pictureBox1.Width / 2, 0);
            d = new PointF(pictureBox1.Width / 2, pictureBox1.Height);
            g.DrawLine(Pens.Black, a, b);
            g.DrawLine(Pens.Black, c, d);
            a = new PointF(-50, -50);
            b = new PointF(-50, 50);
            c = new PointF(50, 50);
            d = new PointF(50, -50);
            rotate(a, b, c, d);

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Sx = (bmp.Width / 2) + 50;
            Sy = (bmp.Height / 2) - 50;
            g.FillRectangle(Brushes.White, 0, 0, pictureBox1.Width, pictureBox1.Height);
            a = new PointF(0, pictureBox1.Height / 2);
            b = new PointF(pictureBox1.Width, pictureBox1.Height / 2);
            c = new PointF(pictureBox1.Width / 2, 0);
            d = new PointF(pictureBox1.Width / 2, pictureBox1.Height);
            g.DrawLine(Pens.Black, a, b);
            g.DrawLine(Pens.Black, c, d);
            a = new PointF(-50, -50);
            b = new PointF(-50, 50);
            c = new PointF(50, 50);
            d = new PointF(50, -50);
            rotate(a, b, c, d);

        }

        private void rotate(PointF a, PointF b, PointF c, PointF d)
        {
            int degrees = 0;
            if(Int32.TryParse(textBox1.Text, out degrees))
            {
                Render(a, b, degrees);
                Render(b, c, degrees);
                Render(c, d, degrees);
                Render(a, d, degrees);
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


    }
}
