using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //сопоставляем область рисования с переменной 
            Graphics g = pictureBox1.CreateGraphics();
            //Создаем обводку 
            Pen p = new Pen(Color.Red);
            //Создаем заливку 
            SolidBrush b = new SolidBrush(Color.Blue);
            //Рисование зхакрашенного прямоугольника 
            g.FillRectangle(b, 100, 120, 50, 80);
            g.DrawRectangle(p, 150, 180, 50, 80);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            SolidBrush b1 = new SolidBrush(Color.Pink);
            SolidBrush b2 = new SolidBrush(Color.Green);
            

            g.FillEllipse(b1, 150, 50,100,100);
            //Глаз синий//
            SolidBrush glaz = new SolidBrush(Color.Blue);
            //Место расположения глаза//
            g.FillEllipse(glaz, 155, 80,25, 25);
            //Второй глаз чёрный//
            SolidBrush glaz1 = new SolidBrush(Color.Black);
            //Место расположения второго глаза//
            g.FillEllipse(glaz1,205,80,25, 25);
            //Делаем нос//
            Pen nos= new Pen(Color.Black);
            g.DrawRectangle(nos, 186, 90, 5, 25);
            //Делаем рот.
            Pen rot =new  Pen(Color.Black);
            g.DrawRectangle(rot, 170, 135,28,3);
           //olidBrush rot1 =
              //new SolidBrush(Color.Red);
           //.FillPolygon(rot1, new Point[] {new Point(170,135),
         // new Point(28,3) });
            g.FillPolygon(b2, new Point[] {
            new Point(130,150),
            new Point(270,150),
            new Point(200,270)});
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
