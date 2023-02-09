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
        public Form4()
        {
            InitializeComponent();
        }
        //
        // Buttons
        //
        private void buttonFirst_Click(object sender, EventArgs e)
        {
            buttonFirst.Text = textBox1.Text;
        }
        private void buttonSecond_Click(object sender, EventArgs e)
        {
            buttonSecond.Text = textBox1.Text;
        }
        private void buttonThird_Click(object sender, EventArgs e)
        {
            buttonThird.Text = textBox1.Text;
        }
        private void buttonFourth_Click(object sender, EventArgs e)
        {
            buttonFourth.Text = textBox1.Text;
        }
    }
}
