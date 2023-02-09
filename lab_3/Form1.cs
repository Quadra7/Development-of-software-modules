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
                double a;
                double X = Convert.ToDouble(textBoxX.Text);
                double Y = Convert.ToDouble(textBoxY.Text);
                if (X * Y > 0)
                {
                    a = Math.Pow(X * X + Y, 2) - Math.Sqrt(X * X * Y);
                }
                else if (X * Y < 0)
                {
                    a = Math.Pow(X * X + Y, 2) + Math.Sqrt(Math.Abs(X * X * Y));
                }
                else
                {
                    a = Math.Pow(X * X + Y, 2) + 1;
                }
                richTextBoxResult.Text = $"При X = {X}\nПри Y = {Y}\nРезультат A = {a}";
            }
            catch
            {
                MessageBox.Show("Wrong numbers", "Wrong", MessageBoxButtons.OK);
            }
        }
        private void buttonSecond_Click(object sender, EventArgs e) // Приблизительно, но не сошлось
        {
            try
            {
                double b;
                double X = Convert.ToDouble(textBoxX.Text);
                double Y = Convert.ToDouble(textBoxY.Text);
                if (X / Y > 0)
                {
                    b = Math.Log(X * X) + Math.Pow(Math.Pow(X * X, 2) + Y, 3);
                }
                else if (X / Y < 0)
                {
                    b = Math.Log(Math.Abs(X * X / Y)) + Math.Pow(X * X + Y, 3);
                }
                else if (X == 0)
                {
                    b = Math.Pow(Math.Pow(X * X, 2) + Y, 3);
                }
                else
                {
                    b = 0;
                }
                richTextBoxResult.Text = $"При X = {X}\nПри Y = {Y}\nРезультат B = {b}";
            }
            catch
            {
                MessageBox.Show("Wrong numbers", "Wrong", MessageBoxButtons.OK);
            }
        }
        private void buttonThird_Click(object sender, EventArgs e) // Сошлось
        {
            try
            {
                double c;
                double X = Convert.ToDouble(textBoxX.Text);
                double Y = Convert.ToDouble(textBoxY.Text);
                if (X - Y == 0)
                {
                    c = Math.Pow(X * X, 2) + Y * Y + Math.Sin(Y);
                }
                else if (X - Y > 0)
                {
                    c = Math.Pow(X * X - Y, 2) + Math.Cos(Y);
                }
                else
                {
                    c = Math.Pow(Y - X * X, 2) + Math.Tan(Y);
                }
                richTextBoxResult.Text = $"При X = {X}\nПри Y = {Y}\nРезультат C = {c}";
            }
            catch
            {
                MessageBox.Show("Wrong numbers", "Wrong", MessageBoxButtons.OK);
            }
        }
        private void buttonFourth_Click(object sender, EventArgs e) // Сошлось
        {
            try
            {
                double d;
                double X = Convert.ToDouble(textBoxX.Text);
                double Y = Convert.ToDouble(textBoxY.Text);
                if (X > Y)
                {
                    d = Math.Pow(X * X - Y, 3) + Math.Atan(X * X);
                }
                else if (X < Y)
                {
                    d = Math.Pow(Y - X * X, 3) + Math.Atan(X * X);
                }
                else
                {
                    d = Math.Pow(Y + X * X, 3) + 0.5;
                }
                richTextBoxResult.Text = $"При X = {X}\nПри Y = {Y}\nРезультат D = {d}";
            }
            catch
            {
                MessageBox.Show("Wrong numbers", "Wrong", MessageBoxButtons.OK);
            }
        }
    }
}
