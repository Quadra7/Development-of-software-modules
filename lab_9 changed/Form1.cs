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
    public partial class Form1 : Form
    {
        int count, k = 1;
        double f = 0.5, X0 = 0, Xk = 7, dx = 0.1;
        double[] x;
        double[] y1;
        double[] y2;
        public Form1()
        {
            InitializeComponent();
            count = (int)Math.Ceiling((Xk - X0) / dx) + 1;
            x = new double[count];
            y1 = new double[count];
            y2 = new double[count];
            chart1.ChartAreas[0].AxisX.Minimum = -1;
            chart1.ChartAreas[0].AxisX.Maximum = 1;
            chart1.ChartAreas[0].AxisY.Minimum = -1;
            chart1.ChartAreas[0].AxisY.Maximum = 1;
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = dx;
        }
        //
        // Timers
        //
        private void timer1_Tick(object sender, EventArgs e)
        {
            f += 0.1;
            try
            {
                k = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                k = 1;
            }
            for (int i = 0; i < count; i++)
            {
                x[i] = X0 + dx * i;
                y1[i] = Math.Sin(x[i]);
                y2[i] = Math.Cos(k * x[i] + f);
            }
            chart1.Series[0].Points.DataBindXY(y1, y2);
            Invalidate();
        }
    }
}
