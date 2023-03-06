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
    public partial class Form4 : Form
    {
        Graphics g;
        int x, y, r = 30, N = 15;
        public Form4()
        {
            InitializeComponent();
            g = CreateGraphics();
            x = r / 2;
            y = r / 2;
        }
        //
        // Functions
        //
        public void DrawRounds(Graphics g, int x, int y, int r, int N)
        {
            if (N == 0) return;
            g.DrawEllipse(new Pen(Brushes.Blue, 2), x, y, r, r);
            DrawRounds(g, x + r / 2, y + r / 2, r + r / 2, --N);
        }
        //
        // Forms
        //
        private void Form4_Paint(object sender, PaintEventArgs e)
        {
            DrawRounds(g, x, y, r, N);
        }
    }
}
