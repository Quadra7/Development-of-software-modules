using System;
using System.Collections;
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
        private void buttonFirst_Click(object sender, EventArgs e)
        {
            try
            {
                int ones = 0, zeroes = 0;
                string text = Convert.ToString(listBox1.Items[listBox1.SelectedIndex]);
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == '1')
                    {
                        ones++;
                    }
                    if (text[i] == '0')
                    {
                        zeroes++;
                    }
                }
                labelResult.Text = $"Количество единиц - {ones}\nКоличество Нулей - {zeroes}";
            }
            catch
            {
                MessageBox.Show("Choose line", "Wrong", MessageBoxButtons.OK);
            }
        }
        private void buttonSecond_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                string text = Convert.ToString(listBox1.Items[listBox1.SelectedIndex]);
                string[] words = text.Split(' ', '.', ',', '?', '!', ':', '"', '-', ';', '«', '»', '\'');
                for (int i = 0; i < words.LongLength; i++)
                {
                    if (words[i] != "")
                    {
                        count++;
                    }
                }
                labelResult.Text = $"Количество слов - {count}";
            }
            catch
            {
                MessageBox.Show("Choose line", "Wrong", MessageBoxButtons.OK);
            }
        }

        private void buttonThird_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                char[] symbols = new char[] { '.', ',', '?', '!', ':', '"', '-' , ';', '«', '»', '\'' };
                string text = Convert.ToString(listBox1.Items[listBox1.SelectedIndex]);
                for (int i = 0; i < text.Length; i++)
                {
                    for (int j = 0; j < symbols.Length; j++)
                    {
                        if (text[i] == symbols[j])
                        {
                            count++;
                        }
                    }
                }
                labelResult.Text = $"Количество знаков препинания - {count}";
            }
            catch
            {
                MessageBox.Show("Choose line", "Wrong", MessageBoxButtons.OK);
            }
        }
        private void buttonFourth_Click(object sender, EventArgs e)
        {
            try
            {
                int k = 0;
                string result = "";
                int[] massive = new int[10];
                string text = Convert.ToString(listBox1.Items[listBox1.SelectedIndex]);
                for (int i = 0; i < text.Length; i++)
                {
                    if (Char.IsDigit(text[i]) && !massive.Contains(Convert.ToInt32(text[i])))
                    {
                        massive[k] = Convert.ToInt32(text[i]);
                        k++;
                        result += text[i];
                    }
                }
                labelResult.Text = $"Цифры, содержащиеся в строке - {result}";
            }
            catch
            {
                MessageBox.Show("Choose line", "Wrong", MessageBoxButtons.OK);
            }
        }
    }
}
