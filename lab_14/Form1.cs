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
    public partial class Form1 : Form
    {
        Graphics g;
        int x, y, r = 20, N = 5;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            x = this.Width / 2 - (r / 2);
            y = this.Height / 2 - (r / 2);
        }
        //
        // Functions 
        //
        public void DrawRounds(Graphics g, int x, int y, int r, int N)
        {
            if (N == 0) return;
            g.DrawEllipse(new Pen(Brushes.Blue), x, y, r, r);
            DrawRounds(g, x - 10, y - 10, r + 20, --N);
        }
        public void DrawSquares(Graphics g, int x, int y, int width, int height, int N)
        {
            if (N == 0) return;
            g.DrawRectangle(new Pen(Brushes.Blue), x, y, width, height);
            //DrawSquares(g, x, y, width, height, --N);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawRounds(g, x, y, r, N);
        }
    }
}
