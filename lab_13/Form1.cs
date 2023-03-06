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
        public Form1()
        {
            InitializeComponent();
            labelRes.Text = "";
        }
        //
        // Functions
        //
        public int min(int x, int y) => x >= y ? y : x; // Min (1 task)
        public int max(int x, int y) => x >= y ? x : y; // Max(2 task)
        public double Calculate_6(int x) => Math.Sin(x) + Math.Cos(2 * x); // Calculate (6 task)
        public double min_6(double x, double y) => x >= y ? y : x; // Min (6 task)
        public int Calculate_7(int x, int y) => x*x + y*y; // Calculate (7 task)
        public int Switch_9(int x) => x % 2 == 0 ? ~x + 1 : x; // Switch (9 task)
        public int Calculate_10(int x) => x < 0 ? x * x * x : x * x; // Calculate (10 task)
        //
        // Buttons
        //
        private void buttonOneTwo_Click(object sender, EventArgs e)
        {
            labelRes.Text = "";
            try
            {
                int res = Convert.ToInt32(textBoxA.Text);
                res = min(res, Convert.ToInt32(textBoxB.Text));
                res = min(res, Convert.ToInt32(textBoxC.Text));
                res = min(res, Convert.ToInt32(textBoxD.Text));
                labelRes.Text += $"Minimum is {res}.\n";
                res = Convert.ToInt32(textBoxA.Text);
                res = max(res, Convert.ToInt32(textBoxB.Text));
                res = max(res, Convert.ToInt32(textBoxC.Text));
                res = max(res, Convert.ToInt32(textBoxD.Text));
                labelRes.Text += $"Maximum is {res}.\n";
            }
            catch
            {
                MessageBox.Show("Wrong number", "Wrong", MessageBoxButtons.OK);
            }
        }
        private void buttonSix_Click(object sender, EventArgs e)
        {
            labelRes.Text = "";
            try
            {
                double res = Calculate_6(Convert.ToInt32(textBoxA.Text));
                res = min_6(res, Calculate_6(Convert.ToInt32(textBoxB.Text)));
                res = min_6(res, Calculate_6(Convert.ToInt32(textBoxC.Text)));
                res = min_6(res, Calculate_6(Convert.ToInt32(textBoxD.Text)));
                labelRes.Text += $"Minimum in {res}.\n";
            }
            catch
            {
                MessageBox.Show("Wrong number", "Wrong", MessageBoxButtons.OK);
            }
        }
        private void buttonSeven_Click(object sender, EventArgs e)
        {
            labelRes.Text = "";
            try
            {
                int ab = Calculate_7(Convert.ToInt32(textBoxA.Text), Convert.ToInt32(textBoxB));
                int cd = Calculate_7(Convert.ToInt32(textBoxC.Text), Convert.ToInt32(textBoxD));
                labelRes.Text = ab >= cd ? $"Maximum in a and b ({ab}).\n" : $"Maximum in c and d ({cd}).\n";
            }
            catch
            {
                MessageBox.Show("Wrong number", "Wrong", MessageBoxButtons.OK);
            }
        }
        private void buttonNine_Click(object sender, EventArgs e)
        {
            labelRes.Text = "";
            try
            {
                labelRes.Text += $"A: {Switch_9(Convert.ToInt32(textBoxA.Text))}\nB: {Switch_9(Convert.ToInt32(textBoxB.Text))}\nC: {Switch_9(Convert.ToInt32(textBoxC.Text))}\nD: {Switch_9(Convert.ToInt32(textBoxD.Text))}";
            }
            catch
            {
                MessageBox.Show("Wrong number", "Wrong", MessageBoxButtons.OK);
            }
        }
        private void buttonTen_Click(object sender, EventArgs e)
        {
            labelRes.Text = "";
            try
            {
                labelRes.Text += $"A: {Calculate_10(Convert.ToInt32(textBoxA.Text))}\nB: {Calculate_10(Convert.ToInt32(textBoxB.Text))}\nC: {Calculate_10(Convert.ToInt32(textBoxC.Text))}\nD: {Calculate_10(Convert.ToInt32(textBoxD.Text))}";
            }
            catch
            {
                MessageBox.Show("Wrong number", "Wrong", MessageBoxButtons.OK);
            }
        }
    }
}
