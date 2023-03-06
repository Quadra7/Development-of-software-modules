using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_02022023
{
    public partial class Form14 : Form
    {
        //
        // Classes
        //
        public class Dot
        {
            public int x, y;
            public Dot(int posX, int posY)
            {
                x = posX;
                y = posY;
            }
            public int ChangePosX(int x, int dx) => x + dx;
            public int ChangePosY(int y, int dy) => y + dy;
        }
        //
        // variables
        //
        Graphics g;
        const int count = 100, size = 10;
        Dot[] dots = new Dot[count];
        Random rnd = new Random();
        //
        // Fomrs
        //
        public Form14()
        {
            InitializeComponent();
            g = CreateGraphics();
            for (int i = 0; i < count; i++)
            {
                dots[i] = new Dot(rnd.Next(size, this.Width - size), rnd.Next(size, this.Height - size));
            }
        }
        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < count; i++)
            { 
                g.FillEllipse(new SolidBrush(Color.Red), dots[i].x, dots[i].y, 10, 10);
            }
        }
        //
        // Timers
        //
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < count; i++)
            {
                dots[i].x = dots[i].ChangePosX(dots[i].x, rnd.Next(-10, 10));
                dots[i].y = dots[i].ChangePosY(dots[i].y, rnd.Next(-10, 10));
            }
            Invalidate();
        }
    }
}
