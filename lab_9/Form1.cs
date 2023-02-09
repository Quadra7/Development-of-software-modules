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
        public Form1()
        {
            InitializeComponent();
        }
        //
        // Buttons
        //
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double X0 = Convert.ToDouble(textBoxX0.Text);
                double Xk = Convert.ToDouble(textBoxXk.Text);
                double dx = Convert.ToDouble(textBoxDx.Text);
                double a = Convert.ToDouble(textBoxA.Text);
                double b = Convert.ToDouble(textBoxB.Text);
                int count = (int)Math.Ceiling((Xk - X0) / dx) + 1;
                double[] x = new double[count];
                double[] y1 = new double[count];
                double[] y2 = new double[count];
                for (int i = 0; i < count; i++)
                {
                    x[i] = X0 + dx * i;
                    y1[i] = 1.2 * Math.Pow(a - b, 3) * Math.Pow(Math.Exp(x[i]), 2) + x[i];
                    y2[i] = Math.Abs(x[i] / 2) - ((3 * Math.Sqrt(33) - 7) / 112) * x[i] * x[i] - 3; 
                }
                chart1.ChartAreas[0].AxisX.Minimum = X0;
                chart1.ChartAreas[0].AxisX.Maximum = Xk;
                chart1.ChartAreas[0].AxisX.MajorGrid.Interval = dx;
                chart1.Series[0].Points.DataBindXY(x, y1);
                chart1.Series[1].Points.DataBindXY(x, y2);
            }
            catch
            {
                MessageBox.Show("Wrong number", "Wrong", MessageBoxButtons.OK);
            }
        }
    }
}
