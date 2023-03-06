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
    public partial class Form5 : Form
    {
        //
        // Variables
        //
        Graphics g;
        int r = 200;
        double a = 0;
        int size = 25;
        int x0, y0, x, y;
        //
        // Forms
        //
        public Form5()
        {
            InitializeComponent();
            g = CreateGraphics();
            x0 = this.Width / 2 - 25;
            y0 = this.Height / 2 - 25;
            x = x0 + (int)(r * Math.Cos(a));
            y = y0 - (int)(r * Math.Sin(a));
        }
        private void Form1_Paint(object sender, PaintEventArgs e) =>
            g.DrawEllipse(new Pen(new SolidBrush(Color.Red), 5), new Rectangle(x, y, size, size));
        //
        // Timers
        //
        private void timer1_Tick(object sender, EventArgs e)
        {
            a += 0.1;
            if (r-- == 0) timer1.Stop();
            x = x0 + (int)(r * Math.Cos(a));
            y = y0 - (int)(r * Math.Sin(a));
            Invalidate();
        }
    }
}
