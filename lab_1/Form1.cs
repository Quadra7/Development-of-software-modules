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
        private void buttonRed_Click(object sender, EventArgs e)
        {
            buttonRed.BackColor = Color.Red;
        }
        private void buttonGreen_Click(object sender, EventArgs e)
        {
            buttonGreen.BackColor = Color.Green;
        }
        private void buttonBlue_Click(object sender, EventArgs e)
        {
            buttonBlue.BackColor = Color.Blue;
        }
        private void buttonYellow_Click(object sender, EventArgs e)
        {
            buttonYellow.BackColor = Color.Yellow;
        }
    }
}
