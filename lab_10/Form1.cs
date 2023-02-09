using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lesson_02022023
{
    public partial class Form1 : Form
    {
        Graphics g;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }
        //
        // Forms
        //
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.Clear(Color.White);
            //Горизонт
            g.DrawLine(new Pen(new SolidBrush(Color.Black)), 0, this.Height/2 + 50, this.Width, this.Height/2 + 50);
            // Снежинки
            for (int i = 0; i < 50; i++)
            {
                g.DrawString("*", new Font("Times New Roman", 24), new SolidBrush(Color.Blue), rnd.Next(0, this.Width), rnd.Next(0, this.Height));
            }
            //Солнце
            g.FillEllipse(new SolidBrush(Color.Yellow), this.Width / 2, 10, 100, 100);
            // Светофор
            g.DrawPolygon(new Pen(new SolidBrush(Color.Red)), new PointF[] { new PointF(40, 100), new PointF(20, 50), new PointF(65, 10), new PointF(110, 50), new PointF(90,100)});
            g.DrawString("СТОП", new Font("Times New Roman", 16), new SolidBrush(Color.Black), 30, 45);
            g.FillRectangle(new SolidBrush(Color.Gray), 40, 100, 50, 150); //Корпус светофора
            g.FillEllipse(new SolidBrush(Color.Red), 40, 100, 50, 50); // Красный фонарь
            g.FillEllipse(new SolidBrush(Color.Yellow), 40, 150, 50, 50); // Жёлтый фонарь
            g.FillEllipse(new SolidBrush(Color.Green), 40, 200, 50, 50); // Зелёный фонарь
            g.FillRectangle(new SolidBrush(Color.Gray), 60, 250, 10, 150); //Держатель светофора
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int x;
            x = rnd.Next(0, 3);
            switch (x)
            {
                case 0:
                    g.FillEllipse(new SolidBrush(Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255))), e.X, e.Y, 50, 50);
                    break;
                case 1:
                    g.FillRectangle(new SolidBrush(Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255))), e.X, e.Y, 50, 50);
                    break;
                case 2:
                    g.DrawPolygon(new Pen(new SolidBrush(Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255)))), new PointF[] { new PointF(e.X, e.Y), new PointF(e.X - 20, e.X - 50), new PointF(e.X + 15, e.Y + 90), new PointF(e.X + 70, e.Y - 50), new PointF(e.X + 50, e.Y) });
                    break;
                default:
                    g.DrawString("?", new Font("Times New Roman", 24), new SolidBrush(Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255))), e.X, e.Y);
                    break;
            }
        }
    }
}
