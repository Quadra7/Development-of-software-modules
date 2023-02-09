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
                double X = Convert.ToDouble(textBoxX.Text);
                double Y = Convert.ToDouble(textBoxY.Text);
                double Z = Convert.ToDouble(textBoxZ.Text);
                double t = ((2 * Math.Cos(X - Math.PI / 6)) / (0.5 + Math.Sin(Y) * Math.Sin(Y))) * (1 + (Z * Z) / (3 - Z * Z / 5));
                richTextBoxResult.Text = $"X = {X}\nY = {Y}\nZ = {Z}\nРезультат T = {t}";
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
                double X = Convert.ToDouble(textBoxX.Text);
                double Y = Convert.ToDouble(textBoxY.Text);
                double Z = Convert.ToDouble(textBoxZ.Text);
                double u = (Math.Pow(8 + Math.Pow(Math.Abs(X - Y), 2) + 1, (1 / 3))) / (X * X + Y * Y + 2) - Math.Exp(Math.Abs(X - Y)) * Math.Pow(Math.Tan(Z) * Math.Tan(Z) + 1, X);
                richTextBoxResult.Text = $"X = {X}\nY = {Y}\nZ = {Z}\nРезультат U = {u}";
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
                double X = Convert.ToDouble(textBoxX.Text);
                double Y = Convert.ToDouble(textBoxY.Text);
                double Z = Convert.ToDouble(textBoxZ.Text);
                double v = (1 + Math.Sin(X + Y) * Math.Sin(X + Y)) / (Math.Abs(X - (2 * Y) / (1 + X * X * Y * Y))) * Math.Pow(X, Math.Abs(Y)) + Math.Cos(Math.Atan(1 / Z)) * Math.Cos(Math.Atan(1 / Z));
                richTextBoxResult.Text = $"X = {X}\nY = {Y}\nZ = {Z}\nРезультат V = {v}";
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
                double X = Convert.ToDouble(textBoxX.Text);
                double Y = Convert.ToDouble(textBoxY.Text);
                double Z = Convert.ToDouble(textBoxZ.Text);
                double w = Math.Pow(Math.Abs(Math.Cos(X) - Math.Cos(Y)), 1 + 2 * Math.Sin(Y) * Math.Sin(Y)) * (1 + Z + Z * Z / 2 + Z * Z * Z / 3 + Z * Z * Z * Z / 4);
                richTextBoxResult.Text = $"X = {X}\nY = {Y}\nZ = {Z}\nРезультат W = {w}";
            }
            catch
            {
                MessageBox.Show("Wrong numbers", "Wrong", MessageBoxButtons.OK);
            }
        }
    }
}
