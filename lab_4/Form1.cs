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
        private void buttonFirst_Click(object sender, EventArgs e) // Приблизительно, но не сошлось
        {

            try
            {
                richTextBoxResult.Text = "";
                double X0 = Convert.ToDouble(textBoxX0.Text);
                double Xk = Convert.ToDouble(textBoxXk.Text);
                double Dx = Convert.ToDouble(textBoxDx.Text);
                double A = Convert.ToDouble(textBoxA.Text);
                double B = Convert.ToDouble(textBoxB.Text);
                double C = Convert.ToDouble(textBoxC.Text);
                for (; X0 <= Xk; X0 += Dx)
                {
                    double y = Math.Pow(10, -2) * B * C / X0 + Math.Cos(Math.Sqrt(Math.Pow(A, 3) * X0));
                    richTextBoxResult.Text += $"X = {X0}; Y = {y}\n";
                }
            }
            catch
            {
                MessageBox.Show("Wrong numbers", "Wrong", MessageBoxButtons.OK);
            }
        }
        private void buttonSecond_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxResult_1.Text = "";
                double X0 = Convert.ToDouble(textBoxX0_1.Text);
                double Xk = Convert.ToDouble(textBoxXk_1.Text);
                double Dx = Convert.ToDouble(textBoxDx_1.Text);
                double A = Convert.ToDouble(textBoxA_1.Text);
                double B = Convert.ToDouble(textBoxB_1.Text);
                for (; X0 <= Xk; X0 += Dx)
                {
                    double y = 1.2 * Math.Pow(A - B, 3) * Math.Pow(Math.Exp(X0), 2) + X0;
                    richTextBoxResult_1.Text += $"X = {X0}; Y = {y}\n";
                }
            }
            catch
            {
                MessageBox.Show("Wrong numbers", "Wrong", MessageBoxButtons.OK);
            }
        }
        private void buttonThird_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxResult_1.Text = "";
                double X0 = Convert.ToDouble(textBoxX0_1.Text);
                double Xk = Convert.ToDouble(textBoxXk_1.Text);
                double Dx = Convert.ToDouble(textBoxDx_1.Text);
                double A = Convert.ToDouble(textBoxA_1.Text);
                double B = Convert.ToDouble(textBoxB_1.Text);
                for (; X0 <= Xk; X0 += Dx)
                {
                    double y = Math.Pow(10, -1) * A * Math.Pow(X0, 3) * Math.Tan(A - B * X0);
                    richTextBoxResult_1.Text += $"X = {X0}; Y = {y}\n";
                }
            }
            catch
            {
                MessageBox.Show("Wrong numbers", "Wrong", MessageBoxButtons.OK);
            }
        }
        private void buttonFourth_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxResult_1.Text = "";
                double X0 = Convert.ToDouble(textBoxX0_1.Text);
                double Xk = Convert.ToDouble(textBoxXk_1.Text);
                double Dx = Convert.ToDouble(textBoxDx_1.Text);
                double A = Convert.ToDouble(textBoxA_1.Text);
                double B = Convert.ToDouble(textBoxB_1.Text);
                for (; X0 <= Xk; X0 += Dx)
                {
                    double y = A * Math.Pow(X0, 3) + Math.Pow(Math.Cos(Math.Pow(X0, 3) - B), 2);
                    richTextBoxResult_1.Text += $"X = {X0}; Y = {y}\n";
                }
            }
            catch
            {
                MessageBox.Show("Wrong numbers", "Wrong", MessageBoxButtons.OK);
            }
        }
    }
}
