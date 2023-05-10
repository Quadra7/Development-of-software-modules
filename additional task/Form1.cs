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
        }
        //
        // Buttons
        //
        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            TextResult.Text = "";

            string textFrom = TextSource.Text;
            int shift = (int)NumericShift.Value % 33;

            string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

            for (int i = 0; i < textFrom.Length; i++)
            {
                int num = 0;
                bool isUpper = false;

                if (Char.IsUpper(textFrom[i])) isUpper = true;

                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (Char.ToLower(textFrom[i]) == alphabet[j])
                    {
                        break;
                    }
                    num++;
                }
                if (num != 33)
                {
                    int pos = num + shift;
                    TextResult.Text += isUpper ? Char.ToUpper(alphabet[pos % 33]) : alphabet[pos % 33];
                }
                else
                {
                    TextResult.Text += textFrom[i];
                }
            }

            /*
            TextResult.Text = "";
            decimal shift = NumericShift.Value;
            string textFrom = TextSource.Text;
            for (int i = 0; i < textFrom.Length; i++)
            {
                char c = textFrom[i];
                int value = textFrom[i];

                if (!Char.IsLetter(c))
                {
                    TextResult.Text += c;
                    continue;
                }
                TextResult.Text += Char.IsLower(c) ? (char)('а' + ((value + shift) % 1072) % 32)
                    : (char)('А' + ((c + shift) % 1040) % 32);
            }
            */
        }
        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            TextResult.Text = "";

            string textFrom = TextSource.Text;
            int shift = (int)NumericShift.Value % 33;

            string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

            for (int i = 0; i < textFrom.Length; i++)
            {
                int num = 0;
                bool isUpper = false;

                if (Char.IsUpper(textFrom[i])) isUpper = true;

                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (Char.ToLower(textFrom[i]) == alphabet[j])
                    {
                        break;
                    }
                    num++;
                }
                if (num != 33)
                {
                    int pos = num - shift;
                    TextResult.Text += isUpper ? Char.ToUpper(alphabet[pos < 0 ? 33 + pos : pos]) : alphabet[pos < 0 ? 33 + pos : pos];
                }
                else
                {
                    TextResult.Text += textFrom[i];
                }
            }

            /*
            TextResult.Text = "";
            decimal shift = NumericShift.Value;
            string textFrom = TextSource.Text;
            for (int i = 0; i < textFrom.Length; i++)
            {
                char c = textFrom[i];
                int value = textFrom[i];
                if (!Char.IsLetter(c))
                {
                    TextResult.Text += c;
                    continue;
                }
                TextResult.Text += Char.IsLower(c) ? (value - shift < 'а' ? (char)('я' - (1103 - (value - shift)) % 32) : (char)('а' + ((value - shift) % 1072) % 32)) 
                    : (value - shift < 'А' ? (char)('Я' - (1071 - (value - shift)) % 32) : (char)('А' + ((value - shift) % 1040) % 32));
            }
            */
        }
    }
}
