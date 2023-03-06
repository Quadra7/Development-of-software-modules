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
    public partial class Form2 : Form
    {
        Graphics g;
        int x, y, width = 100, N = 20;
        public Form2()
        {
            InitializeComponent();
            g = CreateGraphics();
            x = this.Width / 2 - (width / 2);
            y = this.Height / 2 - (width / 2);
        }
        public void DrawSquares(Graphics g, int x, int y, int width, int N)
        {
            if (N == 0) return;
            g.DrawRectangle(new Pen(Brushes.Blue), x, y, width, width);
            DrawSquares(g, x - 15, y - 15, width + 30, --N);
        }
        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            DrawSquares(g, x, y, width, N);
        }
    }
}
