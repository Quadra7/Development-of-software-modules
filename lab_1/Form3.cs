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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        //
        // Buttons
        //
        private void buttonFirst_Click(object sender, EventArgs e)
        {
            labelText.Text = textBoxFirst.Text;
        }
        private void buttonSecond_Click(object sender, EventArgs e)
        {
            labelText.Text = textBoxSecond.Text;
        }
        private void buttonThird_Click(object sender, EventArgs e)
        {
            labelText.Text = textBoxThird.Text;
        }
        private void buttonFourth_Click(object sender, EventArgs e)
        {
            labelText.Text = textBoxFourth.Text;
        }
    }
}
