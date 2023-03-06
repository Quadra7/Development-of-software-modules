using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_02022023
{
    public partial class Form19 : Form
    {
        //
        // Variables
        //
        int tick = 0;
        Graphics g;
        int r = 200;
        double a = 0;
        int size = 25;
        int x0, y0, x, y;
        //
        // Forms
        //
        public Form19()
        {
            InitializeComponent();
            g = CreateGraphics();
            x0 = this.Width / 2 - 25;
            y0 = this.Height / 2 - 25;
            x = x0 + (int)(r * Math.Cos(a));
            y = y0 - (int)(r * Math.Sin(a));
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.DrawEllipse(new Pen(new SolidBrush(Color.Red), 5), new Rectangle(x, y, size, size));
        }
        //
        // Timers
        //
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (r == -200) timer1.Stop();
            if (r > 0 )
            {
                r--;
                a += 0.1;
                x = x0 + (int)(r * Math.Cos(a));
                y = y0 - (int)(r * Math.Sin(a));
                Invalidate();
                if (tick % 10 == 0)
                {
                    timer1.Interval++;
                    tick++;
                }
                else
                {
                    tick++;
                }
            }
            else
            {
                r--;
                a += 0.1;
                x = x0 + (int)(r * Math.Cos(a));
                y = y0 - (int)(r * Math.Sin(a));
                Invalidate();
                if (timer1.Interval - 1 > 0)
                {
                    if (tick % 10 == 0)
                    {
                        timer1.Interval--;
                        tick++;
                    }
                    else
                    {
                        tick++;
                    }
                }
            }
        }
    }
}
