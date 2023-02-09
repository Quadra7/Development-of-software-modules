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
        int[] numbers_first = new int[20];
        int[] numbers_second = new int[10];
        int[] F = new int[18];
        int[] R = new int[28];

        Random rnd = new Random(); 
        public Form1()
        {
            InitializeComponent();
        }
        //
        // First Task
        //
        private void buttonFillFirst_Click(object sender, EventArgs e)
        {
            listBoxFirstMassive.Items.Clear();
            for (int i = 0; i < numbers_first.Length; i++)
            {
                numbers_first[i] = rnd.Next(-150, 150);
                listBoxFirstMassive.Items.Add("mas[" + i + "] = " + numbers_first[i]);
            }
        }
        private void buttonChangeFirst_Click(object sender, EventArgs e)
        {
            int index = 0;
            int maxn = int.MinValue;
            listBoxSecondMassive.Items.Clear();
            for (int i = 0; i < numbers_first.Length; i++)
            {
                if (numbers_first[i] > maxn)
                {
                    maxn = numbers_first[i];
                    index = i;
                }
            }
            (numbers_first[0], numbers_first[index]) = (numbers_first[index], numbers_first[0]);
            for (int i = 0; i < numbers_first.Length; i++)
            {
                listBoxSecondMassive.Items.Add("mas[" + i + "] = " + numbers_first[i]);
            }
        }
        //
        // Second Task
        //
        private void buttonFillSecond_Click(object sender, EventArgs e)
        {
            listBoxFirstMassive.Items.Clear();
            for (int i = 0; i < numbers_second.Length; i++)
            {
                numbers_second[i] = rnd.Next(-150, 150);
                listBoxFirstMassive.Items.Add("mas[" + i + "] = " + numbers_second[i]);
            }
        }
        private void buttonChangeSecond_Click(object sender, EventArgs e)
        {
            int index = 0;
            int maxn = int.MaxValue;
            listBoxSecondMassive.Items.Clear();
            for (int i = 0; i < numbers_second.Length; i++)
            {
                if (numbers_second[i] < maxn)
                {
                    maxn = numbers_second[i];
                    index = i;
                }
            }
            (numbers_second[numbers_second.Length - 2], numbers_second[index]) = (numbers_second[index], numbers_second[numbers_second.Length - 2]);
            for (int i = 0; i < numbers_second.Length; i++)
            {
                listBoxSecondMassive.Items.Add("mas[" + i + "] = " + numbers_second[i]);
            }
        }
        //
        // Third Task
        //
        private void buttonFillThird_Click(object sender, EventArgs e)
        {
            listBoxFirstMassive.Items.Clear();
            for (int i = 0; i < F.Length; i++)
            {
                F[i] = rnd.Next(-150, 150);
                listBoxFirstMassive.Items.Add("F[" + i + "] = " + F[i]);
            }
        }
        private void buttonChangeThird_Click(object sender, EventArgs e)
        {
            double[] P = new double[18];
            listBoxSecondMassive.Items.Clear();
            for (int i = 0; i < F.Length; i++)
            {
                P[i] = 0.13 * Math.Pow(F[i], 3) - 2.5 * F[i] + 8;
                listBoxSecondMassive.Items.Add("P[" + i + "] = " + P[i]);
            }
            listBoxSecondMassive.Items.Add("");
            listBoxSecondMassive.Items.Add("Отрицательные элементы массива P:");
            for (int i = 0; i < P.Length; i++)
            {
                if (P[i] < 0)
                {
                    listBoxSecondMassive.Items.Add("P[" + i + "] = " + P[i]);
                }
            }
        }
        //
        // Fourth Task
        //
        private void buttonFillFourth_Click(object sender, EventArgs e)
        {
            listBoxFirstMassive.Items.Clear();
            for (int i = 0; i < R.Length; i++)
            {
                R[i] = rnd.Next(-20, 20);
                listBoxFirstMassive.Items.Add("F[" + i + "] = " + R[i]);
            }
        }
        private void buttonChangeFourth_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < R.Length; i++)
            {
                if (R[i] < 0)
                {
                    R[i] = R[i] * R[i];
                }
                else if (R[i] > 0)
                {
                    R[i] += 7;
                }
                else
                {
                    R[i] = R[i];
                }
                listBoxSecondMassive.Items.Add("R[" + i + "] = " + R[i]);
            }
        }
    }
}
